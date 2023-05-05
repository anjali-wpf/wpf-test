// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

/*
 *FxCop Violation Message Suppressions
 */
using System.Diagnostics.CodeAnalysis;

[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#NullArgument()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#Parse()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#ParseList()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#ParseListNegative()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#ParseNegative()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#TryParse()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#TryParseList()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#TryParseListNegative()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#TryParseNegative()")]

[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlLanguageTests.#DirectivesMatchSchemaContext()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlLanguageTests.#TypesMatchSchemaContext()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlLanguageTests.#VerifyAllDirectives()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlLanguageTests.#VerifyAllTypes()")]

[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#.ctor()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#DifferentXamlMemberCompare()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#DifferentXamlMemberCompare()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#GetState(System.Xaml.Schema.XamlMember)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#GetState(System.Xaml.Schema.XamlMember)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#GetState(System.Xaml.XamlMember)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#KnownAttachableProperty()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#KnownAttachablePropertyEvent()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#KnownAttachablePropertyInvalid()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#KnownXamlDirective()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#ProtectedStringProperty()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#PublicEventProperty()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#PublicPropertyWithGetterSetter()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#SameXamlMemberComapre()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#SameXamlMemberCompare()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#StringPropertyWithNoSetter()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#TypeConverterOnProperty()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#TypeConverterOnType()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#TypeConverterOnTypeAndProperty()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#UnknownAttachableMember()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#UnknownXamlMember()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#UnknownXamlMemberThatExists()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#XamlMemberXamlMemberCompare()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#XamlMemberXamlMemberCompare()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#XamlMemberXamlMemberSameNameCompare()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#SameXamlMemberCompare()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#DifferentXamlDirectiveCompare()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#GetState(System.Xaml.XamlDirective)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#GetState(System.Xaml.XamlProperty)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#NoTypeConverterProperty()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#SameXamlDirectiveCompare()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#UnknownDirective()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlMemberTests.#XamlDirectiveXamlMemberCompare()")]

[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.GetPropertyTests.#TypeWithDictionaryKeyPropertyTest()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.GetPropertyTests.#TypeWithRuntimeNamePropertyTest()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.GetPropertyTests.#TypeWithUidPropertyTest()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.GetPropertyTests.#TypeWithXmlLangPropertyTest()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.TextSyntaxTests.#ObjectTest()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#.ctor()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#AllowedContentTypesTest(System.Type,System.String[])")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#ContentPropertyTest(System.Type,System.String)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#ContentWrappersTest(System.Type,System.String[])")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#GetAddMethodTest(System.Type,System.Type,System.String[])")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#GetAllAttachableMembersTest(System.Type,System.String[])")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#GetAllMembersTest(System.Type,System.String[])")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#GetAttachableMemberTest(System.Type,System.String,System.Type)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#GetEnumeratorMethodTest(System.Type)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#GetPositionalParametersTest(System.Type,System.Int32,System.String[])")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#GetMemberTest(System.Type,System.String,System.Type)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#GetPropertyTest(System.Type,System.Xaml.XamlMember,System.String,System.Type)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#GetXamlNamespacesTest(System.Type,System.String[])")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#GetXamlType(System.Type)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsArrayTest(System.Type,System.Boolean)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsAssignableFromTest(System.Type,System.Type,System.Boolean)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsCollectionAndItemTypeTest(System.Type,System.Boolean,System.String)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsConstructibleTest(System.Type,System.Boolean)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsDictionaryAndKeyTypeAndItemTypeTest(System.Type,System.Boolean,System.String,System.String)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsGenericTest(System.Type,System.Boolean)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsMarkupExtensionTest(System.Type,System.Boolean)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsNamescopeTest(System.Type,System.Boolean)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsNullableTest(System.Type,System.Boolean)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsPublicTest(System.Type,System.Boolean)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsUnknownTest(System.String,System.String,System.Collections.Generic.IList`1<System.Xaml.XamlType>,System.Xaml.XamlSchemaContext,System.Boolean)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsXDataTest(System.Type,System.Boolean)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#MarkupExtensionReturnTypeTest(System.Type,System.String)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#NameTest(System.Type,System.String)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#PreferredXamlNamespaceTest(System.Type,System.String)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#TemplateConverterTest(System.Type,System.String)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#TextSyntaxTest(System.Type,System.String)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#TypeArgumentsTest(System.Type,System.String[])")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#UnderlyingTypeTest(System.Type)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#ValidateCollectionOrdered(System.Collections.Generic.IList`1<System.Xaml.XamlType>,System.String[])")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#ValidateCollectionUnordered`1(System.Collections.ObjectModel.ReadOnlyCollection`1<!!0>,System.String[])")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#ValidateCollectionUnordered(System.Collections.ObjectModel.ReadOnlyCollection`1<System.Xaml.XamlType>,System.String[])")]

[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XMembersTests.#.ctor()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XMembersTests.#GenericUnknownTypeWithKnownTypeArgumentsTest()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XMembersTests.#GenericUnknownTypeWithUnknownTypeArgumentsTest()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XMembersTests.#NonGenericUnknownTypeTest()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XMembersTests.#RoundTrip(System.Type)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XMembersTests.#RoundTrip(System.Xaml.XamlType)")]

[module: SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "System.Xaml.Schema.XamlTypeName.TryParse(System.String,System.Xaml.IXamlNamespaceResolver,System.Xaml.Schema.XamlTypeName@)", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#NullArgument()")]
[module: SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "System.Xaml.Schema.XamlTypeName.TryParseList(System.String,System.Xaml.IXamlNamespaceResolver,System.Collections.Generic.IList`1<System.Xaml.Schema.XamlTypeName>@)", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeNameTest.#NullArgument()")]

[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Uid", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.GetPropertyTests.#TypeWithUidPropertyTest()")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Namescope", Scope = "type", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.IsNamescopeTests")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Namescope", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.IsNamescopeTests.#TypeImplementingINamescopeTest()")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Namescope", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.IsNamescopeTests.#TypeNotImplementingINamescopeTest()")]
[module: SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "Namescope", Scope = "member", Target = "Microsoft.Test.Xaml.Schema.MethodTests.XamlTypeTests.XamlTypeTestBase.#IsNamescopeTest(System.Type,System.Boolean)")]

[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Parser.MethodTests.XamlTextReader.XamlSubReaderTest.#CreateList(System.Xaml.XamlReader)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Parser.MethodTests.XamlTextReader.XamlSubReaderTest.#CreateReader(System.String,System.String,System.Xaml.XamlSchemaContext&)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Parser.MethodTests.XamlTextReader.XamlSubReaderTest.#ReadToXamlType(System.Xaml.XamlReader,System.Xaml.XamlType)")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Parser.MethodTests.XamlTextReader.XamlSubReaderTest.#RunTest()")]
[module: SuppressMessage("Microsoft.Security", "CA2116:AptcaMethodsShouldOnlyCallAptcaMethods", Scope = "member", Target = "Microsoft.Test.Xaml.Parser.MethodTests.XamlTextReader.XamlSubReaderTest.#VerifySubtree(System.Xaml.XamlReader,System.Collections.ArrayList)")]
[module: SuppressMessage("Microsoft.Usage", "CA1806:DoNotIgnoreMethodResults", MessageId = "System.Windows.FrameworkElement", Scope = "member", Target = "Microsoft.Test.Xaml.Parser.MethodTests.XamlTextReader.XamlSubReaderTest.#RunTest()")]
