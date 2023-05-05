// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using Microsoft.Test.Logging;
using Microsoft.Test.Xaml.Utilities;
using Microsoft.Win32;

namespace Microsoft.Test.Baml.Utilities
{
    /// <summary>
    ///  Static helper routines used for Localization testing,including PomBaml and LocBaml testing.
    /// </summary>
    public class LocHelper
    {
        /******************************************************************************
        * Function:          ExecuteLocBaml
        ******************************************************************************/

        /// <summary>
        /// Calls LocBaml.exe /parse to create a .csv file from the dynamically created .resources.dll or
        /// LocBaml.exe /generate to create a localized version of the dynamically created .resources.dll.
        /// </summary>
        /// <param name="locBamlParameter">Either parse or generate</param>
        /// <param name="workingDirectory">The current directory</param>
        /// <param name="resourcesPath">The location of the resources.dll produced by dynamically compiling a project</param>
        /// <param name="csvFileName">The name of the .csv file</param>
        /// <param name="culture">The culture to which the app is localized</param>
        /// <returns>bool for success</returns>
        public static bool ExecuteLocBaml(string locBamlParameter, string workingDirectory, string resourcesPath, string csvFileName, string culture)
        {
            bool passed = true;
            string csvPath = "\"" + workingDirectory + @"\" + csvFileName + "\"";
            resourcesPath = "\"" + resourcesPath + "\"";
            culture = "\"" + culture + "\"";

            Process app = new Process();
            app.StartInfo.UseShellExecute = false;
            app.StartInfo.RedirectStandardOutput = true;
            app.StartInfo.RedirectStandardError = true;
            app.StartInfo.CreateNoWindow = true;
            app.StartInfo.FileName = "LocBaml.exe";

            if (locBamlParameter == "Parse")
            {
                // Parse the .resources.dll file to create a .csv file containing information (including LocalizationAttribute, 
                // if present, about each item in the .xaml file that potentially can be localized.
                app.StartInfo.Arguments = @"/parse " + resourcesPath + @" /out: " + csvPath;
            }
            else 
            {
                // Generate from the .csv file a new .resources.dll file that contains pseudo-localized strings.
                app.StartInfo.Arguments = @"/generate " + resourcesPath + @" /trans: " + csvPath + @" /out: " + "\"" + workingDirectory + "\"" + " /cul: " + culture;
            }

            app.StartInfo.WorkingDirectory = workingDirectory;
            app.Start();
            app.WaitForExit();

            if (!app.HasExited)
            {
                GlobalLog.LogEvidence("FAIL!  ExecuteLocBaml: " + app + " did not exit.");
                app.Kill();
                passed = false;
            }

            if (app.ExitCode != 0)
            {
                GlobalLog.LogEvidence("FAIL!  ExecuteLocBaml: " + app + " exited with code: " + app.ExitCode.ToString());
                GlobalLog.LogEvidence(app.StandardOutput.ReadToEnd());
                GlobalLog.LogEvidence(app.StandardError.ReadToEnd());
                passed = false;
            }

            if (!passed)
            {
                string output = app.StandardOutput.ReadToEnd() + "\n\n" + app.StandardError.ReadToEnd();
                string logFileName = "LocBaml" + locBamlParameter + ".log";
                StreamWriter writer = new StreamWriter(logFileName);
                writer.Write(output);
                writer.Flush();
                writer.Close();
                GlobalLog.LogFile(logFileName);
            }            

            return passed;
        }

        /******************************************************************************
        * Function:          ValidateParseResults
        ******************************************************************************/

