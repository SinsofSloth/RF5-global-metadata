public class ResourcesMng<T, Type> : SingletonMonoBehaviour<T> // TypeDefIndex: 6839
{
	// Fields
	public int WORK_MAX; // 0x0
	public const int INDEX_EMPTY = -1;
	public int m_baseLevel; // 0x0
	protected ResourcesMng.ResourcesWork<T, Type>[] m_pBuf; // 0x0
	protected string m_rootDirName; // 0x0
	private static int logcounter; // 0x0

	// Properties
	public virtual bool isLog { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	protected override void Awake() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5110 Offset: 0x2CA5211 VA: 0x2CA5110
	|-ResourcesMng<object, object>.Awake
	*/

	// RVA: -1 Offset: -1
	private int GetEmptyIndex() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5340 Offset: 0x2CA5441 VA: 0x2CA5340
	|-ResourcesMng<object, object>.GetEmptyIndex
	*/

	// RVA: -1 Offset: -1
	private int GetIndex(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA53C0 Offset: 0x2CA54C1 VA: 0x2CA53C0
	|-ResourcesMng<object, object>.GetIndex
	*/

	// RVA: -1 Offset: -1
	public int GetOldIndex(int level) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5450 Offset: 0x2CA5551 VA: 0x2CA5450
	|-ResourcesMng<object, object>.GetOldIndex
	*/

	// RVA: -1 Offset: -1
	protected int SearchLoaded(string name, bool notCheckEnable = False) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5520 Offset: 0x2CA5621 VA: 0x2CA5520
	|-ResourcesMng<object, object>.SearchLoaded
	*/

	[IteratorStateMachineAttribute] // RVA: 0x19D3E0 Offset: 0x19D4E1 VA: 0x19D3E0
	// RVA: -1 Offset: -1
	public IEnumerator LoadResource(string name, Action<Type> onComp, int level = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5650 Offset: 0x2CA5751 VA: 0x2CA5650
	|-ResourcesMng<object, object>.LoadResource
	*/

	// RVA: -1 Offset: -1 Slot: 5
	public virtual bool get_isLog() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5710 Offset: 0x2CA5811 VA: 0x2CA5710
	|-ResourcesMng<object, object>.get_isLog
	*/

	[IteratorStateMachineAttribute] // RVA: 0x19D450 Offset: 0x19D551 VA: 0x19D450
	// RVA: -1 Offset: -1
	public IEnumerator GetOrLoadAsync(string name, Action<Type> onComp, int level = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5720 Offset: 0x2CA5821 VA: 0x2CA5720
	|-ResourcesMng<object, object>.GetOrLoadAsync
	*/

	[IteratorStateMachineAttribute] // RVA: 0x19D4C0 Offset: 0x19D5C1 VA: 0x19D4C0
	// RVA: -1 Offset: -1
	protected IEnumerator LoadData(int index, string name, UnityAction<int> callback, int level = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA57E0 Offset: 0x2CA58E1 VA: 0x2CA57E0
	|-ResourcesMng<object, object>.LoadData
	*/

	// RVA: -1 Offset: -1
	protected void LoadData(int index, string name, Master id, UnityAction<int> callback, int level = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA58B0 Offset: 0x2CA59B1 VA: 0x2CA58B0
	|-ResourcesMng<object, object>.LoadData
	*/

	// RVA: -1 Offset: -1 Slot: 6
	protected virtual void ReleaseData(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5A30 Offset: 0x2CA5B31 VA: 0x2CA5A30
	|-ResourcesMng<object, object>.ReleaseData
	*/

	// RVA: -1 Offset: -1 Slot: 7
	public virtual string GetResourcePath() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5A80 Offset: 0x2CA5B81 VA: 0x2CA5A80
	|-ResourcesMng<object, object>.GetResourcePath
	*/

	// RVA: -1 Offset: -1
	public Type GetData(int index) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5AD0 Offset: 0x2CA5BD1 VA: 0x2CA5AD0
	|-ResourcesMng<object, object>.GetData
	*/

	// RVA: -1 Offset: -1
	public Type GetData(string name) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5B40 Offset: 0x2CA5C41 VA: 0x2CA5B40
	|-ResourcesMng<object, object>.GetData
	*/

	// RVA: -1 Offset: -1
	public void AllRelease() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5C00 Offset: 0x2CA5D01 VA: 0x2CA5C00
	|-ResourcesMng<object, object>.AllRelease
	*/

	// RVA: -1 Offset: -1
	public void AllReleaseLevel(int level = -1) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5C50 Offset: 0x2CA5D51 VA: 0x2CA5C50
	|-ResourcesMng<object, object>.AllReleaseLevel
	*/

	// RVA: -1 Offset: -1
	public void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5D00 Offset: 0x2CA5E01 VA: 0x2CA5D00
	|-ResourcesMng<object, object>..ctor
	*/

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CA5D90 Offset: 0x2CA5E91 VA: 0x2CA5D90
	|-ResourcesMng<object, object>..cctor
	*/
}

