public class RideChair : MonoBehaviour // TypeDefIndex: 6784
{
	// Fields
	[SerializeField] // RVA: 0x15F810 Offset: 0x15F911 VA: 0x15F810
	private Transform m_attachPoint; // 0x18
	[SerializeField] // RVA: 0x15F820 Offset: 0x15F921 VA: 0x15F820
	protected MeshFadeController m_FadeController; // 0x20

	// Properties
	public Transform AttachPoint { get; }
	public float FadeAlpha { get; }

	// Methods

	// RVA: 0x23316D0 Offset: 0x23317D1 VA: 0x23316D0
	public Transform get_AttachPoint() { }

	// RVA: 0x23316E0 Offset: 0x23317E1 VA: 0x23316E0
	public float get_FadeAlpha() { }

	// RVA: 0x2331790 Offset: 0x2331891 VA: 0x2331790 Slot: 4
	public virtual void SetFadeAlpha(float alpha) { }

	// RVA: 0x2331850 Offset: 0x2331951 VA: 0x2331850
	public void .ctor() { }
}

