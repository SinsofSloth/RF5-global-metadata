[ComVisibleAttribute] // RVA: 0xAB920 Offset: 0xABA21 VA: 0xAB920
[ComDefaultInterfaceAttribute] // RVA: 0xAB920 Offset: 0xABA21 VA: 0xAB920
[ClassInterfaceAttribute] // RVA: 0xAB920 Offset: 0xABA21 VA: 0xAB920
public sealed class Activator // TypeDefIndex: 173
{
	// Methods

	// RVA: 0x190A8D0 Offset: 0x190A9D1 VA: 0x190A8D0
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture) { }

	// RVA: 0x190A8E0 Offset: 0x190A9E1 VA: 0x190A8E0
	public static object CreateInstance(Type type, BindingFlags bindingAttr, Binder binder, object[] args, CultureInfo culture, object[] activationAttributes) { }

	// RVA: 0x190AB10 Offset: 0x190AC11 VA: 0x190AB10
	public static object CreateInstance(Type type, object[] args) { }

	// RVA: 0x18F5510 Offset: 0x18F5611 VA: 0x18F5510
	public static object CreateInstance(Type type) { }

	// RVA: 0x190AB30 Offset: 0x190AC31 VA: 0x190AB30
	public static object CreateInstance(Type type, bool nonPublic) { }

	// RVA: -1 Offset: -1
	public static T CreateInstance<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23C8240 Offset: 0x23C8341 VA: 0x23C8240
	|-Activator.CreateInstance<CropDataTable>
	|
	|-RVA: 0x23C83C0 Offset: 0x23C84C1 VA: 0x23C83C0
	|-Activator.CreateInstance<EffectDataTable>
	|
	|-RVA: 0x23C8540 Offset: 0x23C8641 VA: 0x23C8540
	|-Activator.CreateInstance<GimmickLayoutDataTable>
	|
	|-RVA: 0x23C86B0 Offset: 0x23C87B1 VA: 0x23C86B0
	|-Activator.CreateInstance<MineTypeDataTable>
	|
	|-RVA: 0x23C8840 Offset: 0x23C8941 VA: 0x23C8840
	|-Activator.CreateInstance<MiningDataTable>
	|
	|-RVA: 0x23C89B0 Offset: 0x23C8AB1 VA: 0x23C89B0
	|-Activator.CreateInstance<object>
	*/
}

