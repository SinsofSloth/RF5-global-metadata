[Serializable]
public struct Coord // TypeDefIndex: 9721
{
	// Fields
	public int x; // 0x0
	public int z; // 0x4

	// Properties
	public int Minimal { get; }
	public int SqrMagnitude { get; }
	public Vector3 vector3 { get; }
	public static Coord zero { get; }

	// Methods

	// RVA: 0x379570 Offset: 0x379671 VA: 0x379570
	public void .ctor(int x, int z) { }

	// RVA: 0x2AE32E0 Offset: 0x2AE33E1 VA: 0x2AE32E0
	public static bool op_GreaterThan(Coord c1, Coord c2) { }

	// RVA: 0x2AE3300 Offset: 0x2AE3401 VA: 0x2AE3300
	public static bool op_LessThan(Coord c1, Coord c2) { }

	// RVA: 0x2AE3320 Offset: 0x2AE3421 VA: 0x2AE3320
	public static bool op_Equality(Coord c1, Coord c2) { }

	// RVA: 0x2AE3340 Offset: 0x2AE3441 VA: 0x2AE3340
	public static bool op_Inequality(Coord c1, Coord c2) { }

	// RVA: 0x2AE3360 Offset: 0x2AE3461 VA: 0x2AE3360
	public static Coord op_Addition(Coord c, int s) { }

	// RVA: 0x2AE3380 Offset: 0x2AE3481 VA: 0x2AE3380
	public static Coord op_Addition(Coord c1, Coord c2) { }

	// RVA: 0x2AE33A0 Offset: 0x2AE34A1 VA: 0x2AE33A0
	public static Coord op_Subtraction(Coord c, int s) { }

	// RVA: 0x2AE33C0 Offset: 0x2AE34C1 VA: 0x2AE33C0
	public static Coord op_Subtraction(Coord c1, Coord c2) { }

	// RVA: 0x2AE33E0 Offset: 0x2AE34E1 VA: 0x2AE33E0
	public static Coord op_Multiply(Coord c, int s) { }

	// RVA: 0x2AE3400 Offset: 0x2AE3501 VA: 0x2AE3400
	public static Vector2 op_Multiply(Coord c, Vector2 s) { }

	// RVA: 0x2AE3440 Offset: 0x2AE3541 VA: 0x2AE3440
	public static Vector3 op_Multiply(Coord c, Vector3 s) { }

	// RVA: 0x2AE3490 Offset: 0x2AE3591 VA: 0x2AE3490
	public static Coord op_Multiply(Coord c, float s) { }

	// RVA: 0x2AE34C0 Offset: 0x2AE35C1 VA: 0x2AE34C0
	public static Coord op_Division(Coord c, int s) { }

	// RVA: 0x2AE34E0 Offset: 0x2AE35E1 VA: 0x2AE34E0
	public static Coord op_Division(Coord c, float s) { }

	// RVA: 0x379580 Offset: 0x379681 VA: 0x379580 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x379600 Offset: 0x379701 VA: 0x379600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x379620 Offset: 0x379721 VA: 0x379620
	public int get_Minimal() { }

	// RVA: 0x379690 Offset: 0x379791 VA: 0x379690
	public int get_SqrMagnitude() { }

	// RVA: 0x3796A0 Offset: 0x3797A1 VA: 0x3796A0
	public Vector3 get_vector3() { }

	// RVA: 0x2AE3680 Offset: 0x2AE3781 VA: 0x2AE3680
	public static Coord get_zero() { }

	// RVA: 0x3796F0 Offset: 0x3797F1 VA: 0x3796F0
	public void Round(int val, bool ceil = False) { }

	// RVA: 0x379700 Offset: 0x379801 VA: 0x379700
	public void Round(Coord c, bool ceil = False) { }

	// RVA: 0x379710 Offset: 0x379811 VA: 0x379710
	public void ClampPositive() { }

	// RVA: 0x3797A0 Offset: 0x3798A1 VA: 0x3797A0
	public void ClampByRect(CoordRect rect) { }

