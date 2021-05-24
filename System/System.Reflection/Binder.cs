[ComVisibleAttribute] // RVA: 0xAD8C0 Offset: 0xAD9C1 VA: 0xAD8C0
[ClassInterfaceAttribute] // RVA: 0xAD8C0 Offset: 0xAD9C1 VA: 0xAD8C0
[Serializable]
public abstract class Binder // TypeDefIndex: 531
{
	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract MethodBase BindToMethod(BindingFlags bindingAttr, MethodBase[] match, ref object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] names, out object state) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract FieldInfo BindToField(BindingFlags bindingAttr, FieldInfo[] match, object value, CultureInfo culture) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract MethodBase SelectMethod(BindingFlags bindingAttr, MethodBase[] match, Type[] types, ParameterModifier[] modifiers) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract PropertyInfo SelectProperty(BindingFlags bindingAttr, PropertyInfo[] match, Type returnType, Type[] indexes, ParameterModifier[] modifiers) { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract object ChangeType(object value, Type type, CultureInfo culture) { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void ReorderArgumentArray(ref object[] args, object state) { }

	// RVA: 0x195BAC0 Offset: 0x195BBC1 VA: 0x195BAC0
	protected void .ctor() { }
}

