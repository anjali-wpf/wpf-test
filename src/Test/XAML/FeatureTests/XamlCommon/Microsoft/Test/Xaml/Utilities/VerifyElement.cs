// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using Microsoft.Test.Logging;

namespace Microsoft.Test.Xaml.Utilities
{
    /// <summary>
    /// Verification methods for some common element
    /// Author: lxuan
    /// Date: 10/28/2003
    /// </summary>
    public class VerifyElement
    {
        /// <summary>
        /// Verify two thicknesses are equal
        /// </summary>
        /// <param name="thickness1">The thickness1.</param>
        /// <param name="thinkness2">The thinkness2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyThickness(Thickness thickness1, Thickness thinkness2, ref bool result)
        {
            if (thickness1 != thinkness2)
            {
                GlobalLog.LogEvidence("Thicknesses are different: " + thickness1.ToString() + " vs " + thinkness2.ToString());
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("Thicknesses are the same:  " + thickness1.ToString());
            }
        }

        /// <summary>
        /// Verify two thicknesses are equal
        /// </summary>
        /// <param name="thickness1">The thickness1.</param>
        /// <param name="thickness2">The thickness2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyThickness(Thickness thickness1, double thickness2, ref bool result)
        {
            VerifyThickness(thickness1, new Thickness(thickness2), ref result);
        }

        /// <summary>
        /// Verify two color are the same
        /// </summary>
        /// <param name="color1">The color1.</param>
        /// <param name="color2">The color2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyColor(Color color1, Color color2, ref bool result)
        {
            if (!color1.Equals(color2))
            {
                GlobalLog.LogEvidence("Colors are different:  " + color1.ToString() + " vs  " + color2.ToString());
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("Colors are the same:  " + color1.ToString());
            }
        }

        /// <summary>
        /// Verify strings
        /// </summary>
        /// <param name="string1">The string1.</param>
        /// <param name="string2">The string2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyString(string string1, string string2, ref bool result)
        {
            if (0 != String.Compare(string1, string2, StringComparison.InvariantCulture))
            {
                GlobalLog.LogEvidence("Strings are different:  " + string1 + " vs  " + string2);
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("strings are the same:  " + string1);
            }
        }

        /// <summary>
        /// Verify two docks are the same
        /// </summary>
        /// <param name="dock1">The dock1.</param>
        /// <param name="dock2">The dock2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyDock(Dock dock1, Dock dock2, ref bool result)
        {
            if (dock1 != dock2)
            {
                GlobalLog.LogEvidence("Docks are different:  " + dock1.ToString() + " vs  " + dock1.ToString());
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("Docks are the same:  " + dock1.ToString());
            }
        }

        /// <summary>
        /// Verify a DockPanel has expected LastChildFill.
        /// </summary>
        /// <param name="dockPanel">The dock panel.</param>
        /// <param name="lastChildFill">if set to <c>true</c> [last child fill].</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyDock(DockPanel dockPanel, bool lastChildFill, ref bool result)
        {
            if (dockPanel.LastChildFill != lastChildFill)
            {
                GlobalLog.LogEvidence("LastChildFill is different:  " + dockPanel.LastChildFill.ToString() + " vs  " + lastChildFill.ToString());
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("LastChildFill is the same:  " + dockPanel.LastChildFill.ToString());
            }
        }

        /// <summary>
        /// Verifies the int.
        /// </summary>
        /// <param name="i1">The int i1.</param>
        /// <param name="i2">The int i2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyInt(int i1, int i2, ref bool result)
        {
            if (i1 != i2)
            {
                GlobalLog.LogEvidence("ints are different:  " + i1 + " vs  " + i2);
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("Integers are the same:  " + i1);
            }
        }

        /// <summary>
        /// Verifies the bool.
        /// </summary>
        /// <param name="b1">if set to <c>true</c> [b1].</param>
        /// <param name="b2">if set to <c>true</c> [b2].</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyBool(bool b1, bool b2, ref bool result)
        {
            if (b1 != b2)
            {
                GlobalLog.LogEvidence("bools are different:  " + b1.ToString() + " vs  " + b2.ToString());
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("Bools are the same:  " + b1.ToString());
            }
        }

