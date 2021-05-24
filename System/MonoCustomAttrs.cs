internal static class MonoCustomAttrs // TypeDefIndex: 384
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB44E0 Offset: 0xB45E1 VA: 0xB44E0
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x18DE4C0 Offset: 0x18DE5C1 VA: 0x18DE4C0
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x18DE6C0 Offset: 0x18DE7C1 VA: 0x18DE6C0
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x18DE6D0 Offset: 0x18DE7D1 VA: 0x18DE6D0
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x18DE9D0 Offset: 0x18DEAD1 VA: 0x18DE9D0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x18DEB50 Offset: 0x18DEC51 VA: 0x18DEB50
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x18DED30 Offset: 0x18DEE31 VA: 0x18DED30
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18DFBE0 Offset: 0x18DFCE1 VA: 0x18DFBE0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x18DFD60 Offset: 0x18DFE61 VA: 0x18DFD60
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFD70 Offset: 0x18DFE71 VA: 0x18DFD70
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFE30 Offset: 0x18DFF31 VA: 0x18DFE30
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18E0120 Offset: 0x18E0221 VA: 0x18E0120
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x18E0130 Offset: 0x18E0231 VA: 0x18E0130
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x18E0400 Offset: 0x18E0501 VA: 0x18E0400
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x18DF7D0 Offset: 0x18DF8D1 VA: 0x18DF7D0
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x18E05D0 Offset: 0x18E06D1 VA: 0x18E05D0
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x18DFA20 Offset: 0x18DFB21 VA: 0x18DFA20
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x18E0820 Offset: 0x18E0921 VA: 0x18E0820
	private static void .cctor() { }
}

internal static class MonoCustomAttrs // TypeDefIndex: 384
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB44E0 Offset: 0xB45E1 VA: 0xB44E0
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x18DE4C0 Offset: 0x18DE5C1 VA: 0x18DE4C0
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x18DE6C0 Offset: 0x18DE7C1 VA: 0x18DE6C0
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x18DE6D0 Offset: 0x18DE7D1 VA: 0x18DE6D0
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x18DE9D0 Offset: 0x18DEAD1 VA: 0x18DE9D0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x18DEB50 Offset: 0x18DEC51 VA: 0x18DEB50
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x18DED30 Offset: 0x18DEE31 VA: 0x18DED30
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18DFBE0 Offset: 0x18DFCE1 VA: 0x18DFBE0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x18DFD60 Offset: 0x18DFE61 VA: 0x18DFD60
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFD70 Offset: 0x18DFE71 VA: 0x18DFD70
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFE30 Offset: 0x18DFF31 VA: 0x18DFE30
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18E0120 Offset: 0x18E0221 VA: 0x18E0120
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x18E0130 Offset: 0x18E0231 VA: 0x18E0130
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x18E0400 Offset: 0x18E0501 VA: 0x18E0400
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x18DF7D0 Offset: 0x18DF8D1 VA: 0x18DF7D0
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x18E05D0 Offset: 0x18E06D1 VA: 0x18E05D0
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x18DFA20 Offset: 0x18DFB21 VA: 0x18DFA20
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x18E0820 Offset: 0x18E0921 VA: 0x18E0820
	private static void .cctor() { }
}

internal static class MonoCustomAttrs // TypeDefIndex: 384
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB44E0 Offset: 0xB45E1 VA: 0xB44E0
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x18DE4C0 Offset: 0x18DE5C1 VA: 0x18DE4C0
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x18DE6C0 Offset: 0x18DE7C1 VA: 0x18DE6C0
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x18DE6D0 Offset: 0x18DE7D1 VA: 0x18DE6D0
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x18DE9D0 Offset: 0x18DEAD1 VA: 0x18DE9D0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x18DEB50 Offset: 0x18DEC51 VA: 0x18DEB50
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x18DED30 Offset: 0x18DEE31 VA: 0x18DED30
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18DFBE0 Offset: 0x18DFCE1 VA: 0x18DFBE0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x18DFD60 Offset: 0x18DFE61 VA: 0x18DFD60
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFD70 Offset: 0x18DFE71 VA: 0x18DFD70
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFE30 Offset: 0x18DFF31 VA: 0x18DFE30
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18E0120 Offset: 0x18E0221 VA: 0x18E0120
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x18E0130 Offset: 0x18E0231 VA: 0x18E0130
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x18E0400 Offset: 0x18E0501 VA: 0x18E0400
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x18DF7D0 Offset: 0x18DF8D1 VA: 0x18DF7D0
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x18E05D0 Offset: 0x18E06D1 VA: 0x18E05D0
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x18DFA20 Offset: 0x18DFB21 VA: 0x18DFA20
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x18E0820 Offset: 0x18E0921 VA: 0x18E0820
	private static void .cctor() { }
}

