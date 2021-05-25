[RequireComponent] // RVA: 0x146760 Offset: 0x146861 VA: 0x146760
[RequireComponent] // RVA: 0x146760 Offset: 0x146861 VA: 0x146760
public class FadeUI : MonoBehaviour, IFade // TypeDefIndex: 7703
{
	// Fields
	[SerializeField] // RVA: 0x168BB0 Offset: 0x168CB1 VA: 0x168BB0
	private Material mat; // 0x18
	[SerializeField] // RVA: 0x168BC0 Offset: 0x168CC1 VA: 0x168BC0
	private RenderTexture rt; // 0x20
	[SerializeField] // RVA: 0x168BD0 Offset: 0x168CD1 VA: 0x168BD0
	private Texture texture; // 0x28
	[SerializeField] // RVA: 0x168BE0 Offset: 0x168CE1 VA: 0x168BE0
	private Color color; // 0x30
	[SerializeField] // RVA: 0x168BF0 Offset: 0x168CF1 VA: 0x168BF0
	[RangeAttribute] // RVA: 0x168BF0 Offset: 0x168CF1 VA: 0x168BF0
	private float cutoutRange; // 0x40

	// Properties
	public float Range { get; set; }
	public Color fadeColor { get; set; }

	// Methods

	// RVA: 0x2084E60 Offset: 0x2084F61 VA: 0x2084E60 Slot: 4
	public float get_Range() { }

	// RVA: 0x2084E70 Offset: 0x2084F71 VA: 0x2084E70 Slot: 5
	public void set_Range(float value) { }

	// RVA: 0x2084F70 Offset: 0x2085071 VA: 0x2084F70 Slot: 6
	public Color get_fadeColor() { }

	// RVA: 0x2084F80 Offset: 0x2085081 VA: 0x2084F80 Slot: 7
	public void set_fadeColor(Color value) { }

	// RVA: 0x2084F90 Offset: 0x2085091 VA: 0x2084F90
	private void Start() { }

	// RVA: 0x2084FA0 Offset: 0x20850A1 VA: 0x2084FA0
	public void UpdateMaskTexture(Texture texture) { }

	// RVA: 0x2084E80 Offset: 0x2084F81 VA: 0x2084E80
	private void UpdateMaskCutout(float range) { }

	// RVA: 0x2085030 Offset: 0x2085131 VA: 0x2085030
	public void .ctor() { }
}

