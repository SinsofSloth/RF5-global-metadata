internal abstract class BaseInvokableCall // TypeDefIndex: 3094
{
	// Methods

	// RVA: 0x2B07850 Offset: 0x2B07951 VA: 0x2B07850
	protected void .ctor() { }

	// RVA: 0x2B07860 Offset: 0x2B07961 VA: 0x2B07860
	protected void .ctor(object target, MethodInfo function) { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract void Invoke(object[] args) { }

	// RVA: -1 Offset: -1
	protected static void ThrowOnInvalidArg<T>(object arg) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x23E3E70 Offset: 0x23E3F71 VA: 0x23E3E70
	|-BaseInvokableCall.ThrowOnInvalidArg<DamageInfo>
	|
	|-RVA: 0x23E4010 Offset: 0x23E4111 VA: 0x23E4010
	|-BaseInvokableCall.ThrowOnInvalidArg<bool>
	|
	|-RVA: 0x23E41B0 Offset: 0x23E42B1 VA: 0x23E41B0
	|-BaseInvokableCall.ThrowOnInvalidArg<int>
	|
	|-RVA: 0x23E4350 Offset: 0x23E4451 VA: 0x23E4350
	|-BaseInvokableCall.ThrowOnInvalidArg<Int32Enum>
	|
	|-RVA: 0x23E44F0 Offset: 0x23E45F1 VA: 0x23E44F0
	|-BaseInvokableCall.ThrowOnInvalidArg<object>
	|
	|-RVA: 0x23E4690 Offset: 0x23E4791 VA: 0x23E4690
	|-BaseInvokableCall.ThrowOnInvalidArg<float>
	|
	|-RVA: 0x23E4830 Offset: 0x23E4931 VA: 0x23E4830
	|-BaseInvokableCall.ThrowOnInvalidArg<Color>
	|
	|-RVA: 0x23E49D0 Offset: 0x23E4AD1 VA: 0x23E49D0
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector2>
	|
	|-RVA: 0x23E4B70 Offset: 0x23E4C71 VA: 0x23E4B70
	|-BaseInvokableCall.ThrowOnInvalidArg<Vector3>
	*/

	// RVA: 0x2B07920 Offset: 0x2B07A21 VA: 0x2B07920
	protected static bool AllowInvoke(Delegate delegate) { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool Find(object targetObj, MethodInfo method) { }
}