internal static class MonoCustomAttrs // TypeDefIndex: 384
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB44E0 Offset: 0xB45E1 VA: 0xB44E0
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x18DE4C0 Offset: 0x18DE5C1 VA: 0x18DE4C0
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x18DE6C0 Offset: 0x18DE7C1 VA: 0x18DE6C0
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x18DE6D0 Offset: 0x18DE7D1 VA: 0x18DE6D0
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x18DE9D0 Offset: 0x18DEAD1 VA: 0x18DE9D0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x18DEB50 Offset: 0x18DEC51 VA: 0x18DEB50
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x18DED30 Offset: 0x18DEE31 VA: 0x18DED30
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18DFBE0 Offset: 0x18DFCE1 VA: 0x18DFBE0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x18DFD60 Offset: 0x18DFE61 VA: 0x18DFD60
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFD70 Offset: 0x18DFE71 VA: 0x18DFD70
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFE30 Offset: 0x18DFF31 VA: 0x18DFE30
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18E0120 Offset: 0x18E0221 VA: 0x18E0120
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x18E0130 Offset: 0x18E0231 VA: 0x18E0130
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x18E0400 Offset: 0x18E0501 VA: 0x18E0400
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x18DF7D0 Offset: 0x18DF8D1 VA: 0x18DF7D0
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x18E05D0 Offset: 0x18E06D1 VA: 0x18E05D0
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x18DFA20 Offset: 0x18DFB21 VA: 0x18DFA20
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x18E0820 Offset: 0x18E0921 VA: 0x18E0820
	private static void .cctor() { }
}

internal static class MonoCustomAttrs // TypeDefIndex: 384
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB44E0 Offset: 0xB45E1 VA: 0xB44E0
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x18DE4C0 Offset: 0x18DE5C1 VA: 0x18DE4C0
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x18DE6C0 Offset: 0x18DE7C1 VA: 0x18DE6C0
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x18DE6D0 Offset: 0x18DE7D1 VA: 0x18DE6D0
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x18DE9D0 Offset: 0x18DEAD1 VA: 0x18DE9D0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x18DEB50 Offset: 0x18DEC51 VA: 0x18DEB50
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x18DED30 Offset: 0x18DEE31 VA: 0x18DED30
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18DFBE0 Offset: 0x18DFCE1 VA: 0x18DFBE0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x18DFD60 Offset: 0x18DFE61 VA: 0x18DFD60
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFD70 Offset: 0x18DFE71 VA: 0x18DFD70
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFE30 Offset: 0x18DFF31 VA: 0x18DFE30
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18E0120 Offset: 0x18E0221 VA: 0x18E0120
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x18E0130 Offset: 0x18E0231 VA: 0x18E0130
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x18E0400 Offset: 0x18E0501 VA: 0x18E0400
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x18DF7D0 Offset: 0x18DF8D1 VA: 0x18DF7D0
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x18E05D0 Offset: 0x18E06D1 VA: 0x18E05D0
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x18DFA20 Offset: 0x18DFB21 VA: 0x18DFA20
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x18E0820 Offset: 0x18E0921 VA: 0x18E0820
	private static void .cctor() { }
}

internal static class MonoCustomAttrs // TypeDefIndex: 384
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB44E0 Offset: 0xB45E1 VA: 0xB44E0
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x18DE4C0 Offset: 0x18DE5C1 VA: 0x18DE4C0
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x18DE6C0 Offset: 0x18DE7C1 VA: 0x18DE6C0
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x18DE6D0 Offset: 0x18DE7D1 VA: 0x18DE6D0
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x18DE9D0 Offset: 0x18DEAD1 VA: 0x18DE9D0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x18DEB50 Offset: 0x18DEC51 VA: 0x18DEB50
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x18DED30 Offset: 0x18DEE31 VA: 0x18DED30
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18DFBE0 Offset: 0x18DFCE1 VA: 0x18DFBE0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x18DFD60 Offset: 0x18DFE61 VA: 0x18DFD60
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFD70 Offset: 0x18DFE71 VA: 0x18DFD70
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFE30 Offset: 0x18DFF31 VA: 0x18DFE30
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18E0120 Offset: 0x18E0221 VA: 0x18E0120
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x18E0130 Offset: 0x18E0231 VA: 0x18E0130
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x18E0400 Offset: 0x18E0501 VA: 0x18E0400
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x18DF7D0 Offset: 0x18DF8D1 VA: 0x18DF7D0
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x18E05D0 Offset: 0x18E06D1 VA: 0x18E05D0
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x18DFA20 Offset: 0x18DFB21 VA: 0x18DFA20
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x18E0820 Offset: 0x18E0921 VA: 0x18E0820
	private static void .cctor() { }
}

