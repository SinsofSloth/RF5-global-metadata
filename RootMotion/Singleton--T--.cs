public abstract class Singleton<T> : MonoBehaviour // TypeDefIndex: 9324
{
	// Fields
	private static T sInstance; // 0x0

	// Properties
	public static T instance { get; }

	// Methods

	// RVA: -1 Offset: -1
	public static T get_instance() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5DA0 Offset: 0x2CA5EA1 VA: 0x2CA5DA0
	|-Singleton<object>.get_instance
	*/

	// RVA: -1 Offset: -1 Slot: 4
	protected virtual void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5ED0 Offset: 0x2CA5FD1 VA: 0x2CA5ED0
	|-Singleton<object>.Awake
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6130 Offset: 0x2CA6231 VA: 0x2CA6130
	|-Singleton<object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA6150 Offset: 0x2CA6251 VA: 0x2CA6150
	|-Singleton<object>..cctor
	*/
}

