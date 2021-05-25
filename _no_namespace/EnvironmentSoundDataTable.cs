[Serializable]
public class EnvironmentSoundDataTable // TypeDefIndex: 6953
{
	// Fields
	[SerializeField] // RVA: 0x161CD0 Offset: 0x161DD1 VA: 0x161CD0
	public EnvironmentSoundType EnvironmentSoundType; // 0x10
	[SerializeField] // RVA: 0x161CE0 Offset: 0x161DE1 VA: 0x161CE0
	public FieldSceneId FieldSceneId; // 0x14
	[SerializeField] // RVA: 0x161CF0 Offset: 0x161DF1 VA: 0x161CF0
	public SoundID SoundID; // 0x18
	[SerializeField] // RVA: 0x161D00 Offset: 0x161E01 VA: 0x161D00
	public bool IsSpring; // 0x1C
	[SerializeField] // RVA: 0x161D10 Offset: 0x161E11 VA: 0x161D10
	public bool IsSummer; // 0x1D
	[SerializeField] // RVA: 0x161D20 Offset: 0x161E21 VA: 0x161D20
	public bool IsAutumn; // 0x1E
	[SerializeField] // RVA: 0x161D30 Offset: 0x161E31 VA: 0x161D30
	public bool IsWinter; // 0x1F
	[SerializeField] // RVA: 0x161D40 Offset: 0x161E41 VA: 0x161D40
	public bool IsSunny; // 0x20
	[SerializeField] // RVA: 0x161D50 Offset: 0x161E51 VA: 0x161D50
	public bool IsCloud; // 0x21
	[SerializeField] // RVA: 0x161D60 Offset: 0x161E61 VA: 0x161D60
	public bool IsRain; // 0x22
	[SerializeField] // RVA: 0x161D70 Offset: 0x161E71 VA: 0x161D70
	public bool IsSnow; // 0x23
	[SerializeField] // RVA: 0x161D80 Offset: 0x161E81 VA: 0x161D80
	public bool IsTyphoon; // 0x24
	[SerializeField] // RVA: 0x161D90 Offset: 0x161E91 VA: 0x161D90
	public bool IsSnowstorm; // 0x25
	[SerializeField] // RVA: 0x161DA0 Offset: 0x161EA1 VA: 0x161DA0
	public bool IsRoony; // 0x26
	[SerializeField] // RVA: 0x161DB0 Offset: 0x161EB1 VA: 0x161DB0
	public bool IsMeteorShower; // 0x27
	[SerializeField] // RVA: 0x161DC0 Offset: 0x161EC1 VA: 0x161DC0
	public int StartHour; // 0x28
	[SerializeField] // RVA: 0x161DD0 Offset: 0x161ED1 VA: 0x161DD0
	public int EndHour; // 0x2C
	[SerializeField] // RVA: 0x161DE0 Offset: 0x161EE1 VA: 0x161DE0
	public int Interval; // 0x30
	[SerializeField] // RVA: 0x161DF0 Offset: 0x161EF1 VA: 0x161DF0
	public int IntervalMax; // 0x34
	private static EnvironmentSoundDataTableArray _EnvironmentSoundDataTableArray; // 0x0

	// Methods

	// RVA: 0x201EEC0 Offset: 0x201EFC1 VA: 0x201EEC0
	public static EnvironmentSoundDataTable[] GetDataTables(EnvironmentSoundType type) { }

	// RVA: 0x201F040 Offset: 0x201F141 VA: 0x201F040
	public static EnvironmentSoundDataTable[] GetDataTables(FieldSceneId id) { }

	// RVA: 0x201F1C0 Offset: 0x201F2C1 VA: 0x201F1C0
	public void .ctor() { }

	// RVA: 0x201F1D0 Offset: 0x201F2D1 VA: 0x201F1D0
	private static void .cctor() { }
}

