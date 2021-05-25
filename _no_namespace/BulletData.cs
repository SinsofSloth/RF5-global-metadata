[Serializable]
public class BulletData // TypeDefIndex: 6915
{
	// Fields
	[SerializeField] // RVA: 0x160EC0 Offset: 0x160FC1 VA: 0x160EC0
	public BulletAttach Attach; // 0x10
	[SerializeField] // RVA: 0x160ED0 Offset: 0x160FD1 VA: 0x160ED0
	public BulletMotorType Type; // 0x14
	[SerializeField] // RVA: 0x160EE0 Offset: 0x160FE1 VA: 0x160EE0
	public bool Interception; // 0x18
	[SerializeField] // RVA: 0x160EF0 Offset: 0x160FF1 VA: 0x160EF0
	public bool AdjustAngle; // 0x19
	[SerializeField] // RVA: 0x160F00 Offset: 0x161001 VA: 0x160F00
	public float InitSpeed; // 0x1C
	[SerializeField] // RVA: 0x160F10 Offset: 0x161011 VA: 0x160F10
	public float Acceleration; // 0x20
	[SerializeField] // RVA: 0x160F20 Offset: 0x161021 VA: 0x160F20
	public float MaxSpeed; // 0x24
	[SerializeField] // RVA: 0x160F30 Offset: 0x161031 VA: 0x160F30
	public float MinSpeed; // 0x28
	[SerializeField] // RVA: 0x160F40 Offset: 0x161041 VA: 0x160F40
	public float BaseScale; // 0x2C
	[SerializeField] // RVA: 0x160F50 Offset: 0x161051 VA: 0x160F50
	public float RootOffsetX; // 0x30
	[SerializeField] // RVA: 0x160F60 Offset: 0x161061 VA: 0x160F60
	public float RootOffsetY; // 0x34
	[SerializeField] // RVA: 0x160F70 Offset: 0x161071 VA: 0x160F70
	public float RootOffsetZ; // 0x38
	[SerializeField] // RVA: 0x160F80 Offset: 0x161081 VA: 0x160F80
	public float RootRotateX; // 0x3C
	[SerializeField] // RVA: 0x160F90 Offset: 0x161091 VA: 0x160F90
	public float RootRotateY; // 0x40
	[SerializeField] // RVA: 0x160FA0 Offset: 0x1610A1 VA: 0x160FA0
	public float RootRotateZ; // 0x44
	[SerializeField] // RVA: 0x160FB0 Offset: 0x1610B1 VA: 0x160FB0
	public float RootScaleX; // 0x48
	[SerializeField] // RVA: 0x160FC0 Offset: 0x1610C1 VA: 0x160FC0
	public float RootScaleY; // 0x4C
	[SerializeField] // RVA: 0x160FD0 Offset: 0x1610D1 VA: 0x160FD0
	public float RootScaleZ; // 0x50
	public int MaxHitCount; // 0x54
	[SerializeField] // RVA: 0x160FE0 Offset: 0x1610E1 VA: 0x160FE0
	public BulletHitCharaEvent HitChara_Event; // 0x58
	[SerializeField] // RVA: 0x160FF0 Offset: 0x1610F1 VA: 0x160FF0
	public BulletHitAlliance HitChara_Alliance; // 0x5C
	[SerializeField] // RVA: 0x161000 Offset: 0x161101 VA: 0x161000
	public int HitChara_MaxHitCount; // 0x60
	[SerializeField] // RVA: 0x161010 Offset: 0x161111 VA: 0x161010
	public float HitChara_HitInterval; // 0x64
	[SerializeField] // RVA: 0x161020 Offset: 0x161121 VA: 0x161020
	public BulletHitObstacleEvent HitObstacle_Event; // 0x68
	[SerializeField] // RVA: 0x161030 Offset: 0x161131 VA: 0x161030
	public int HitObstacle_MaxHitCount; // 0x6C
	[SerializeField] // RVA: 0x161040 Offset: 0x161141 VA: 0x161040
	public float HitObstacle_HitInterval; // 0x70
	[SerializeField] // RVA: 0x161050 Offset: 0x161151 VA: 0x161050
	public float LifeTime; // 0x74
	[SerializeField] // RVA: 0x161060 Offset: 0x161161 VA: 0x161060
	public float LifeDistance; // 0x78
	[SerializeField] // RVA: 0x161070 Offset: 0x161171 VA: 0x161070
	public float Homing_StartTime; // 0x7C
	[SerializeField] // RVA: 0x161080 Offset: 0x161181 VA: 0x161080
	public float Homing_Range; // 0x80
	[SerializeField] // RVA: 0x161090 Offset: 0x161191 VA: 0x161090
	public float Homing_Inductive; // 0x84
	[SerializeField] // RVA: 0x1610A0 Offset: 0x1611A1 VA: 0x1610A0
	public float Spin_SpeedX; // 0x88
	[SerializeField] // RVA: 0x1610B0 Offset: 0x1611B1 VA: 0x1610B0
	public float Spin_SpeedY; // 0x8C
	[SerializeField] // RVA: 0x1610C0 Offset: 0x1611C1 VA: 0x1610C0
	public float Spin_SpeedZ; // 0x90
	[SerializeField] // RVA: 0x1610D0 Offset: 0x1611D1 VA: 0x1610D0
	public float Curve_SpeedX; // 0x94
	[SerializeField] // RVA: 0x1610E0 Offset: 0x1611E1 VA: 0x1610E0
	public float Curve_SpeedY; // 0x98
	[SerializeField] // RVA: 0x1610F0 Offset: 0x1611F1 VA: 0x1610F0
	public float Curve_SpeedZ; // 0x9C
	[SerializeField] // RVA: 0x161100 Offset: 0x161201 VA: 0x161100
	public float Curve_Duration; // 0xA0
	[SerializeField] // RVA: 0x161110 Offset: 0x161211 VA: 0x161110
	public float Swing_SizeX; // 0xA4
	[SerializeField] // RVA: 0x161120 Offset: 0x161221 VA: 0x161120
	public float Swing_SizeY; // 0xA8
	[SerializeField] // RVA: 0x161130 Offset: 0x161231 VA: 0x161130
	public float Swing_SizeZ; // 0xAC
	[SerializeField] // RVA: 0x161140 Offset: 0x161241 VA: 0x161140
	public float Swing_DurationX; // 0xB0
	[SerializeField] // RVA: 0x161150 Offset: 0x161251 VA: 0x161150
	public float Swing_DurationY; // 0xB4
	[SerializeField] // RVA: 0x161160 Offset: 0x161261 VA: 0x161160
	public float Swing_DurationZ; // 0xB8
	[SerializeField] // RVA: 0x161170 Offset: 0x161271 VA: 0x161170
	public float Rotate_StartTime; // 0xBC
	[SerializeField] // RVA: 0x161180 Offset: 0x161281 VA: 0x161180
	public float Rotate_EndTime; // 0xC0
	[SerializeField] // RVA: 0x161190 Offset: 0x161291 VA: 0x161190
	public float Rotate_AngleX; // 0xC4
	[SerializeField] // RVA: 0x1611A0 Offset: 0x1612A1 VA: 0x1611A0
	public float Rotate_AngleY; // 0xC8
	[SerializeField] // RVA: 0x1611B0 Offset: 0x1612B1 VA: 0x1611B0
	public float Rotate_AngleZ; // 0xCC
	[SerializeField] // RVA: 0x1611C0 Offset: 0x1612C1 VA: 0x1611C0
	public float AttractForce_Radius; // 0xD0
	[SerializeField] // RVA: 0x1611D0 Offset: 0x1612D1 VA: 0x1611D0
	public float AttractForce_Power; // 0xD4
	[SerializeField] // RVA: 0x1611E0 Offset: 0x1612E1 VA: 0x1611E0
	public TargetAlliance AttractForce_Alliance; // 0xD8
	[SerializeField] // RVA: 0x1611F0 Offset: 0x1612F1 VA: 0x1611F0
	public float ChangeSpeed_StartTime; // 0xDC
	[SerializeField] // RVA: 0x161200 Offset: 0x161301 VA: 0x161200
	public float ChangeSpeed_Speed; // 0xE0
	[SerializeField] // RVA: 0x161210 Offset: 0x161311 VA: 0x161210
	public float ChangeAccele_StartTime; // 0xE4
	[SerializeField] // RVA: 0x161220 Offset: 0x161321 VA: 0x161220
	public float ChangeAccele_Accele; // 0xE8
	[SerializeField] // RVA: 0x161230 Offset: 0x161331 VA: 0x161230
	public float ChangeScale_StartTime; // 0xEC
	[SerializeField] // RVA: 0x161240 Offset: 0x161341 VA: 0x161240
	public float ChangeScale_EndTime; // 0xF0
	[SerializeField] // RVA: 0x161250 Offset: 0x161351 VA: 0x161250
	public float ChangeScale_ScaleX; // 0xF4
	[SerializeField] // RVA: 0x161260 Offset: 0x161361 VA: 0x161260
	public float ChangeScale_ScaleY; // 0xF8
	[SerializeField] // RVA: 0x161270 Offset: 0x161371 VA: 0x161270
	public float ChangeScale_ScaleZ; // 0xFC
	[SerializeField] // RVA: 0x161280 Offset: 0x161381 VA: 0x161280
	public float Grounder_Height; // 0x100
	[SerializeField] // RVA: 0x161290 Offset: 0x161391 VA: 0x161290
	public EffectID Grounder_EffectID; // 0x104
	[SerializeField] // RVA: 0x1612A0 Offset: 0x1613A1 VA: 0x1612A0
	public float Grounder_Interval; // 0x108
	[SerializeField] // RVA: 0x1612B0 Offset: 0x1613B1 VA: 0x1612B0
	public BulletExplosionType Explosion_Type; // 0x10C
	[SerializeField] // RVA: 0x1612C0 Offset: 0x1613C1 VA: 0x1612C0
	public float Explosion_Radius; // 0x110
	[SerializeField] // RVA: 0x1612D0 Offset: 0x1613D1 VA: 0x1612D0
	public EffectID Explosion_EffectID; // 0x114
	[SerializeField] // RVA: 0x1612E0 Offset: 0x1613E1 VA: 0x1612E0
	public float Explosion_EffectScale; // 0x118
	[SerializeField] // RVA: 0x1612F0 Offset: 0x1613F1 VA: 0x1612F0
	public MagicParamID Explosion_ParamID; // 0x11C
	[SerializeField] // RVA: 0x161300 Offset: 0x161401 VA: 0x161300
	public float Laser_Radius; // 0x120
	[SerializeField] // RVA: 0x161310 Offset: 0x161411 VA: 0x161310
	public float Laser_Length; // 0x124
	[SerializeField] // RVA: 0x161320 Offset: 0x161421 VA: 0x161320
	public float Laser_Speed; // 0x128
	[SerializeField] // RVA: 0x161330 Offset: 0x161431 VA: 0x161330
	public float Search_Radius; // 0x12C
	[SerializeField] // RVA: 0x161340 Offset: 0x161441 VA: 0x161340
	public float Search_Interval; // 0x130
	[SerializeField] // RVA: 0x161350 Offset: 0x161451 VA: 0x161350
	public TargetAlliance Search_Alliance; // 0x134
	[SerializeField] // RVA: 0x161360 Offset: 0x161461 VA: 0x161360
	public BulletScriptPlayType Script_PlayType; // 0x138
	[SerializeField] // RVA: 0x161370 Offset: 0x161471 VA: 0x161370
	public string Script_Name; // 0x140
	[SerializeField] // RVA: 0x161380 Offset: 0x161481 VA: 0x161380
	public Prefab PrefabID; // 0x148
	[SerializeField] // RVA: 0x161390 Offset: 0x161491 VA: 0x161390
	public bool EffectLoop; // 0x14C
	[SerializeField] // RVA: 0x1613A0 Offset: 0x1614A1 VA: 0x1613A0
	public MagicParamID ParamID; // 0x150
	[SerializeField] // RVA: 0x1613B0 Offset: 0x1614B1 VA: 0x1613B0
	public SoundID SoundID; // 0x154
	[SerializeField] // RVA: 0x1613C0 Offset: 0x1614C1 VA: 0x1613C0
	public EffectID Shot_EffectID; // 0x158
	[SerializeField] // RVA: 0x1613D0 Offset: 0x1614D1 VA: 0x1613D0
	public SoundID Shot_SoundID; // 0x15C
	[SerializeField] // RVA: 0x1613E0 Offset: 0x1614E1 VA: 0x1613E0
	public SoundID Shot_SoundID2; // 0x160
	[SerializeField] // RVA: 0x1613F0 Offset: 0x1614F1 VA: 0x1613F0
	public EffectID Dead_EffectID; // 0x164
	[SerializeField] // RVA: 0x161400 Offset: 0x161501 VA: 0x161400
	public SoundID Dead_SoundID; // 0x168
	[SerializeField] // RVA: 0x161410 Offset: 0x161511 VA: 0x161410
	public EffectID Hit_EffectID; // 0x16C
	[SerializeField] // RVA: 0x161420 Offset: 0x161521 VA: 0x161420
	public SoundID Hit_SoundID; // 0x170

	// Methods

	// RVA: 0x20665A0 Offset: 0x20666A1 VA: 0x20665A0
	public void .ctor() { }
}

