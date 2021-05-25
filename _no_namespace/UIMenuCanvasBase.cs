public class UIMenuCanvasBase : MonoBehaviour // TypeDefIndex: 8764
{
	// Fields
	[SerializeField] // RVA: 0x173420 Offset: 0x173521 VA: 0x173420
	protected CursorController MyCursor; // 0x18
	[SerializeField] // RVA: 0x173430 Offset: 0x173531 VA: 0x173430
	protected CursorLinker FirstActiveCenterGroup; // 0x20
	protected bool MenuOpened; // 0x28
	private Animator CanvasActivateAnimator; // 0x30
	[SerializeField] // RVA: 0x173440 Offset: 0x173541 VA: 0x173440
	protected CursorLinker MainMenuObject; // 0x38

	// Methods

	// RVA: 0x1ED78F0 Offset: 0x1ED79F1 VA: 0x1ED78F0 Slot: 4
	protected virtual void Start() { }

	// RVA: 0x1EE1EB0 Offset: 0x1EE1FB1 VA: 0x1EE1EB0 Slot: 5
	public virtual void StartMainCanvas() { }

	// RVA: 0x1EE1EE0 Offset: 0x1EE1FE1 VA: 0x1EE1EE0 Slot: 6
	public virtual void StartCanvas() { }

	// RVA: 0x1ED8D40 Offset: 0x1ED8E41 VA: 0x1ED8D40 Slot: 7
	public virtual void CloseCanvas() { }

	// RVA: 0x1ED83C0 Offset: 0x1ED84C1 VA: 0x1ED83C0
	public void CloseAllCanvas() { }

	// RVA: 0x1EE1F00 Offset: 0x1EE2001 VA: 0x1EE1F00 Slot: 8
	public virtual void OpenMainCanvas(CursorLinker firstActiveGroup) { }

	// RVA: 0x1ED9560 Offset: 0x1ED9661 VA: 0x1ED9560
	public void .ctor() { }
}

