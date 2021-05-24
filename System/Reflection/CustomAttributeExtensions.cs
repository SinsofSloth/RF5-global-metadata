[ExtensionAttribute] // RVA: 0xAD400 Offset: 0xAD501 VA: 0xAD400
public static class CustomAttributeExtensions // TypeDefIndex: 512
{
	// Methods

	[ExtensionAttribute] // RVA: 0xB7FD0 Offset: 0xB80D1 VA: 0xB7FD0
	// RVA: 0x195D780 Offset: 0x195D881 VA: 0x195D780
	public static Attribute GetCustomAttribute(Assembly element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0xB7FE0 Offset: 0xB80E1 VA: 0xB7FE0
	// RVA: 0x195D790 Offset: 0x195D891 VA: 0x195D790
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0xB7FF0 Offset: 0xB80F1 VA: 0xB7FF0
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(Assembly element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2263D60 Offset: 0x2263E61 VA: 0x2263D60
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	|-CustomAttributeExtensions.GetCustomAttribute<NeutralResourcesLanguageAttribute>
	*/

	[ExtensionAttribute] // RVA: 0xB8000 Offset: 0xB8101 VA: 0xB8000
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2263E40 Offset: 0x2263F41 VA: 0x2263E40
	|-CustomAttributeExtensions.GetCustomAttribute<FlagsAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<DataContractAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<EnumMemberAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[ExtensionAttribute] // RVA: 0xB8010 Offset: 0xB8111 VA: 0xB8010
	// RVA: 0x195D7A0 Offset: 0x195D8A1 VA: 0x195D7A0
	public static Attribute GetCustomAttribute(MemberInfo element, Type attributeType, bool inherit) { }

	[ExtensionAttribute] // RVA: 0xB8020 Offset: 0xB8121 VA: 0xB8020
	// RVA: -1 Offset: -1
	public static T GetCustomAttribute<T>(MemberInfo element, bool inherit) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2263F20 Offset: 0x2264021 VA: 0x2263F20
	|-CustomAttributeExtensions.GetCustomAttribute<IgnoreMemberAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<KeyAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<MessagePackFormatterAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<SerializationConstructorAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<CompilerGeneratedAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<DataMemberAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<IgnoreDataMemberAttribute>
	|-CustomAttributeExtensions.GetCustomAttribute<object>
	*/

	[ExtensionAttribute] // RVA: 0xB8030 Offset: 0xB8131 VA: 0xB8030
	// RVA: 0x195D7B0 Offset: 0x195D8B1 VA: 0x195D7B0
	public static IEnumerable<Attribute> GetCustomAttributes(MemberInfo element, Type attributeType) { }

	[ExtensionAttribute] // RVA: 0xB8040 Offset: 0xB8141 VA: 0xB8040
	// RVA: -1 Offset: -1
	public static IEnumerable<T> GetCustomAttributes<T>(MemberInfo element) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x22D51E0 Offset: 0x22D52E1 VA: 0x22D51E0
	|-CustomAttributeExtensions.GetCustomAttributes<MessagePackObjectAttribute>
	|-CustomAttributeExtensions.GetCustomAttributes<UnionAttribute>
	|-CustomAttributeExtensions.GetCustomAttributes<object>
	*/
}

