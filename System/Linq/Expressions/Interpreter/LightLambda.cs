internal class LightLambda // TypeDefIndex: 2543
{
	// Fields
	private readonly IStrongBox[] _closure; // 0x10
	private readonly Interpreter _interpreter; // 0x18
	private static readonly CacheDict<Type, Func<LightLambda, Delegate>> _runCache; // 0x0
	private readonly LightDelegateCreator _delegateCreator; // 0x20

	// Methods

	// RVA: 0x190D1B0 Offset: 0x190D2B1 VA: 0x190D1B0
	internal void RunVoid0() { }

	// RVA: 0x190D0A0 Offset: 0x190D1A1 VA: 0x190D0A0
	internal void .ctor(LightDelegateCreator delegateCreator, IStrongBox[] closure) { }

	// RVA: 0x190D330 Offset: 0x190D431 VA: 0x190D330
	private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType) { }

	// RVA: 0x190D4D0 Offset: 0x190D5D1 VA: 0x190D4D0
	private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType) { }

	// RVA: 0x190DD40 Offset: 0x190DE41 VA: 0x190DD40
	private Delegate CreateCustomDelegate(Type delegateType) { }

	// RVA: 0x190D110 Offset: 0x190D211 VA: 0x190D110
	internal Delegate MakeDelegate(Type delegateType) { }

	// RVA: 0x190D2B0 Offset: 0x190D3B1 VA: 0x190D2B0
	private InterpretedFrame MakeFrame() { }

	// RVA: -1 Offset: -1
	internal void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x24B8020 Offset: 0x24B8121 VA: 0x24B8020
	|-LightLambda.RunVoidRef2<object, object>
	*/

	// RVA: 0x190E630 Offset: 0x190E731 VA: 0x190E630
	public object Run(object[] arguments) { }

	// RVA: 0x190E850 Offset: 0x190E951 VA: 0x190E850
	public object RunVoid(object[] arguments) { }

	// RVA: 0x190EA70 Offset: 0x190EB71 VA: 0x190EA70
	private static void .cctor() { }
}

