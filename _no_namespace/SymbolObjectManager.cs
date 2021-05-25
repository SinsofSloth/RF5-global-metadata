public class SymbolObjectManager : SingletonMonoBehaviour<SymbolObjectManager> // TypeDefIndex: 8310
{
	// Fields
	private FocusInterface focusObject; // 0x18
	private FocusInterface[] fieldObject; // 0x20
	private const int FIELD_FOCUS_MAX = 10;
	private SymbolObjectManager.SymbolObject currentFocusSymbol; // 0x28
	private SymbolObjectManager.SymbolObject[] currentFieldSymbol; // 0x30
	private GameObject redTriangle; // 0x38
	private readonly int RED_TRIANGLE_ID; // 0x40
	private GameObject blueTriangle; // 0x48
	private readonly int BLUE_TRIANGLE_ID; // 0x50
	private SpriteSymbolObject spriteSymbolObject; // 0x58
	private readonly int SPRITE_ACCESSSYMBOL_ID; // 0x60
	[SerializeField] // RVA: 0x16ECE0 Offset: 0x16EDE1 VA: 0x16ECE0
	private List<Sprite> iconBorder; // 0x68
	[SerializeField] // RVA: 0x16ECF0 Offset: 0x16EDF1 VA: 0x16ECF0
	private List<Sprite> iconSprite; // 0x70
	[SerializeField] // RVA: 0x16ED00 Offset: 0x16EE01 VA: 0x16ED00
	private SpriteRenderer orderBoardSprite; // 0x78
	[SerializeField] // RVA: 0x16ED10 Offset: 0x16EE11 VA: 0x16ED10
	private float symbolOffset; // 0x80
	private float curveRate; // 0x84
	[SerializeField] // RVA: 0x16ED20 Offset: 0x16EE21 VA: 0x16ED20
	private AnimationCurve animCurve; // 0x88
	[SerializeField] // RVA: 0x16ED30 Offset: 0x16EE31 VA: 0x16ED30
	private float curveSpeed; // 0x90
	[SerializeField] // RVA: 0x16ED40 Offset: 0x16EE41 VA: 0x16ED40
	private float animHeight; // 0x94
	[SerializeField] // RVA: 0x16ED50 Offset: 0x16EE51 VA: 0x16ED50
	private float rotateSpeed; // 0x98
	[SerializeField] // RVA: 0x16ED60 Offset: 0x16EE61 VA: 0x16ED60
	private float startAnimSpeed; // 0x9C

	// Methods

	// RVA: 0x1C65260 Offset: 0x1C65361 VA: 0x1C65260
	private void Start() { }

	// RVA: 0x1C65440 Offset: 0x1C65541 VA: 0x1C65440
	private void LateUpdate() { }

	// RVA: 0x1C68AE0 Offset: 0x1C68BE1 VA: 0x1C68AE0
	private void OnDestroy() { }

	// RVA: 0x1C662F0 Offset: 0x1C663F1 VA: 0x1C662F0
	private bool IsLoading() { }

	// RVA: 0x1C67780 Offset: 0x1C67881 VA: 0x1C67780
	private void CreateFocusSymbolObject(SymbolObjectManager.SymbolObject _symbol) { }

	// RVA: 0x1C67F80 Offset: 0x1C68081 VA: 0x1C67F80
	private void CreateFieldSymbolObject(SymbolObjectManager.SymbolObject _symbol) { }

	// RVA: 0x1C68630 Offset: 0x1C68731 VA: 0x1C68630
	private void UpdateSymbolObject(SymbolObjectManager.SymbolObject _symbol) { }

	// RVA: 0x1C688E0 Offset: 0x1C689E1 VA: 0x1C688E0
	private bool IsCropHarvest(SymbolObjectManager.SymbolObject _symbol) { }

	[IteratorStateMachineAttribute] // RVA: 0x1A6CE0 Offset: 0x1A6DE1 VA: 0x1A6CE0
	// RVA: 0x1C68B70 Offset: 0x1C68C71 VA: 0x1C68B70
	private IEnumerator CreateSymbolAnimation(SymbolObjectManager.SymbolObject _symbol) { }

	// RVA: 0x1C685B0 Offset: 0x1C686B1 VA: 0x1C685B0
	private bool IsSymbolObjectExist() { }

	// RVA: 0x1C66650 Offset: 0x1C66751 VA: 0x1C66650
	private bool CanInteraction(FocusInterface _target) { }

	// RVA: 0x1C66A70 Offset: 0x1C66B71 VA: 0x1C66A70
	private SymbolObjectManager.SymbolObjectType GetSymbolObjectType(FocusInterface _target) { }

	// RVA: 0x1C674A0 Offset: 0x1C675A1 VA: 0x1C674A0
	private float GetSymbolOffest(GameObject _object, Collider _collider) { }

	// RVA: 0x1C67330 Offset: 0x1C67431 VA: 0x1C67330
	private GameObject GetTargetEffectPos(GameObject _object) { }

	// RVA: 0x1C67BC0 Offset: 0x1C67CC1 VA: 0x1C67BC0
	private bool IsFieldObjectFocused() { }

	// RVA: 0x1C663E0 Offset: 0x1C664E1 VA: 0x1C663E0
	private void ClearFocusSymbolObject() { }

	// RVA: 0x1C67DF0 Offset: 0x1C67EF1 VA: 0x1C67DF0
	private void ClearFieldSymbolObject(int _index) { }

	// RVA: 0x1C664C0 Offset: 0x1C665C1 VA: 0x1C664C0
	private void ClearAllFieldSymbolObject() { }

	// RVA: 0x1C64EA0 Offset: 0x1C64FA1 VA: 0x1C64EA0
	public bool IsFocusSymbolTarget(FocusInterface _target) { }

	// RVA: 0x1C64F40 Offset: 0x1C65041 VA: 0x1C64F40
	public bool IsFieldSymbolTarget(FocusInterface _target) { }

	// RVA: 0x1C68CB0 Offset: 0x1C68DB1 VA: 0x1C68CB0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6D50 Offset: 0x1A6E51 VA: 0x1A6D50
	// RVA: 0x1C68DF0 Offset: 0x1C68EF1 VA: 0x1C68DF0
	private void <Start>b__25_0(AssetHandle<GameObject> _handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6D60 Offset: 0x1A6E61 VA: 0x1A6D60
	// RVA: 0x1C68E70 Offset: 0x1C68F71 VA: 0x1C68E70
	private void <Start>b__25_1(AssetHandle<GameObject> _handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6D70 Offset: 0x1A6E71 VA: 0x1A6D70
	// RVA: 0x1C68EF0 Offset: 0x1C68FF1 VA: 0x1C68EF0
	private void <Start>b__25_2(AssetHandle<GameObject> _handle) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A6D80 Offset: 0x1A6E81 VA: 0x1A6D80
	// RVA: 0x1C68F80 Offset: 0x1C69081 VA: 0x1C68F80
	private void <Start>b__25_3() { }
}