        /// <summary>
        /// Verifies that the .csv file generated by LocBaml.exe matches a master file.
        /// </summary>
        /// <param name="csvFileName">The name of the generated .csv.</param>
        /// <returns>A boolean indicating whether or not the validation succeeded</returns>
        public static bool ValidateParseResults(string csvFileName)
        {
            bool passed = true;
            string masterString = string.Empty;
            string generatedString = string.Empty;
            string masterFileName = Path.GetFileNameWithoutExtension(csvFileName) + ".MasterCsv";

            // Load the generated file and retrieve its contents.
            try
            {
                StreamReader streamReader = new StreamReader(csvFileName);
                generatedString = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                GlobalLog.LogEvidence("Reading generated .csv file failed.");
                GlobalLog.LogEvidence(ex);
                return false;
            }

            // Load the master file and retrieve its contents.
            try
            {
                StreamReader streamReader = new StreamReader(masterFileName);
                masterString = streamReader.ReadToEnd();
            }
            catch (Exception ex)
            {
                GlobalLog.LogEvidence("Reading master .MasterCsv file failed.");
                GlobalLog.LogEvidence(ex);
                return false;
            }

            // Compare the master to the created one.
            if (!masterString.Equals(generatedString))
            {
                passed = false;
            }

            return passed;
        }

        /******************************************************************************
        * Function:          RunApplication
        ******************************************************************************/

        /// <summary>
        /// Runs the application being tested.
        /// </summary>
        /// <param name="appName">app to launch</param>
        /// <param name="args">args to run with</param>
        /// <param name="applicationTimeout">interval for process WaitForExit</param>
        /// <returns>bool for success</returns>
        public static bool RunApplication(string appName, string args, int applicationTimeout)
        {
            ProcessStartInfo procStart = new ProcessStartInfo("Launcher.exe");
            procStart.Arguments = appName + ".exe " + args;
            Process app = Process.Start(procStart);
            app.WaitForExit(applicationTimeout);

            if (!app.HasExited)
            {
                GlobalLog.LogEvidence("FAIL!  RunApplication: " + appName + " did not exit.");
                app.Kill();
                return false;
            }

            if (app.ExitCode != 0)
            {
                GlobalLog.LogEvidence("FAIL!  RunApplication: " + appName + " exited with code: " + app.ExitCode.ToString());
                GlobalLog.LogEvidence(app.StandardOutput.ReadToEnd());
                GlobalLog.LogEvidence(app.StandardError.ReadToEnd());
                return false;
            }

            return true;
        }        

        /******************************************************************************
        * Function:          ExtractStringsFromResourceBinary
        ******************************************************************************/

