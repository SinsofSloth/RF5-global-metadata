public class EscapeShineBall : MonoBehaviour // TypeDefIndex: 7116
{
	// Fields
	[SerializeField] // RVA: 0x162FD0 Offset: 0x1630D1 VA: 0x162FD0
	private ParticleSystem m_ball; // 0x18
	[SerializeField] // RVA: 0x162FE0 Offset: 0x1630E1 VA: 0x162FE0
	private Animator m_animator; // 0x20
	private Action m_callback; // 0x28

	// Methods

	// RVA: 0x1C1A0C0 Offset: 0x1C1A1C1 VA: 0x1C1A0C0
	public void Hide() { }

	// RVA: 0x1C1A110 Offset: 0x1C1A211 VA: 0x1C1A110
	public bool DoStartRise(Action callback) { }

	// RVA: 0x1C1A190 Offset: 0x1C1A291 VA: 0x1C1A190
	public void DoEndRise() { }

	// RVA: 0x1C1A380 Offset: 0x1C1A481 VA: 0x1C1A380
	public bool DoStartFall(Action callback) { }

	// RVA: 0x1C1A400 Offset: 0x1C1A501 VA: 0x1C1A400 Slot: 4
	public virtual void DoEndFall() { }

	// RVA: 0x1C1A5F0 Offset: 0x1C1A6F1 VA: 0x1C1A5F0 Slot: 5
	public virtual void DoPlayDust() { }

	// RVA: 0x1C1A840 Offset: 0x1C1A941 VA: 0x1C1A840
	public void .ctor() { }
}

