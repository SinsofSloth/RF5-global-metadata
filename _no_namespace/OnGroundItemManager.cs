public class OnGroundItemManager : SingletonMonoBehaviour<OnGroundItemManager> // TypeDefIndex: 7690
{
	// Fields
	public const int FieldMax = 15;
	[CompilerGeneratedAttribute] // RVA: 0x1689F0 Offset: 0x168AF1 VA: 0x1689F0
	private readonly LinkedList<FieldOnGroundItemInfo> <InfoList>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x168A00 Offset: 0x168B01 VA: 0x168A00
	private readonly Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>> <OnGroundItems>k__BackingField; // 0x20
	private bool prevFrame_IsHideByCamera; // 0x28

	// Properties
	public LinkedList<FieldOnGroundItemInfo> InfoList { get; }
	public Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>> OnGroundItems { get; }
	public static bool IsHideByCamera { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x1A2640 Offset: 0x1A2741 VA: 0x1A2640
	// RVA: 0x1F19210 Offset: 0x1F19311 VA: 0x1F19210
	public LinkedList<FieldOnGroundItemInfo> get_InfoList() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A2650 Offset: 0x1A2751 VA: 0x1A2650
	// RVA: 0x1F19220 Offset: 0x1F19321 VA: 0x1F19220
	public Dictionary<OnGroundItem, LinkedListNode<FieldOnGroundItemInfo>> get_OnGroundItems() { }

	// RVA: 0x1F19230 Offset: 0x1F19331 VA: 0x1F19230
	public void Regist(OnGroundItem onGroundItem) { }

	// RVA: 0x1F19530 Offset: 0x1F19631 VA: 0x1F19530
	public void Remove(OnGroundItem onGroundItem) { }

	// RVA: 0x1F196A0 Offset: 0x1F197A1 VA: 0x1F196A0
	public void OnDestroyOnGroundItem(OnGroundItem onGroundItem) { }

	// RVA: 0x1F197C0 Offset: 0x1F198C1 VA: 0x1F197C0
	public void OnSceneChanged(FieldSceneId nextScene) { }

	// RVA: 0x1F199F0 Offset: 0x1F19AF1 VA: 0x1F199F0
	public void UpdateMeshShadow(Func<float, bool> checkEnableShadowFunc) { }

	// RVA: 0x1F19D20 Offset: 0x1F19E21 VA: 0x1F19D20
	public void ResetMeshShadow() { }

	// RVA: 0x1F19EF0 Offset: 0x1F19FF1 VA: 0x1F19EF0
	public static bool get_IsHideByCamera() { }

	// RVA: 0x1F19FB0 Offset: 0x1F1A0B1 VA: 0x1F19FB0
	private void Update() { }

	// RVA: 0x1F1A280 Offset: 0x1F1A381 VA: 0x1F1A280
	private void Start() { }

	// RVA: 0x1F1A3D0 Offset: 0x1F1A4D1 VA: 0x1F1A3D0
	public void PrevSave() { }

	// RVA: 0x1F1A5F0 Offset: 0x1F1A6F1 VA: 0x1F1A5F0
	private void OnChangeScene() { }

	// RVA: 0x1F1A650 Offset: 0x1F1A751 VA: 0x1F1A650
	public void .ctor() { }
}