        /// <summary>
        /// Extracts strings from a baml file compiled within a dll.
        /// </summary>
        /// <param name="targetDllPath">location of the dll to get baml from</param>
        /// <param name="outputFile">dasm file to generate</param>
        /// <returns>the extracted strings</returns>
        public static List<BamlString> ExtractStringsFromResourceBinary(string targetDllPath, string outputFile)
        {
            // Extract Baml.
            string bamlFile = outputFile + ".baml";
            BamlHelper.ExtractBamlResource(targetDllPath, bamlFile);

            // Disassemble Baml.
            FileStream filestream = new FileStream(bamlFile, FileMode.Open, FileAccess.Read, FileShare.Read);
            BamlBinaryReader reader = new BamlBinaryReader(filestream);

            StringWriter writer = new StringWriter();
            BamlDisassemblerSettings settings = new BamlDisassemblerSettings();
            settings.ShowAddresses = true;
            settings.ShowHex = true;
            XmlBamlDisassembler bdasm = new XmlBamlDisassembler(reader, writer, settings);
            bdasm.Run();

            filestream.Close();

            FileStream outFileStream = new FileStream(outputFile, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(outFileStream);
            streamWriter.Write(writer.ToString());
            streamWriter.Flush();
            streamWriter.Close();
            GlobalLog.LogFile(outputFile);

            // Extract Strings.
            XmlDasmStringExtractor extractor = new XmlDasmStringExtractor(outputFile);
            extractor.ExtractStrings();

            return extractor.ExtractedStrings;
        }

        /******************************************************************************
        * Function:          Localize
        ******************************************************************************/

        /// <summary>
        /// Run LSbuild agains a resource dll to perform pseudo-localization (for PomBaml).
        /// </summary>
        /// <param name="srcDll">dll to localize</param>
        /// <param name="outputDll">localized dll</param>
        /// <param name="targetCulture">culture to localize to</param>
        /// <returns>bool for success</returns>
        public static bool Localize(string srcDll, string outputDll, string targetCulture)
        {
            // generate /o {Output file} /p {Parser ID} /l {Target Culture} /pseudo {dll to localize}
            string cmdArgs = string.Format("generate /o {0} /p 211 /l {1} /pseudo {2}", outputDll, targetCulture, srcDll);
            GlobalLog.LogStatus("Starting Lsbuild with args: " + cmdArgs);

            // COMPLUS_Version should be 2.0 or 4.0.30319  Subsequent version info after that is ignored, but 4.5 doesn't work.
            // Since the Environment.Version is what is used internally by tools such as lsbuild.exe, use this as it is more stable/correct.
            string complusVersion = "v" + Environment.Version.Major + "." + Environment.Version.Minor + "." + Environment.Version.Build;
            GlobalLog.LogStatus("Using COMPLUS_Version=" + complusVersion);

            ProcessStartInfo lsbuildInfo = new ProcessStartInfo("lsbuild.exe", cmdArgs);
            lsbuildInfo.UseShellExecute = false;
            lsbuildInfo.RedirectStandardOutput = true;
            lsbuildInfo.RedirectStandardError = true;
            lsbuildInfo.EnvironmentVariables["COMPLUS_Version"] = complusVersion;
            Process lsbuild = Process.Start(lsbuildInfo);
            lsbuild.WaitForExit();

            GlobalLog.LogStatus("Lsbuild exited with code: " + lsbuild.ExitCode.ToString());
            if (lsbuild.ExitCode != 0)
            {
                GlobalLog.LogStatus(lsbuild.StandardOutput.ReadToEnd());
                GlobalLog.LogStatus(lsbuild.StandardError.ReadToEnd());
                return false;
            }

            return true;
        }

        /******************************************************************************
        * Function:          PseudoLocalizeStringTableFile
        ******************************************************************************/

        /// <summary>
        /// Inserts strings into the .csv file generated by LocBaml (pseudo-localization).
        /// </summary>
        /// <param name="csvFileName">the .csv file that was output from LocBaml /parse</param>
        /// <param name="pseudoString">the text used to pseudo-Localize the .csv contents</param>
        /// <returns>the name of the .csv file that has been edited</returns>
        public static string PseudoLocalizeStringTableFile(string csvFileName, string pseudoString)
        {
            string originalText = string.Empty;
            string localizedText = string.Empty;
            bool unmodifiable = false;
            bool categoryNone = false;
            bool containsString = false;
            string[] resultArray;

            string[] inputText = File.ReadAllLines(csvFileName);
            string[] outputText = new string[inputText.Length];

            for (int i = 0; i < inputText.Length; i++)
            {
                char[] delimiters = new char[] { ',' };
                resultArray = inputText[i].Split(delimiters);

                // The third item in each .csv line refers to the LocalizationCategory localization attribute.
                // If set to "None", no localization will take place.
                categoryNone = resultArray[2].Contains("None");

                // The fifth item in each .csv line refers to the Modifiablity localization attribute.
                // If set to "Unmodifiable", no localization will take place.
                unmodifiable = (Convert.ToBoolean(resultArray[4]) == false);

                // A string must be present after the last comma.
                containsString = !inputText[i].EndsWith(",");

                // Replace the original text with pseudoString only when appropriate.
                if (!categoryNone && !unmodifiable && containsString)
                {
                    originalText = inputText[i].Substring(inputText[i].LastIndexOf(',') + 1);
                    localizedText = pseudoString + originalText + pseudoString;
                    inputText[i] = inputText[i].Remove(inputText[i].LastIndexOf(',') + 1);
                    inputText[i] = inputText[i] + localizedText;
                }

                outputText[i] = inputText[i];
            }

            // The original .csv is replaced by a new one, which will contain the localized strings.
            string localizedCsvFileName = Path.GetFileNameWithoutExtension(csvFileName) + "2.csv";
            File.WriteAllLines(localizedCsvFileName, outputText);

            return localizedCsvFileName;
        }

        /******************************************************************************
        * Function:          CompareExtractedStrings
        ******************************************************************************/

        /// <summary>
        /// Compares extracted strings.
        /// </summary>
        /// <param name="originalStrings">original strings</param>
        /// <param name="localizedStrings">localized strings</param>
        /// <returns>bool for success</returns>
        public static bool CompareExtractedStrings(List<BamlString> originalStrings, List<BamlString> localizedStrings)
        {
            bool result = true;

            if (originalStrings.Count != localizedStrings.Count)
            {
                GlobalLog.LogEvidence("String counts did not match!!");
                return false;
            }

            foreach (BamlString originalString in originalStrings)
            {
                BamlString locString = localizedStrings[originalStrings.IndexOf(originalString)];
                switch (CompareBamlString(originalString, locString))
                {
                    case 0:
                        break;
                    case 1:
                        GlobalLog.LogEvidence("Values should not have matched {0}.  Parent Uid: {1}", originalString.Value, originalString.ParentUid);
                        result &= false;
                        break;
                    case 2:
                        GlobalLog.LogEvidence("Values should have matched {0} vs {1}.  Parent Uid: {2}", originalString.Value, locString.Value, originalString.ParentUid);
                        result &= false;
                        break;
                }
            }

            return result;
        }

        /******************************************************************************
        * Function:          CheckLocalizedCount
        ******************************************************************************/

        /// <summary>
        /// Compares the count of localized strings to the expected count specified in an .xtc file.
        /// </summary>
        /// <param name="localizedStrings">localized strings</param>
        /// <param name="locString">The string added (pseudo-localization) before and after the original value</param>
        /// <param name="expectedCount">The expected number of string containing the pseudo-localized values</param>
        /// <returns>bool for success</returns>
        public static bool CheckLocalizedCount(ref List<BamlString> localizedStrings, string locString, int expectedCount)
        {
            bool result = true;
            int actualCount = 0;
            string actualStrings = string.Empty;
            List<BamlString> tempStrings = new List<BamlString>();

            for (int i = 0; i < localizedStrings.Count; i++)
            {
                // Ignore and remove strings that consist only of the locString (workaround for product bug).
                // Removal is necessary for the next step, CompareExtractedValues.
                if (!localizedStrings[i].Value.Equals("zzz"))
                {
                    tempStrings.Add(localizedStrings[i]);

                    // Increment the count of stings that contain the psuedo-loc string previously added to the .csv file.
                    if (localizedStrings[i].Value.Contains(locString))
                    {
                        actualStrings += localizedStrings[i].Value + "\n";
                        actualCount++;
                    }
                }
            }

            GlobalLog.LogEvidence("Count of pseudo-localized strings in resources.  Expected: " + expectedCount + " / Actual: " + actualCount);

            if (actualCount != expectedCount)
            {
                GlobalLog.LogEvidence("FAIL: Actual pseudo-localized Count is incorrect");
                GlobalLog.LogEvidence("\nExtracted strings after pseudo-localization:\n" + actualStrings);
                result = false;
            }

            localizedStrings = tempStrings;

            return result;
        }

        /******************************************************************************
        * Function:          CompareExtractedValues
        ******************************************************************************/

        /// <summary>
        /// Compares the value extracted from the localized resources.dll to that of the original.  The localized version
        /// should contain a constant string (locString) before and after the orginal version.
        /// </summary>
        /// <param name="originalStrings">original strings</param>
        /// <param name="localizedStrings">localized strings</param>
        /// <param name="locString">The string added (pseudo-localization) before and after the original value</param>
        /// <param name="locMarker">A 'marker' string added to in markup to strings expected to be localized</param>
        /// <param name="extractedStringsFileName">The file name of a file containing the extracted strings</param>
        /// <param name="expectedCount">The number of strings expected to be localized</param>
        /// <returns>bool for success</returns>
        public static bool CompareExtractedValues(List<BamlString> originalStrings, List<BamlString> localizedStrings, string locString, string locMarker, string extractedStringsFileName, int expectedCount)
        {
            bool passed = true;
            bool result = true;
            string extractedStrings = string.Empty;
            string expectedValue = string.Empty;
            string actualValue = string.Empty;

            GlobalLog.LogStatus("Count of all original strings: " + originalStrings.Count + " / Count of all strings after localization: " + localizedStrings.Count);

            if (originalStrings.Count != localizedStrings.Count)
            {
                GlobalLog.LogEvidence("FAIL! String counts did not match!!");

                GlobalLog.LogEvidence("\nORIGINAL:");
                for (int j = 0; j < originalStrings.Count; j++)
                {
                    GlobalLog.LogStatus(j.ToString() + ": " + originalStrings[j].Value);
                }

                GlobalLog.LogEvidence("\nPOST-LOCALIZATION:");
                for (int k = 0; k < localizedStrings.Count; k++)
                {
                    GlobalLog.LogStatus(k.ToString() + ": " + localizedStrings[k].Value);
                }

                return false;
            }

            for (int i = 0; i < originalStrings.Count; i++)
            {
                actualValue = localizedStrings[i].Value;

                // Strings that are expected to be localized contain a 'marker' string that is used to determine expected values.
                // Special case:  a property value that contains only a space.
                if (localizedStrings[i].Value.Contains(locMarker) || localizedStrings[i].Value.Contains("zzz zzz"))
                {
                    // The string contains the marker, so it should also contain the pseudo-loc string added before and after.
                    expectedValue = locString + originalStrings[i].Value + locString;
                }
                else
                {
                    // The string does not contain the marker, so it is not expected to contain the pseudo-loc string.
                    expectedValue = originalStrings[i].Value;
                }

                extractedStrings += i.ToString() + ":  Expected: " + expectedValue + "\n" + i.ToString() + ":  Actual:   " + actualValue + "\n";
                GlobalLog.LogStatus(i.ToString() + ":  Expected: " + expectedValue + "\n" + i.ToString() + ":  Actual:   " + actualValue + "\n");
                result = String.Equals(expectedValue, actualValue);

                if (!result)
                {
                    GlobalLog.LogEvidence("\nFAIL: the value of the extracted string after localization is incorrect:\n  Expected: " + expectedValue + " / Actual: " + actualValue + "\n");
                    passed = false;
                }
            }

            StreamWriter writer = new StreamWriter(extractedStringsFileName);
            writer.Write(extractedStrings);
            writer.Flush();
            writer.Close();

            return passed;
        }

        /******************************************************************************
        * Function:          CompareBamlString
        ******************************************************************************/
        
        /// <summary>
        /// Compares two baml strings.  Return code is condition based on value of IsLocalizable
        /// and if the BamlString.Value values match.
        /// </summary>
        /// <param name="string1">first string</param>
        /// <param name="string2">second string</param>
        /// <returns>
        /// O: IsLocalizable=True - Values were different, IsLocalizable=False - Values matched
        /// 1: IsLocalizable=True, values should have been different, they match
        /// 2: IsLocalizable=True, values should have matched, were different
        /// </returns>
        private static int CompareBamlString(BamlString string1, BamlString string2)
        {
            if (string1.IsLocalizable)
            {
                if (!String.Equals(string1.Value, string2.Value))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                if (!String.Equals(string1.Value, string2.Value))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
