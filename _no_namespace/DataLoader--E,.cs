public abstract class DataLoader<E, T> : SingletonMonoBehaviour<T> // TypeDefIndex: 6813
{
	// Fields
	private Dictionary<E, ScriptableObject> LoadedDic; // 0x0
	private int LoadCount; // 0x0
	private int LoadCountMax; // 0x0

	// Properties
	public bool IsCompleted { get; }
	public bool IsLoading { get; }
	protected virtual int LoadPriority { get; }

	// Methods

	// RVA: -1 Offset: -1
	public bool get_IsCompleted() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C881F0 Offset: 0x2C882F1 VA: 0x2C881F0
	|-DataLoader<Master, MasterDataLoader>.get_IsCompleted
	|-DataLoader<MasterPreload, PreloadMasterDataLoader>.get_IsCompleted
	|-DataLoader<Int32Enum, object>.get_IsCompleted
	|
	|-RVA: 0x2C88760 Offset: 0x2C88861 VA: 0x2C88760
	|-DataLoader<object, object>.get_IsCompleted
	*/

	// RVA: -1 Offset: -1
	public bool get_IsLoading() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C88200 Offset: 0x2C88301 VA: 0x2C88200
	|-DataLoader<Int32Enum, object>.get_IsLoading
	|
	|-RVA: 0x2C88770 Offset: 0x2C88871 VA: 0x2C88770
	|-DataLoader<object, object>.get_IsLoading
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected virtual int get_LoadPriority() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C88240 Offset: 0x2C88341 VA: 0x2C88240
	|-DataLoader<Master, MasterDataLoader>.get_LoadPriority
	|-DataLoader<Int32Enum, object>.get_LoadPriority
	|
	|-RVA: 0x2C887B0 Offset: 0x2C888B1 VA: 0x2C887B0
	|-DataLoader<object, object>.get_LoadPriority
	*/

	// RVA: -1 Offset: -1
	public bool Load() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C88250 Offset: 0x2C88351 VA: 0x2C88250
	|-DataLoader<Master, MasterDataLoader>.Load
	|-DataLoader<MasterPreload, PreloadMasterDataLoader>.Load
	|-DataLoader<Int32Enum, object>.Load
	|
	|-RVA: 0x2C887C0 Offset: 0x2C888C1 VA: 0x2C887C0
	|-DataLoader<object, object>.Load
	*/

	// RVA: -1 Offset: -1
	private void Load_internal(E id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C88470 Offset: 0x2C88571 VA: 0x2C88470
	|-DataLoader<Int32Enum, object>.Load_internal
	|
	|-RVA: 0x2C889B0 Offset: 0x2C88AB1 VA: 0x2C889B0
	|-DataLoader<object, object>.Load_internal
	*/

	// RVA: -1 Offset: -1
	public ScriptableObject Get(E id) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C88610 Offset: 0x2C88711 VA: 0x2C88610
	|-DataLoader<Master, MasterDataLoader>.Get
	|-DataLoader<MasterPreload, PreloadMasterDataLoader>.Get
	|-DataLoader<Int32Enum, object>.Get
	|
	|-RVA: 0x2C88B30 Offset: 0x2C88C31 VA: 0x2C88B30
	|-DataLoader<object, object>.Get
	*/

	// RVA: -1 Offset: -1
	public void Reset() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C88690 Offset: 0x2C88791 VA: 0x2C88690
	|-DataLoader<Master, MasterDataLoader>.Reset
	|-DataLoader<MasterPreload, PreloadMasterDataLoader>.Reset
	|-DataLoader<Int32Enum, object>.Reset
	|
	|-RVA: 0x2C88BB0 Offset: 0x2C88CB1 VA: 0x2C88BB0
	|-DataLoader<object, object>.Reset
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2C886C0 Offset: 0x2C887C1 VA: 0x2C886C0
	|-DataLoader<Master, MasterDataLoader>..ctor
	|-DataLoader<MasterPreload, PreloadMasterDataLoader>..ctor
	|-DataLoader<Int32Enum, object>..ctor
	|
	|-RVA: 0x2C88BE0 Offset: 0x2C88CE1 VA: 0x2C88BE0
	|-DataLoader<object, object>..ctor
	*/
}

