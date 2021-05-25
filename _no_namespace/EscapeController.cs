public abstract class EscapeController : MonoBehaviour // TypeDefIndex: 6583
{
	// Fields
	protected Action m_Callback; // 0x18

	// Properties
	public abstract bool IsPlaying { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool get_IsPlaying() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract bool DoRise(Action callback) { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool DoFall(Action callback) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void DoEnd() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void DoCancel() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool DoTakeOff() { }

	// RVA: 0x1C19990 Offset: 0x1C19A91 VA: 0x1C19990 Slot: 10
	public virtual void OnUpdate() { }

	// RVA: 0x1C199A0 Offset: 0x1C19AA1 VA: 0x1C199A0
	protected void .ctor() { }
}

