[MessagePackObjectAttribute] // RVA: 0x146800 Offset: 0x146901 VA: 0x146800
[Serializable]
public class ChildData // TypeDefIndex: 8098
{
	// Fields
	[KeyAttribute] // RVA: 0x16A460 Offset: 0x16A561 VA: 0x16A460
	[SerializeField] // RVA: 0x16A460 Offset: 0x16A561 VA: 0x16A460
	public string Name; // 0x10
	[KeyAttribute] // RVA: 0x16A4B0 Offset: 0x16A5B1 VA: 0x16A4B0
	[SerializeField] // RVA: 0x16A4B0 Offset: 0x16A5B1 VA: 0x16A4B0
	public bool IsMale; // 0x18
	[KeyAttribute] // RVA: 0x16A500 Offset: 0x16A601 VA: 0x16A500
	[SerializeField] // RVA: 0x16A500 Offset: 0x16A601 VA: 0x16A500
	public int Personality; // 0x1C
	[KeyAttribute] // RVA: 0x16A550 Offset: 0x16A651 VA: 0x16A550
	[SerializeField] // RVA: 0x16A550 Offset: 0x16A651 VA: 0x16A550
	public int BirthDay; // 0x20

	// Methods

	// RVA: 0x1E5F380 Offset: 0x1E5F481 VA: 0x1E5F380
	public void Initialize() { }

	// RVA: 0x1E5F3F0 Offset: 0x1E5F4F1 VA: 0x1E5F3F0
	public void SetName(string name) { }

	// RVA: 0x1E5F400 Offset: 0x1E5F501 VA: 0x1E5F400
	public void SetIsMale(bool isMale) { }

	// RVA: 0x1E5F410 Offset: 0x1E5F511 VA: 0x1E5F410
	public void SetBirthDay(int season, int day) { }

	// RVA: 0x1E5F420 Offset: 0x1E5F521 VA: 0x1E5F420
	public void SetData(ChildData data) { }

	// RVA: 0x1E5F470 Offset: 0x1E5F571 VA: 0x1E5F470
	public int GetPersonalityByGender() { }

	// RVA: 0x1E5F4A0 Offset: 0x1E5F5A1 VA: 0x1E5F4A0
	public bool IsBorn() { }

	// RVA: 0x1E5F4B0 Offset: 0x1E5F5B1 VA: 0x1E5F4B0
	public void SetGender(int select) { }

	// RVA: 0x1E5F500 Offset: 0x1E5F601 VA: 0x1E5F500
	public void SetPersonality(int p) { }

	// RVA: 0x1E5F620 Offset: 0x1E5F721 VA: 0x1E5F620
	public void SetPersonalityByGender(int p) { }

	// RVA: 0x1E5F750 Offset: 0x1E5F851 VA: 0x1E5F750
	public void SetRandomPersonality() { }

	// RVA: 0x1E5F790 Offset: 0x1E5F891 VA: 0x1E5F790
	public void .ctor() { }
}