        /// <summary>
        /// Verifies the float.
        /// </summary>
        /// <param name="b1">The float b1.</param>
        /// <param name="b2">The float b2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyFloat(float b1, float b2, ref bool result)
        {
            if (b1 != b2)
            {
                GlobalLog.LogEvidence("floats are different:  " + b1.ToString() + " vs  " + b2.ToString());
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("floats are the same:  " + b1.ToString());
            }
        }

        /// <summary>
        /// Verifies the double.
        /// </summary>
        /// <param name="b1">The double b1.</param>
        /// <param name="b2">The double b2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyDouble(double b1, double b2, ref bool result)
        {
            bool close = true;
            double error = 0.00001;
            if (Math.Abs(b2) < error)
            {
                if (Math.Abs(b1 - b2) > error * error)
                {
                    close = false;
                }
            }
            else if (Math.Abs((b1 / b2) - 1) > error)
            {
                close = false;
            }

            if (Double.IsNaN(b1) ^ Double.IsNaN(b2))
            {
                close = false;
            }

            if (!close)
            {
                GlobalLog.LogEvidence("doubles are note close:  " + b1.ToString() + " vs  " + b2.ToString());
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("double  are the same:  " + b1.ToString());
            }
        }

        /// <summary>
        /// Verifies the image source.
        /// </summary>
        /// <param name="i1">The string i1.</param>
        /// <param name="i2">The bool i2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyImageSource(ImageSource i1, string i2, ref bool result)
        {
            BitmapSource imgsrc = new BitmapImage(new Uri(i2, UriKind.RelativeOrAbsolute));
            BitmapSource bitmap = i1 as BitmapSource;
            if (i1 != null)
            {
                VerifyElement.VerifyInt(bitmap.PixelHeight, imgsrc.PixelHeight, ref result);
                VerifyElement.VerifyInt(bitmap.PixelWidth, imgsrc.PixelWidth, ref result);
            }
            else
            {
                VerifyElement.VerifyDouble(i1.Height, imgsrc.Height, ref result);
                VerifyElement.VerifyDouble(i1.Width, imgsrc.Width, ref result);
            }

            GlobalLog.LogStatus("two Image Source are the same");
        }

        /// <summary>
        /// Verifies the rect.
        /// </summary>
        /// <param name="r1">The Rect r1.</param>
        /// <param name="r2">The bool r2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyRect(Rect r1, Rect r2, ref bool result)
        {
            if (!r1.Equals(r2))
            {
                GlobalLog.LogEvidence("Rectangles are different:  " + r1.ToString() + " vs  " + r2.ToString());
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("Rectangles are the same:  " + r1.ToString());
            }
        }

        /// <summary>
        /// Verifies the point.
        /// </summary>
        /// <param name="p1">The Point p1.</param>
        /// <param name="p2">The Point p2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifyPoint(Point p1, Point p2, ref bool result)
        {
            if (!p1.Equals(p2))
            {
                GlobalLog.LogEvidence("Points are different:  " + p1.ToString() + " vs  " + p2.ToString());
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("Points are the same:  " + p1.ToString());
            }
        }

        /// <summary>
        /// Verifies the size.
        /// </summary>
        /// <param name="p1">The Size p1.</param>
        /// <param name="p2">The Size p2.</param>
        /// <param name="result">if set to <c>true</c> [result].</param>
        public static void VerifySize(Size p1, Size p2, ref bool result)
        {
            if (!(p1 == p2))
            {
                GlobalLog.LogEvidence("Sizes are different:  " + p1.ToString() + " vs  " + p2.ToString());
                result &= false;
            }
            else
            {
                GlobalLog.LogStatus("Sizes are the same:  " + p1.ToString());
            }
        }
    }
}