public abstract class MagicMotionController : MonoBehaviour // TypeDefIndex: 6597
{
	// Properties
	public virtual bool IsPlaying { get; }

	// Methods

	// RVA: 0x1E0E540 Offset: 0x1E0E641 VA: 0x1E0E540 Slot: 4
	public virtual bool get_IsPlaying() { }

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void Setup() { }

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool DoPlay(int no, MagicID magicId, int level) { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void DoStop() { }

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void DoCancel() { }

	// RVA: -1 Offset: -1 Slot: 9
	public abstract bool DoShot(float rpRate) { }

	// RVA: 0x1E0E550 Offset: 0x1E0E651 VA: 0x1E0E550
	protected void .ctor() { }
}

