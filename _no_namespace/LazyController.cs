public abstract class LazyController : MonoBehaviour // TypeDefIndex: 6593
{
	// Fields
	protected bool m_isLazy; // 0x18
	protected bool m_isSetuped; // 0x19

	// Properties
	public bool IsLazy { get; }

	// Methods

	// RVA: 0x218AE60 Offset: 0x218AF61 VA: 0x218AE60
	public bool get_IsLazy() { }

	// RVA: 0x218AE70 Offset: 0x218AF71 VA: 0x218AE70 Slot: 4
	public virtual void Setup() { }

	// RVA: 0x218AE90 Offset: 0x218AF91 VA: 0x218AE90 Slot: 5
	public virtual void Cleanup() { }

	// RVA: 0x218AEA0 Offset: 0x218AFA1 VA: 0x218AEA0 Slot: 6
	public virtual void SetLazy(bool isLazy) { }

	// RVA: 0x218AEC0 Offset: 0x218AFC1 VA: 0x218AEC0 Slot: 7
	public virtual void DoUpdateEmotion() { }

	// RVA: 0x218AED0 Offset: 0x218AFD1 VA: 0x218AED0
	protected void .ctor() { }
}

