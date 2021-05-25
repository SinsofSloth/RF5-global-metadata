public class EnvironmentSoundArea : MonoBehaviour // TypeDefIndex: 8256
{
	// Fields
	[SerializeField] // RVA: 0x16E570 Offset: 0x16E671 VA: 0x16E570
	private SoundID m_SoundID; // 0x18
	[SerializeField] // RVA: 0x16E580 Offset: 0x16E681 VA: 0x16E580
	[RangeAttribute] // RVA: 0x16E580 Offset: 0x16E681 VA: 0x16E580
	private float m_Volume; // 0x1C

	// Properties
	public SoundID SoundID { get; }
	public float Volume { get; }

	// Methods

	// RVA: 0x201ED20 Offset: 0x201EE21 VA: 0x201ED20
	public SoundID get_SoundID() { }

	// RVA: 0x201ED30 Offset: 0x201EE31 VA: 0x201ED30
	public float get_Volume() { }

	// RVA: 0x201ED50 Offset: 0x201EE51 VA: 0x201ED50
	private void OnTriggerEnter(Collider other) { }

	// RVA: 0x201EE00 Offset: 0x201EF01 VA: 0x201EE00
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x201EEB0 Offset: 0x201EFB1 VA: 0x201EEB0
	public void .ctor() { }
}