internal static class MonoCustomAttrs // TypeDefIndex: 384
{
	// Fields
	private static Assembly corlib; // 0x0
	[ThreadStaticAttribute] // RVA: 0xB44E0 Offset: 0xB45E1 VA: 0xB44E0
	private static Dictionary<Type, AttributeUsageAttribute> usage_cache; // 0x80000000
	private static readonly AttributeUsageAttribute DefaultAttributeUsage; // 0x8

	// Methods

	// RVA: 0x18DE4C0 Offset: 0x18DE5C1 VA: 0x18DE4C0
	private static bool IsUserCattrProvider(object obj) { }

	// RVA: 0x18DE6C0 Offset: 0x18DE7C1 VA: 0x18DE6C0
	internal static object[] GetCustomAttributesInternal(ICustomAttributeProvider obj, Type attributeType, bool pseudoAttrs) { }

	// RVA: 0x18DE6D0 Offset: 0x18DE7D1 VA: 0x18DE6D0
	internal static object[] GetPseudoCustomAttributes(ICustomAttributeProvider obj, Type attributeType) { }

	// RVA: 0x18DE9D0 Offset: 0x18DEAD1 VA: 0x18DE9D0
	private static object[] GetPseudoCustomAttributes(Type type) { }

	// RVA: 0x18DEB50 Offset: 0x18DEC51 VA: 0x18DEB50
	internal static object[] GetCustomAttributesBase(ICustomAttributeProvider obj, Type attributeType, bool inheritedOnly) { }

	// RVA: 0x18DED30 Offset: 0x18DEE31 VA: 0x18DED30
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18DFBE0 Offset: 0x18DFCE1 VA: 0x18DFBE0
	internal static object[] GetCustomAttributes(ICustomAttributeProvider obj, bool inherit) { }

	// RVA: 0x18DFD60 Offset: 0x18DFE61 VA: 0x18DFD60
	private static CustomAttributeData[] GetCustomAttributesDataInternal(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFD70 Offset: 0x18DFE71 VA: 0x18DFD70
	internal static IList<CustomAttributeData> GetCustomAttributesData(ICustomAttributeProvider obj) { }

	// RVA: 0x18DFE30 Offset: 0x18DFF31 VA: 0x18DFE30
	internal static bool IsDefined(ICustomAttributeProvider obj, Type attributeType, bool inherit) { }

	// RVA: 0x18E0120 Offset: 0x18E0221 VA: 0x18E0120
	internal static bool IsDefinedInternal(ICustomAttributeProvider obj, Type AttributeType) { }

	// RVA: 0x18E0130 Offset: 0x18E0231 VA: 0x18E0130
	private static PropertyInfo GetBasePropertyDefinition(MonoProperty property) { }

	// RVA: 0x18E0400 Offset: 0x18E0501 VA: 0x18E0400
	private static EventInfo GetBaseEventDefinition(MonoEvent evt) { }

	// RVA: 0x18DF7D0 Offset: 0x18DF8D1 VA: 0x18DF7D0
	private static ICustomAttributeProvider GetBase(ICustomAttributeProvider obj) { }

	// RVA: 0x18E05D0 Offset: 0x18E06D1 VA: 0x18E05D0
	private static AttributeUsageAttribute RetrieveAttributeUsageNoCache(Type attributeType) { }

	// RVA: 0x18DFA20 Offset: 0x18DFB21 VA: 0x18DFA20
	private static AttributeUsageAttribute RetrieveAttributeUsage(Type attributeType) { }

	// RVA: 0x18E0820 Offset: 0x18E0921 VA: 0x18E0820
	private static void .cctor() { }
}

