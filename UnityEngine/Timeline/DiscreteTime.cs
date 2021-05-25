internal struct DiscreteTime : IComparable // TypeDefIndex: 4576
{
	// Fields
	private const double k_Tick = 1E-12;
	public static readonly DiscreteTime kMaxTime; // 0x0
	private readonly long m_DiscreteTime; // 0x0

	// Properties
	public static double tickValue { get; }

	// Methods

	// RVA: 0x17DFE30 Offset: 0x17DFF31 VA: 0x17DFE30
	public static double get_tickValue() { }

	// RVA: 0xA260 Offset: 0xA361 VA: 0xA260
	public void .ctor(DiscreteTime time) { }

	// RVA: 0xA270 Offset: 0xA371 VA: 0xA270
	private void .ctor(long time) { }

	// RVA: 0xA280 Offset: 0xA381 VA: 0xA280
	public void .ctor(double time) { }

	// RVA: 0xA290 Offset: 0xA391 VA: 0xA290
	public void .ctor(float time) { }

	// RVA: 0xA2A0 Offset: 0xA3A1 VA: 0xA2A0
	public void .ctor(int time) { }

	// RVA: 0xA320 Offset: 0xA421 VA: 0xA320
	public void .ctor(int frame, double fps) { }

	// RVA: 0xA330 Offset: 0xA431 VA: 0xA330
	public DiscreteTime OneTickBefore() { }

	// RVA: 0xA340 Offset: 0xA441 VA: 0xA340
	public DiscreteTime OneTickAfter() { }

	// RVA: 0xA350 Offset: 0xA451 VA: 0xA350
	public long GetTick() { }

	// RVA: 0x17E0510 Offset: 0x17E0611 VA: 0x17E0510
	public static DiscreteTime FromTicks(long ticks) { }

	// RVA: 0xA360 Offset: 0xA461 VA: 0xA360 Slot: 4
	public int CompareTo(object obj) { }

	// RVA: 0xA420 Offset: 0xA521 VA: 0xA420
	public bool Equals(DiscreteTime other) { }

	// RVA: 0xA430 Offset: 0xA531 VA: 0xA430 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x17DFF90 Offset: 0x17E0091 VA: 0x17DFF90
	private static long DoubleToDiscreteTime(double time) { }

	// RVA: 0x17E0170 Offset: 0x17E0271 VA: 0x17E0170
	private static long FloatToDiscreteTime(float time) { }

	// RVA: 0x17E02B0 Offset: 0x17E03B1 VA: 0x17E02B0
	private static long IntToDiscreteTime(int time) { }

	// RVA: 0x17E06A0 Offset: 0x17E07A1 VA: 0x17E06A0
	private static double ToDouble(long time) { }

	// RVA: 0x17E06C0 Offset: 0x17E07C1 VA: 0x17E06C0
	private static float ToFloat(long time) { }

	// RVA: 0x17DD380 Offset: 0x17DD481 VA: 0x17DD380
	public static double op_Explicit(DiscreteTime b) { }

	// RVA: 0x17E0740 Offset: 0x17E0841 VA: 0x17E0740
	public static float op_Explicit(DiscreteTime b) { }

	// RVA: 0x17E0810 Offset: 0x17E0911 VA: 0x17E0810
	public static long op_Explicit(DiscreteTime b) { }

	// RVA: 0x17DD340 Offset: 0x17DD441 VA: 0x17DD340
	public static DiscreteTime op_Explicit(double time) { }

	// RVA: 0x17E0820 Offset: 0x17E0921 VA: 0x17E0820
	public static DiscreteTime op_Explicit(float time) { }

	// RVA: 0x17E0850 Offset: 0x17E0951 VA: 0x17E0850
	public static DiscreteTime op_Implicit(int time) { }

	// RVA: 0x17E08D0 Offset: 0x17E09D1 VA: 0x17E08D0
	public static DiscreteTime op_Explicit(long time) { }

	// RVA: 0x17E08E0 Offset: 0x17E09E1 VA: 0x17E08E0
	public static bool op_Equality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x17E08F0 Offset: 0x17E09F1 VA: 0x17E08F0
	public static bool op_Inequality(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x17E0970 Offset: 0x17E0A71 VA: 0x17E0970
	public static bool op_GreaterThan(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x17E0980 Offset: 0x17E0A81 VA: 0x17E0980
	public static bool op_LessThan(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x17E0990 Offset: 0x17E0A91 VA: 0x17E0990
	public static bool op_LessThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x17E09A0 Offset: 0x17E0AA1 VA: 0x17E09A0
	public static bool op_GreaterThanOrEqual(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x17E09B0 Offset: 0x17E0AB1 VA: 0x17E09B0
	public static DiscreteTime op_Addition(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x17E09C0 Offset: 0x17E0AC1 VA: 0x17E09C0
	public static DiscreteTime op_Subtraction(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0xA4E0 Offset: 0xA5E1 VA: 0xA4E0 Slot: 3
	public override string ToString() { }

	// RVA: 0xA510 Offset: 0xA611 VA: 0xA510 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x17E0A30 Offset: 0x17E0B31 VA: 0x17E0A30
	public static DiscreteTime Min(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x17E0AB0 Offset: 0x17E0BB1 VA: 0x17E0AB0
	public static DiscreteTime Max(DiscreteTime lhs, DiscreteTime rhs) { }

	// RVA: 0x17E0B30 Offset: 0x17E0C31 VA: 0x17E0B30
	public static double SnapToNearestTick(double time) { }

	// RVA: 0x17E0C50 Offset: 0x17E0D51 VA: 0x17E0C50
	public static float SnapToNearestTick(float time) { }

	// RVA: 0x17E0DB0 Offset: 0x17E0EB1 VA: 0x17E0DB0
	public static long GetNearestTick(double time) { }

	// RVA: 0x17E0EC0 Offset: 0x17E0FC1 VA: 0x17E0EC0
	private static void .cctor() { }
}