	// RVA: 0x2AE39F0 Offset: 0x2AE3AF1 VA: 0x2AE39F0
	public static Coord Min(Coord c1, Coord c2) { }

	// RVA: 0x2AE3AA0 Offset: 0x2AE3BA1 VA: 0x2AE3AA0
	public static Coord Max(Coord c1, Coord c2) { }

	// RVA: 0x2AE3B50 Offset: 0x2AE3C51 VA: 0x2AE3B50
	public static float Distance(Coord c1, Coord c2) { }

	// RVA: 0x2AE3C00 Offset: 0x2AE3D01 VA: 0x2AE3C00
	public static float Distance(Coord c1, int x, int z) { }

	// RVA: 0x379810 Offset: 0x379911 VA: 0x379810 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACC50 Offset: 0x1ACD51 VA: 0x1ACC50
	// RVA: 0x379820 Offset: 0x379921 VA: 0x379820
	public IEnumerable<Coord> DistanceStep(int i, int dist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACCC0 Offset: 0x1ACDC1 VA: 0x1ACCC0
	// RVA: 0x3798C0 Offset: 0x3799C1 VA: 0x3798C0
	public IEnumerable<Coord> DistancePerimeter(int dist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACD30 Offset: 0x1ACE31 VA: 0x1ACD30
	// RVA: 0x379960 Offset: 0x379A61 VA: 0x379960
	public IEnumerable<Coord> DistanceArea(int maxDist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACDA0 Offset: 0x1ACEA1 VA: 0x1ACDA0
	// RVA: 0x379A00 Offset: 0x379B01 VA: 0x379A00
	public IEnumerable<Coord> DistanceArea(CoordRect rect) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACE10 Offset: 0x1ACF11 VA: 0x1ACE10
	// RVA: 0x2AE4260 Offset: 0x2AE4361 VA: 0x2AE4260
	public static IEnumerable<Coord> MultiDistanceArea(Coord[] coords, int maxDist) { }

	// RVA: 0x379AA0 Offset: 0x379BA1 VA: 0x379AA0
	public Vector3 ToVector3(float cellSize) { }

	// RVA: 0x379AF0 Offset: 0x379BF1 VA: 0x379AF0
	public Vector2 ToVector2(float cellSize) { }

	// RVA: 0x379B40 Offset: 0x379C41 VA: 0x379B40
	public Rect ToRect(float cellSize) { }
}

[Serializable]
public struct Coord // TypeDefIndex: 9721
{
	// Fields
	public int x; // 0x0
	public int z; // 0x4

	// Properties
	public int Minimal { get; }
	public int SqrMagnitude { get; }
	public Vector3 vector3 { get; }
	public static Coord zero { get; }

	// Methods

	// RVA: 0x379570 Offset: 0x379671 VA: 0x379570
	public void .ctor(int x, int z) { }

	// RVA: 0x2AE32E0 Offset: 0x2AE33E1 VA: 0x2AE32E0
	public static bool op_GreaterThan(Coord c1, Coord c2) { }

	// RVA: 0x2AE3300 Offset: 0x2AE3401 VA: 0x2AE3300
	public static bool op_LessThan(Coord c1, Coord c2) { }

	// RVA: 0x2AE3320 Offset: 0x2AE3421 VA: 0x2AE3320
	public static bool op_Equality(Coord c1, Coord c2) { }

	// RVA: 0x2AE3340 Offset: 0x2AE3441 VA: 0x2AE3340
	public static bool op_Inequality(Coord c1, Coord c2) { }

	// RVA: 0x2AE3360 Offset: 0x2AE3461 VA: 0x2AE3360
	public static Coord op_Addition(Coord c, int s) { }

	// RVA: 0x2AE3380 Offset: 0x2AE3481 VA: 0x2AE3380
	public static Coord op_Addition(Coord c1, Coord c2) { }

	// RVA: 0x2AE33A0 Offset: 0x2AE34A1 VA: 0x2AE33A0
	public static Coord op_Subtraction(Coord c, int s) { }

	// RVA: 0x2AE33C0 Offset: 0x2AE34C1 VA: 0x2AE33C0
	public static Coord op_Subtraction(Coord c1, Coord c2) { }

	// RVA: 0x2AE33E0 Offset: 0x2AE34E1 VA: 0x2AE33E0
	public static Coord op_Multiply(Coord c, int s) { }

	// RVA: 0x2AE3400 Offset: 0x2AE3501 VA: 0x2AE3400
	public static Vector2 op_Multiply(Coord c, Vector2 s) { }

	// RVA: 0x2AE3440 Offset: 0x2AE3541 VA: 0x2AE3440
	public static Vector3 op_Multiply(Coord c, Vector3 s) { }

	// RVA: 0x2AE3490 Offset: 0x2AE3591 VA: 0x2AE3490
	public static Coord op_Multiply(Coord c, float s) { }

	// RVA: 0x2AE34C0 Offset: 0x2AE35C1 VA: 0x2AE34C0
	public static Coord op_Division(Coord c, int s) { }

	// RVA: 0x2AE34E0 Offset: 0x2AE35E1 VA: 0x2AE34E0
	public static Coord op_Division(Coord c, float s) { }

	// RVA: 0x379580 Offset: 0x379681 VA: 0x379580 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x379600 Offset: 0x379701 VA: 0x379600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x379620 Offset: 0x379721 VA: 0x379620
	public int get_Minimal() { }

	// RVA: 0x379690 Offset: 0x379791 VA: 0x379690
	public int get_SqrMagnitude() { }

	// RVA: 0x3796A0 Offset: 0x3797A1 VA: 0x3796A0
	public Vector3 get_vector3() { }

	// RVA: 0x2AE3680 Offset: 0x2AE3781 VA: 0x2AE3680
	public static Coord get_zero() { }

	// RVA: 0x3796F0 Offset: 0x3797F1 VA: 0x3796F0
	public void Round(int val, bool ceil = False) { }

	// RVA: 0x379700 Offset: 0x379801 VA: 0x379700
	public void Round(Coord c, bool ceil = False) { }

	// RVA: 0x379710 Offset: 0x379811 VA: 0x379710
	public void ClampPositive() { }

	// RVA: 0x3797A0 Offset: 0x3798A1 VA: 0x3797A0
	public void ClampByRect(CoordRect rect) { }

	// RVA: 0x2AE39F0 Offset: 0x2AE3AF1 VA: 0x2AE39F0
	public static Coord Min(Coord c1, Coord c2) { }

	// RVA: 0x2AE3AA0 Offset: 0x2AE3BA1 VA: 0x2AE3AA0
	public static Coord Max(Coord c1, Coord c2) { }

	// RVA: 0x2AE3B50 Offset: 0x2AE3C51 VA: 0x2AE3B50
	public static float Distance(Coord c1, Coord c2) { }

	// RVA: 0x2AE3C00 Offset: 0x2AE3D01 VA: 0x2AE3C00
	public static float Distance(Coord c1, int x, int z) { }

	// RVA: 0x379810 Offset: 0x379911 VA: 0x379810 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACC50 Offset: 0x1ACD51 VA: 0x1ACC50
	// RVA: 0x379820 Offset: 0x379921 VA: 0x379820
	public IEnumerable<Coord> DistanceStep(int i, int dist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACCC0 Offset: 0x1ACDC1 VA: 0x1ACCC0
	// RVA: 0x3798C0 Offset: 0x3799C1 VA: 0x3798C0
	public IEnumerable<Coord> DistancePerimeter(int dist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACD30 Offset: 0x1ACE31 VA: 0x1ACD30
	// RVA: 0x379960 Offset: 0x379A61 VA: 0x379960
	public IEnumerable<Coord> DistanceArea(int maxDist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACDA0 Offset: 0x1ACEA1 VA: 0x1ACDA0
	// RVA: 0x379A00 Offset: 0x379B01 VA: 0x379A00
	public IEnumerable<Coord> DistanceArea(CoordRect rect) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACE10 Offset: 0x1ACF11 VA: 0x1ACE10
	// RVA: 0x2AE4260 Offset: 0x2AE4361 VA: 0x2AE4260
	public static IEnumerable<Coord> MultiDistanceArea(Coord[] coords, int maxDist) { }

	// RVA: 0x379AA0 Offset: 0x379BA1 VA: 0x379AA0
	public Vector3 ToVector3(float cellSize) { }

	// RVA: 0x379AF0 Offset: 0x379BF1 VA: 0x379AF0
	public Vector2 ToVector2(float cellSize) { }

	// RVA: 0x379B40 Offset: 0x379C41 VA: 0x379B40
	public Rect ToRect(float cellSize) { }
}

[Serializable]
public struct Coord // TypeDefIndex: 9721
{
	// Fields
	public int x; // 0x0
	public int z; // 0x4

	// Properties
	public int Minimal { get; }
	public int SqrMagnitude { get; }
	public Vector3 vector3 { get; }
	public static Coord zero { get; }

	// Methods

	// RVA: 0x379570 Offset: 0x379671 VA: 0x379570
	public void .ctor(int x, int z) { }

	// RVA: 0x2AE32E0 Offset: 0x2AE33E1 VA: 0x2AE32E0
	public static bool op_GreaterThan(Coord c1, Coord c2) { }

	// RVA: 0x2AE3300 Offset: 0x2AE3401 VA: 0x2AE3300
	public static bool op_LessThan(Coord c1, Coord c2) { }

	// RVA: 0x2AE3320 Offset: 0x2AE3421 VA: 0x2AE3320
	public static bool op_Equality(Coord c1, Coord c2) { }

	// RVA: 0x2AE3340 Offset: 0x2AE3441 VA: 0x2AE3340
	public static bool op_Inequality(Coord c1, Coord c2) { }

	// RVA: 0x2AE3360 Offset: 0x2AE3461 VA: 0x2AE3360
	public static Coord op_Addition(Coord c, int s) { }

	// RVA: 0x2AE3380 Offset: 0x2AE3481 VA: 0x2AE3380
	public static Coord op_Addition(Coord c1, Coord c2) { }

	// RVA: 0x2AE33A0 Offset: 0x2AE34A1 VA: 0x2AE33A0
	public static Coord op_Subtraction(Coord c, int s) { }

	// RVA: 0x2AE33C0 Offset: 0x2AE34C1 VA: 0x2AE33C0
	public static Coord op_Subtraction(Coord c1, Coord c2) { }

	// RVA: 0x2AE33E0 Offset: 0x2AE34E1 VA: 0x2AE33E0
	public static Coord op_Multiply(Coord c, int s) { }

	// RVA: 0x2AE3400 Offset: 0x2AE3501 VA: 0x2AE3400
	public static Vector2 op_Multiply(Coord c, Vector2 s) { }

	// RVA: 0x2AE3440 Offset: 0x2AE3541 VA: 0x2AE3440
	public static Vector3 op_Multiply(Coord c, Vector3 s) { }

	// RVA: 0x2AE3490 Offset: 0x2AE3591 VA: 0x2AE3490
	public static Coord op_Multiply(Coord c, float s) { }

	// RVA: 0x2AE34C0 Offset: 0x2AE35C1 VA: 0x2AE34C0
	public static Coord op_Division(Coord c, int s) { }

	// RVA: 0x2AE34E0 Offset: 0x2AE35E1 VA: 0x2AE34E0
	public static Coord op_Division(Coord c, float s) { }

	// RVA: 0x379580 Offset: 0x379681 VA: 0x379580 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x379600 Offset: 0x379701 VA: 0x379600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x379620 Offset: 0x379721 VA: 0x379620
	public int get_Minimal() { }

	// RVA: 0x379690 Offset: 0x379791 VA: 0x379690
	public int get_SqrMagnitude() { }

	// RVA: 0x3796A0 Offset: 0x3797A1 VA: 0x3796A0
	public Vector3 get_vector3() { }

	// RVA: 0x2AE3680 Offset: 0x2AE3781 VA: 0x2AE3680
	public static Coord get_zero() { }

	// RVA: 0x3796F0 Offset: 0x3797F1 VA: 0x3796F0
	public void Round(int val, bool ceil = False) { }

	// RVA: 0x379700 Offset: 0x379801 VA: 0x379700
	public void Round(Coord c, bool ceil = False) { }

	// RVA: 0x379710 Offset: 0x379811 VA: 0x379710
	public void ClampPositive() { }

	// RVA: 0x3797A0 Offset: 0x3798A1 VA: 0x3797A0
	public void ClampByRect(CoordRect rect) { }

	// RVA: 0x2AE39F0 Offset: 0x2AE3AF1 VA: 0x2AE39F0
	public static Coord Min(Coord c1, Coord c2) { }

	// RVA: 0x2AE3AA0 Offset: 0x2AE3BA1 VA: 0x2AE3AA0
	public static Coord Max(Coord c1, Coord c2) { }

	// RVA: 0x2AE3B50 Offset: 0x2AE3C51 VA: 0x2AE3B50
	public static float Distance(Coord c1, Coord c2) { }

	// RVA: 0x2AE3C00 Offset: 0x2AE3D01 VA: 0x2AE3C00
	public static float Distance(Coord c1, int x, int z) { }

	// RVA: 0x379810 Offset: 0x379911 VA: 0x379810 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACC50 Offset: 0x1ACD51 VA: 0x1ACC50
	// RVA: 0x379820 Offset: 0x379921 VA: 0x379820
	public IEnumerable<Coord> DistanceStep(int i, int dist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACCC0 Offset: 0x1ACDC1 VA: 0x1ACCC0
	// RVA: 0x3798C0 Offset: 0x3799C1 VA: 0x3798C0
	public IEnumerable<Coord> DistancePerimeter(int dist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACD30 Offset: 0x1ACE31 VA: 0x1ACD30
	// RVA: 0x379960 Offset: 0x379A61 VA: 0x379960
	public IEnumerable<Coord> DistanceArea(int maxDist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACDA0 Offset: 0x1ACEA1 VA: 0x1ACDA0
	// RVA: 0x379A00 Offset: 0x379B01 VA: 0x379A00
	public IEnumerable<Coord> DistanceArea(CoordRect rect) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACE10 Offset: 0x1ACF11 VA: 0x1ACE10
	// RVA: 0x2AE4260 Offset: 0x2AE4361 VA: 0x2AE4260
	public static IEnumerable<Coord> MultiDistanceArea(Coord[] coords, int maxDist) { }

	// RVA: 0x379AA0 Offset: 0x379BA1 VA: 0x379AA0
	public Vector3 ToVector3(float cellSize) { }

	// RVA: 0x379AF0 Offset: 0x379BF1 VA: 0x379AF0
	public Vector2 ToVector2(float cellSize) { }

	// RVA: 0x379B40 Offset: 0x379C41 VA: 0x379B40
	public Rect ToRect(float cellSize) { }
}

[Serializable]
public struct Coord // TypeDefIndex: 9721
{
	// Fields
	public int x; // 0x0
	public int z; // 0x4

	// Properties
	public int Minimal { get; }
	public int SqrMagnitude { get; }
	public Vector3 vector3 { get; }
	public static Coord zero { get; }

	// Methods

	// RVA: 0x379570 Offset: 0x379671 VA: 0x379570
	public void .ctor(int x, int z) { }

	// RVA: 0x2AE32E0 Offset: 0x2AE33E1 VA: 0x2AE32E0
	public static bool op_GreaterThan(Coord c1, Coord c2) { }

	// RVA: 0x2AE3300 Offset: 0x2AE3401 VA: 0x2AE3300
	public static bool op_LessThan(Coord c1, Coord c2) { }

	// RVA: 0x2AE3320 Offset: 0x2AE3421 VA: 0x2AE3320
	public static bool op_Equality(Coord c1, Coord c2) { }

	// RVA: 0x2AE3340 Offset: 0x2AE3441 VA: 0x2AE3340
	public static bool op_Inequality(Coord c1, Coord c2) { }

	// RVA: 0x2AE3360 Offset: 0x2AE3461 VA: 0x2AE3360
	public static Coord op_Addition(Coord c, int s) { }

	// RVA: 0x2AE3380 Offset: 0x2AE3481 VA: 0x2AE3380
	public static Coord op_Addition(Coord c1, Coord c2) { }

	// RVA: 0x2AE33A0 Offset: 0x2AE34A1 VA: 0x2AE33A0
	public static Coord op_Subtraction(Coord c, int s) { }

	// RVA: 0x2AE33C0 Offset: 0x2AE34C1 VA: 0x2AE33C0
	public static Coord op_Subtraction(Coord c1, Coord c2) { }

	// RVA: 0x2AE33E0 Offset: 0x2AE34E1 VA: 0x2AE33E0
	public static Coord op_Multiply(Coord c, int s) { }

	// RVA: 0x2AE3400 Offset: 0x2AE3501 VA: 0x2AE3400
	public static Vector2 op_Multiply(Coord c, Vector2 s) { }

	// RVA: 0x2AE3440 Offset: 0x2AE3541 VA: 0x2AE3440
	public static Vector3 op_Multiply(Coord c, Vector3 s) { }

	// RVA: 0x2AE3490 Offset: 0x2AE3591 VA: 0x2AE3490
	public static Coord op_Multiply(Coord c, float s) { }

	// RVA: 0x2AE34C0 Offset: 0x2AE35C1 VA: 0x2AE34C0
	public static Coord op_Division(Coord c, int s) { }

	// RVA: 0x2AE34E0 Offset: 0x2AE35E1 VA: 0x2AE34E0
	public static Coord op_Division(Coord c, float s) { }

	// RVA: 0x379580 Offset: 0x379681 VA: 0x379580 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x379600 Offset: 0x379701 VA: 0x379600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x379620 Offset: 0x379721 VA: 0x379620
	public int get_Minimal() { }

	// RVA: 0x379690 Offset: 0x379791 VA: 0x379690
	public int get_SqrMagnitude() { }

	// RVA: 0x3796A0 Offset: 0x3797A1 VA: 0x3796A0
	public Vector3 get_vector3() { }

	// RVA: 0x2AE3680 Offset: 0x2AE3781 VA: 0x2AE3680
	public static Coord get_zero() { }

	// RVA: 0x3796F0 Offset: 0x3797F1 VA: 0x3796F0
	public void Round(int val, bool ceil = False) { }

	// RVA: 0x379700 Offset: 0x379801 VA: 0x379700
	public void Round(Coord c, bool ceil = False) { }

	// RVA: 0x379710 Offset: 0x379811 VA: 0x379710
	public void ClampPositive() { }

	// RVA: 0x3797A0 Offset: 0x3798A1 VA: 0x3797A0
	public void ClampByRect(CoordRect rect) { }

	// RVA: 0x2AE39F0 Offset: 0x2AE3AF1 VA: 0x2AE39F0
	public static Coord Min(Coord c1, Coord c2) { }

	// RVA: 0x2AE3AA0 Offset: 0x2AE3BA1 VA: 0x2AE3AA0
	public static Coord Max(Coord c1, Coord c2) { }

	// RVA: 0x2AE3B50 Offset: 0x2AE3C51 VA: 0x2AE3B50
	public static float Distance(Coord c1, Coord c2) { }

	// RVA: 0x2AE3C00 Offset: 0x2AE3D01 VA: 0x2AE3C00
	public static float Distance(Coord c1, int x, int z) { }

	// RVA: 0x379810 Offset: 0x379911 VA: 0x379810 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACC50 Offset: 0x1ACD51 VA: 0x1ACC50
	// RVA: 0x379820 Offset: 0x379921 VA: 0x379820
	public IEnumerable<Coord> DistanceStep(int i, int dist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACCC0 Offset: 0x1ACDC1 VA: 0x1ACCC0
	// RVA: 0x3798C0 Offset: 0x3799C1 VA: 0x3798C0
	public IEnumerable<Coord> DistancePerimeter(int dist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACD30 Offset: 0x1ACE31 VA: 0x1ACD30
	// RVA: 0x379960 Offset: 0x379A61 VA: 0x379960
	public IEnumerable<Coord> DistanceArea(int maxDist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACDA0 Offset: 0x1ACEA1 VA: 0x1ACDA0
	// RVA: 0x379A00 Offset: 0x379B01 VA: 0x379A00
	public IEnumerable<Coord> DistanceArea(CoordRect rect) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACE10 Offset: 0x1ACF11 VA: 0x1ACE10
	// RVA: 0x2AE4260 Offset: 0x2AE4361 VA: 0x2AE4260
	public static IEnumerable<Coord> MultiDistanceArea(Coord[] coords, int maxDist) { }

	// RVA: 0x379AA0 Offset: 0x379BA1 VA: 0x379AA0
	public Vector3 ToVector3(float cellSize) { }

	// RVA: 0x379AF0 Offset: 0x379BF1 VA: 0x379AF0
	public Vector2 ToVector2(float cellSize) { }

	// RVA: 0x379B40 Offset: 0x379C41 VA: 0x379B40
	public Rect ToRect(float cellSize) { }
}

[Serializable]
public struct Coord // TypeDefIndex: 9721
{
	// Fields
	public int x; // 0x0
	public int z; // 0x4

	// Properties
	public int Minimal { get; }
	public int SqrMagnitude { get; }
	public Vector3 vector3 { get; }
	public static Coord zero { get; }

	// Methods

	// RVA: 0x379570 Offset: 0x379671 VA: 0x379570
	public void .ctor(int x, int z) { }

	// RVA: 0x2AE32E0 Offset: 0x2AE33E1 VA: 0x2AE32E0
	public static bool op_GreaterThan(Coord c1, Coord c2) { }

	// RVA: 0x2AE3300 Offset: 0x2AE3401 VA: 0x2AE3300
	public static bool op_LessThan(Coord c1, Coord c2) { }

	// RVA: 0x2AE3320 Offset: 0x2AE3421 VA: 0x2AE3320
	public static bool op_Equality(Coord c1, Coord c2) { }

	// RVA: 0x2AE3340 Offset: 0x2AE3441 VA: 0x2AE3340
	public static bool op_Inequality(Coord c1, Coord c2) { }

	// RVA: 0x2AE3360 Offset: 0x2AE3461 VA: 0x2AE3360
	public static Coord op_Addition(Coord c, int s) { }

	// RVA: 0x2AE3380 Offset: 0x2AE3481 VA: 0x2AE3380
	public static Coord op_Addition(Coord c1, Coord c2) { }

	// RVA: 0x2AE33A0 Offset: 0x2AE34A1 VA: 0x2AE33A0
	public static Coord op_Subtraction(Coord c, int s) { }

	// RVA: 0x2AE33C0 Offset: 0x2AE34C1 VA: 0x2AE33C0
	public static Coord op_Subtraction(Coord c1, Coord c2) { }

	// RVA: 0x2AE33E0 Offset: 0x2AE34E1 VA: 0x2AE33E0
	public static Coord op_Multiply(Coord c, int s) { }

	// RVA: 0x2AE3400 Offset: 0x2AE3501 VA: 0x2AE3400
	public static Vector2 op_Multiply(Coord c, Vector2 s) { }

	// RVA: 0x2AE3440 Offset: 0x2AE3541 VA: 0x2AE3440
	public static Vector3 op_Multiply(Coord c, Vector3 s) { }

	// RVA: 0x2AE3490 Offset: 0x2AE3591 VA: 0x2AE3490
	public static Coord op_Multiply(Coord c, float s) { }

	// RVA: 0x2AE34C0 Offset: 0x2AE35C1 VA: 0x2AE34C0
	public static Coord op_Division(Coord c, int s) { }

	// RVA: 0x2AE34E0 Offset: 0x2AE35E1 VA: 0x2AE34E0
	public static Coord op_Division(Coord c, float s) { }

	// RVA: 0x379580 Offset: 0x379681 VA: 0x379580 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x379600 Offset: 0x379701 VA: 0x379600 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x379620 Offset: 0x379721 VA: 0x379620
	public int get_Minimal() { }

	// RVA: 0x379690 Offset: 0x379791 VA: 0x379690
	public int get_SqrMagnitude() { }

	// RVA: 0x3796A0 Offset: 0x3797A1 VA: 0x3796A0
	public Vector3 get_vector3() { }

	// RVA: 0x2AE3680 Offset: 0x2AE3781 VA: 0x2AE3680
	public static Coord get_zero() { }

	// RVA: 0x3796F0 Offset: 0x3797F1 VA: 0x3796F0
	public void Round(int val, bool ceil = False) { }

	// RVA: 0x379700 Offset: 0x379801 VA: 0x379700
	public void Round(Coord c, bool ceil = False) { }

	// RVA: 0x379710 Offset: 0x379811 VA: 0x379710
	public void ClampPositive() { }

	// RVA: 0x3797A0 Offset: 0x3798A1 VA: 0x3797A0
	public void ClampByRect(CoordRect rect) { }

	// RVA: 0x2AE39F0 Offset: 0x2AE3AF1 VA: 0x2AE39F0
	public static Coord Min(Coord c1, Coord c2) { }

	// RVA: 0x2AE3AA0 Offset: 0x2AE3BA1 VA: 0x2AE3AA0
	public static Coord Max(Coord c1, Coord c2) { }

	// RVA: 0x2AE3B50 Offset: 0x2AE3C51 VA: 0x2AE3B50
	public static float Distance(Coord c1, Coord c2) { }

	// RVA: 0x2AE3C00 Offset: 0x2AE3D01 VA: 0x2AE3C00
	public static float Distance(Coord c1, int x, int z) { }

	// RVA: 0x379810 Offset: 0x379911 VA: 0x379810 Slot: 3
	public override string ToString() { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACC50 Offset: 0x1ACD51 VA: 0x1ACC50
	// RVA: 0x379820 Offset: 0x379921 VA: 0x379820
	public IEnumerable<Coord> DistanceStep(int i, int dist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACCC0 Offset: 0x1ACDC1 VA: 0x1ACCC0
	// RVA: 0x3798C0 Offset: 0x3799C1 VA: 0x3798C0
	public IEnumerable<Coord> DistancePerimeter(int dist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACD30 Offset: 0x1ACE31 VA: 0x1ACD30
	// RVA: 0x379960 Offset: 0x379A61 VA: 0x379960
	public IEnumerable<Coord> DistanceArea(int maxDist) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACDA0 Offset: 0x1ACEA1 VA: 0x1ACDA0
	// RVA: 0x379A00 Offset: 0x379B01 VA: 0x379A00
	public IEnumerable<Coord> DistanceArea(CoordRect rect) { }

	[IteratorStateMachineAttribute] // RVA: 0x1ACE10 Offset: 0x1ACF11 VA: 0x1ACE10
	// RVA: 0x2AE4260 Offset: 0x2AE4361 VA: 0x2AE4260
	public static IEnumerable<Coord> MultiDistanceArea(Coord[] coords, int maxDist) { }

	// RVA: 0x379AA0 Offset: 0x379BA1 VA: 0x379AA0
	public Vector3 ToVector3(float cellSize) { }

	// RVA: 0x379AF0 Offset: 0x379BF1 VA: 0x379AF0
	public Vector2 ToVector2(float cellSize) { }

	// RVA: 0x379B40 Offset: 0x379C41 VA: 0x379B40
	public Rect ToRect(float cellSize) { }
}

