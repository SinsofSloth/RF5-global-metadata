public class UISaveMenuManager : UIScrollBoxBase // TypeDefIndex: 8725
{
	// Fields
	[SerializeField] // RVA: 0x172E70 Offset: 0x172F71 VA: 0x172E70
	private UISaveMenuManager.PageState StartState; // 0x68
	public UISaveMenuManager.PageState nowState; // 0x6C
	[SerializeField] // RVA: 0x172E80 Offset: 0x172F81 VA: 0x172E80
	private GameObject NowSaving; // 0x70
	[SerializeField] // RVA: 0x172E90 Offset: 0x172F91 VA: 0x172E90
	private GameObject NowLoading; // 0x78
	[SerializeField] // RVA: 0x172EA0 Offset: 0x172FA1 VA: 0x172EA0
	private GameObject NowDeleting; // 0x80
	private bool isDeleted; // 0x88
	[SerializeField] // RVA: 0x172EB0 Offset: 0x172FB1 VA: 0x172EB0
	private CursorLinker TopSaveObject; // 0x90
	[SerializeField] // RVA: 0x172EC0 Offset: 0x172FC1 VA: 0x172EC0
	private CursorLinker TopLoadObject; // 0x98
	private int LoadingIndex; // 0xA0
	private NextTargetDataTable nextTargetDataTable; // 0xA8
	private UIMakingMenu UIMakingMenu; // 0xB0
	private UISaveMenuManager.StepState step; // 0xB8
	[SerializeField] // RVA: 0x172ED0 Offset: 0x172FD1 VA: 0x172ED0
	public UISaveMenuManager.SavePageType PageType; // 0xBC
	[SerializeField] // RVA: 0x172EE0 Offset: 0x172FE1 VA: 0x172EE0
	private TwoChoicePopupLite TwoChoicePopupLite; // 0xC0
	[SerializeField] // RVA: 0x172EF0 Offset: 0x172FF1 VA: 0x172EF0
	private NoChoicePopupLite NoChoicePopupLite; // 0xC8
	private List<RF5ThumbnailData> thumbSaveDatas; // 0xD0
	private int latestSaveSlot; // 0xD8
	[SerializeField] // RVA: 0x172F00 Offset: 0x173001 VA: 0x172F00
	private CursorControllerLite cursorControllerLite; // 0xE0
	[SerializeField] // RVA: 0x172F10 Offset: 0x173011 VA: 0x172F10
	private ButtonHintMain buttonHint; // 0xE8
	private bool onPopupSelectingOnTitle; // 0xF0

	// Properties
	private NextTargetDataTable NextTargetDataTable { get; }
	public bool CampScreen { get; }
	public bool TitleLoadScreen { get; }
	public bool MakingScreen { get; }

	// Methods

	// RVA: 0x1DD5960 Offset: 0x1DD5A61 VA: 0x1DD5960
	private NextTargetDataTable get_NextTargetDataTable() { }

	// RVA: 0x1DD47A0 Offset: 0x1DD48A1 VA: 0x1DD47A0
	public bool get_CampScreen() { }

	// RVA: 0x1DD4FC0 Offset: 0x1DD50C1 VA: 0x1DD4FC0
	public bool get_TitleLoadScreen() { }

	// RVA: 0x1DD4FD0 Offset: 0x1DD50D1 VA: 0x1DD4FD0
	public bool get_MakingScreen() { }

	// RVA: 0x1DD5A60 Offset: 0x1DD5B61 VA: 0x1DD5A60 Slot: 8
	protected override void Start() { }

	// RVA: 0x1DD5AB0 Offset: 0x1DD5BB1 VA: 0x1DD5AB0 Slot: 10
	protected override void OnDisable() { }

	// RVA: 0x1DD5B60 Offset: 0x1DD5C61 VA: 0x1DD5B60
	private void SetThumpDataSave() { }

	// RVA: 0x1DD5C50 Offset: 0x1DD5D51 VA: 0x1DD5C50
	public void ChangeState(UISaveMenuManager.PageState state) { }

	// RVA: 0x1DD5EB0 Offset: 0x1DD5FB1 VA: 0x1DD5EB0
	private void OnEnable() { }

	// RVA: 0x1DD60F0 Offset: 0x1DD61F1 VA: 0x1DD60F0
	public void FocusLatestSlot() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A81C0 Offset: 0x1A82C1 VA: 0x1A81C0
	// RVA: 0x1DD6070 Offset: 0x1DD6171 VA: 0x1DD6070
	private IEnumerator SetupButtonHint() { }

	// RVA: 0x1DD63B0 Offset: 0x1DD64B1 VA: 0x1DD63B0 Slot: 9
	protected override void Update() { }

	// RVA: 0x1DD6E60 Offset: 0x1DD6F61 VA: 0x1DD6E60
	private void DoAfterSaved(ErrorCode errCode) { }

	// RVA: 0x1DD7010 Offset: 0x1DD7111 VA: 0x1DD7010
	private void LoadGame(int focusingNo) { }

	// RVA: 0x1DD63E0 Offset: 0x1DD64E1 VA: 0x1DD63E0
	private void UpdateLoadSave() { }

	// RVA: 0x1DD7110 Offset: 0x1DD7211 VA: 0x1DD7110
	private void OpenNoVersionErrorPopup() { }

	// RVA: 0x1DD71C0 Offset: 0x1DD72C1 VA: 0x1DD71C0
	private void OpenDeleteCheckPopup() { }

	[IteratorStateMachineAttribute] // RVA: 0x1A8230 Offset: 0x1A8331 VA: 0x1A8230
	// RVA: 0x1DD7470 Offset: 0x1DD7571 VA: 0x1DD7470
	private IEnumerator OpenDeletedPopup() { }

	// RVA: 0x1DD7520 Offset: 0x1DD7621 VA: 0x1DD7520
	public void DoSaveBlockAction() { }

	// RVA: 0x1DD7EC0 Offset: 0x1DD7FC1 VA: 0x1DD7EC0
	private bool CheckCanDoSaveAction() { }

	// RVA: 0x1DD7F70 Offset: 0x1DD8071 VA: 0x1DD7F70
	public void OpenMakingUILoadPage(UIMakingMenu _UIMakingMenu) { }

	// RVA: 0x1DD7FB0 Offset: 0x1DD80B1 VA: 0x1DD7FB0 Slot: 5
	protected override int GetListCount() { }

	// RVA: 0x1DD8000 Offset: 0x1DD8101 VA: 0x1DD8000 Slot: 6
	protected override void SetButtonDisp(UIButtonLinkerInScrollBox button) { }

	// RVA: 0x1DD8100 Offset: 0x1DD8201 VA: 0x1DD8100 Slot: 7
	public override void SetFocusDetail() { }

	// RVA: 0x1DD81D0 Offset: 0x1DD82D1 VA: 0x1DD81D0
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A82A0 Offset: 0x1A83A1 VA: 0x1A82A0
	// RVA: 0x1DD81F0 Offset: 0x1DD82F1 VA: 0x1DD81F0
	private bool <SetupButtonHint>b__36_0() { }

	[CompilerGeneratedAttribute] // RVA: 0x1A82B0 Offset: 0x1A83B1 VA: 0x1A82B0
	// RVA: 0x1DD8210 Offset: 0x1DD8311 VA: 0x1DD8210
	private void <DoAfterSaved>b__38_0(bool a) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A82C0 Offset: 0x1A83C1 VA: 0x1A82C0
	// RVA: 0x1DD82E0 Offset: 0x1DD83E1 VA: 0x1DD82E0
	private void <DoAfterSaved>b__38_1(bool a) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A82D0 Offset: 0x1A83D1 VA: 0x1A82D0
	// RVA: 0x1DD83B0 Offset: 0x1DD84B1 VA: 0x1DD83B0
	private void <UpdateLoadSave>b__41_0(bool a) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A82E0 Offset: 0x1A83E1 VA: 0x1A82E0
	// RVA: 0x1DD8440 Offset: 0x1DD8541 VA: 0x1DD8440
	private void <UpdateLoadSave>b__41_3(bool select) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A82F0 Offset: 0x1A83F1 VA: 0x1A82F0
	// RVA: 0x1DD8450 Offset: 0x1DD8551 VA: 0x1DD8450
	private void <UpdateLoadSave>b__41_1(bool select) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8300 Offset: 0x1A8401 VA: 0x1A8300
	// RVA: 0x1DD8460 Offset: 0x1DD8561 VA: 0x1DD8460
	private void <UpdateLoadSave>b__41_4(bool select) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8310 Offset: 0x1A8411 VA: 0x1A8310
	// RVA: 0x1DD8470 Offset: 0x1DD8571 VA: 0x1DD8470
	private void <UpdateLoadSave>b__41_2(bool select) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8320 Offset: 0x1A8421 VA: 0x1A8320
	// RVA: 0x1DD8480 Offset: 0x1DD8581 VA: 0x1DD8480
	private void <OpenDeleteCheckPopup>b__43_1(bool select) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8330 Offset: 0x1A8431 VA: 0x1A8330
	// RVA: 0x1DD85D0 Offset: 0x1DD86D1 VA: 0x1DD85D0
	private void <OpenDeleteCheckPopup>b__43_2(ErrorCode a) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8340 Offset: 0x1A8441 VA: 0x1A8340
	// RVA: 0x1DD85E0 Offset: 0x1DD86E1 VA: 0x1DD85E0
	private void <OpenDeleteCheckPopup>b__43_0(bool select) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8350 Offset: 0x1A8451 VA: 0x1A8350
	// RVA: 0x1DD87D0 Offset: 0x1DD88D1 VA: 0x1DD87D0
	private void <OpenDeleteCheckPopup>b__43_3(ErrorCode a) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8360 Offset: 0x1A8461 VA: 0x1A8360
	// RVA: 0x1DD87E0 Offset: 0x1DD88E1 VA: 0x1DD87E0
	private void <OpenDeletedPopup>b__44_1(bool select) { }

	[CompilerGeneratedAttribute] // RVA: 0x1A8370 Offset: 0x1A8471 VA: 0x1A8370
	// RVA: 0x1DD8860 Offset: 0x1DD8961 VA: 0x1DD8860
	private void <OpenDeletedPopup>b__44_0(bool select) { }
}

