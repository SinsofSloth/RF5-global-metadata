[Serializable]
public class HitEffectUnit : HitEffectBase // TypeDefIndex: 7617
{
	// Fields
	[SerializeField] // RVA: 0x168590 Offset: 0x168691 VA: 0x168590
	public float StartSec; // 0x48
	[SerializeField] // RVA: 0x1685A0 Offset: 0x1686A1 VA: 0x1685A0
	public HumanJointIDEnum Joint; // 0x4C
	[SerializeField] // RVA: 0x1685B0 Offset: 0x1686B1 VA: 0x1685B0
	public bool IsWorld; // 0x50
	public HitEffectUnit.STATE State; // 0x54

	// Methods

	// RVA: 0x2305080 Offset: 0x2305181 VA: 0x2305080
	public void .ctor() { }

	// RVA: 0x2305150 Offset: 0x2305251 VA: 0x2305150
	public void Start() { }

	// RVA: 0x2305170 Offset: 0x2305271 VA: 0x2305170
	public void End() { }

	// RVA: 0x2305180 Offset: 0x2305281 VA: 0x2305180
	public bool Update(float time) { }

	// RVA: 0x23051C0 Offset: 0x23052C1 VA: 0x23051C0
	public void Copy(HitEffectUnit effectUnit) { }
}

