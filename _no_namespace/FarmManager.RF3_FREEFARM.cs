private struct FarmManager.RF3_FREEFARM // TypeDefIndex: 10346
{
	// Fields
	public int farm_id; // 0x0
	public bool flag_disp; // 0x4
	public FarmManager.RF4_CROP_PARAM[] pCropParam; // 0x8
	public FarmManager.RF4_CROP_STATE[][] crop; // 0x10
	public FarmManager.RF4_SOIL_INFO[][] soil; // 0x18
	public int[] damege_rand_tbl; // 0x20
	public int[] damege_crop_rand_tbl; // 0x28
	public int[] rock_rand_tbl; // 0x30
	public int[] wood_rand_tbl; // 0x38
	public string str; // 0x40

	// Methods

	// RVA: 0x2E21D0 Offset: 0x2E22D1 VA: 0x2E21D0
	public void .ctor(int id) { }
}

