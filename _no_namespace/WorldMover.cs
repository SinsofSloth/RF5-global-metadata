public class WorldMover : MonoBehaviour // TypeDefIndex: 9099
{
	// Fields
	public static string WORLDMOVERTAG; // 0x0
	[TooltipAttribute] // RVA: 0x177080 Offset: 0x177181 VA: 0x177080
	public float xTileRange; // 0x18
	[TooltipAttribute] // RVA: 0x1770C0 Offset: 0x1771C1 VA: 0x1770C0
	public float yTileRange; // 0x1C
	[TooltipAttribute] // RVA: 0x177100 Offset: 0x177201 VA: 0x177100
	public float zTileRange; // 0x20
	[HideInInspector] // RVA: 0x177140 Offset: 0x177241 VA: 0x177140
	public float xCurrentTile; // 0x24
	[HideInInspector] // RVA: 0x177150 Offset: 0x177251 VA: 0x177150
	public float yCurrentTile; // 0x28
	[HideInInspector] // RVA: 0x177160 Offset: 0x177261 VA: 0x177160
	public float zCurrentTile; // 0x2C
	[TooltipAttribute] // RVA: 0x177170 Offset: 0x177271 VA: 0x177170
	public Streamer streamerMajor; // 0x30
	[TooltipAttribute] // RVA: 0x1771B0 Offset: 0x1772B1 VA: 0x1771B0
	public Streamer[] streamerMinors; // 0x38
	[TooltipAttribute] // RVA: 0x1771F0 Offset: 0x1772F1 VA: 0x1771F0
	public Vector3 currentMove; // 0x40
	[HideInInspector] // RVA: 0x177230 Offset: 0x177331 VA: 0x177230
	public List<Transform> objectsToMove; // 0x50
	[TooltipAttribute] // RVA: 0x177240 Offset: 0x177341 VA: 0x177240
	public Vector3 playerPositionMovedLooped; // 0x58
	private Vector3 worldSize; // 0x64

	// Methods

	// RVA: 0x1D0CAC0 Offset: 0x1D0CBC1 VA: 0x1D0CAC0
	public void Start() { }

	// RVA: 0x1D0CC20 Offset: 0x1D0CD21 VA: 0x1D0CC20
	public void Update() { }

	// RVA: 0x1D0CF50 Offset: 0x1D0D051 VA: 0x1D0CF50
	public void CheckMoverDistance(int xPosCurrent, int yPosCurrent, int zPosCurrent) { }

	// RVA: 0x1D0D080 Offset: 0x1D0D181 VA: 0x1D0D080
	private void MoveWorld(int xPosCurrent, int yPosCurrent, int zPosCurrent) { }

	// RVA: 0x1D0D800 Offset: 0x1D0D901 VA: 0x1D0D800
	public void MoveObject(Transform objectTransform) { }

	// RVA: 0x1D0D8E0 Offset: 0x1D0D9E1 VA: 0x1D0D8E0
	public void AddObjectToMove(Transform objectToMove) { }

	// RVA: 0x1D0CF20 Offset: 0x1D0D021 VA: 0x1D0CF20
	private float modf(float x, float m) { }

	// RVA: 0x1D0D9E0 Offset: 0x1D0DAE1 VA: 0x1D0D9E0
	public void .ctor() { }

	// RVA: 0x1D0DAA0 Offset: 0x1D0DBA1 VA: 0x1D0DAA0
	private static void .cctor() { }
}

