public abstract class Singleton<T> // TypeDefIndex: 11726
{
	// Fields
	private static T instance; // 0x0

	// Properties
	public static T Instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	private static bool Compare<U>(U x, U y) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x25191A0 Offset: 0x25192A1 VA: 0x25191A0
	|-Singleton<object>.Compare<object>
	*/

	// RVA: -1 Offset: -1
	public static T get_Instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23820 Offset: 0x2D23921 VA: 0x2D23820
	|-Singleton<BloomHelper>.get_Instance
	|-Singleton<DOFHelper>.get_Instance
	|-Singleton<object>.get_Instance
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23C20 Offset: 0x2D23D21 VA: 0x2D23C20
	|-Singleton<BloomHelper>..ctor
	|-Singleton<DOFHelper>..ctor
	|-Singleton<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2D23C40 Offset: 0x2D23D41 VA: 0x2D23C40
	|-Singleton<object>..cctor
	*/
}

