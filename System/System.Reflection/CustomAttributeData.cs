[ComVisibleAttribute] // RVA: 0xAE1B0 Offset: 0xAE2B1 VA: 0xAE1B0
[Serializable]
public class CustomAttributeData // TypeDefIndex: 572
{
	// Fields
	private ConstructorInfo ctorInfo; // 0x10
	private IList<CustomAttributeTypedArgument> ctorArgs; // 0x18
	private IList<CustomAttributeNamedArgument> namedArgs; // 0x20
	private CustomAttributeData.LazyCAttrData lazyData; // 0x28

	// Properties
	[ComVisibleAttribute] // RVA: 0xBA150 Offset: 0xBA251 VA: 0xBA150
	public virtual ConstructorInfo Constructor { get; }
	[ComVisibleAttribute] // RVA: 0xBA170 Offset: 0xBA271 VA: 0xBA170
	public virtual IList<CustomAttributeTypedArgument> ConstructorArguments { get; }
	public virtual IList<CustomAttributeNamedArgument> NamedArguments { get; }
	public Type AttributeType { get; }

	// Methods

	// RVA: 0x195BD30 Offset: 0x195BE31 VA: 0x195BD30
	protected void .ctor() { }

	// RVA: 0x195BD40 Offset: 0x195BE41 VA: 0x195BD40
	internal void .ctor(ConstructorInfo ctorInfo, Assembly assembly, IntPtr data, uint data_length) { }

	// RVA: 0x195BE30 Offset: 0x195BF31 VA: 0x195BE30
	private static void ResolveArgumentsInternal(ConstructorInfo ctor, Assembly assembly, IntPtr data, uint data_length, out object[] ctorArgs, out object[] namedArgs) { }

	// RVA: 0x195BE40 Offset: 0x195BF41 VA: 0x195BE40
	private void ResolveArguments() { }

	// RVA: 0x195BFA0 Offset: 0x195C0A1 VA: 0x195BFA0 Slot: 4
	public virtual ConstructorInfo get_Constructor() { }

	// RVA: 0x195BFB0 Offset: 0x195C0B1 VA: 0x195BFB0 Slot: 5
	public virtual IList<CustomAttributeTypedArgument> get_ConstructorArguments() { }

	// RVA: 0x195BFE0 Offset: 0x195C0E1 VA: 0x195BFE0 Slot: 6
	public virtual IList<CustomAttributeNamedArgument> get_NamedArguments() { }

	// RVA: 0x195C010 Offset: 0x195C111 VA: 0x195C010
	public static IList<CustomAttributeData> GetCustomAttributes(Assembly target) { }

	// RVA: 0x195C080 Offset: 0x195C181 VA: 0x195C080
	public static IList<CustomAttributeData> GetCustomAttributes(MemberInfo target) { }

	// RVA: 0x195C0F0 Offset: 0x195C1F1 VA: 0x195C0F0
	internal static IList<CustomAttributeData> GetCustomAttributesInternal(RuntimeType target) { }

	// RVA: 0x195C160 Offset: 0x195C261 VA: 0x195C160
	public static IList<CustomAttributeData> GetCustomAttributes(Module target) { }

	// RVA: 0x195C1D0 Offset: 0x195C2D1 VA: 0x195C1D0
	public static IList<CustomAttributeData> GetCustomAttributes(ParameterInfo target) { }

	// RVA: 0x195C240 Offset: 0x195C341 VA: 0x195C240
	public Type get_AttributeType() { }

	// RVA: 0x195C260 Offset: 0x195C361 VA: 0x195C260 Slot: 3
	public override string ToString() { }

	// RVA: -1 Offset: -1
	private static T[] UnboxValues<T>(object[] values) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2274840 Offset: 0x2274941 VA: 0x2274840
	|-CustomAttributeData.UnboxValues<object>
	|
	|-RVA: 0x2274970 Offset: 0x2274A71 VA: 0x2274970
	|-CustomAttributeData.UnboxValues<CustomAttributeNamedArgument>
	|
	|-RVA: 0x2274AB0 Offset: 0x2274BB1 VA: 0x2274AB0
	|-CustomAttributeData.UnboxValues<CustomAttributeTypedArgument>
	*/

	// RVA: 0x195CAC0 Offset: 0x195CBC1 VA: 0x195CAC0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x195D330 Offset: 0x195D431 VA: 0x195D330 Slot: 2
	public override int GetHashCode() { }
}

