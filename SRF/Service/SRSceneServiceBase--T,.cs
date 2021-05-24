public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 4350
{
	// Fields
	private TImpl _rootObject; // 0x0

	// Properties
	protected abstract string SceneName { get; }
	protected TImpl RootObject { get; }
	public bool IsLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract string get_SceneName() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SRSceneServiceBase<object, object>.get_SceneName
	*/

	// RVA: -1 Offset: -1
	protected TImpl get_RootObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD920 Offset: 0x2CADA21 VA: 0x2CAD920
	|-SRSceneServiceBase<object, object>.get_RootObject
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool get_IsLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD930 Offset: 0x2CADA31 VA: 0x2CAD930
	|-SRSceneServiceBase<object, object>.get_IsLoaded
	*/

	[ConditionalAttribute] // RVA: 0x128290 Offset: 0x128391 VA: 0x128290
	// RVA: -1 Offset: -1
	private void Log(string msg, Object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD9A0 Offset: 0x2CADAA1 VA: 0x2CAD9A0
	|-SRSceneServiceBase<object, object>.Log
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA20 Offset: 0x2CADB21 VA: 0x2CADA20
	|-SRSceneServiceBase<object, object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA80 Offset: 0x2CADB81 VA: 0x2CADA80
	|-SRSceneServiceBase<object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB50 Offset: 0x2CADC51 VA: 0x2CADB50
	|-SRSceneServiceBase<object, object>.OnLoaded
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1282D0 Offset: 0x1283D1 VA: 0x1282D0
	// RVA: -1 Offset: -1
	private IEnumerator LoadCoroutine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB60 Offset: 0x2CADC61 VA: 0x2CADB60
	|-SRSceneServiceBase<object, object>.LoadCoroutine
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADBF0 Offset: 0x2CADCF1 VA: 0x2CADBF0
	|-SRSceneServiceBase<object, object>..ctor
	*/
}

public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 4350
{
	// Fields
	private TImpl _rootObject; // 0x0

	// Properties
	protected abstract string SceneName { get; }
	protected TImpl RootObject { get; }
	public bool IsLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract string get_SceneName() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SRSceneServiceBase<object, object>.get_SceneName
	*/

	// RVA: -1 Offset: -1
	protected TImpl get_RootObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD920 Offset: 0x2CADA21 VA: 0x2CAD920
	|-SRSceneServiceBase<object, object>.get_RootObject
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool get_IsLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD930 Offset: 0x2CADA31 VA: 0x2CAD930
	|-SRSceneServiceBase<object, object>.get_IsLoaded
	*/

	[ConditionalAttribute] // RVA: 0x128290 Offset: 0x128391 VA: 0x128290
	// RVA: -1 Offset: -1
	private void Log(string msg, Object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD9A0 Offset: 0x2CADAA1 VA: 0x2CAD9A0
	|-SRSceneServiceBase<object, object>.Log
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA20 Offset: 0x2CADB21 VA: 0x2CADA20
	|-SRSceneServiceBase<object, object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA80 Offset: 0x2CADB81 VA: 0x2CADA80
	|-SRSceneServiceBase<object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB50 Offset: 0x2CADC51 VA: 0x2CADB50
	|-SRSceneServiceBase<object, object>.OnLoaded
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1282D0 Offset: 0x1283D1 VA: 0x1282D0
	// RVA: -1 Offset: -1
	private IEnumerator LoadCoroutine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB60 Offset: 0x2CADC61 VA: 0x2CADB60
	|-SRSceneServiceBase<object, object>.LoadCoroutine
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADBF0 Offset: 0x2CADCF1 VA: 0x2CADBF0
	|-SRSceneServiceBase<object, object>..ctor
	*/
}

public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 4350
{
	// Fields
	private TImpl _rootObject; // 0x0

	// Properties
	protected abstract string SceneName { get; }
	protected TImpl RootObject { get; }
	public bool IsLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract string get_SceneName() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SRSceneServiceBase<object, object>.get_SceneName
	*/

	// RVA: -1 Offset: -1
	protected TImpl get_RootObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD920 Offset: 0x2CADA21 VA: 0x2CAD920
	|-SRSceneServiceBase<object, object>.get_RootObject
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool get_IsLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD930 Offset: 0x2CADA31 VA: 0x2CAD930
	|-SRSceneServiceBase<object, object>.get_IsLoaded
	*/

	[ConditionalAttribute] // RVA: 0x128290 Offset: 0x128391 VA: 0x128290
	// RVA: -1 Offset: -1
	private void Log(string msg, Object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD9A0 Offset: 0x2CADAA1 VA: 0x2CAD9A0
	|-SRSceneServiceBase<object, object>.Log
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA20 Offset: 0x2CADB21 VA: 0x2CADA20
	|-SRSceneServiceBase<object, object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA80 Offset: 0x2CADB81 VA: 0x2CADA80
	|-SRSceneServiceBase<object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB50 Offset: 0x2CADC51 VA: 0x2CADB50
	|-SRSceneServiceBase<object, object>.OnLoaded
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1282D0 Offset: 0x1283D1 VA: 0x1282D0
	// RVA: -1 Offset: -1
	private IEnumerator LoadCoroutine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB60 Offset: 0x2CADC61 VA: 0x2CADB60
	|-SRSceneServiceBase<object, object>.LoadCoroutine
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADBF0 Offset: 0x2CADCF1 VA: 0x2CADBF0
	|-SRSceneServiceBase<object, object>..ctor
	*/
}

public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 4350
{
	// Fields
	private TImpl _rootObject; // 0x0

	// Properties
	protected abstract string SceneName { get; }
	protected TImpl RootObject { get; }
	public bool IsLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract string get_SceneName() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SRSceneServiceBase<object, object>.get_SceneName
	*/

	// RVA: -1 Offset: -1
	protected TImpl get_RootObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD920 Offset: 0x2CADA21 VA: 0x2CAD920
	|-SRSceneServiceBase<object, object>.get_RootObject
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool get_IsLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD930 Offset: 0x2CADA31 VA: 0x2CAD930
	|-SRSceneServiceBase<object, object>.get_IsLoaded
	*/

	[ConditionalAttribute] // RVA: 0x128290 Offset: 0x128391 VA: 0x128290
	// RVA: -1 Offset: -1
	private void Log(string msg, Object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD9A0 Offset: 0x2CADAA1 VA: 0x2CAD9A0
	|-SRSceneServiceBase<object, object>.Log
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA20 Offset: 0x2CADB21 VA: 0x2CADA20
	|-SRSceneServiceBase<object, object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA80 Offset: 0x2CADB81 VA: 0x2CADA80
	|-SRSceneServiceBase<object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB50 Offset: 0x2CADC51 VA: 0x2CADB50
	|-SRSceneServiceBase<object, object>.OnLoaded
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1282D0 Offset: 0x1283D1 VA: 0x1282D0
	// RVA: -1 Offset: -1
	private IEnumerator LoadCoroutine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB60 Offset: 0x2CADC61 VA: 0x2CADB60
	|-SRSceneServiceBase<object, object>.LoadCoroutine
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADBF0 Offset: 0x2CADCF1 VA: 0x2CADBF0
	|-SRSceneServiceBase<object, object>..ctor
	*/
}

public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 4350
{
	// Fields
	private TImpl _rootObject; // 0x0

	// Properties
	protected abstract string SceneName { get; }
	protected TImpl RootObject { get; }
	public bool IsLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract string get_SceneName() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SRSceneServiceBase<object, object>.get_SceneName
	*/

	// RVA: -1 Offset: -1
	protected TImpl get_RootObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD920 Offset: 0x2CADA21 VA: 0x2CAD920
	|-SRSceneServiceBase<object, object>.get_RootObject
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool get_IsLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD930 Offset: 0x2CADA31 VA: 0x2CAD930
	|-SRSceneServiceBase<object, object>.get_IsLoaded
	*/

	[ConditionalAttribute] // RVA: 0x128290 Offset: 0x128391 VA: 0x128290
	// RVA: -1 Offset: -1
	private void Log(string msg, Object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD9A0 Offset: 0x2CADAA1 VA: 0x2CAD9A0
	|-SRSceneServiceBase<object, object>.Log
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA20 Offset: 0x2CADB21 VA: 0x2CADA20
	|-SRSceneServiceBase<object, object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA80 Offset: 0x2CADB81 VA: 0x2CADA80
	|-SRSceneServiceBase<object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB50 Offset: 0x2CADC51 VA: 0x2CADB50
	|-SRSceneServiceBase<object, object>.OnLoaded
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1282D0 Offset: 0x1283D1 VA: 0x1282D0
	// RVA: -1 Offset: -1
	private IEnumerator LoadCoroutine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB60 Offset: 0x2CADC61 VA: 0x2CADB60
	|-SRSceneServiceBase<object, object>.LoadCoroutine
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADBF0 Offset: 0x2CADCF1 VA: 0x2CADBF0
	|-SRSceneServiceBase<object, object>..ctor
	*/
}

public abstract class SRSceneServiceBase<T, TImpl> : SRServiceBase<T>, IAsyncService // TypeDefIndex: 4350
{
	// Fields
	private TImpl _rootObject; // 0x0

	// Properties
	protected abstract string SceneName { get; }
	protected TImpl RootObject { get; }
	public bool IsLoaded { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 12
	protected abstract string get_SceneName() { }
	/* GenericInstMethod :
	|
	|-RVA: -1 Offset: -1
	|-SRSceneServiceBase<object, object>.get_SceneName
	*/

	// RVA: -1 Offset: -1
	protected TImpl get_RootObject() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD920 Offset: 0x2CADA21 VA: 0x2CAD920
	|-SRSceneServiceBase<object, object>.get_RootObject
	*/

	// RVA: -1 Offset: -1 Slot: 11
	public bool get_IsLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD930 Offset: 0x2CADA31 VA: 0x2CAD930
	|-SRSceneServiceBase<object, object>.get_IsLoaded
	*/

	[ConditionalAttribute] // RVA: 0x128290 Offset: 0x128391 VA: 0x128290
	// RVA: -1 Offset: -1
	private void Log(string msg, Object target) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CAD9A0 Offset: 0x2CADAA1 VA: 0x2CAD9A0
	|-SRSceneServiceBase<object, object>.Log
	*/

	// RVA: -1 Offset: -1 Slot: 5
	protected override void Start() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA20 Offset: 0x2CADB21 VA: 0x2CADA20
	|-SRSceneServiceBase<object, object>.Start
	*/

	// RVA: -1 Offset: -1 Slot: 10
	protected override void OnDestroy() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADA80 Offset: 0x2CADB81 VA: 0x2CADA80
	|-SRSceneServiceBase<object, object>.OnDestroy
	*/

	// RVA: -1 Offset: -1 Slot: 13
	protected virtual void OnLoaded() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB50 Offset: 0x2CADC51 VA: 0x2CADB50
	|-SRSceneServiceBase<object, object>.OnLoaded
	*/

	[IteratorStateMachineAttribute] // RVA: 0x1282D0 Offset: 0x1283D1 VA: 0x1282D0
	// RVA: -1 Offset: -1
	private IEnumerator LoadCoroutine() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADB60 Offset: 0x2CADC61 VA: 0x2CADB60
	|-SRSceneServiceBase<object, object>.LoadCoroutine
	*/

	// RVA: -1 Offset: -1
	protected void .ctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x2CADBF0 Offset: 0x2CADCF1 VA: 0x2CADBF0
	|-SRSceneServiceBase<object, object>..ctor
	*/
}

