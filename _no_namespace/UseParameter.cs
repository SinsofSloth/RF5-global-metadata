[Serializable]
public class UseParameter : ICloneable // TypeDefIndex: 8231
{
	// Fields
	[SerializeField] // RVA: 0x16DA60 Offset: 0x16DB61 VA: 0x16DA60
	public int HealHp; // 0x10
	[SerializeField] // RVA: 0x16DA70 Offset: 0x16DB71 VA: 0x16DA70
	public int HealRp; // 0x14
	[SerializeField] // RVA: 0x16DA80 Offset: 0x16DB81 VA: 0x16DA80
	public bool Levelup; // 0x18
	[SerializeField] // RVA: 0x16DA90 Offset: 0x16DB91 VA: 0x16DA90
	public float PercentHealHp; // 0x1C
	[SerializeField] // RVA: 0x16DAA0 Offset: 0x16DBA1 VA: 0x16DAA0
	public float PercentHealRp; // 0x20
	[SerializeField] // RVA: 0x16DAB0 Offset: 0x16DBB1 VA: 0x16DAB0
	public Parameter Buff; // 0x24
	[SerializeField] // RVA: 0x16DAC0 Offset: 0x16DBC1 VA: 0x16DAC0
	public FloatParameter BuffPercent; // 0xE0
	[SerializeField] // RVA: 0x16DAD0 Offset: 0x16DBD1 VA: 0x16DAD0
	public BadStatus HealBadStatus; // 0x19C
	[SerializeField] // RVA: 0x16DAE0 Offset: 0x16DBE1 VA: 0x16DAE0
	public BadStatus AddBadStatus; // 0x1A0
	[SerializeField] // RVA: 0x16DAF0 Offset: 0x16DBF1 VA: 0x16DAF0
	public Parameter Persistent; // 0x1A4

	// Methods

	// RVA: 0x1CFD660 Offset: 0x1CFD761 VA: 0x1CFD660
	public void .ctor() { }

	// RVA: 0x1CFD670 Offset: 0x1CFD771 VA: 0x1CFD670
	public void .ctor(UseParameter other) { }

	// RVA: 0x1CFD720 Offset: 0x1CFD821 VA: 0x1CFD720 Slot: 4
	public object Clone() { }

	// RVA: 0x1CFD800 Offset: 0x1CFD901 VA: 0x1CFD800
	public UseParameter Copy() { }

	// RVA: 0x1CFD940 Offset: 0x1CFDA41 VA: 0x1CFD940
	public void Add(UseParameter other) { }

	// RVA: 0x1CFDBB0 Offset: 0x1CFDCB1 VA: 0x1CFDBB0
	public void Multi(float value) { }
}

