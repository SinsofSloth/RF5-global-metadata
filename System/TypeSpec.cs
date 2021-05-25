internal class TypeSpec // TypeDefIndex: 425
{
	// Fields
	private TypeIdentifier name; // 0x10
	private string assembly_name; // 0x18
	private List<TypeIdentifier> nested; // 0x20
	private List<TypeSpec> generic_params; // 0x28
	private List<ModifierSpec> modifier_spec; // 0x30
	private bool is_byref; // 0x38
	private string display_fullname; // 0x40

	// Properties
	internal bool HasModifiers { get; }
	internal string DisplayFullName { get; }

	// Methods

	// RVA: 0x1ADF6F0 Offset: 0x1ADF7F1 VA: 0x1ADF6F0
	internal bool get_HasModifiers() { }

	// RVA: 0x1ADF700 Offset: 0x1ADF801 VA: 0x1ADF700
	private string GetDisplayFullName(TypeSpec.DisplayNameFormat flags) { }

	// RVA: 0x1ADFC10 Offset: 0x1ADFD11 VA: 0x1ADFC10
	private StringBuilder GetModifierString(StringBuilder sb) { }

	// RVA: 0x1ADFBB0 Offset: 0x1ADFCB1 VA: 0x1ADFBB0
	internal string get_DisplayFullName() { }

	// RVA: 0x1ADEBC0 Offset: 0x1ADECC1 VA: 0x1ADEBC0
	internal static TypeSpec Parse(string typeName) { }

	// RVA: 0x1ADE0B0 Offset: 0x1ADE1B1 VA: 0x1ADE0B0
	internal static string UnescapeInternalName(string displayName) { }

	// RVA: 0x1ADECB0 Offset: 0x1ADEDB1 VA: 0x1ADECB0
	internal Type Resolve(Func<AssemblyName, Assembly> assemblyResolver, Func<Assembly, string, bool, Type> typeResolver, bool throwOnError, bool ignoreCase) { }

	// RVA: 0x1AE0C50 Offset: 0x1AE0D51 VA: 0x1AE0C50
	private void AddName(string type_name) { }

	// RVA: 0x1AE0E70 Offset: 0x1AE0F71 VA: 0x1AE0E70
	private void AddModifier(ModifierSpec md) { }

	// RVA: 0x1AE0F20 Offset: 0x1AE1021 VA: 0x1AE0F20
	private static void SkipSpace(string name, ref int pos) { }

	// RVA: 0x1AE0FF0 Offset: 0x1AE10F1 VA: 0x1AE0FF0
	private static void BoundCheck(int idx, string s) { }

	// RVA: 0x1AE0DF0 Offset: 0x1AE0EF1 VA: 0x1AE0DF0
	private static TypeIdentifier ParsedTypeIdentifier(string displayName) { }

	// RVA: 0x1ADFDC0 Offset: 0x1ADFEC1 VA: 0x1ADFDC0
	private static TypeSpec Parse(string name, ref int p, bool is_recurse, bool allow_aqn) { }

	// RVA: 0x1AE10A0 Offset: 0x1AE11A1 VA: 0x1AE10A0
	public void .ctor() { }
}

