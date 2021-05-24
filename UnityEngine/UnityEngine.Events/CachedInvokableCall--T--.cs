internal class CachedInvokableCall<T> : InvokableCall<T> // TypeDefIndex: 3100
{
	// Fields
	private readonly T m_Arg1; // 0x0

	// Methods

	// RVA: -1 Offset: -1
	public void .ctor(Object target, MethodInfo theFunction, T argument) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C22A0 Offset: 0x28C23A1 VA: 0x28C22A0
	|-CachedInvokableCall<bool>..ctor
	|
	|-RVA: 0x28C2350 Offset: 0x28C2451 VA: 0x28C2350
	|-CachedInvokableCall<int>..ctor
	|
	|-RVA: 0x28C23F0 Offset: 0x28C24F1 VA: 0x28C23F0
	|-CachedInvokableCall<object>..ctor
	|-CachedInvokableCall<string>..ctor
	|
	|-RVA: 0x28C24A0 Offset: 0x28C25A1 VA: 0x28C24A0
	|-CachedInvokableCall<float>..ctor
	*/

	// RVA: -1 Offset: -1 Slot: 4
	public override void Invoke(object[] args) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C22F0 Offset: 0x28C23F1 VA: 0x28C22F0
	|-CachedInvokableCall<bool>.Invoke
	|
	|-RVA: 0x28C2390 Offset: 0x28C2491 VA: 0x28C2390
	|-CachedInvokableCall<int>.Invoke
	|
	|-RVA: 0x28C2440 Offset: 0x28C2541 VA: 0x28C2440
	|-CachedInvokableCall<object>.Invoke
	|
	|-RVA: 0x28C24F0 Offset: 0x28C25F1 VA: 0x28C24F0
	|-CachedInvokableCall<float>.Invoke
	*/

	// RVA: -1 Offset: -1 Slot: 6
	public override void Invoke(T arg0) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x28C2320 Offset: 0x28C2421 VA: 0x28C2320
	|-CachedInvokableCall<bool>.Invoke
	|
	|-RVA: 0x28C23C0 Offset: 0x28C24C1 VA: 0x28C23C0
	|-CachedInvokableCall<int>.Invoke
	|
	|-RVA: 0x28C2470 Offset: 0x28C2571 VA: 0x28C2470
	|-CachedInvokableCall<object>.Invoke
	|
	|-RVA: 0x28C2520 Offset: 0x28C2621 VA: 0x28C2520
	|-CachedInvokableCall<float>.Invoke
	*/
}

