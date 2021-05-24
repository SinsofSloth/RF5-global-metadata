public class SkyMaterialController // TypeDefIndex: 9676
{
	// Fields
	[SerializeField] // RVA: 0x17D840 Offset: 0x17D941 VA: 0x17D840
	private Material _skyboxMaterial; // 0x10
	[SerializeField] // RVA: 0x17D850 Offset: 0x17D951 VA: 0x17D850
	private Color _skyColor; // 0x18
	[SerializeField] // RVA: 0x17D860 Offset: 0x17D961 VA: 0x17D860
	private Color _skyMiddleColor; // 0x28
	[SerializeField] // RVA: 0x17D870 Offset: 0x17D971 VA: 0x17D870
	private Color _horizonColor; // 0x38
	[SerializeField] // RVA: 0x17D880 Offset: 0x17D981 VA: 0x17D880
	[RangeAttribute] // RVA: 0x17D880 Offset: 0x17D981 VA: 0x17D880
	private float _gradientFadeBegin; // 0x48
	[SerializeField] // RVA: 0x17D8C0 Offset: 0x17D9C1 VA: 0x17D8C0
	[RangeAttribute] // RVA: 0x17D8C0 Offset: 0x17D9C1 VA: 0x17D8C0
	private float _gradientFadeLength; // 0x4C
	[SerializeField] // RVA: 0x17D900 Offset: 0x17DA01 VA: 0x17D900
	[RangeAttribute] // RVA: 0x17D900 Offset: 0x17DA01 VA: 0x17D900
	private float _skyMiddlePosition; // 0x50
	[SerializeField] // RVA: 0x17D940 Offset: 0x17DA41 VA: 0x17D940
	private Cubemap _backgroundCubemap; // 0x58
	[SerializeField] // RVA: 0x17D950 Offset: 0x17DA51 VA: 0x17D950
	[RangeAttribute] // RVA: 0x17D950 Offset: 0x17DA51 VA: 0x17D950
	private float _starFadeBegin; // 0x60
	[SerializeField] // RVA: 0x17D990 Offset: 0x17DA91 VA: 0x17D990
	[RangeAttribute] // RVA: 0x17D990 Offset: 0x17DA91 VA: 0x17D990
	private float _starFadeLength; // 0x64
	[SerializeField] // RVA: 0x17D9D0 Offset: 0x17DAD1 VA: 0x17D9D0
	[RangeAttribute] // RVA: 0x17D9D0 Offset: 0x17DAD1 VA: 0x17D9D0
	private float _horizonDistanceScale; // 0x68
	[SerializeField] // RVA: 0x17DA10 Offset: 0x17DB11 VA: 0x17DA10
	private Texture _starBasicCubemap; // 0x70
	[SerializeField] // RVA: 0x17DA20 Offset: 0x17DB21 VA: 0x17DA20
	private float _starBasicTwinkleSpeed; // 0x78
	[SerializeField] // RVA: 0x17DA30 Offset: 0x17DB31 VA: 0x17DA30
	private float _starBasicTwinkleAmount; // 0x7C
	[SerializeField] // RVA: 0x17DA40 Offset: 0x17DB41 VA: 0x17DA40
	private float _starBasicOpacity; // 0x80
	[SerializeField] // RVA: 0x17DA50 Offset: 0x17DB51 VA: 0x17DA50
	private Color _starBasicTintColor; // 0x84
	[SerializeField] // RVA: 0x17DA60 Offset: 0x17DB61 VA: 0x17DA60
	private float _starBasicExponent; // 0x94
	[SerializeField] // RVA: 0x17DA70 Offset: 0x17DB71 VA: 0x17DA70
	private float _starBasicIntensity; // 0x98
	[SerializeField] // RVA: 0x17DA80 Offset: 0x17DB81 VA: 0x17DA80
	private Texture _starLayer1Texture; // 0xA0
	[SerializeField] // RVA: 0x17DA90 Offset: 0x17DB91 VA: 0x17DA90
	private Texture2D _starLayer1DataTexture; // 0xA8
	[SerializeField] // RVA: 0x17DAA0 Offset: 0x17DBA1 VA: 0x17DAA0
	private Color _starLayer1Color; // 0xB0
	[SerializeField] // RVA: 0x17DAB0 Offset: 0x17DBB1 VA: 0x17DAB0
	[RangeAttribute] // RVA: 0x17DAB0 Offset: 0x17DBB1 VA: 0x17DAB0
	private float _starLayer1MaxRadius; // 0xC0
	[SerializeField] // RVA: 0x17DB00 Offset: 0x17DC01 VA: 0x17DB00
	[RangeAttribute] // RVA: 0x17DB00 Offset: 0x17DC01 VA: 0x17DB00
	private float _starLayer1TwinkleAmount; // 0xC4
	[SerializeField] // RVA: 0x17DB40 Offset: 0x17DC41 VA: 0x17DB40
	[RangeAttribute] // RVA: 0x17DB40 Offset: 0x17DC41 VA: 0x17DB40
	private float _starLayer1TwinkleSpeed; // 0xC8
	[SerializeField] // RVA: 0x17DB80 Offset: 0x17DC81 VA: 0x17DB80
	[RangeAttribute] // RVA: 0x17DB80 Offset: 0x17DC81 VA: 0x17DB80
	private float _starLayer1RotationSpeed; // 0xCC
	[SerializeField] // RVA: 0x17DBC0 Offset: 0x17DCC1 VA: 0x17DBC0
	[RangeAttribute] // RVA: 0x17DBC0 Offset: 0x17DCC1 VA: 0x17DBC0
	private float _starLayer1EdgeFeathering; // 0xD0
	[SerializeField] // RVA: 0x17DC10 Offset: 0x17DD11 VA: 0x17DC10
	[RangeAttribute] // RVA: 0x17DC10 Offset: 0x17DD11 VA: 0x17DC10
	private float _starLayer1BloomFilterBoost; // 0xD4
	[SerializeField] // RVA: 0x17DC50 Offset: 0x17DD51 VA: 0x17DC50
	private Vector4 _starLayer1SpriteDimensions; // 0xD8
	[SerializeField] // RVA: 0x17DC60 Offset: 0x17DD61 VA: 0x17DC60
	private int _starLayer1SpriteItemCount; // 0xE8
	[SerializeField] // RVA: 0x17DC70 Offset: 0x17DD71 VA: 0x17DC70
	[RangeAttribute] // RVA: 0x17DC70 Offset: 0x17DD71 VA: 0x17DC70
	private float _starLayer1SpriteAnimationSpeed; // 0xEC
	[SerializeField] // RVA: 0x17DCB0 Offset: 0x17DDB1 VA: 0x17DCB0
	private Texture _starLayer2Texture; // 0xF0
	[SerializeField] // RVA: 0x17DCC0 Offset: 0x17DDC1 VA: 0x17DCC0
	private Texture2D _starLayer2DataTexture; // 0xF8
	[SerializeField] // RVA: 0x17DCD0 Offset: 0x17DDD1 VA: 0x17DCD0
	private Color _starLayer2Color; // 0x100
	[SerializeField] // RVA: 0x17DCE0 Offset: 0x17DDE1 VA: 0x17DCE0
	[RangeAttribute] // RVA: 0x17DCE0 Offset: 0x17DDE1 VA: 0x17DCE0
	private float _starLayer2MaxRadius; // 0x110
	[SerializeField] // RVA: 0x17DD30 Offset: 0x17DE31 VA: 0x17DD30
	[RangeAttribute] // RVA: 0x17DD30 Offset: 0x17DE31 VA: 0x17DD30
	private float _starLayer2TwinkleAmount; // 0x114
	[SerializeField] // RVA: 0x17DD70 Offset: 0x17DE71 VA: 0x17DD70
	[RangeAttribute] // RVA: 0x17DD70 Offset: 0x17DE71 VA: 0x17DD70
	private float _starLayer2TwinkleSpeed; // 0x118
	[SerializeField] // RVA: 0x17DDB0 Offset: 0x17DEB1 VA: 0x17DDB0
	[RangeAttribute] // RVA: 0x17DDB0 Offset: 0x17DEB1 VA: 0x17DDB0
	private float _starLayer2RotationSpeed; // 0x11C
	[SerializeField] // RVA: 0x17DDF0 Offset: 0x17DEF1 VA: 0x17DDF0
	[RangeAttribute] // RVA: 0x17DDF0 Offset: 0x17DEF1 VA: 0x17DDF0
	private float _starLayer2EdgeFeathering; // 0x120
	[SerializeField] // RVA: 0x17DE40 Offset: 0x17DF41 VA: 0x17DE40
	[RangeAttribute] // RVA: 0x17DE40 Offset: 0x17DF41 VA: 0x17DE40
	private float _starLayer2BloomFilterBoost; // 0x124
	[SerializeField] // RVA: 0x17DE80 Offset: 0x17DF81 VA: 0x17DE80
	private Vector4 _starLayer2SpriteDimensions; // 0x128
	[SerializeField] // RVA: 0x17DE90 Offset: 0x17DF91 VA: 0x17DE90
	private int _starLayer2SpriteItemCount; // 0x138
	[SerializeField] // RVA: 0x17DEA0 Offset: 0x17DFA1 VA: 0x17DEA0
	[RangeAttribute] // RVA: 0x17DEA0 Offset: 0x17DFA1 VA: 0x17DEA0
	private float _starLayer2SpriteAnimationSpeed; // 0x13C
	[SerializeField] // RVA: 0x17DEE0 Offset: 0x17DFE1 VA: 0x17DEE0
	private Texture _starLayer3Texture; // 0x140
	[SerializeField] // RVA: 0x17DEF0 Offset: 0x17DFF1 VA: 0x17DEF0
	private Texture2D _starLayer3DataTexture; // 0x148
	[SerializeField] // RVA: 0x17DF00 Offset: 0x17E001 VA: 0x17DF00
	private Color _starLayer3Color; // 0x150
	[SerializeField] // RVA: 0x17DF10 Offset: 0x17E011 VA: 0x17DF10
	[RangeAttribute] // RVA: 0x17DF10 Offset: 0x17E011 VA: 0x17DF10
	private float _starLayer3MaxRadius; // 0x160
	[SerializeField] // RVA: 0x17DF60 Offset: 0x17E061 VA: 0x17DF60
	[RangeAttribute] // RVA: 0x17DF60 Offset: 0x17E061 VA: 0x17DF60
	private float _starLayer3TwinkleAmount; // 0x164
	[SerializeField] // RVA: 0x17DFA0 Offset: 0x17E0A1 VA: 0x17DFA0
	[RangeAttribute] // RVA: 0x17DFA0 Offset: 0x17E0A1 VA: 0x17DFA0
	private float _starLayer3TwinkleSpeed; // 0x168
	[SerializeField] // RVA: 0x17DFE0 Offset: 0x17E0E1 VA: 0x17DFE0
	[RangeAttribute] // RVA: 0x17DFE0 Offset: 0x17E0E1 VA: 0x17DFE0
	private float _starLayer3RotationSpeed; // 0x16C
	[SerializeField] // RVA: 0x17E020 Offset: 0x17E121 VA: 0x17E020
	[RangeAttribute] // RVA: 0x17E020 Offset: 0x17E121 VA: 0x17E020
	private float _starLayer3EdgeFeathering; // 0x170
	[SerializeField] // RVA: 0x17E070 Offset: 0x17E171 VA: 0x17E070
	[RangeAttribute] // RVA: 0x17E070 Offset: 0x17E171 VA: 0x17E070
	private float _starLayer3BloomFilterBoost; // 0x174
	[SerializeField] // RVA: 0x17E0B0 Offset: 0x17E1B1 VA: 0x17E0B0
	private Vector4 _starLayer3SpriteDimensions; // 0x178
	[SerializeField] // RVA: 0x17E0C0 Offset: 0x17E1C1 VA: 0x17E0C0
	private int _starLayer3SpriteItemCount; // 0x188
	[SerializeField] // RVA: 0x17E0D0 Offset: 0x17E1D1 VA: 0x17E0D0
	[RangeAttribute] // RVA: 0x17E0D0 Offset: 0x17E1D1 VA: 0x17E0D0
	private float _starLayer3SpriteAnimationSpeed; // 0x18C
	[SerializeField] // RVA: 0x17E110 Offset: 0x17E211 VA: 0x17E110
	private Texture _moonTexture; // 0x190
	[SerializeField] // RVA: 0x17E120 Offset: 0x17E221 VA: 0x17E120
	private float _moonRotationSpeed; // 0x198
	[SerializeField] // RVA: 0x17E130 Offset: 0x17E231 VA: 0x17E130
	private Color _moonColor; // 0x19C
	[SerializeField] // RVA: 0x17E140 Offset: 0x17E241 VA: 0x17E140
	private Vector3 _moonDirection; // 0x1AC
	[SerializeField] // RVA: 0x17E150 Offset: 0x17E251 VA: 0x17E150
	private Matrix4x4 _moonWorldToLocalMatrix; // 0x1B8
	[SerializeField] // RVA: 0x17E160 Offset: 0x17E261 VA: 0x17E160
	[RangeAttribute] // RVA: 0x17E160 Offset: 0x17E261 VA: 0x17E160
	private float _moonSize; // 0x1F8
	[SerializeField] // RVA: 0x17E1A0 Offset: 0x17E2A1 VA: 0x17E1A0
	[RangeAttribute] // RVA: 0x17E1A0 Offset: 0x17E2A1 VA: 0x17E1A0
	private float _moonEdgeFeathering; // 0x1FC
	[SerializeField] // RVA: 0x17E1F0 Offset: 0x17E2F1 VA: 0x17E1F0
	[RangeAttribute] // RVA: 0x17E1F0 Offset: 0x17E2F1 VA: 0x17E1F0
	private float _moonBloomFilterBoost; // 0x200
	[SerializeField] // RVA: 0x17E230 Offset: 0x17E331 VA: 0x17E230
	private Vector4 _moonSpriteDimensions; // 0x204
	[SerializeField] // RVA: 0x17E240 Offset: 0x17E341 VA: 0x17E240
	private int _moonSpriteItemCount; // 0x214
	[SerializeField] // RVA: 0x17E250 Offset: 0x17E351 VA: 0x17E250
	[RangeAttribute] // RVA: 0x17E250 Offset: 0x17E351 VA: 0x17E250
	private float _moonSpriteAnimationSpeed; // 0x218
	[SerializeField] // RVA: 0x17E290 Offset: 0x17E391 VA: 0x17E290
	private Texture _sunTexture; // 0x220
	[SerializeField] // RVA: 0x17E2A0 Offset: 0x17E3A1 VA: 0x17E2A0
	private Color _sunColor; // 0x228
	[SerializeField] // RVA: 0x17E2B0 Offset: 0x17E3B1 VA: 0x17E2B0
	private float _sunRotationSpeed; // 0x238
	[SerializeField] // RVA: 0x17E2C0 Offset: 0x17E3C1 VA: 0x17E2C0
	private Vector3 _sunDirection; // 0x23C
	[SerializeField] // RVA: 0x17E2D0 Offset: 0x17E3D1 VA: 0x17E2D0
	private Matrix4x4 _sunWorldToLocalMatrix; // 0x248
	[SerializeField] // RVA: 0x17E2E0 Offset: 0x17E3E1 VA: 0x17E2E0
	[RangeAttribute] // RVA: 0x17E2E0 Offset: 0x17E3E1 VA: 0x17E2E0
	private float _sunSize; // 0x288
	[SerializeField] // RVA: 0x17E320 Offset: 0x17E421 VA: 0x17E320
	[RangeAttribute] // RVA: 0x17E320 Offset: 0x17E421 VA: 0x17E320
	private float _sunEdgeFeathering; // 0x28C
	[SerializeField] // RVA: 0x17E370 Offset: 0x17E471 VA: 0x17E370
	[RangeAttribute] // RVA: 0x17E370 Offset: 0x17E471 VA: 0x17E370
	private float _sunBloomFilterBoost; // 0x290
	[SerializeField] // RVA: 0x17E3B0 Offset: 0x17E4B1 VA: 0x17E3B0
	private Vector4 _sunSpriteDimensions; // 0x294
	[SerializeField] // RVA: 0x17E3C0 Offset: 0x17E4C1 VA: 0x17E3C0
	private int _sunSpriteItemCount; // 0x2A4
	[SerializeField] // RVA: 0x17E3D0 Offset: 0x17E4D1 VA: 0x17E3D0
	[RangeAttribute] // RVA: 0x17E3D0 Offset: 0x17E4D1 VA: 0x17E3D0
	private float _sunSpriteAnimationSpeed; // 0x2A8
	[SerializeField] // RVA: 0x17E410 Offset: 0x17E511 VA: 0x17E410
	[RangeAttribute] // RVA: 0x17E410 Offset: 0x17E511 VA: 0x17E410
	private float _cloudBegin; // 0x2AC
	private float _cloudTextureTiling; // 0x2B0
	private float _cloud2TextureTiling; // 0x2B4
	[SerializeField] // RVA: 0x17E450 Offset: 0x17E551 VA: 0x17E450
	private Color _cloudColor; // 0x2B8
	[SerializeField] // RVA: 0x17E460 Offset: 0x17E561 VA: 0x17E460
	private Texture _cloudTexture; // 0x2C8
	[SerializeField] // RVA: 0x17E470 Offset: 0x17E571 VA: 0x17E470
	private Texture _cloud2Texture; // 0x2D0
	[SerializeField] // RVA: 0x17E480 Offset: 0x17E581 VA: 0x17E480
	private Texture _artCloudCustomTexture; // 0x2D8
	[SerializeField] // RVA: 0x17E490 Offset: 0x17E591 VA: 0x17E490
	private float _cloudDensity; // 0x2E0
	[SerializeField] // RVA: 0x17E4A0 Offset: 0x17E5A1 VA: 0x17E4A0
	private float _cloud2Density; // 0x2E4
	[SerializeField] // RVA: 0x17E4B0 Offset: 0x17E5B1 VA: 0x17E4B0
	private float _cloudSpeed; // 0x2E8
	[SerializeField] // RVA: 0x17E4C0 Offset: 0x17E5C1 VA: 0x17E4C0
	private float _cloud2Speed; // 0x2EC
	[SerializeField] // RVA: 0x17E4D0 Offset: 0x17E5D1 VA: 0x17E4D0
	private float _cloudDirection; // 0x2F0
	[SerializeField] // RVA: 0x17E4E0 Offset: 0x17E5E1 VA: 0x17E4E0
	private float _cloud2Direction; // 0x2F4
	[SerializeField] // RVA: 0x17E4F0 Offset: 0x17E5F1 VA: 0x17E4F0
	private float _cloudHeight; // 0x2F8
	[SerializeField] // RVA: 0x17E500 Offset: 0x17E601 VA: 0x17E500
	private float _cloud2Height; // 0x2FC
	[SerializeField] // RVA: 0x17E510 Offset: 0x17E611 VA: 0x17E510
	private Color _cloudColor1; // 0x300
	[SerializeField] // RVA: 0x17E520 Offset: 0x17E621 VA: 0x17E520
	private Color _cloud2Color1; // 0x310
	[SerializeField] // RVA: 0x17E530 Offset: 0x17E631 VA: 0x17E530
	private Color _cloudColor2; // 0x320
	[SerializeField] // RVA: 0x17E540 Offset: 0x17E641 VA: 0x17E540
	private Color _cloud2Color2; // 0x330
	[SerializeField] // RVA: 0x17E550 Offset: 0x17E651 VA: 0x17E550
	private float _cloudFadePosition; // 0x340
	[SerializeField] // RVA: 0x17E560 Offset: 0x17E661 VA: 0x17E560
	private float _cloud2FadePosition; // 0x344
	[SerializeField] // RVA: 0x17E570 Offset: 0x17E671 VA: 0x17E570
	private float _cloudFadeAmount; // 0x348
	[SerializeField] // RVA: 0x17E580 Offset: 0x17E681 VA: 0x17E580
	private float _cloud2FadeAmount; // 0x34C
	[SerializeField] // RVA: 0x17E590 Offset: 0x17E691 VA: 0x17E590
	private Texture _cloudCubemap; // 0x350
	[SerializeField] // RVA: 0x17E5A0 Offset: 0x17E6A1 VA: 0x17E5A0
	private float _cloudCubemapRotationSpeed; // 0x358
	[SerializeField] // RVA: 0x17E5B0 Offset: 0x17E6B1 VA: 0x17E5B0
	private Texture _cloudCubemapDoubleLayerCustomTexture; // 0x360
	[SerializeField] // RVA: 0x17E5C0 Offset: 0x17E6C1 VA: 0x17E5C0
	private float _cloudCubemapDoubleLayerRotationSpeed; // 0x368
	[SerializeField] // RVA: 0x17E5D0 Offset: 0x17E6D1 VA: 0x17E5D0
	private float _cloudCubemapDoubleLayerHeight; // 0x36C
	[SerializeField] // RVA: 0x17E5E0 Offset: 0x17E6E1 VA: 0x17E5E0
	private Color _cloudCubemapDoubleLayerTintColor; // 0x370
	[SerializeField] // RVA: 0x17E5F0 Offset: 0x17E6F1 VA: 0x17E5F0
	private Color _cloudCubemapTintColor; // 0x380
	[SerializeField] // RVA: 0x17E600 Offset: 0x17E701 VA: 0x17E600
	private float _cloudCubemapHeight; // 0x390
	[SerializeField] // RVA: 0x17E610 Offset: 0x17E711 VA: 0x17E610
	private Texture _cloudCubemapNormalTexture; // 0x398
	[SerializeField] // RVA: 0x17E620 Offset: 0x17E721 VA: 0x17E620
	private Color _cloudCubemapNormalLitColor; // 0x3A0
	[SerializeField] // RVA: 0x17E630 Offset: 0x17E731 VA: 0x17E630
	private Color _cloudCubemapNormalShadowColor; // 0x3B0
	[SerializeField] // RVA: 0x17E640 Offset: 0x17E741 VA: 0x17E640
	private float _cloudCubemapNormalRotationSpeed; // 0x3C0
	[SerializeField] // RVA: 0x17E650 Offset: 0x17E751 VA: 0x17E650
	private float _cloudCubemapNormalHeight; // 0x3C4
	[SerializeField] // RVA: 0x17E660 Offset: 0x17E761 VA: 0x17E660
	private float _cloudCubemapNormalAmbientItensity; // 0x3C8
	[SerializeField] // RVA: 0x17E670 Offset: 0x17E771 VA: 0x17E670
	private Texture _cloudCubemapNormalDoubleLayerCustomTexture; // 0x3D0
	[SerializeField] // RVA: 0x17E680 Offset: 0x17E781 VA: 0x17E680
	private float _cloudCubemapNormalDoubleLayerRotationSpeed; // 0x3D8
	[SerializeField] // RVA: 0x17E690 Offset: 0x17E791 VA: 0x17E690
	private float _cloudCubemapNormalDoubleLayerHeight; // 0x3DC
	[SerializeField] // RVA: 0x17E6A0 Offset: 0x17E7A1 VA: 0x17E6A0
	private Color _cloudCubemapNormalDoubleLayerLitColor; // 0x3E0
	[SerializeField] // RVA: 0x17E6B0 Offset: 0x17E7B1 VA: 0x17E6B0
	private Color _cloudCubemapNormalDoubleLayerShadowColor; // 0x3F0
	[SerializeField] // RVA: 0x17E6C0 Offset: 0x17E7C1 VA: 0x17E6C0
	private Vector3 _cloudCubemapNormalLightDirection; // 0x400
	[SerializeField] // RVA: 0x17E6D0 Offset: 0x17E7D1 VA: 0x17E6D0
	private Color _fogColor; // 0x40C
	[SerializeField] // RVA: 0x17E6E0 Offset: 0x17E7E1 VA: 0x17E6E0
	private float _fogDensity; // 0x41C
	[SerializeField] // RVA: 0x17E6F0 Offset: 0x17E7F1 VA: 0x17E6F0
	private float _fogHeight; // 0x420
	private int _GradientSkyUpperColorId; // 0x424
	private int _GradientSkyMiddleColorId; // 0x428
	private int _GradientSkyLowerColorId; // 0x42C
	private int _GradientFadeMiddlePositionId; // 0x430
	private int _MainTexId; // 0x434
	private int _HorizonScaleFactorId; // 0x438
	private int _StarBasicCubemapId; // 0x43C
	private int _StarBasicTwinkleSpeedId; // 0x440
	private int _StarBasicTwinkleAmountId; // 0x444
	private int _StarBasicOpacityId; // 0x448
	private int _StarBasicTintColorId; // 0x44C
	private int _StarBasicExponentId; // 0x450
	private int _StarBasicHDRBoostId; // 0x454
	private int _StarLayer1TexId; // 0x458
	private int _StarLayer1DataTexId; // 0x45C
	private int _StarLayer1ColorId; // 0x460
	private int _StarLayer1MaxRadiusId; // 0x464
	private int _StarLayer1TwinkleAmountId; // 0x468
	private int _StarLayer1TwinkleSpeedId; // 0x46C
	private int _StarLayer1RotationSpeedId; // 0x470
	private int _StarLayer1EdgeFadeId; // 0x474
	private int _StarLayer1HDRBoostId; // 0x478
	private int _StarLayer1SpriteDimensionsId; // 0x47C
	private int _StarLayer1SpriteItemCountId; // 0x480
	private int _StarLayer1SpriteAnimationSpeedId; // 0x484
	private int _StarLayer2TexId; // 0x488
	private int _StarLayer2DataTexId; // 0x48C
	private int _StarLayer2ColorId; // 0x490
	private int _StarLayer2MaxRadiusId; // 0x494
	private int _StarLayer2TwinkleAmountId; // 0x498
	private int _StarLayer2TwinkleSpeedId; // 0x49C
	private int _StarLayer2RotationSpeedId; // 0x4A0
	private int _StarLayer2EdgeFadeId; // 0x4A4
	private int _StarLayer2HDRBoostId; // 0x4A8
	private int _StarLayer2SpriteDimensionsId; // 0x4AC
	private int _StarLayer2SpriteItemCountId; // 0x4B0
	private int _StarLayer2SpriteAnimationSpeedId; // 0x4B4
	private int _StarLayer3TexId; // 0x4B8
	private int _StarLayer3DataTexId; // 0x4BC
	private int _StarLayer3ColorId; // 0x4C0
	private int _StarLayer3MaxRadiusId; // 0x4C4
	private int _StarLayer3TwinkleAmountId; // 0x4C8
	private int _StarLayer3TwinkleSpeedId; // 0x4CC
	private int _StarLayer3RotationSpeedId; // 0x4D0
	private int _StarLayer3EdgeFadeId; // 0x4D4
	private int _StarLayer3HDRBoostId; // 0x4D8
	private int _StarLayer3SpriteDimensionsId; // 0x4DC
	private int _StarLayer3SpriteItemCountId; // 0x4E0
	private int _StarLayer3SpriteAnimationSpeedId; // 0x4E4
	private int _MoonTexId; // 0x4E8
	private int _MoonRotationSpeedId; // 0x4EC
	private int _MoonColorId; // 0x4F0
	private int _MoonPositionId; // 0x4F4
	private int _MoonWorldToLocalMatId; // 0x4F8
	private int _MoonRadiusId; // 0x4FC
	private int _MoonEdgeFadeId; // 0x500
	private int _MoonHDRBoostId; // 0x504
	private int _MoonSpriteDimensionsId; // 0x508
	private int _MoonSpriteItemCountId; // 0x50C
	private int _MoonSpriteAnimationSpeedId; // 0x510
	private int _SunTexId; // 0x514
	private int _SunColorId; // 0x518
	private int _SunRotationSpeedId; // 0x51C
	private int _SunPositionId; // 0x520
	private int _SunWorldToLocalMatId; // 0x524
	private int _SunRadiusId; // 0x528
	private int _SunEdgeFadeId; // 0x52C
	private int _SunHDRBoostId; // 0x530
	private int _SunSpriteDimensionsId; // 0x534
	private int _SunSpriteItemCountId; // 0x538
	private int _SunSpriteAnimationSpeedId; // 0x53C
	private int _CloudBeginId; // 0x540
	private int _CloudTextureTilingId; // 0x544
	private int _Cloud2TextureTilingId; // 0x548
	private int _CloudColorId; // 0x54C
	private int _CloudNoiseTextureId; // 0x550
	private int _Cloud2NoiseTextureId; // 0x554
	private int _ArtCloudCustomTextureId; // 0x558
	private int _CloudDensityId; // 0x55C
	private int _Cloud2DensityId; // 0x560
	private int _CloudSpeedId; // 0x564
	private int _Cloud2SpeedId; // 0x568
	private int _CloudDirectionId; // 0x56C
	private int _Cloud2DirectionId; // 0x570
	private int _CloudHeightId; // 0x574
	private int _Cloud2HeightId; // 0x578
	private int _CloudColor1Id; // 0x57C
	private int _Cloud2Color1Id; // 0x580
	private int _CloudColor2Id; // 0x584
	private int _Cloud2Color2Id; // 0x588
	private int _CloudFadePositionId; // 0x58C
	private int _Cloud2FadePositionId; // 0x590
	private int _CloudFadeAmountId; // 0x594
	private int _Cloud2FadeAmountId; // 0x598
	private int _CloudCubemapTextureId; // 0x59C
	private int _CloudCubemapRotationSpeedId; // 0x5A0
	private int _CloudCubemapDoubleTextureId; // 0x5A4
	private int _CloudCubemapDoubleLayerRotationSpeedId; // 0x5A8
	private int _CloudCubemapDoubleLayerHeightId; // 0x5AC
	private int _CloudCubemapDoubleLayerTintColorId; // 0x5B0
	private int _CloudCubemapTintColorId; // 0x5B4
	private int _CloudCubemapHeightId; // 0x5B8
	private int _CloudCubemapNormalTextureId; // 0x5BC
	private int _CloudCubemapNormalLitColorId; // 0x5C0
	private int _CloudCubemapNormalShadowColorId; // 0x5C4
	private int _CloudCubemapNormalRotationSpeedId; // 0x5C8
	private int _CloudCubemapNormalHeightId; // 0x5CC
	private int _CloudCubemapNormalAmbientIntensityId; // 0x5D0
	private int _CloudCubemapNormalDoubleTextureId; // 0x5D4
	private int _CloudCubemapNormalDoubleLayerRotationSpeedId; // 0x5D8
	private int _CloudCubemapNormalDoubleLayerHeightId; // 0x5DC
	private int _CloudCubemapNormalDoubleLitColorId; // 0x5E0
	private int _CloudCubemapNormalDoubleShadowColorId; // 0x5E4
	private int _CloudCubemapNormalToLightId; // 0x5E8
	private int _HorizonFogColorId; // 0x5EC
	private int _HorizonFogDensityId; // 0x5F0
	private int _HorizonFogLengthId; // 0x5F4
	private int _GradientFadeBeginId; // 0x5F8
	private int _GradientFadeEndId; // 0x5FC
	private int _StarFadeBeginId; // 0x600
	private int _StarFadeEndId; // 0x604

	// Properties
	public Material SkyboxMaterial { get; set; }
	public Color SkyColor { get; set; }
	public Color SkyMiddleColor { get; set; }
	public Color HorizonColor { get; set; }
	public float GradientFadeBegin { get; set; }
	public float GradientFadeLength { get; set; }
	public float SkyMiddlePosition { get; set; }
	public Cubemap BackgroundCubemap { get; set; }
	public float StarFadeBegin { get; set; }
	public float StarFadeLength { get; set; }
	public float HorizonDistanceScale { get; set; }
	public Texture StarBasicCubemap { get; set; }
	public float StarBasicTwinkleSpeed { get; set; }
	public float StarBasicTwinkleAmount { get; set; }
	public float StarBasicOpacity { get; set; }
	public Color StarBasicTintColor { get; set; }
	public float StarBasicExponent { get; set; }
	public float StarBasicIntensity { get; set; }
	public Texture StarLayer1Texture { get; set; }
	public Texture2D StarLayer1DataTexture { get; set; }
	public Color StarLayer1Color { get; set; }
	public float StarLayer1MaxRadius { get; set; }
	public float StarLayer1TwinkleAmount { get; set; }
	public float StarLayer1TwinkleSpeed { get; set; }
	public float StarLayer1RotationSpeed { get; set; }
	public float StarLayer1EdgeFeathering { get; set; }
	public float StarLayer1BloomFilterBoost { get; set; }
	public int StarLayer1SpriteItemCount { get; set; }
	public float StarLayer1SpriteAnimationSpeed { get; set; }
	public Texture StarLayer2Texture { get; set; }
	public Texture2D StarLayer2DataTexture { get; set; }
	public Color StarLayer2Color { get; set; }
	public float StarLayer2MaxRadius { get; set; }
	public float StarLayer2TwinkleAmount { get; set; }
	public float StarLayer2TwinkleSpeed { get; set; }
	public float StarLayer2RotationSpeed { get; set; }
	public float StarLayer2EdgeFeathering { get; set; }
	public float StarLayer2BloomFilterBoost { get; set; }
	public int StarLayer2SpriteItemCount { get; set; }
	public float StarLayer2SpriteAnimationSpeed { get; set; }
	public Texture StarLayer3Texture { get; set; }
	public Texture2D StarLayer3DataTexture { get; set; }
	public Color StarLayer3Color { get; set; }
	public float StarLayer3MaxRadius { get; set; }
	public float StarLayer3TwinkleAmount { get; set; }
	public float StarLayer3TwinkleSpeed { get; set; }
	public float StarLayer3RotationSpeed { get; set; }
	public float StarLayer3EdgeFeathering { get; set; }
	public float StarLayer3BloomFilterBoost { get; set; }
	public int StarLayer3SpriteItemCount { get; set; }
	public float StarLayer3SpriteAnimationSpeed { get; set; }
	public Texture MoonTexture { get; set; }
	public float MoonRotationSpeed { get; set; }
	public Color MoonColor { get; set; }
	public Vector3 MoonDirection { get; set; }
	public Matrix4x4 MoonWorldToLocalMatrix { get; set; }
	public float MoonSize { get; set; }
	public float MoonEdgeFeathering { get; set; }
	public float MoonBloomFilterBoost { get; set; }
	public int MoonSpriteItemCount { get; set; }
	public float MoonSpriteAnimationSpeed { get; set; }
	public Texture SunTexture { get; set; }
	public Color SunColor { get; set; }
	public float SunRotationSpeed { get; set; }
	public Vector3 SunDirection { get; set; }
	public Matrix4x4 SunWorldToLocalMatrix { get; set; }
	public float SunSize { get; set; }
	public float SunEdgeFeathering { get; set; }
	public float SunBloomFilterBoost { get; set; }
	public int SunSpriteItemCount { get; set; }
	public float SunSpriteAnimationSpeed { get; set; }
	public float CloudBegin { get; set; }
	public float CloudTextureTiling { get; set; }
	public float Cloud2TextureTiling { get; set; }
	public Color CloudColor { get; set; }
	public Texture CloudTexture { get; set; }
	public Texture Cloud2Texture { get; set; }
	public Texture ArtCloudCustomTexture { get; set; }
	public float CloudDensity { get; set; }
	public float Cloud2Density { get; set; }
	public float CloudSpeed { get; set; }
	public float Cloud2Speed { get; set; }
	public float CloudDirection { get; set; }
	public float Cloud2Direction { get; set; }
	public float CloudHeight { get; set; }
	public float Cloud2Height { get; set; }
	public Color CloudColor1 { get; set; }
	public Color Cloud2Color1 { get; set; }
	public Color CloudColor2 { get; set; }
	public Color Cloud2Color2 { get; set; }
	public float CloudFadePosition { get; set; }
	public float Cloud2FadePosition { get; set; }
	public float CloudFadeAmount { get; set; }
	public float Cloud2FadeAmount { get; set; }
	public Texture CloudCubemap { get; set; }
	public float CloudCubemapRotationSpeed { get; set; }
	public Texture CloudCubemapDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapDoubleLayerHeight { get; set; }
	public Color CloudCubemapDoubleLayerTintColor { get; set; }
	public Color CloudCubemapTintColor { get; set; }
	public float CloudCubemapHeight { get; set; }
	public Texture CloudCubemapNormalTexture { get; set; }
	public Color CloudCubemapNormalLitColor { get; set; }
	public Color CloudCubemapNormalShadowColor { get; set; }
	public float CloudCubemapNormalRotationSpeed { get; set; }
	public float CloudCubemapNormalHeight { get; set; }
	public float CloudCubemapNormalAmbientIntensity { get; set; }
	public Texture CloudCubemapNormalDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapNormalDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapNormalDoubleLayerHeight { get; set; }
	public Color CloudCubemapNormalDoubleLayerLitColor { get; set; }
	public Color CloudCubemapNormalDoubleLayerShadowColor { get; set; }
	public Vector3 CloudCubemapNormalLightDirection { get; set; }
	public Color FogColor { get; set; }
	public float FogDensity { get; set; }
	public float FogHeight { get; set; }

	// Methods

	// RVA: 0x22B8820 Offset: 0x22B8921 VA: 0x22B8820
	public Material get_SkyboxMaterial() { }

	// RVA: 0x22B8830 Offset: 0x22B8931 VA: 0x22B8830
	public void set_SkyboxMaterial(Material value) { }

	// RVA: 0x22B8860 Offset: 0x22B8961 VA: 0x22B8860
	public Color get_SkyColor() { }

	// RVA: 0x22B8870 Offset: 0x22B8971 VA: 0x22B8870
	public void set_SkyColor(Color value) { }

	// RVA: 0x22B88B0 Offset: 0x22B89B1 VA: 0x22B88B0
	public Color get_SkyMiddleColor() { }

	// RVA: 0x22B88C0 Offset: 0x22B89C1 VA: 0x22B88C0
	public void set_SkyMiddleColor(Color value) { }

	// RVA: 0x22B8900 Offset: 0x22B8A01 VA: 0x22B8900
	public Color get_HorizonColor() { }

	// RVA: 0x22B8910 Offset: 0x22B8A11 VA: 0x22B8910
	public void set_HorizonColor(Color value) { }

	// RVA: 0x22B8950 Offset: 0x22B8A51 VA: 0x22B8950
	public float get_GradientFadeBegin() { }

	// RVA: 0x22B8960 Offset: 0x22B8A61 VA: 0x22B8960
	public void set_GradientFadeBegin(float value) { }

	// RVA: 0x22B8A30 Offset: 0x22B8B31 VA: 0x22B8A30
	public float get_GradientFadeLength() { }

	// RVA: 0x22B8A40 Offset: 0x22B8B41 VA: 0x22B8A40
	public void set_GradientFadeLength(float value) { }

	// RVA: 0x22B8A50 Offset: 0x22B8B51 VA: 0x22B8A50
	public float get_SkyMiddlePosition() { }

	// RVA: 0x22B8A60 Offset: 0x22B8B61 VA: 0x22B8A60
	public void set_SkyMiddlePosition(float value) { }

	// RVA: 0x22B8A90 Offset: 0x22B8B91 VA: 0x22B8A90
	public Cubemap get_BackgroundCubemap() { }

	// RVA: 0x22B8AA0 Offset: 0x22B8BA1 VA: 0x22B8AA0
	public void set_BackgroundCubemap(Cubemap value) { }

	// RVA: 0x22B8AF0 Offset: 0x22B8BF1 VA: 0x22B8AF0
	public float get_StarFadeBegin() { }

	// RVA: 0x22B8B00 Offset: 0x22B8C01 VA: 0x22B8B00
	public void set_StarFadeBegin(float value) { }

	// RVA: 0x22B8BD0 Offset: 0x22B8CD1 VA: 0x22B8BD0
	public float get_StarFadeLength() { }

	// RVA: 0x22B8BE0 Offset: 0x22B8CE1 VA: 0x22B8BE0
	public void set_StarFadeLength(float value) { }

	// RVA: 0x22B8BF0 Offset: 0x22B8CF1 VA: 0x22B8BF0
	public float get_HorizonDistanceScale() { }

	// RVA: 0x22B8C00 Offset: 0x22B8D01 VA: 0x22B8C00
	public void set_HorizonDistanceScale(float value) { }

	// RVA: 0x22B8C30 Offset: 0x22B8D31 VA: 0x22B8C30
	public Texture get_StarBasicCubemap() { }

	// RVA: 0x22B8C40 Offset: 0x22B8D41 VA: 0x22B8C40
	public void set_StarBasicCubemap(Texture value) { }

	// RVA: 0x22B8C90 Offset: 0x22B8D91 VA: 0x22B8C90
	public float get_StarBasicTwinkleSpeed() { }

	// RVA: 0x22B8CA0 Offset: 0x22B8DA1 VA: 0x22B8CA0
	public void set_StarBasicTwinkleSpeed(float value) { }

	// RVA: 0x22B8CD0 Offset: 0x22B8DD1 VA: 0x22B8CD0
	public float get_StarBasicTwinkleAmount() { }

	// RVA: 0x22B8CE0 Offset: 0x22B8DE1 VA: 0x22B8CE0
	public void set_StarBasicTwinkleAmount(float value) { }

	// RVA: 0x22B8D10 Offset: 0x22B8E11 VA: 0x22B8D10
	public float get_StarBasicOpacity() { }

	// RVA: 0x22B8D20 Offset: 0x22B8E21 VA: 0x22B8D20
	public void set_StarBasicOpacity(float value) { }

	// RVA: 0x22B8D50 Offset: 0x22B8E51 VA: 0x22B8D50
	public Color get_StarBasicTintColor() { }

	// RVA: 0x22B8D60 Offset: 0x22B8E61 VA: 0x22B8D60
	public void set_StarBasicTintColor(Color value) { }

	// RVA: 0x22B8DA0 Offset: 0x22B8EA1 VA: 0x22B8DA0
	public float get_StarBasicExponent() { }

	// RVA: 0x22B8DB0 Offset: 0x22B8EB1 VA: 0x22B8DB0
	public void set_StarBasicExponent(float value) { }

	// RVA: 0x22B8DE0 Offset: 0x22B8EE1 VA: 0x22B8DE0
	public float get_StarBasicIntensity() { }

	// RVA: 0x22B8DF0 Offset: 0x22B8EF1 VA: 0x22B8DF0
	public void set_StarBasicIntensity(float value) { }

	// RVA: 0x22B8E20 Offset: 0x22B8F21 VA: 0x22B8E20
	public Texture get_StarLayer1Texture() { }

	// RVA: 0x22B8E30 Offset: 0x22B8F31 VA: 0x22B8E30
	public void set_StarLayer1Texture(Texture value) { }

	// RVA: 0x22B8E80 Offset: 0x22B8F81 VA: 0x22B8E80
	public Texture2D get_StarLayer1DataTexture() { }

	// RVA: 0x22B8E90 Offset: 0x22B8F91 VA: 0x22B8E90
	public void set_StarLayer1DataTexture(Texture2D value) { }

	// RVA: 0x22B8EE0 Offset: 0x22B8FE1 VA: 0x22B8EE0
	public Color get_StarLayer1Color() { }

	// RVA: 0x22B8EF0 Offset: 0x22B8FF1 VA: 0x22B8EF0
	public void set_StarLayer1Color(Color value) { }

	// RVA: 0x22B8F30 Offset: 0x22B9031 VA: 0x22B8F30
	public float get_StarLayer1MaxRadius() { }

	// RVA: 0x22B8F40 Offset: 0x22B9041 VA: 0x22B8F40
	public void set_StarLayer1MaxRadius(float value) { }

	// RVA: 0x22B8F70 Offset: 0x22B9071 VA: 0x22B8F70
	public float get_StarLayer1TwinkleAmount() { }

	// RVA: 0x22B8F80 Offset: 0x22B9081 VA: 0x22B8F80
	public void set_StarLayer1TwinkleAmount(float value) { }

	// RVA: 0x22B8FB0 Offset: 0x22B90B1 VA: 0x22B8FB0
	public float get_StarLayer1TwinkleSpeed() { }

	// RVA: 0x22B8FC0 Offset: 0x22B90C1 VA: 0x22B8FC0
	public void set_StarLayer1TwinkleSpeed(float value) { }

	// RVA: 0x22B8FF0 Offset: 0x22B90F1 VA: 0x22B8FF0
	public float get_StarLayer1RotationSpeed() { }

	// RVA: 0x22B9000 Offset: 0x22B9101 VA: 0x22B9000
	public void set_StarLayer1RotationSpeed(float value) { }

	// RVA: 0x22B9030 Offset: 0x22B9131 VA: 0x22B9030
	public float get_StarLayer1EdgeFeathering() { }

	// RVA: 0x22B9040 Offset: 0x22B9141 VA: 0x22B9040
	public void set_StarLayer1EdgeFeathering(float value) { }

	// RVA: 0x22B9070 Offset: 0x22B9171 VA: 0x22B9070
	public float get_StarLayer1BloomFilterBoost() { }

	// RVA: 0x22B9080 Offset: 0x22B9181 VA: 0x22B9080
	public void set_StarLayer1BloomFilterBoost(float value) { }

	// RVA: 0x22B90B0 Offset: 0x22B91B1 VA: 0x22B90B0
	public void SetStarLayer1SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B90F0 Offset: 0x22B91F1 VA: 0x22B90F0
	public Vector2 GetStarLayer1SpriteDimensions() { }

	// RVA: 0x22B9120 Offset: 0x22B9221 VA: 0x22B9120
	public int get_StarLayer1SpriteItemCount() { }

	// RVA: 0x22B9130 Offset: 0x22B9231 VA: 0x22B9130
	public void set_StarLayer1SpriteItemCount(int value) { }

	// RVA: 0x22B9160 Offset: 0x22B9261 VA: 0x22B9160
	public float get_StarLayer1SpriteAnimationSpeed() { }

	// RVA: 0x22B9170 Offset: 0x22B9271 VA: 0x22B9170
	public void set_StarLayer1SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B91A0 Offset: 0x22B92A1 VA: 0x22B91A0
	public Texture get_StarLayer2Texture() { }

	// RVA: 0x22B91B0 Offset: 0x22B92B1 VA: 0x22B91B0
	public void set_StarLayer2Texture(Texture value) { }

	// RVA: 0x22B9200 Offset: 0x22B9301 VA: 0x22B9200
	public Texture2D get_StarLayer2DataTexture() { }

	// RVA: 0x22B9210 Offset: 0x22B9311 VA: 0x22B9210
	public void set_StarLayer2DataTexture(Texture2D value) { }

	// RVA: 0x22B9260 Offset: 0x22B9361 VA: 0x22B9260
	public Color get_StarLayer2Color() { }

	// RVA: 0x22B9280 Offset: 0x22B9381 VA: 0x22B9280
	public void set_StarLayer2Color(Color value) { }

	// RVA: 0x22B92C0 Offset: 0x22B93C1 VA: 0x22B92C0
	public float get_StarLayer2MaxRadius() { }

	// RVA: 0x22B92D0 Offset: 0x22B93D1 VA: 0x22B92D0
	public void set_StarLayer2MaxRadius(float value) { }

	// RVA: 0x22B9300 Offset: 0x22B9401 VA: 0x22B9300
	public float get_StarLayer2TwinkleAmount() { }

	// RVA: 0x22B9310 Offset: 0x22B9411 VA: 0x22B9310
	public void set_StarLayer2TwinkleAmount(float value) { }

	// RVA: 0x22B9340 Offset: 0x22B9441 VA: 0x22B9340
	public float get_StarLayer2TwinkleSpeed() { }

	// RVA: 0x22B9350 Offset: 0x22B9451 VA: 0x22B9350
	public void set_StarLayer2TwinkleSpeed(float value) { }

	// RVA: 0x22B9380 Offset: 0x22B9481 VA: 0x22B9380
	public float get_StarLayer2RotationSpeed() { }

	// RVA: 0x22B9390 Offset: 0x22B9491 VA: 0x22B9390
	public void set_StarLayer2RotationSpeed(float value) { }

	// RVA: 0x22B93C0 Offset: 0x22B94C1 VA: 0x22B93C0
	public float get_StarLayer2EdgeFeathering() { }

	// RVA: 0x22B93D0 Offset: 0x22B94D1 VA: 0x22B93D0
	public void set_StarLayer2EdgeFeathering(float value) { }

	// RVA: 0x22B9400 Offset: 0x22B9501 VA: 0x22B9400
	public float get_StarLayer2BloomFilterBoost() { }

	// RVA: 0x22B9410 Offset: 0x22B9511 VA: 0x22B9410
	public void set_StarLayer2BloomFilterBoost(float value) { }

	// RVA: 0x22B9440 Offset: 0x22B9541 VA: 0x22B9440
	public void SetStarLayer2SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9480 Offset: 0x22B9581 VA: 0x22B9480
	public Vector2 GetStarLayer2SpriteDimensions() { }

	// RVA: 0x22B94C0 Offset: 0x22B95C1 VA: 0x22B94C0
	public int get_StarLayer2SpriteItemCount() { }

	// RVA: 0x22B94D0 Offset: 0x22B95D1 VA: 0x22B94D0
	public void set_StarLayer2SpriteItemCount(int value) { }

	// RVA: 0x22B9500 Offset: 0x22B9601 VA: 0x22B9500
	public float get_StarLayer2SpriteAnimationSpeed() { }

	// RVA: 0x22B9510 Offset: 0x22B9611 VA: 0x22B9510
	public void set_StarLayer2SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B9540 Offset: 0x22B9641 VA: 0x22B9540
	public Texture get_StarLayer3Texture() { }

	// RVA: 0x22B9550 Offset: 0x22B9651 VA: 0x22B9550
	public void set_StarLayer3Texture(Texture value) { }

	// RVA: 0x22B9590 Offset: 0x22B9691 VA: 0x22B9590
	public Texture2D get_StarLayer3DataTexture() { }

	// RVA: 0x22B95A0 Offset: 0x22B96A1 VA: 0x22B95A0
	public void set_StarLayer3DataTexture(Texture2D value) { }

	// RVA: 0x22B95F0 Offset: 0x22B96F1 VA: 0x22B95F0
	public Color get_StarLayer3Color() { }

	// RVA: 0x22B9610 Offset: 0x22B9711 VA: 0x22B9610
	public void set_StarLayer3Color(Color value) { }

	// RVA: 0x22B9650 Offset: 0x22B9751 VA: 0x22B9650
	public float get_StarLayer3MaxRadius() { }

	// RVA: 0x22B9660 Offset: 0x22B9761 VA: 0x22B9660
	public void set_StarLayer3MaxRadius(float value) { }

	// RVA: 0x22B9690 Offset: 0x22B9791 VA: 0x22B9690
	public float get_StarLayer3TwinkleAmount() { }

	// RVA: 0x22B96A0 Offset: 0x22B97A1 VA: 0x22B96A0
	public void set_StarLayer3TwinkleAmount(float value) { }

	// RVA: 0x22B96D0 Offset: 0x22B97D1 VA: 0x22B96D0
	public float get_StarLayer3TwinkleSpeed() { }

	// RVA: 0x22B96E0 Offset: 0x22B97E1 VA: 0x22B96E0
	public void set_StarLayer3TwinkleSpeed(float value) { }

	// RVA: 0x22B9710 Offset: 0x22B9811 VA: 0x22B9710
	public float get_StarLayer3RotationSpeed() { }

	// RVA: 0x22B9720 Offset: 0x22B9821 VA: 0x22B9720
	public void set_StarLayer3RotationSpeed(float value) { }

	// RVA: 0x22B9750 Offset: 0x22B9851 VA: 0x22B9750
	public float get_StarLayer3EdgeFeathering() { }

	// RVA: 0x22B9760 Offset: 0x22B9861 VA: 0x22B9760
	public void set_StarLayer3EdgeFeathering(float value) { }

	// RVA: 0x22B9790 Offset: 0x22B9891 VA: 0x22B9790
	public float get_StarLayer3BloomFilterBoost() { }

	// RVA: 0x22B97A0 Offset: 0x22B98A1 VA: 0x22B97A0
	public void set_StarLayer3BloomFilterBoost(float value) { }

	// RVA: 0x22B97D0 Offset: 0x22B98D1 VA: 0x22B97D0
	public void SetStarLayer3SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9810 Offset: 0x22B9911 VA: 0x22B9810
	public Vector2 GetStarLayer3SpriteDimensions() { }

	// RVA: 0x22B9850 Offset: 0x22B9951 VA: 0x22B9850
	public int get_StarLayer3SpriteItemCount() { }

	// RVA: 0x22B9860 Offset: 0x22B9961 VA: 0x22B9860
	public void set_StarLayer3SpriteItemCount(int value) { }

	// RVA: 0x22B9890 Offset: 0x22B9991 VA: 0x22B9890
	public float get_StarLayer3SpriteAnimationSpeed() { }

	// RVA: 0x22B98A0 Offset: 0x22B99A1 VA: 0x22B98A0
	public void set_StarLayer3SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B98D0 Offset: 0x22B99D1 VA: 0x22B98D0
	public Texture get_MoonTexture() { }

	// RVA: 0x22B98E0 Offset: 0x22B99E1 VA: 0x22B98E0
	public void set_MoonTexture(Texture value) { }

	// RVA: 0x22B9920 Offset: 0x22B9A21 VA: 0x22B9920
	public float get_MoonRotationSpeed() { }

	// RVA: 0x22B9930 Offset: 0x22B9A31 VA: 0x22B9930
	public void set_MoonRotationSpeed(float value) { }

	// RVA: 0x22B9960 Offset: 0x22B9A61 VA: 0x22B9960
	public Color get_MoonColor() { }

	// RVA: 0x22B9980 Offset: 0x22B9A81 VA: 0x22B9980
	public void set_MoonColor(Color value) { }

	// RVA: 0x22B99C0 Offset: 0x22B9AC1 VA: 0x22B99C0
	public Vector3 get_MoonDirection() { }

	// RVA: 0x22B99D0 Offset: 0x22B9AD1 VA: 0x22B99D0
	public void set_MoonDirection(Vector3 value) { }

	// RVA: 0x22B9AB0 Offset: 0x22B9BB1 VA: 0x22B9AB0
	public Matrix4x4 get_MoonWorldToLocalMatrix() { }

	// RVA: 0x22B9AE0 Offset: 0x22B9BE1 VA: 0x22B9AE0
	public void set_MoonWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x22B9B70 Offset: 0x22B9C71 VA: 0x22B9B70
	public float get_MoonSize() { }

	// RVA: 0x22B9B80 Offset: 0x22B9C81 VA: 0x22B9B80
	public void set_MoonSize(float value) { }

	// RVA: 0x22B9BB0 Offset: 0x22B9CB1 VA: 0x22B9BB0
	public float get_MoonEdgeFeathering() { }

	// RVA: 0x22B9BC0 Offset: 0x22B9CC1 VA: 0x22B9BC0
	public void set_MoonEdgeFeathering(float value) { }

	// RVA: 0x22B9BF0 Offset: 0x22B9CF1 VA: 0x22B9BF0
	public float get_MoonBloomFilterBoost() { }

	// RVA: 0x22B9C00 Offset: 0x22B9D01 VA: 0x22B9C00
	public void set_MoonBloomFilterBoost(float value) { }

	// RVA: 0x22B9C30 Offset: 0x22B9D31 VA: 0x22B9C30
	public void SetMoonSpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9C70 Offset: 0x22B9D71 VA: 0x22B9C70
	public Vector2 GetMoonSpriteDimensions() { }

	// RVA: 0x22B9CB0 Offset: 0x22B9DB1 VA: 0x22B9CB0
	public int get_MoonSpriteItemCount() { }

	// RVA: 0x22B9CC0 Offset: 0x22B9DC1 VA: 0x22B9CC0
	public void set_MoonSpriteItemCount(int value) { }

	// RVA: 0x22B9CF0 Offset: 0x22B9DF1 VA: 0x22B9CF0
	public float get_MoonSpriteAnimationSpeed() { }

	// RVA: 0x22B9D00 Offset: 0x22B9E01 VA: 0x22B9D00
	public void set_MoonSpriteAnimationSpeed(float value) { }

	// RVA: 0x22B9D30 Offset: 0x22B9E31 VA: 0x22B9D30
	public Texture get_SunTexture() { }

	// RVA: 0x22B9D40 Offset: 0x22B9E41 VA: 0x22B9D40
	public void set_SunTexture(Texture value) { }

	// RVA: 0x22B9D80 Offset: 0x22B9E81 VA: 0x22B9D80
	public Color get_SunColor() { }

	// RVA: 0x22B9DA0 Offset: 0x22B9EA1 VA: 0x22B9DA0
	public void set_SunColor(Color value) { }

	// RVA: 0x22B9DE0 Offset: 0x22B9EE1 VA: 0x22B9DE0
	public float get_SunRotationSpeed() { }

	// RVA: 0x22B9DF0 Offset: 0x22B9EF1 VA: 0x22B9DF0
	public void set_SunRotationSpeed(float value) { }

	// RVA: 0x22B9E20 Offset: 0x22B9F21 VA: 0x22B9E20
	public Vector3 get_SunDirection() { }

	// RVA: 0x22B9E30 Offset: 0x22B9F31 VA: 0x22B9E30
	public void set_SunDirection(Vector3 value) { }

	// RVA: 0x22B9F10 Offset: 0x22BA011 VA: 0x22B9F10
	public Matrix4x4 get_SunWorldToLocalMatrix() { }

	// RVA: 0x22B9F50 Offset: 0x22BA051 VA: 0x22B9F50
	public void set_SunWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x22B9FF0 Offset: 0x22BA0F1 VA: 0x22B9FF0
	public float get_SunSize() { }

	// RVA: 0x22BA000 Offset: 0x22BA101 VA: 0x22BA000
	public void set_SunSize(float value) { }

	// RVA: 0x22BA030 Offset: 0x22BA131 VA: 0x22BA030
	public float get_SunEdgeFeathering() { }

	// RVA: 0x22BA040 Offset: 0x22BA141 VA: 0x22BA040
	public void set_SunEdgeFeathering(float value) { }

	// RVA: 0x22BA070 Offset: 0x22BA171 VA: 0x22BA070
	public float get_SunBloomFilterBoost() { }

	// RVA: 0x22BA080 Offset: 0x22BA181 VA: 0x22BA080
	public void set_SunBloomFilterBoost(float value) { }

	// RVA: 0x22BA0B0 Offset: 0x22BA1B1 VA: 0x22BA0B0
	public void SetSunSpriteDimensions(int columns, int rows) { }

	// RVA: 0x22BA0F0 Offset: 0x22BA1F1 VA: 0x22BA0F0
	public Vector2 GetSunSpriteDimensions() { }

	// RVA: 0x22BA130 Offset: 0x22BA231 VA: 0x22BA130
	public int get_SunSpriteItemCount() { }

	// RVA: 0x22BA140 Offset: 0x22BA241 VA: 0x22BA140
	public void set_SunSpriteItemCount(int value) { }

	// RVA: 0x22BA170 Offset: 0x22BA271 VA: 0x22BA170
	public float get_SunSpriteAnimationSpeed() { }

	// RVA: 0x22BA180 Offset: 0x22BA281 VA: 0x22BA180
	public void set_SunSpriteAnimationSpeed(float value) { }

	// RVA: 0x22BA1B0 Offset: 0x22BA2B1 VA: 0x22BA1B0
	public float get_CloudBegin() { }

	// RVA: 0x22BA1C0 Offset: 0x22BA2C1 VA: 0x22BA1C0
	public void set_CloudBegin(float value) { }

	// RVA: 0x22BA1F0 Offset: 0x22BA2F1 VA: 0x22BA1F0
	public float get_CloudTextureTiling() { }

	// RVA: 0x22BA200 Offset: 0x22BA301 VA: 0x22BA200
	public void set_CloudTextureTiling(float value) { }

	// RVA: 0x22BA230 Offset: 0x22BA331 VA: 0x22BA230
	public float get_Cloud2TextureTiling() { }

	// RVA: 0x22BA240 Offset: 0x22BA341 VA: 0x22BA240
	public void set_Cloud2TextureTiling(float value) { }

	// RVA: 0x22BA270 Offset: 0x22BA371 VA: 0x22BA270
	public Color get_CloudColor() { }

	// RVA: 0x22BA290 Offset: 0x22BA391 VA: 0x22BA290
	public void set_CloudColor(Color value) { }

	// RVA: 0x22BA2D0 Offset: 0x22BA3D1 VA: 0x22BA2D0
	public Texture get_CloudTexture() { }

	// RVA: 0x22BA360 Offset: 0x22BA461 VA: 0x22BA360
	public void set_CloudTexture(Texture value) { }

	// RVA: 0x22BA3A0 Offset: 0x22BA4A1 VA: 0x22BA3A0
	public Texture get_Cloud2Texture() { }

	// RVA: 0x22BA430 Offset: 0x22BA531 VA: 0x22BA430
	public void set_Cloud2Texture(Texture value) { }

	// RVA: 0x22BA470 Offset: 0x22BA571 VA: 0x22BA470
	public Texture get_ArtCloudCustomTexture() { }

	// RVA: 0x22BA500 Offset: 0x22BA601 VA: 0x22BA500
	public void set_ArtCloudCustomTexture(Texture value) { }

	// RVA: 0x22BA540 Offset: 0x22BA641 VA: 0x22BA540
	public float get_CloudDensity() { }

	// RVA: 0x22BA550 Offset: 0x22BA651 VA: 0x22BA550
	public void set_CloudDensity(float value) { }

	// RVA: 0x22BA580 Offset: 0x22BA681 VA: 0x22BA580
	public float get_Cloud2Density() { }

	// RVA: 0x22BA590 Offset: 0x22BA691 VA: 0x22BA590
	public void set_Cloud2Density(float value) { }

	// RVA: 0x22BA5C0 Offset: 0x22BA6C1 VA: 0x22BA5C0
	public float get_CloudSpeed() { }

	// RVA: 0x22BA5D0 Offset: 0x22BA6D1 VA: 0x22BA5D0
	public void set_CloudSpeed(float value) { }

	// RVA: 0x22BA600 Offset: 0x22BA701 VA: 0x22BA600
	public float get_Cloud2Speed() { }

	// RVA: 0x22BA610 Offset: 0x22BA711 VA: 0x22BA610
	public void set_Cloud2Speed(float value) { }

	// RVA: 0x22BA640 Offset: 0x22BA741 VA: 0x22BA640
	public float get_CloudDirection() { }

	// RVA: 0x22BA650 Offset: 0x22BA751 VA: 0x22BA650
	public void set_CloudDirection(float value) { }

	// RVA: 0x22BA680 Offset: 0x22BA781 VA: 0x22BA680
	public float get_Cloud2Direction() { }

	// RVA: 0x22BA690 Offset: 0x22BA791 VA: 0x22BA690
	public void set_Cloud2Direction(float value) { }

	// RVA: 0x22BA6C0 Offset: 0x22BA7C1 VA: 0x22BA6C0
	public float get_CloudHeight() { }

	// RVA: 0x22BA6D0 Offset: 0x22BA7D1 VA: 0x22BA6D0
	public void set_CloudHeight(float value) { }

	// RVA: 0x22BA700 Offset: 0x22BA801 VA: 0x22BA700
	public float get_Cloud2Height() { }

	// RVA: 0x22BA710 Offset: 0x22BA811 VA: 0x22BA710
	public void set_Cloud2Height(float value) { }

	// RVA: 0x22BA740 Offset: 0x22BA841 VA: 0x22BA740
	public Color get_CloudColor1() { }

	// RVA: 0x22BA760 Offset: 0x22BA861 VA: 0x22BA760
	public void set_CloudColor1(Color value) { }

	// RVA: 0x22BA7A0 Offset: 0x22BA8A1 VA: 0x22BA7A0
	public Color get_Cloud2Color1() { }

	// RVA: 0x22BA7C0 Offset: 0x22BA8C1 VA: 0x22BA7C0
	public void set_Cloud2Color1(Color value) { }

	// RVA: 0x22BA800 Offset: 0x22BA901 VA: 0x22BA800
	public Color get_CloudColor2() { }

	// RVA: 0x22BA820 Offset: 0x22BA921 VA: 0x22BA820
	public void set_CloudColor2(Color value) { }

	// RVA: 0x22BA860 Offset: 0x22BA961 VA: 0x22BA860
	public Color get_Cloud2Color2() { }

	// RVA: 0x22BA880 Offset: 0x22BA981 VA: 0x22BA880
	public void set_Cloud2Color2(Color value) { }

	// RVA: 0x22BA8C0 Offset: 0x22BA9C1 VA: 0x22BA8C0
	public float get_CloudFadePosition() { }

	// RVA: 0x22BA8D0 Offset: 0x22BA9D1 VA: 0x22BA8D0
	public void set_CloudFadePosition(float value) { }

	// RVA: 0x22BA900 Offset: 0x22BAA01 VA: 0x22BA900
	public float get_Cloud2FadePosition() { }

	// RVA: 0x22BA910 Offset: 0x22BAA11 VA: 0x22BA910
	public void set_Cloud2FadePosition(float value) { }

	// RVA: 0x22BA940 Offset: 0x22BAA41 VA: 0x22BA940
	public float get_CloudFadeAmount() { }

	// RVA: 0x22BA950 Offset: 0x22BAA51 VA: 0x22BA950
	public void set_CloudFadeAmount(float value) { }

	// RVA: 0x22BA980 Offset: 0x22BAA81 VA: 0x22BA980
	public float get_Cloud2FadeAmount() { }

	// RVA: 0x22BA990 Offset: 0x22BAA91 VA: 0x22BA990
	public void set_Cloud2FadeAmount(float value) { }

	// RVA: 0x22BA9C0 Offset: 0x22BAAC1 VA: 0x22BA9C0
	public Texture get_CloudCubemap() { }

	// RVA: 0x22BA9D0 Offset: 0x22BAAD1 VA: 0x22BA9D0
	public void set_CloudCubemap(Texture value) { }

	// RVA: 0x22BAA10 Offset: 0x22BAB11 VA: 0x22BAA10
	public float get_CloudCubemapRotationSpeed() { }

	// RVA: 0x22BAA20 Offset: 0x22BAB21 VA: 0x22BAA20
	public void set_CloudCubemapRotationSpeed(float value) { }

	// RVA: 0x22BAA50 Offset: 0x22BAB51 VA: 0x22BAA50
	public Texture get_CloudCubemapDoubleLayerCustomTexture() { }

	// RVA: 0x22BAA60 Offset: 0x22BAB61 VA: 0x22BAA60
	public void set_CloudCubemapDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x22BAAA0 Offset: 0x22BABA1 VA: 0x22BAAA0
	public float get_CloudCubemapDoubleLayerRotationSpeed() { }

	// RVA: 0x22BAAB0 Offset: 0x22BABB1 VA: 0x22BAAB0
	public void set_CloudCubemapDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x22BAAE0 Offset: 0x22BABE1 VA: 0x22BAAE0
	public float get_CloudCubemapDoubleLayerHeight() { }

	// RVA: 0x22BAAF0 Offset: 0x22BABF1 VA: 0x22BAAF0
	public void set_CloudCubemapDoubleLayerHeight(float value) { }

	// RVA: 0x22BAB20 Offset: 0x22BAC21 VA: 0x22BAB20
	public Color get_CloudCubemapDoubleLayerTintColor() { }

	// RVA: 0x22BAB40 Offset: 0x22BAC41 VA: 0x22BAB40
	public void set_CloudCubemapDoubleLayerTintColor(Color value) { }

	// RVA: 0x22BAB80 Offset: 0x22BAC81 VA: 0x22BAB80
	public Color get_CloudCubemapTintColor() { }

	// RVA: 0x22BABA0 Offset: 0x22BACA1 VA: 0x22BABA0
	public void set_CloudCubemapTintColor(Color value) { }

	// RVA: 0x22BABE0 Offset: 0x22BACE1 VA: 0x22BABE0
	public float get_CloudCubemapHeight() { }

	// RVA: 0x22BABF0 Offset: 0x22BACF1 VA: 0x22BABF0
	public void set_CloudCubemapHeight(float value) { }

	// RVA: 0x22BAC20 Offset: 0x22BAD21 VA: 0x22BAC20
	public Texture get_CloudCubemapNormalTexture() { }

	// RVA: 0x22BAC30 Offset: 0x22BAD31 VA: 0x22BAC30
	public void set_CloudCubemapNormalTexture(Texture value) { }

	// RVA: 0x22BAC70 Offset: 0x22BAD71 VA: 0x22BAC70
	public Color get_CloudCubemapNormalLitColor() { }

	// RVA: 0x22BAC90 Offset: 0x22BAD91 VA: 0x22BAC90
	public void set_CloudCubemapNormalLitColor(Color value) { }

	// RVA: 0x22BACD0 Offset: 0x22BADD1 VA: 0x22BACD0
	public Color get_CloudCubemapNormalShadowColor() { }

	// RVA: 0x22BACF0 Offset: 0x22BADF1 VA: 0x22BACF0
	public void set_CloudCubemapNormalShadowColor(Color value) { }

	// RVA: 0x22BAD30 Offset: 0x22BAE31 VA: 0x22BAD30
	public float get_CloudCubemapNormalRotationSpeed() { }

	// RVA: 0x22BAD40 Offset: 0x22BAE41 VA: 0x22BAD40
	public void set_CloudCubemapNormalRotationSpeed(float value) { }

	// RVA: 0x22BAD70 Offset: 0x22BAE71 VA: 0x22BAD70
	public float get_CloudCubemapNormalHeight() { }

	// RVA: 0x22BAD80 Offset: 0x22BAE81 VA: 0x22BAD80
	public void set_CloudCubemapNormalHeight(float value) { }

	// RVA: 0x22BADB0 Offset: 0x22BAEB1 VA: 0x22BADB0
	public float get_CloudCubemapNormalAmbientIntensity() { }

	// RVA: 0x22BADC0 Offset: 0x22BAEC1 VA: 0x22BADC0
	public void set_CloudCubemapNormalAmbientIntensity(float value) { }

	// RVA: 0x22BADF0 Offset: 0x22BAEF1 VA: 0x22BADF0
	public Texture get_CloudCubemapNormalDoubleLayerCustomTexture() { }

	// RVA: 0x22BAE00 Offset: 0x22BAF01 VA: 0x22BAE00
	public void set_CloudCubemapNormalDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x22BAE40 Offset: 0x22BAF41 VA: 0x22BAE40
	public float get_CloudCubemapNormalDoubleLayerRotationSpeed() { }

	// RVA: 0x22BAE50 Offset: 0x22BAF51 VA: 0x22BAE50
	public void set_CloudCubemapNormalDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x22BAE80 Offset: 0x22BAF81 VA: 0x22BAE80
	public float get_CloudCubemapNormalDoubleLayerHeight() { }

	// RVA: 0x22BAE90 Offset: 0x22BAF91 VA: 0x22BAE90
	public void set_CloudCubemapNormalDoubleLayerHeight(float value) { }

	// RVA: 0x22BAEC0 Offset: 0x22BAFC1 VA: 0x22BAEC0
	public Color get_CloudCubemapNormalDoubleLayerLitColor() { }

	// RVA: 0x22BAEE0 Offset: 0x22BAFE1 VA: 0x22BAEE0
	public void set_CloudCubemapNormalDoubleLayerLitColor(Color value) { }

	// RVA: 0x22BAF20 Offset: 0x22BB021 VA: 0x22BAF20
	public Color get_CloudCubemapNormalDoubleLayerShadowColor() { }

	// RVA: 0x22BAF40 Offset: 0x22BB041 VA: 0x22BAF40
	public void set_CloudCubemapNormalDoubleLayerShadowColor(Color value) { }

	// RVA: 0x22BAF80 Offset: 0x22BB081 VA: 0x22BAF80
	public Vector3 get_CloudCubemapNormalLightDirection() { }

	// RVA: 0x22BAF90 Offset: 0x22BB091 VA: 0x22BAF90
	public void set_CloudCubemapNormalLightDirection(Vector3 value) { }

	// RVA: 0x22BB050 Offset: 0x22BB151 VA: 0x22BB050
	public Color get_FogColor() { }

	// RVA: 0x22BB070 Offset: 0x22BB171 VA: 0x22BB070
	public void set_FogColor(Color value) { }

	// RVA: 0x22BB0B0 Offset: 0x22BB1B1 VA: 0x22BB0B0
	public float get_FogDensity() { }

	// RVA: 0x22BB0C0 Offset: 0x22BB1C1 VA: 0x22BB0C0
	public void set_FogDensity(float value) { }

	// RVA: 0x22BB0F0 Offset: 0x22BB1F1 VA: 0x22BB0F0
	public float get_FogHeight() { }

	// RVA: 0x22BB100 Offset: 0x22BB201 VA: 0x22BB100
	public void set_FogHeight(float value) { }

	// RVA: 0x22B8970 Offset: 0x22B8A71 VA: 0x22B8970
	private void ApplyGradientValuesOnMaterial() { }

	// RVA: 0x22B8B10 Offset: 0x22B8C11 VA: 0x22B8B10
	private void ApplyStarFadeValuesOnMaterial() { }

	// RVA: 0x22BB130 Offset: 0x22BB231 VA: 0x22BB130
	public void .ctor() { }
}

public class SkyMaterialController // TypeDefIndex: 9676
{
	// Fields
	[SerializeField] // RVA: 0x17D840 Offset: 0x17D941 VA: 0x17D840
	private Material _skyboxMaterial; // 0x10
	[SerializeField] // RVA: 0x17D850 Offset: 0x17D951 VA: 0x17D850
	private Color _skyColor; // 0x18
	[SerializeField] // RVA: 0x17D860 Offset: 0x17D961 VA: 0x17D860
	private Color _skyMiddleColor; // 0x28
	[SerializeField] // RVA: 0x17D870 Offset: 0x17D971 VA: 0x17D870
	private Color _horizonColor; // 0x38
	[SerializeField] // RVA: 0x17D880 Offset: 0x17D981 VA: 0x17D880
	[RangeAttribute] // RVA: 0x17D880 Offset: 0x17D981 VA: 0x17D880
	private float _gradientFadeBegin; // 0x48
	[SerializeField] // RVA: 0x17D8C0 Offset: 0x17D9C1 VA: 0x17D8C0
	[RangeAttribute] // RVA: 0x17D8C0 Offset: 0x17D9C1 VA: 0x17D8C0
	private float _gradientFadeLength; // 0x4C
	[SerializeField] // RVA: 0x17D900 Offset: 0x17DA01 VA: 0x17D900
	[RangeAttribute] // RVA: 0x17D900 Offset: 0x17DA01 VA: 0x17D900
	private float _skyMiddlePosition; // 0x50
	[SerializeField] // RVA: 0x17D940 Offset: 0x17DA41 VA: 0x17D940
	private Cubemap _backgroundCubemap; // 0x58
	[SerializeField] // RVA: 0x17D950 Offset: 0x17DA51 VA: 0x17D950
	[RangeAttribute] // RVA: 0x17D950 Offset: 0x17DA51 VA: 0x17D950
	private float _starFadeBegin; // 0x60
	[SerializeField] // RVA: 0x17D990 Offset: 0x17DA91 VA: 0x17D990
	[RangeAttribute] // RVA: 0x17D990 Offset: 0x17DA91 VA: 0x17D990
	private float _starFadeLength; // 0x64
	[SerializeField] // RVA: 0x17D9D0 Offset: 0x17DAD1 VA: 0x17D9D0
	[RangeAttribute] // RVA: 0x17D9D0 Offset: 0x17DAD1 VA: 0x17D9D0
	private float _horizonDistanceScale; // 0x68
	[SerializeField] // RVA: 0x17DA10 Offset: 0x17DB11 VA: 0x17DA10
	private Texture _starBasicCubemap; // 0x70
	[SerializeField] // RVA: 0x17DA20 Offset: 0x17DB21 VA: 0x17DA20
	private float _starBasicTwinkleSpeed; // 0x78
	[SerializeField] // RVA: 0x17DA30 Offset: 0x17DB31 VA: 0x17DA30
	private float _starBasicTwinkleAmount; // 0x7C
	[SerializeField] // RVA: 0x17DA40 Offset: 0x17DB41 VA: 0x17DA40
	private float _starBasicOpacity; // 0x80
	[SerializeField] // RVA: 0x17DA50 Offset: 0x17DB51 VA: 0x17DA50
	private Color _starBasicTintColor; // 0x84
	[SerializeField] // RVA: 0x17DA60 Offset: 0x17DB61 VA: 0x17DA60
	private float _starBasicExponent; // 0x94
	[SerializeField] // RVA: 0x17DA70 Offset: 0x17DB71 VA: 0x17DA70
	private float _starBasicIntensity; // 0x98
	[SerializeField] // RVA: 0x17DA80 Offset: 0x17DB81 VA: 0x17DA80
	private Texture _starLayer1Texture; // 0xA0
	[SerializeField] // RVA: 0x17DA90 Offset: 0x17DB91 VA: 0x17DA90
	private Texture2D _starLayer1DataTexture; // 0xA8
	[SerializeField] // RVA: 0x17DAA0 Offset: 0x17DBA1 VA: 0x17DAA0
	private Color _starLayer1Color; // 0xB0
	[SerializeField] // RVA: 0x17DAB0 Offset: 0x17DBB1 VA: 0x17DAB0
	[RangeAttribute] // RVA: 0x17DAB0 Offset: 0x17DBB1 VA: 0x17DAB0
	private float _starLayer1MaxRadius; // 0xC0
	[SerializeField] // RVA: 0x17DB00 Offset: 0x17DC01 VA: 0x17DB00
	[RangeAttribute] // RVA: 0x17DB00 Offset: 0x17DC01 VA: 0x17DB00
	private float _starLayer1TwinkleAmount; // 0xC4
	[SerializeField] // RVA: 0x17DB40 Offset: 0x17DC41 VA: 0x17DB40
	[RangeAttribute] // RVA: 0x17DB40 Offset: 0x17DC41 VA: 0x17DB40
	private float _starLayer1TwinkleSpeed; // 0xC8
	[SerializeField] // RVA: 0x17DB80 Offset: 0x17DC81 VA: 0x17DB80
	[RangeAttribute] // RVA: 0x17DB80 Offset: 0x17DC81 VA: 0x17DB80
	private float _starLayer1RotationSpeed; // 0xCC
	[SerializeField] // RVA: 0x17DBC0 Offset: 0x17DCC1 VA: 0x17DBC0
	[RangeAttribute] // RVA: 0x17DBC0 Offset: 0x17DCC1 VA: 0x17DBC0
	private float _starLayer1EdgeFeathering; // 0xD0
	[SerializeField] // RVA: 0x17DC10 Offset: 0x17DD11 VA: 0x17DC10
	[RangeAttribute] // RVA: 0x17DC10 Offset: 0x17DD11 VA: 0x17DC10
	private float _starLayer1BloomFilterBoost; // 0xD4
	[SerializeField] // RVA: 0x17DC50 Offset: 0x17DD51 VA: 0x17DC50
	private Vector4 _starLayer1SpriteDimensions; // 0xD8
	[SerializeField] // RVA: 0x17DC60 Offset: 0x17DD61 VA: 0x17DC60
	private int _starLayer1SpriteItemCount; // 0xE8
	[SerializeField] // RVA: 0x17DC70 Offset: 0x17DD71 VA: 0x17DC70
	[RangeAttribute] // RVA: 0x17DC70 Offset: 0x17DD71 VA: 0x17DC70
	private float _starLayer1SpriteAnimationSpeed; // 0xEC
	[SerializeField] // RVA: 0x17DCB0 Offset: 0x17DDB1 VA: 0x17DCB0
	private Texture _starLayer2Texture; // 0xF0
	[SerializeField] // RVA: 0x17DCC0 Offset: 0x17DDC1 VA: 0x17DCC0
	private Texture2D _starLayer2DataTexture; // 0xF8
	[SerializeField] // RVA: 0x17DCD0 Offset: 0x17DDD1 VA: 0x17DCD0
	private Color _starLayer2Color; // 0x100
	[SerializeField] // RVA: 0x17DCE0 Offset: 0x17DDE1 VA: 0x17DCE0
	[RangeAttribute] // RVA: 0x17DCE0 Offset: 0x17DDE1 VA: 0x17DCE0
	private float _starLayer2MaxRadius; // 0x110
	[SerializeField] // RVA: 0x17DD30 Offset: 0x17DE31 VA: 0x17DD30
	[RangeAttribute] // RVA: 0x17DD30 Offset: 0x17DE31 VA: 0x17DD30
	private float _starLayer2TwinkleAmount; // 0x114
	[SerializeField] // RVA: 0x17DD70 Offset: 0x17DE71 VA: 0x17DD70
	[RangeAttribute] // RVA: 0x17DD70 Offset: 0x17DE71 VA: 0x17DD70
	private float _starLayer2TwinkleSpeed; // 0x118
	[SerializeField] // RVA: 0x17DDB0 Offset: 0x17DEB1 VA: 0x17DDB0
	[RangeAttribute] // RVA: 0x17DDB0 Offset: 0x17DEB1 VA: 0x17DDB0
	private float _starLayer2RotationSpeed; // 0x11C
	[SerializeField] // RVA: 0x17DDF0 Offset: 0x17DEF1 VA: 0x17DDF0
	[RangeAttribute] // RVA: 0x17DDF0 Offset: 0x17DEF1 VA: 0x17DDF0
	private float _starLayer2EdgeFeathering; // 0x120
	[SerializeField] // RVA: 0x17DE40 Offset: 0x17DF41 VA: 0x17DE40
	[RangeAttribute] // RVA: 0x17DE40 Offset: 0x17DF41 VA: 0x17DE40
	private float _starLayer2BloomFilterBoost; // 0x124
	[SerializeField] // RVA: 0x17DE80 Offset: 0x17DF81 VA: 0x17DE80
	private Vector4 _starLayer2SpriteDimensions; // 0x128
	[SerializeField] // RVA: 0x17DE90 Offset: 0x17DF91 VA: 0x17DE90
	private int _starLayer2SpriteItemCount; // 0x138
	[SerializeField] // RVA: 0x17DEA0 Offset: 0x17DFA1 VA: 0x17DEA0
	[RangeAttribute] // RVA: 0x17DEA0 Offset: 0x17DFA1 VA: 0x17DEA0
	private float _starLayer2SpriteAnimationSpeed; // 0x13C
	[SerializeField] // RVA: 0x17DEE0 Offset: 0x17DFE1 VA: 0x17DEE0
	private Texture _starLayer3Texture; // 0x140
	[SerializeField] // RVA: 0x17DEF0 Offset: 0x17DFF1 VA: 0x17DEF0
	private Texture2D _starLayer3DataTexture; // 0x148
	[SerializeField] // RVA: 0x17DF00 Offset: 0x17E001 VA: 0x17DF00
	private Color _starLayer3Color; // 0x150
	[SerializeField] // RVA: 0x17DF10 Offset: 0x17E011 VA: 0x17DF10
	[RangeAttribute] // RVA: 0x17DF10 Offset: 0x17E011 VA: 0x17DF10
	private float _starLayer3MaxRadius; // 0x160
	[SerializeField] // RVA: 0x17DF60 Offset: 0x17E061 VA: 0x17DF60
	[RangeAttribute] // RVA: 0x17DF60 Offset: 0x17E061 VA: 0x17DF60
	private float _starLayer3TwinkleAmount; // 0x164
	[SerializeField] // RVA: 0x17DFA0 Offset: 0x17E0A1 VA: 0x17DFA0
	[RangeAttribute] // RVA: 0x17DFA0 Offset: 0x17E0A1 VA: 0x17DFA0
	private float _starLayer3TwinkleSpeed; // 0x168
	[SerializeField] // RVA: 0x17DFE0 Offset: 0x17E0E1 VA: 0x17DFE0
	[RangeAttribute] // RVA: 0x17DFE0 Offset: 0x17E0E1 VA: 0x17DFE0
	private float _starLayer3RotationSpeed; // 0x16C
	[SerializeField] // RVA: 0x17E020 Offset: 0x17E121 VA: 0x17E020
	[RangeAttribute] // RVA: 0x17E020 Offset: 0x17E121 VA: 0x17E020
	private float _starLayer3EdgeFeathering; // 0x170
	[SerializeField] // RVA: 0x17E070 Offset: 0x17E171 VA: 0x17E070
	[RangeAttribute] // RVA: 0x17E070 Offset: 0x17E171 VA: 0x17E070
	private float _starLayer3BloomFilterBoost; // 0x174
	[SerializeField] // RVA: 0x17E0B0 Offset: 0x17E1B1 VA: 0x17E0B0
	private Vector4 _starLayer3SpriteDimensions; // 0x178
	[SerializeField] // RVA: 0x17E0C0 Offset: 0x17E1C1 VA: 0x17E0C0
	private int _starLayer3SpriteItemCount; // 0x188
	[SerializeField] // RVA: 0x17E0D0 Offset: 0x17E1D1 VA: 0x17E0D0
	[RangeAttribute] // RVA: 0x17E0D0 Offset: 0x17E1D1 VA: 0x17E0D0
	private float _starLayer3SpriteAnimationSpeed; // 0x18C
	[SerializeField] // RVA: 0x17E110 Offset: 0x17E211 VA: 0x17E110
	private Texture _moonTexture; // 0x190
	[SerializeField] // RVA: 0x17E120 Offset: 0x17E221 VA: 0x17E120
	private float _moonRotationSpeed; // 0x198
	[SerializeField] // RVA: 0x17E130 Offset: 0x17E231 VA: 0x17E130
	private Color _moonColor; // 0x19C
	[SerializeField] // RVA: 0x17E140 Offset: 0x17E241 VA: 0x17E140
	private Vector3 _moonDirection; // 0x1AC
	[SerializeField] // RVA: 0x17E150 Offset: 0x17E251 VA: 0x17E150
	private Matrix4x4 _moonWorldToLocalMatrix; // 0x1B8
	[SerializeField] // RVA: 0x17E160 Offset: 0x17E261 VA: 0x17E160
	[RangeAttribute] // RVA: 0x17E160 Offset: 0x17E261 VA: 0x17E160
	private float _moonSize; // 0x1F8
	[SerializeField] // RVA: 0x17E1A0 Offset: 0x17E2A1 VA: 0x17E1A0
	[RangeAttribute] // RVA: 0x17E1A0 Offset: 0x17E2A1 VA: 0x17E1A0
	private float _moonEdgeFeathering; // 0x1FC
	[SerializeField] // RVA: 0x17E1F0 Offset: 0x17E2F1 VA: 0x17E1F0
	[RangeAttribute] // RVA: 0x17E1F0 Offset: 0x17E2F1 VA: 0x17E1F0
	private float _moonBloomFilterBoost; // 0x200
	[SerializeField] // RVA: 0x17E230 Offset: 0x17E331 VA: 0x17E230
	private Vector4 _moonSpriteDimensions; // 0x204
	[SerializeField] // RVA: 0x17E240 Offset: 0x17E341 VA: 0x17E240
	private int _moonSpriteItemCount; // 0x214
	[SerializeField] // RVA: 0x17E250 Offset: 0x17E351 VA: 0x17E250
	[RangeAttribute] // RVA: 0x17E250 Offset: 0x17E351 VA: 0x17E250
	private float _moonSpriteAnimationSpeed; // 0x218
	[SerializeField] // RVA: 0x17E290 Offset: 0x17E391 VA: 0x17E290
	private Texture _sunTexture; // 0x220
	[SerializeField] // RVA: 0x17E2A0 Offset: 0x17E3A1 VA: 0x17E2A0
	private Color _sunColor; // 0x228
	[SerializeField] // RVA: 0x17E2B0 Offset: 0x17E3B1 VA: 0x17E2B0
	private float _sunRotationSpeed; // 0x238
	[SerializeField] // RVA: 0x17E2C0 Offset: 0x17E3C1 VA: 0x17E2C0
	private Vector3 _sunDirection; // 0x23C
	[SerializeField] // RVA: 0x17E2D0 Offset: 0x17E3D1 VA: 0x17E2D0
	private Matrix4x4 _sunWorldToLocalMatrix; // 0x248
	[SerializeField] // RVA: 0x17E2E0 Offset: 0x17E3E1 VA: 0x17E2E0
	[RangeAttribute] // RVA: 0x17E2E0 Offset: 0x17E3E1 VA: 0x17E2E0
	private float _sunSize; // 0x288
	[SerializeField] // RVA: 0x17E320 Offset: 0x17E421 VA: 0x17E320
	[RangeAttribute] // RVA: 0x17E320 Offset: 0x17E421 VA: 0x17E320
	private float _sunEdgeFeathering; // 0x28C
	[SerializeField] // RVA: 0x17E370 Offset: 0x17E471 VA: 0x17E370
	[RangeAttribute] // RVA: 0x17E370 Offset: 0x17E471 VA: 0x17E370
	private float _sunBloomFilterBoost; // 0x290
	[SerializeField] // RVA: 0x17E3B0 Offset: 0x17E4B1 VA: 0x17E3B0
	private Vector4 _sunSpriteDimensions; // 0x294
	[SerializeField] // RVA: 0x17E3C0 Offset: 0x17E4C1 VA: 0x17E3C0
	private int _sunSpriteItemCount; // 0x2A4
	[SerializeField] // RVA: 0x17E3D0 Offset: 0x17E4D1 VA: 0x17E3D0
	[RangeAttribute] // RVA: 0x17E3D0 Offset: 0x17E4D1 VA: 0x17E3D0
	private float _sunSpriteAnimationSpeed; // 0x2A8
	[SerializeField] // RVA: 0x17E410 Offset: 0x17E511 VA: 0x17E410
	[RangeAttribute] // RVA: 0x17E410 Offset: 0x17E511 VA: 0x17E410
	private float _cloudBegin; // 0x2AC
	private float _cloudTextureTiling; // 0x2B0
	private float _cloud2TextureTiling; // 0x2B4
	[SerializeField] // RVA: 0x17E450 Offset: 0x17E551 VA: 0x17E450
	private Color _cloudColor; // 0x2B8
	[SerializeField] // RVA: 0x17E460 Offset: 0x17E561 VA: 0x17E460
	private Texture _cloudTexture; // 0x2C8
	[SerializeField] // RVA: 0x17E470 Offset: 0x17E571 VA: 0x17E470
	private Texture _cloud2Texture; // 0x2D0
	[SerializeField] // RVA: 0x17E480 Offset: 0x17E581 VA: 0x17E480
	private Texture _artCloudCustomTexture; // 0x2D8
	[SerializeField] // RVA: 0x17E490 Offset: 0x17E591 VA: 0x17E490
	private float _cloudDensity; // 0x2E0
	[SerializeField] // RVA: 0x17E4A0 Offset: 0x17E5A1 VA: 0x17E4A0
	private float _cloud2Density; // 0x2E4
	[SerializeField] // RVA: 0x17E4B0 Offset: 0x17E5B1 VA: 0x17E4B0
	private float _cloudSpeed; // 0x2E8
	[SerializeField] // RVA: 0x17E4C0 Offset: 0x17E5C1 VA: 0x17E4C0
	private float _cloud2Speed; // 0x2EC
	[SerializeField] // RVA: 0x17E4D0 Offset: 0x17E5D1 VA: 0x17E4D0
	private float _cloudDirection; // 0x2F0
	[SerializeField] // RVA: 0x17E4E0 Offset: 0x17E5E1 VA: 0x17E4E0
	private float _cloud2Direction; // 0x2F4
	[SerializeField] // RVA: 0x17E4F0 Offset: 0x17E5F1 VA: 0x17E4F0
	private float _cloudHeight; // 0x2F8
	[SerializeField] // RVA: 0x17E500 Offset: 0x17E601 VA: 0x17E500
	private float _cloud2Height; // 0x2FC
	[SerializeField] // RVA: 0x17E510 Offset: 0x17E611 VA: 0x17E510
	private Color _cloudColor1; // 0x300
	[SerializeField] // RVA: 0x17E520 Offset: 0x17E621 VA: 0x17E520
	private Color _cloud2Color1; // 0x310
	[SerializeField] // RVA: 0x17E530 Offset: 0x17E631 VA: 0x17E530
	private Color _cloudColor2; // 0x320
	[SerializeField] // RVA: 0x17E540 Offset: 0x17E641 VA: 0x17E540
	private Color _cloud2Color2; // 0x330
	[SerializeField] // RVA: 0x17E550 Offset: 0x17E651 VA: 0x17E550
	private float _cloudFadePosition; // 0x340
	[SerializeField] // RVA: 0x17E560 Offset: 0x17E661 VA: 0x17E560
	private float _cloud2FadePosition; // 0x344
	[SerializeField] // RVA: 0x17E570 Offset: 0x17E671 VA: 0x17E570
	private float _cloudFadeAmount; // 0x348
	[SerializeField] // RVA: 0x17E580 Offset: 0x17E681 VA: 0x17E580
	private float _cloud2FadeAmount; // 0x34C
	[SerializeField] // RVA: 0x17E590 Offset: 0x17E691 VA: 0x17E590
	private Texture _cloudCubemap; // 0x350
	[SerializeField] // RVA: 0x17E5A0 Offset: 0x17E6A1 VA: 0x17E5A0
	private float _cloudCubemapRotationSpeed; // 0x358
	[SerializeField] // RVA: 0x17E5B0 Offset: 0x17E6B1 VA: 0x17E5B0
	private Texture _cloudCubemapDoubleLayerCustomTexture; // 0x360
	[SerializeField] // RVA: 0x17E5C0 Offset: 0x17E6C1 VA: 0x17E5C0
	private float _cloudCubemapDoubleLayerRotationSpeed; // 0x368
	[SerializeField] // RVA: 0x17E5D0 Offset: 0x17E6D1 VA: 0x17E5D0
	private float _cloudCubemapDoubleLayerHeight; // 0x36C
	[SerializeField] // RVA: 0x17E5E0 Offset: 0x17E6E1 VA: 0x17E5E0
	private Color _cloudCubemapDoubleLayerTintColor; // 0x370
	[SerializeField] // RVA: 0x17E5F0 Offset: 0x17E6F1 VA: 0x17E5F0
	private Color _cloudCubemapTintColor; // 0x380
	[SerializeField] // RVA: 0x17E600 Offset: 0x17E701 VA: 0x17E600
	private float _cloudCubemapHeight; // 0x390
	[SerializeField] // RVA: 0x17E610 Offset: 0x17E711 VA: 0x17E610
	private Texture _cloudCubemapNormalTexture; // 0x398
	[SerializeField] // RVA: 0x17E620 Offset: 0x17E721 VA: 0x17E620
	private Color _cloudCubemapNormalLitColor; // 0x3A0
	[SerializeField] // RVA: 0x17E630 Offset: 0x17E731 VA: 0x17E630
	private Color _cloudCubemapNormalShadowColor; // 0x3B0
	[SerializeField] // RVA: 0x17E640 Offset: 0x17E741 VA: 0x17E640
	private float _cloudCubemapNormalRotationSpeed; // 0x3C0
	[SerializeField] // RVA: 0x17E650 Offset: 0x17E751 VA: 0x17E650
	private float _cloudCubemapNormalHeight; // 0x3C4
	[SerializeField] // RVA: 0x17E660 Offset: 0x17E761 VA: 0x17E660
	private float _cloudCubemapNormalAmbientItensity; // 0x3C8
	[SerializeField] // RVA: 0x17E670 Offset: 0x17E771 VA: 0x17E670
	private Texture _cloudCubemapNormalDoubleLayerCustomTexture; // 0x3D0
	[SerializeField] // RVA: 0x17E680 Offset: 0x17E781 VA: 0x17E680
	private float _cloudCubemapNormalDoubleLayerRotationSpeed; // 0x3D8
	[SerializeField] // RVA: 0x17E690 Offset: 0x17E791 VA: 0x17E690
	private float _cloudCubemapNormalDoubleLayerHeight; // 0x3DC
	[SerializeField] // RVA: 0x17E6A0 Offset: 0x17E7A1 VA: 0x17E6A0
	private Color _cloudCubemapNormalDoubleLayerLitColor; // 0x3E0
	[SerializeField] // RVA: 0x17E6B0 Offset: 0x17E7B1 VA: 0x17E6B0
	private Color _cloudCubemapNormalDoubleLayerShadowColor; // 0x3F0
	[SerializeField] // RVA: 0x17E6C0 Offset: 0x17E7C1 VA: 0x17E6C0
	private Vector3 _cloudCubemapNormalLightDirection; // 0x400
	[SerializeField] // RVA: 0x17E6D0 Offset: 0x17E7D1 VA: 0x17E6D0
	private Color _fogColor; // 0x40C
	[SerializeField] // RVA: 0x17E6E0 Offset: 0x17E7E1 VA: 0x17E6E0
	private float _fogDensity; // 0x41C
	[SerializeField] // RVA: 0x17E6F0 Offset: 0x17E7F1 VA: 0x17E6F0
	private float _fogHeight; // 0x420
	private int _GradientSkyUpperColorId; // 0x424
	private int _GradientSkyMiddleColorId; // 0x428
	private int _GradientSkyLowerColorId; // 0x42C
	private int _GradientFadeMiddlePositionId; // 0x430
	private int _MainTexId; // 0x434
	private int _HorizonScaleFactorId; // 0x438
	private int _StarBasicCubemapId; // 0x43C
	private int _StarBasicTwinkleSpeedId; // 0x440
	private int _StarBasicTwinkleAmountId; // 0x444
	private int _StarBasicOpacityId; // 0x448
	private int _StarBasicTintColorId; // 0x44C
	private int _StarBasicExponentId; // 0x450
	private int _StarBasicHDRBoostId; // 0x454
	private int _StarLayer1TexId; // 0x458
	private int _StarLayer1DataTexId; // 0x45C
	private int _StarLayer1ColorId; // 0x460
	private int _StarLayer1MaxRadiusId; // 0x464
	private int _StarLayer1TwinkleAmountId; // 0x468
	private int _StarLayer1TwinkleSpeedId; // 0x46C
	private int _StarLayer1RotationSpeedId; // 0x470
	private int _StarLayer1EdgeFadeId; // 0x474
	private int _StarLayer1HDRBoostId; // 0x478
	private int _StarLayer1SpriteDimensionsId; // 0x47C
	private int _StarLayer1SpriteItemCountId; // 0x480
	private int _StarLayer1SpriteAnimationSpeedId; // 0x484
	private int _StarLayer2TexId; // 0x488
	private int _StarLayer2DataTexId; // 0x48C
	private int _StarLayer2ColorId; // 0x490
	private int _StarLayer2MaxRadiusId; // 0x494
	private int _StarLayer2TwinkleAmountId; // 0x498
	private int _StarLayer2TwinkleSpeedId; // 0x49C
	private int _StarLayer2RotationSpeedId; // 0x4A0
	private int _StarLayer2EdgeFadeId; // 0x4A4
	private int _StarLayer2HDRBoostId; // 0x4A8
	private int _StarLayer2SpriteDimensionsId; // 0x4AC
	private int _StarLayer2SpriteItemCountId; // 0x4B0
	private int _StarLayer2SpriteAnimationSpeedId; // 0x4B4
	private int _StarLayer3TexId; // 0x4B8
	private int _StarLayer3DataTexId; // 0x4BC
	private int _StarLayer3ColorId; // 0x4C0
	private int _StarLayer3MaxRadiusId; // 0x4C4
	private int _StarLayer3TwinkleAmountId; // 0x4C8
	private int _StarLayer3TwinkleSpeedId; // 0x4CC
	private int _StarLayer3RotationSpeedId; // 0x4D0
	private int _StarLayer3EdgeFadeId; // 0x4D4
	private int _StarLayer3HDRBoostId; // 0x4D8
	private int _StarLayer3SpriteDimensionsId; // 0x4DC
	private int _StarLayer3SpriteItemCountId; // 0x4E0
	private int _StarLayer3SpriteAnimationSpeedId; // 0x4E4
	private int _MoonTexId; // 0x4E8
	private int _MoonRotationSpeedId; // 0x4EC
	private int _MoonColorId; // 0x4F0
	private int _MoonPositionId; // 0x4F4
	private int _MoonWorldToLocalMatId; // 0x4F8
	private int _MoonRadiusId; // 0x4FC
	private int _MoonEdgeFadeId; // 0x500
	private int _MoonHDRBoostId; // 0x504
	private int _MoonSpriteDimensionsId; // 0x508
	private int _MoonSpriteItemCountId; // 0x50C
	private int _MoonSpriteAnimationSpeedId; // 0x510
	private int _SunTexId; // 0x514
	private int _SunColorId; // 0x518
	private int _SunRotationSpeedId; // 0x51C
	private int _SunPositionId; // 0x520
	private int _SunWorldToLocalMatId; // 0x524
	private int _SunRadiusId; // 0x528
	private int _SunEdgeFadeId; // 0x52C
	private int _SunHDRBoostId; // 0x530
	private int _SunSpriteDimensionsId; // 0x534
	private int _SunSpriteItemCountId; // 0x538
	private int _SunSpriteAnimationSpeedId; // 0x53C
	private int _CloudBeginId; // 0x540
	private int _CloudTextureTilingId; // 0x544
	private int _Cloud2TextureTilingId; // 0x548
	private int _CloudColorId; // 0x54C
	private int _CloudNoiseTextureId; // 0x550
	private int _Cloud2NoiseTextureId; // 0x554
	private int _ArtCloudCustomTextureId; // 0x558
	private int _CloudDensityId; // 0x55C
	private int _Cloud2DensityId; // 0x560
	private int _CloudSpeedId; // 0x564
	private int _Cloud2SpeedId; // 0x568
	private int _CloudDirectionId; // 0x56C
	private int _Cloud2DirectionId; // 0x570
	private int _CloudHeightId; // 0x574
	private int _Cloud2HeightId; // 0x578
	private int _CloudColor1Id; // 0x57C
	private int _Cloud2Color1Id; // 0x580
	private int _CloudColor2Id; // 0x584
	private int _Cloud2Color2Id; // 0x588
	private int _CloudFadePositionId; // 0x58C
	private int _Cloud2FadePositionId; // 0x590
	private int _CloudFadeAmountId; // 0x594
	private int _Cloud2FadeAmountId; // 0x598
	private int _CloudCubemapTextureId; // 0x59C
	private int _CloudCubemapRotationSpeedId; // 0x5A0
	private int _CloudCubemapDoubleTextureId; // 0x5A4
	private int _CloudCubemapDoubleLayerRotationSpeedId; // 0x5A8
	private int _CloudCubemapDoubleLayerHeightId; // 0x5AC
	private int _CloudCubemapDoubleLayerTintColorId; // 0x5B0
	private int _CloudCubemapTintColorId; // 0x5B4
	private int _CloudCubemapHeightId; // 0x5B8
	private int _CloudCubemapNormalTextureId; // 0x5BC
	private int _CloudCubemapNormalLitColorId; // 0x5C0
	private int _CloudCubemapNormalShadowColorId; // 0x5C4
	private int _CloudCubemapNormalRotationSpeedId; // 0x5C8
	private int _CloudCubemapNormalHeightId; // 0x5CC
	private int _CloudCubemapNormalAmbientIntensityId; // 0x5D0
	private int _CloudCubemapNormalDoubleTextureId; // 0x5D4
	private int _CloudCubemapNormalDoubleLayerRotationSpeedId; // 0x5D8
	private int _CloudCubemapNormalDoubleLayerHeightId; // 0x5DC
	private int _CloudCubemapNormalDoubleLitColorId; // 0x5E0
	private int _CloudCubemapNormalDoubleShadowColorId; // 0x5E4
	private int _CloudCubemapNormalToLightId; // 0x5E8
	private int _HorizonFogColorId; // 0x5EC
	private int _HorizonFogDensityId; // 0x5F0
	private int _HorizonFogLengthId; // 0x5F4
	private int _GradientFadeBeginId; // 0x5F8
	private int _GradientFadeEndId; // 0x5FC
	private int _StarFadeBeginId; // 0x600
	private int _StarFadeEndId; // 0x604

	// Properties
	public Material SkyboxMaterial { get; set; }
	public Color SkyColor { get; set; }
	public Color SkyMiddleColor { get; set; }
	public Color HorizonColor { get; set; }
	public float GradientFadeBegin { get; set; }
	public float GradientFadeLength { get; set; }
	public float SkyMiddlePosition { get; set; }
	public Cubemap BackgroundCubemap { get; set; }
	public float StarFadeBegin { get; set; }
	public float StarFadeLength { get; set; }
	public float HorizonDistanceScale { get; set; }
	public Texture StarBasicCubemap { get; set; }
	public float StarBasicTwinkleSpeed { get; set; }
	public float StarBasicTwinkleAmount { get; set; }
	public float StarBasicOpacity { get; set; }
	public Color StarBasicTintColor { get; set; }
	public float StarBasicExponent { get; set; }
	public float StarBasicIntensity { get; set; }
	public Texture StarLayer1Texture { get; set; }
	public Texture2D StarLayer1DataTexture { get; set; }
	public Color StarLayer1Color { get; set; }
	public float StarLayer1MaxRadius { get; set; }
	public float StarLayer1TwinkleAmount { get; set; }
	public float StarLayer1TwinkleSpeed { get; set; }
	public float StarLayer1RotationSpeed { get; set; }
	public float StarLayer1EdgeFeathering { get; set; }
	public float StarLayer1BloomFilterBoost { get; set; }
	public int StarLayer1SpriteItemCount { get; set; }
	public float StarLayer1SpriteAnimationSpeed { get; set; }
	public Texture StarLayer2Texture { get; set; }
	public Texture2D StarLayer2DataTexture { get; set; }
	public Color StarLayer2Color { get; set; }
	public float StarLayer2MaxRadius { get; set; }
	public float StarLayer2TwinkleAmount { get; set; }
	public float StarLayer2TwinkleSpeed { get; set; }
	public float StarLayer2RotationSpeed { get; set; }
	public float StarLayer2EdgeFeathering { get; set; }
	public float StarLayer2BloomFilterBoost { get; set; }
	public int StarLayer2SpriteItemCount { get; set; }
	public float StarLayer2SpriteAnimationSpeed { get; set; }
	public Texture StarLayer3Texture { get; set; }
	public Texture2D StarLayer3DataTexture { get; set; }
	public Color StarLayer3Color { get; set; }
	public float StarLayer3MaxRadius { get; set; }
	public float StarLayer3TwinkleAmount { get; set; }
	public float StarLayer3TwinkleSpeed { get; set; }
	public float StarLayer3RotationSpeed { get; set; }
	public float StarLayer3EdgeFeathering { get; set; }
	public float StarLayer3BloomFilterBoost { get; set; }
	public int StarLayer3SpriteItemCount { get; set; }
	public float StarLayer3SpriteAnimationSpeed { get; set; }
	public Texture MoonTexture { get; set; }
	public float MoonRotationSpeed { get; set; }
	public Color MoonColor { get; set; }
	public Vector3 MoonDirection { get; set; }
	public Matrix4x4 MoonWorldToLocalMatrix { get; set; }
	public float MoonSize { get; set; }
	public float MoonEdgeFeathering { get; set; }
	public float MoonBloomFilterBoost { get; set; }
	public int MoonSpriteItemCount { get; set; }
	public float MoonSpriteAnimationSpeed { get; set; }
	public Texture SunTexture { get; set; }
	public Color SunColor { get; set; }
	public float SunRotationSpeed { get; set; }
	public Vector3 SunDirection { get; set; }
	public Matrix4x4 SunWorldToLocalMatrix { get; set; }
	public float SunSize { get; set; }
	public float SunEdgeFeathering { get; set; }
	public float SunBloomFilterBoost { get; set; }
	public int SunSpriteItemCount { get; set; }
	public float SunSpriteAnimationSpeed { get; set; }
	public float CloudBegin { get; set; }
	public float CloudTextureTiling { get; set; }
	public float Cloud2TextureTiling { get; set; }
	public Color CloudColor { get; set; }
	public Texture CloudTexture { get; set; }
	public Texture Cloud2Texture { get; set; }
	public Texture ArtCloudCustomTexture { get; set; }
	public float CloudDensity { get; set; }
	public float Cloud2Density { get; set; }
	public float CloudSpeed { get; set; }
	public float Cloud2Speed { get; set; }
	public float CloudDirection { get; set; }
	public float Cloud2Direction { get; set; }
	public float CloudHeight { get; set; }
	public float Cloud2Height { get; set; }
	public Color CloudColor1 { get; set; }
	public Color Cloud2Color1 { get; set; }
	public Color CloudColor2 { get; set; }
	public Color Cloud2Color2 { get; set; }
	public float CloudFadePosition { get; set; }
	public float Cloud2FadePosition { get; set; }
	public float CloudFadeAmount { get; set; }
	public float Cloud2FadeAmount { get; set; }
	public Texture CloudCubemap { get; set; }
	public float CloudCubemapRotationSpeed { get; set; }
	public Texture CloudCubemapDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapDoubleLayerHeight { get; set; }
	public Color CloudCubemapDoubleLayerTintColor { get; set; }
	public Color CloudCubemapTintColor { get; set; }
	public float CloudCubemapHeight { get; set; }
	public Texture CloudCubemapNormalTexture { get; set; }
	public Color CloudCubemapNormalLitColor { get; set; }
	public Color CloudCubemapNormalShadowColor { get; set; }
	public float CloudCubemapNormalRotationSpeed { get; set; }
	public float CloudCubemapNormalHeight { get; set; }
	public float CloudCubemapNormalAmbientIntensity { get; set; }
	public Texture CloudCubemapNormalDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapNormalDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapNormalDoubleLayerHeight { get; set; }
	public Color CloudCubemapNormalDoubleLayerLitColor { get; set; }
	public Color CloudCubemapNormalDoubleLayerShadowColor { get; set; }
	public Vector3 CloudCubemapNormalLightDirection { get; set; }
	public Color FogColor { get; set; }
	public float FogDensity { get; set; }
	public float FogHeight { get; set; }

	// Methods

	// RVA: 0x22B8820 Offset: 0x22B8921 VA: 0x22B8820
	public Material get_SkyboxMaterial() { }

	// RVA: 0x22B8830 Offset: 0x22B8931 VA: 0x22B8830
	public void set_SkyboxMaterial(Material value) { }

	// RVA: 0x22B8860 Offset: 0x22B8961 VA: 0x22B8860
	public Color get_SkyColor() { }

	// RVA: 0x22B8870 Offset: 0x22B8971 VA: 0x22B8870
	public void set_SkyColor(Color value) { }

	// RVA: 0x22B88B0 Offset: 0x22B89B1 VA: 0x22B88B0
	public Color get_SkyMiddleColor() { }

	// RVA: 0x22B88C0 Offset: 0x22B89C1 VA: 0x22B88C0
	public void set_SkyMiddleColor(Color value) { }

	// RVA: 0x22B8900 Offset: 0x22B8A01 VA: 0x22B8900
	public Color get_HorizonColor() { }

	// RVA: 0x22B8910 Offset: 0x22B8A11 VA: 0x22B8910
	public void set_HorizonColor(Color value) { }

	// RVA: 0x22B8950 Offset: 0x22B8A51 VA: 0x22B8950
	public float get_GradientFadeBegin() { }

	// RVA: 0x22B8960 Offset: 0x22B8A61 VA: 0x22B8960
	public void set_GradientFadeBegin(float value) { }

	// RVA: 0x22B8A30 Offset: 0x22B8B31 VA: 0x22B8A30
	public float get_GradientFadeLength() { }

	// RVA: 0x22B8A40 Offset: 0x22B8B41 VA: 0x22B8A40
	public void set_GradientFadeLength(float value) { }

	// RVA: 0x22B8A50 Offset: 0x22B8B51 VA: 0x22B8A50
	public float get_SkyMiddlePosition() { }

	// RVA: 0x22B8A60 Offset: 0x22B8B61 VA: 0x22B8A60
	public void set_SkyMiddlePosition(float value) { }

	// RVA: 0x22B8A90 Offset: 0x22B8B91 VA: 0x22B8A90
	public Cubemap get_BackgroundCubemap() { }

	// RVA: 0x22B8AA0 Offset: 0x22B8BA1 VA: 0x22B8AA0
	public void set_BackgroundCubemap(Cubemap value) { }

	// RVA: 0x22B8AF0 Offset: 0x22B8BF1 VA: 0x22B8AF0
	public float get_StarFadeBegin() { }

	// RVA: 0x22B8B00 Offset: 0x22B8C01 VA: 0x22B8B00
	public void set_StarFadeBegin(float value) { }

	// RVA: 0x22B8BD0 Offset: 0x22B8CD1 VA: 0x22B8BD0
	public float get_StarFadeLength() { }

	// RVA: 0x22B8BE0 Offset: 0x22B8CE1 VA: 0x22B8BE0
	public void set_StarFadeLength(float value) { }

	// RVA: 0x22B8BF0 Offset: 0x22B8CF1 VA: 0x22B8BF0
	public float get_HorizonDistanceScale() { }

	// RVA: 0x22B8C00 Offset: 0x22B8D01 VA: 0x22B8C00
	public void set_HorizonDistanceScale(float value) { }

	// RVA: 0x22B8C30 Offset: 0x22B8D31 VA: 0x22B8C30
	public Texture get_StarBasicCubemap() { }

	// RVA: 0x22B8C40 Offset: 0x22B8D41 VA: 0x22B8C40
	public void set_StarBasicCubemap(Texture value) { }

	// RVA: 0x22B8C90 Offset: 0x22B8D91 VA: 0x22B8C90
	public float get_StarBasicTwinkleSpeed() { }

	// RVA: 0x22B8CA0 Offset: 0x22B8DA1 VA: 0x22B8CA0
	public void set_StarBasicTwinkleSpeed(float value) { }

	// RVA: 0x22B8CD0 Offset: 0x22B8DD1 VA: 0x22B8CD0
	public float get_StarBasicTwinkleAmount() { }

	// RVA: 0x22B8CE0 Offset: 0x22B8DE1 VA: 0x22B8CE0
	public void set_StarBasicTwinkleAmount(float value) { }

	// RVA: 0x22B8D10 Offset: 0x22B8E11 VA: 0x22B8D10
	public float get_StarBasicOpacity() { }

	// RVA: 0x22B8D20 Offset: 0x22B8E21 VA: 0x22B8D20
	public void set_StarBasicOpacity(float value) { }

	// RVA: 0x22B8D50 Offset: 0x22B8E51 VA: 0x22B8D50
	public Color get_StarBasicTintColor() { }

	// RVA: 0x22B8D60 Offset: 0x22B8E61 VA: 0x22B8D60
	public void set_StarBasicTintColor(Color value) { }

	// RVA: 0x22B8DA0 Offset: 0x22B8EA1 VA: 0x22B8DA0
	public float get_StarBasicExponent() { }

	// RVA: 0x22B8DB0 Offset: 0x22B8EB1 VA: 0x22B8DB0
	public void set_StarBasicExponent(float value) { }

	// RVA: 0x22B8DE0 Offset: 0x22B8EE1 VA: 0x22B8DE0
	public float get_StarBasicIntensity() { }

	// RVA: 0x22B8DF0 Offset: 0x22B8EF1 VA: 0x22B8DF0
	public void set_StarBasicIntensity(float value) { }

	// RVA: 0x22B8E20 Offset: 0x22B8F21 VA: 0x22B8E20
	public Texture get_StarLayer1Texture() { }

	// RVA: 0x22B8E30 Offset: 0x22B8F31 VA: 0x22B8E30
	public void set_StarLayer1Texture(Texture value) { }

	// RVA: 0x22B8E80 Offset: 0x22B8F81 VA: 0x22B8E80
	public Texture2D get_StarLayer1DataTexture() { }

	// RVA: 0x22B8E90 Offset: 0x22B8F91 VA: 0x22B8E90
	public void set_StarLayer1DataTexture(Texture2D value) { }

	// RVA: 0x22B8EE0 Offset: 0x22B8FE1 VA: 0x22B8EE0
	public Color get_StarLayer1Color() { }

	// RVA: 0x22B8EF0 Offset: 0x22B8FF1 VA: 0x22B8EF0
	public void set_StarLayer1Color(Color value) { }

	// RVA: 0x22B8F30 Offset: 0x22B9031 VA: 0x22B8F30
	public float get_StarLayer1MaxRadius() { }

	// RVA: 0x22B8F40 Offset: 0x22B9041 VA: 0x22B8F40
	public void set_StarLayer1MaxRadius(float value) { }

	// RVA: 0x22B8F70 Offset: 0x22B9071 VA: 0x22B8F70
	public float get_StarLayer1TwinkleAmount() { }

	// RVA: 0x22B8F80 Offset: 0x22B9081 VA: 0x22B8F80
	public void set_StarLayer1TwinkleAmount(float value) { }

	// RVA: 0x22B8FB0 Offset: 0x22B90B1 VA: 0x22B8FB0
	public float get_StarLayer1TwinkleSpeed() { }

	// RVA: 0x22B8FC0 Offset: 0x22B90C1 VA: 0x22B8FC0
	public void set_StarLayer1TwinkleSpeed(float value) { }

	// RVA: 0x22B8FF0 Offset: 0x22B90F1 VA: 0x22B8FF0
	public float get_StarLayer1RotationSpeed() { }

	// RVA: 0x22B9000 Offset: 0x22B9101 VA: 0x22B9000
	public void set_StarLayer1RotationSpeed(float value) { }

	// RVA: 0x22B9030 Offset: 0x22B9131 VA: 0x22B9030
	public float get_StarLayer1EdgeFeathering() { }

	// RVA: 0x22B9040 Offset: 0x22B9141 VA: 0x22B9040
	public void set_StarLayer1EdgeFeathering(float value) { }

	// RVA: 0x22B9070 Offset: 0x22B9171 VA: 0x22B9070
	public float get_StarLayer1BloomFilterBoost() { }

	// RVA: 0x22B9080 Offset: 0x22B9181 VA: 0x22B9080
	public void set_StarLayer1BloomFilterBoost(float value) { }

	// RVA: 0x22B90B0 Offset: 0x22B91B1 VA: 0x22B90B0
	public void SetStarLayer1SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B90F0 Offset: 0x22B91F1 VA: 0x22B90F0
	public Vector2 GetStarLayer1SpriteDimensions() { }

	// RVA: 0x22B9120 Offset: 0x22B9221 VA: 0x22B9120
	public int get_StarLayer1SpriteItemCount() { }

	// RVA: 0x22B9130 Offset: 0x22B9231 VA: 0x22B9130
	public void set_StarLayer1SpriteItemCount(int value) { }

	// RVA: 0x22B9160 Offset: 0x22B9261 VA: 0x22B9160
	public float get_StarLayer1SpriteAnimationSpeed() { }

	// RVA: 0x22B9170 Offset: 0x22B9271 VA: 0x22B9170
	public void set_StarLayer1SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B91A0 Offset: 0x22B92A1 VA: 0x22B91A0
	public Texture get_StarLayer2Texture() { }

	// RVA: 0x22B91B0 Offset: 0x22B92B1 VA: 0x22B91B0
	public void set_StarLayer2Texture(Texture value) { }

	// RVA: 0x22B9200 Offset: 0x22B9301 VA: 0x22B9200
	public Texture2D get_StarLayer2DataTexture() { }

	// RVA: 0x22B9210 Offset: 0x22B9311 VA: 0x22B9210
	public void set_StarLayer2DataTexture(Texture2D value) { }

	// RVA: 0x22B9260 Offset: 0x22B9361 VA: 0x22B9260
	public Color get_StarLayer2Color() { }

	// RVA: 0x22B9280 Offset: 0x22B9381 VA: 0x22B9280
	public void set_StarLayer2Color(Color value) { }

	// RVA: 0x22B92C0 Offset: 0x22B93C1 VA: 0x22B92C0
	public float get_StarLayer2MaxRadius() { }

	// RVA: 0x22B92D0 Offset: 0x22B93D1 VA: 0x22B92D0
	public void set_StarLayer2MaxRadius(float value) { }

	// RVA: 0x22B9300 Offset: 0x22B9401 VA: 0x22B9300
	public float get_StarLayer2TwinkleAmount() { }

	// RVA: 0x22B9310 Offset: 0x22B9411 VA: 0x22B9310
	public void set_StarLayer2TwinkleAmount(float value) { }

	// RVA: 0x22B9340 Offset: 0x22B9441 VA: 0x22B9340
	public float get_StarLayer2TwinkleSpeed() { }

	// RVA: 0x22B9350 Offset: 0x22B9451 VA: 0x22B9350
	public void set_StarLayer2TwinkleSpeed(float value) { }

	// RVA: 0x22B9380 Offset: 0x22B9481 VA: 0x22B9380
	public float get_StarLayer2RotationSpeed() { }

	// RVA: 0x22B9390 Offset: 0x22B9491 VA: 0x22B9390
	public void set_StarLayer2RotationSpeed(float value) { }

	// RVA: 0x22B93C0 Offset: 0x22B94C1 VA: 0x22B93C0
	public float get_StarLayer2EdgeFeathering() { }

	// RVA: 0x22B93D0 Offset: 0x22B94D1 VA: 0x22B93D0
	public void set_StarLayer2EdgeFeathering(float value) { }

	// RVA: 0x22B9400 Offset: 0x22B9501 VA: 0x22B9400
	public float get_StarLayer2BloomFilterBoost() { }

	// RVA: 0x22B9410 Offset: 0x22B9511 VA: 0x22B9410
	public void set_StarLayer2BloomFilterBoost(float value) { }

	// RVA: 0x22B9440 Offset: 0x22B9541 VA: 0x22B9440
	public void SetStarLayer2SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9480 Offset: 0x22B9581 VA: 0x22B9480
	public Vector2 GetStarLayer2SpriteDimensions() { }

	// RVA: 0x22B94C0 Offset: 0x22B95C1 VA: 0x22B94C0
	public int get_StarLayer2SpriteItemCount() { }

	// RVA: 0x22B94D0 Offset: 0x22B95D1 VA: 0x22B94D0
	public void set_StarLayer2SpriteItemCount(int value) { }

	// RVA: 0x22B9500 Offset: 0x22B9601 VA: 0x22B9500
	public float get_StarLayer2SpriteAnimationSpeed() { }

	// RVA: 0x22B9510 Offset: 0x22B9611 VA: 0x22B9510
	public void set_StarLayer2SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B9540 Offset: 0x22B9641 VA: 0x22B9540
	public Texture get_StarLayer3Texture() { }

	// RVA: 0x22B9550 Offset: 0x22B9651 VA: 0x22B9550
	public void set_StarLayer3Texture(Texture value) { }

	// RVA: 0x22B9590 Offset: 0x22B9691 VA: 0x22B9590
	public Texture2D get_StarLayer3DataTexture() { }

	// RVA: 0x22B95A0 Offset: 0x22B96A1 VA: 0x22B95A0
	public void set_StarLayer3DataTexture(Texture2D value) { }

	// RVA: 0x22B95F0 Offset: 0x22B96F1 VA: 0x22B95F0
	public Color get_StarLayer3Color() { }

	// RVA: 0x22B9610 Offset: 0x22B9711 VA: 0x22B9610
	public void set_StarLayer3Color(Color value) { }

	// RVA: 0x22B9650 Offset: 0x22B9751 VA: 0x22B9650
	public float get_StarLayer3MaxRadius() { }

	// RVA: 0x22B9660 Offset: 0x22B9761 VA: 0x22B9660
	public void set_StarLayer3MaxRadius(float value) { }

	// RVA: 0x22B9690 Offset: 0x22B9791 VA: 0x22B9690
	public float get_StarLayer3TwinkleAmount() { }

	// RVA: 0x22B96A0 Offset: 0x22B97A1 VA: 0x22B96A0
	public void set_StarLayer3TwinkleAmount(float value) { }

	// RVA: 0x22B96D0 Offset: 0x22B97D1 VA: 0x22B96D0
	public float get_StarLayer3TwinkleSpeed() { }

	// RVA: 0x22B96E0 Offset: 0x22B97E1 VA: 0x22B96E0
	public void set_StarLayer3TwinkleSpeed(float value) { }

	// RVA: 0x22B9710 Offset: 0x22B9811 VA: 0x22B9710
	public float get_StarLayer3RotationSpeed() { }

	// RVA: 0x22B9720 Offset: 0x22B9821 VA: 0x22B9720
	public void set_StarLayer3RotationSpeed(float value) { }

	// RVA: 0x22B9750 Offset: 0x22B9851 VA: 0x22B9750
	public float get_StarLayer3EdgeFeathering() { }

	// RVA: 0x22B9760 Offset: 0x22B9861 VA: 0x22B9760
	public void set_StarLayer3EdgeFeathering(float value) { }

	// RVA: 0x22B9790 Offset: 0x22B9891 VA: 0x22B9790
	public float get_StarLayer3BloomFilterBoost() { }

	// RVA: 0x22B97A0 Offset: 0x22B98A1 VA: 0x22B97A0
	public void set_StarLayer3BloomFilterBoost(float value) { }

	// RVA: 0x22B97D0 Offset: 0x22B98D1 VA: 0x22B97D0
	public void SetStarLayer3SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9810 Offset: 0x22B9911 VA: 0x22B9810
	public Vector2 GetStarLayer3SpriteDimensions() { }

	// RVA: 0x22B9850 Offset: 0x22B9951 VA: 0x22B9850
	public int get_StarLayer3SpriteItemCount() { }

	// RVA: 0x22B9860 Offset: 0x22B9961 VA: 0x22B9860
	public void set_StarLayer3SpriteItemCount(int value) { }

	// RVA: 0x22B9890 Offset: 0x22B9991 VA: 0x22B9890
	public float get_StarLayer3SpriteAnimationSpeed() { }

	// RVA: 0x22B98A0 Offset: 0x22B99A1 VA: 0x22B98A0
	public void set_StarLayer3SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B98D0 Offset: 0x22B99D1 VA: 0x22B98D0
	public Texture get_MoonTexture() { }

	// RVA: 0x22B98E0 Offset: 0x22B99E1 VA: 0x22B98E0
	public void set_MoonTexture(Texture value) { }

	// RVA: 0x22B9920 Offset: 0x22B9A21 VA: 0x22B9920
	public float get_MoonRotationSpeed() { }

	// RVA: 0x22B9930 Offset: 0x22B9A31 VA: 0x22B9930
	public void set_MoonRotationSpeed(float value) { }

	// RVA: 0x22B9960 Offset: 0x22B9A61 VA: 0x22B9960
	public Color get_MoonColor() { }

	// RVA: 0x22B9980 Offset: 0x22B9A81 VA: 0x22B9980
	public void set_MoonColor(Color value) { }

	// RVA: 0x22B99C0 Offset: 0x22B9AC1 VA: 0x22B99C0
	public Vector3 get_MoonDirection() { }

	// RVA: 0x22B99D0 Offset: 0x22B9AD1 VA: 0x22B99D0
	public void set_MoonDirection(Vector3 value) { }

	// RVA: 0x22B9AB0 Offset: 0x22B9BB1 VA: 0x22B9AB0
	public Matrix4x4 get_MoonWorldToLocalMatrix() { }

	// RVA: 0x22B9AE0 Offset: 0x22B9BE1 VA: 0x22B9AE0
	public void set_MoonWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x22B9B70 Offset: 0x22B9C71 VA: 0x22B9B70
	public float get_MoonSize() { }

	// RVA: 0x22B9B80 Offset: 0x22B9C81 VA: 0x22B9B80
	public void set_MoonSize(float value) { }

	// RVA: 0x22B9BB0 Offset: 0x22B9CB1 VA: 0x22B9BB0
	public float get_MoonEdgeFeathering() { }

	// RVA: 0x22B9BC0 Offset: 0x22B9CC1 VA: 0x22B9BC0
	public void set_MoonEdgeFeathering(float value) { }

	// RVA: 0x22B9BF0 Offset: 0x22B9CF1 VA: 0x22B9BF0
	public float get_MoonBloomFilterBoost() { }

	// RVA: 0x22B9C00 Offset: 0x22B9D01 VA: 0x22B9C00
	public void set_MoonBloomFilterBoost(float value) { }

	// RVA: 0x22B9C30 Offset: 0x22B9D31 VA: 0x22B9C30
	public void SetMoonSpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9C70 Offset: 0x22B9D71 VA: 0x22B9C70
	public Vector2 GetMoonSpriteDimensions() { }

	// RVA: 0x22B9CB0 Offset: 0x22B9DB1 VA: 0x22B9CB0
	public int get_MoonSpriteItemCount() { }

	// RVA: 0x22B9CC0 Offset: 0x22B9DC1 VA: 0x22B9CC0
	public void set_MoonSpriteItemCount(int value) { }

	// RVA: 0x22B9CF0 Offset: 0x22B9DF1 VA: 0x22B9CF0
	public float get_MoonSpriteAnimationSpeed() { }

	// RVA: 0x22B9D00 Offset: 0x22B9E01 VA: 0x22B9D00
	public void set_MoonSpriteAnimationSpeed(float value) { }

	// RVA: 0x22B9D30 Offset: 0x22B9E31 VA: 0x22B9D30
	public Texture get_SunTexture() { }

	// RVA: 0x22B9D40 Offset: 0x22B9E41 VA: 0x22B9D40
	public void set_SunTexture(Texture value) { }

	// RVA: 0x22B9D80 Offset: 0x22B9E81 VA: 0x22B9D80
	public Color get_SunColor() { }

	// RVA: 0x22B9DA0 Offset: 0x22B9EA1 VA: 0x22B9DA0
	public void set_SunColor(Color value) { }

	// RVA: 0x22B9DE0 Offset: 0x22B9EE1 VA: 0x22B9DE0
	public float get_SunRotationSpeed() { }

	// RVA: 0x22B9DF0 Offset: 0x22B9EF1 VA: 0x22B9DF0
	public void set_SunRotationSpeed(float value) { }

	// RVA: 0x22B9E20 Offset: 0x22B9F21 VA: 0x22B9E20
	public Vector3 get_SunDirection() { }

	// RVA: 0x22B9E30 Offset: 0x22B9F31 VA: 0x22B9E30
	public void set_SunDirection(Vector3 value) { }

	// RVA: 0x22B9F10 Offset: 0x22BA011 VA: 0x22B9F10
	public Matrix4x4 get_SunWorldToLocalMatrix() { }

	// RVA: 0x22B9F50 Offset: 0x22BA051 VA: 0x22B9F50
	public void set_SunWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x22B9FF0 Offset: 0x22BA0F1 VA: 0x22B9FF0
	public float get_SunSize() { }

	// RVA: 0x22BA000 Offset: 0x22BA101 VA: 0x22BA000
	public void set_SunSize(float value) { }

	// RVA: 0x22BA030 Offset: 0x22BA131 VA: 0x22BA030
	public float get_SunEdgeFeathering() { }

	// RVA: 0x22BA040 Offset: 0x22BA141 VA: 0x22BA040
	public void set_SunEdgeFeathering(float value) { }

	// RVA: 0x22BA070 Offset: 0x22BA171 VA: 0x22BA070
	public float get_SunBloomFilterBoost() { }

	// RVA: 0x22BA080 Offset: 0x22BA181 VA: 0x22BA080
	public void set_SunBloomFilterBoost(float value) { }

	// RVA: 0x22BA0B0 Offset: 0x22BA1B1 VA: 0x22BA0B0
	public void SetSunSpriteDimensions(int columns, int rows) { }

	// RVA: 0x22BA0F0 Offset: 0x22BA1F1 VA: 0x22BA0F0
	public Vector2 GetSunSpriteDimensions() { }

	// RVA: 0x22BA130 Offset: 0x22BA231 VA: 0x22BA130
	public int get_SunSpriteItemCount() { }

	// RVA: 0x22BA140 Offset: 0x22BA241 VA: 0x22BA140
	public void set_SunSpriteItemCount(int value) { }

	// RVA: 0x22BA170 Offset: 0x22BA271 VA: 0x22BA170
	public float get_SunSpriteAnimationSpeed() { }

	// RVA: 0x22BA180 Offset: 0x22BA281 VA: 0x22BA180
	public void set_SunSpriteAnimationSpeed(float value) { }

	// RVA: 0x22BA1B0 Offset: 0x22BA2B1 VA: 0x22BA1B0
	public float get_CloudBegin() { }

	// RVA: 0x22BA1C0 Offset: 0x22BA2C1 VA: 0x22BA1C0
	public void set_CloudBegin(float value) { }

	// RVA: 0x22BA1F0 Offset: 0x22BA2F1 VA: 0x22BA1F0
	public float get_CloudTextureTiling() { }

	// RVA: 0x22BA200 Offset: 0x22BA301 VA: 0x22BA200
	public void set_CloudTextureTiling(float value) { }

	// RVA: 0x22BA230 Offset: 0x22BA331 VA: 0x22BA230
	public float get_Cloud2TextureTiling() { }

	// RVA: 0x22BA240 Offset: 0x22BA341 VA: 0x22BA240
	public void set_Cloud2TextureTiling(float value) { }

	// RVA: 0x22BA270 Offset: 0x22BA371 VA: 0x22BA270
	public Color get_CloudColor() { }

	// RVA: 0x22BA290 Offset: 0x22BA391 VA: 0x22BA290
	public void set_CloudColor(Color value) { }

	// RVA: 0x22BA2D0 Offset: 0x22BA3D1 VA: 0x22BA2D0
	public Texture get_CloudTexture() { }

	// RVA: 0x22BA360 Offset: 0x22BA461 VA: 0x22BA360
	public void set_CloudTexture(Texture value) { }

	// RVA: 0x22BA3A0 Offset: 0x22BA4A1 VA: 0x22BA3A0
	public Texture get_Cloud2Texture() { }

	// RVA: 0x22BA430 Offset: 0x22BA531 VA: 0x22BA430
	public void set_Cloud2Texture(Texture value) { }

	// RVA: 0x22BA470 Offset: 0x22BA571 VA: 0x22BA470
	public Texture get_ArtCloudCustomTexture() { }

	// RVA: 0x22BA500 Offset: 0x22BA601 VA: 0x22BA500
	public void set_ArtCloudCustomTexture(Texture value) { }

	// RVA: 0x22BA540 Offset: 0x22BA641 VA: 0x22BA540
	public float get_CloudDensity() { }

	// RVA: 0x22BA550 Offset: 0x22BA651 VA: 0x22BA550
	public void set_CloudDensity(float value) { }

	// RVA: 0x22BA580 Offset: 0x22BA681 VA: 0x22BA580
	public float get_Cloud2Density() { }

	// RVA: 0x22BA590 Offset: 0x22BA691 VA: 0x22BA590
	public void set_Cloud2Density(float value) { }

	// RVA: 0x22BA5C0 Offset: 0x22BA6C1 VA: 0x22BA5C0
	public float get_CloudSpeed() { }

	// RVA: 0x22BA5D0 Offset: 0x22BA6D1 VA: 0x22BA5D0
	public void set_CloudSpeed(float value) { }

	// RVA: 0x22BA600 Offset: 0x22BA701 VA: 0x22BA600
	public float get_Cloud2Speed() { }

	// RVA: 0x22BA610 Offset: 0x22BA711 VA: 0x22BA610
	public void set_Cloud2Speed(float value) { }

	// RVA: 0x22BA640 Offset: 0x22BA741 VA: 0x22BA640
	public float get_CloudDirection() { }

	// RVA: 0x22BA650 Offset: 0x22BA751 VA: 0x22BA650
	public void set_CloudDirection(float value) { }

	// RVA: 0x22BA680 Offset: 0x22BA781 VA: 0x22BA680
	public float get_Cloud2Direction() { }

	// RVA: 0x22BA690 Offset: 0x22BA791 VA: 0x22BA690
	public void set_Cloud2Direction(float value) { }

	// RVA: 0x22BA6C0 Offset: 0x22BA7C1 VA: 0x22BA6C0
	public float get_CloudHeight() { }

	// RVA: 0x22BA6D0 Offset: 0x22BA7D1 VA: 0x22BA6D0
	public void set_CloudHeight(float value) { }

	// RVA: 0x22BA700 Offset: 0x22BA801 VA: 0x22BA700
	public float get_Cloud2Height() { }

	// RVA: 0x22BA710 Offset: 0x22BA811 VA: 0x22BA710
	public void set_Cloud2Height(float value) { }

	// RVA: 0x22BA740 Offset: 0x22BA841 VA: 0x22BA740
	public Color get_CloudColor1() { }

	// RVA: 0x22BA760 Offset: 0x22BA861 VA: 0x22BA760
	public void set_CloudColor1(Color value) { }

	// RVA: 0x22BA7A0 Offset: 0x22BA8A1 VA: 0x22BA7A0
	public Color get_Cloud2Color1() { }

	// RVA: 0x22BA7C0 Offset: 0x22BA8C1 VA: 0x22BA7C0
	public void set_Cloud2Color1(Color value) { }

	// RVA: 0x22BA800 Offset: 0x22BA901 VA: 0x22BA800
	public Color get_CloudColor2() { }

	// RVA: 0x22BA820 Offset: 0x22BA921 VA: 0x22BA820
	public void set_CloudColor2(Color value) { }

	// RVA: 0x22BA860 Offset: 0x22BA961 VA: 0x22BA860
	public Color get_Cloud2Color2() { }

	// RVA: 0x22BA880 Offset: 0x22BA981 VA: 0x22BA880
	public void set_Cloud2Color2(Color value) { }

	// RVA: 0x22BA8C0 Offset: 0x22BA9C1 VA: 0x22BA8C0
	public float get_CloudFadePosition() { }

	// RVA: 0x22BA8D0 Offset: 0x22BA9D1 VA: 0x22BA8D0
	public void set_CloudFadePosition(float value) { }

	// RVA: 0x22BA900 Offset: 0x22BAA01 VA: 0x22BA900
	public float get_Cloud2FadePosition() { }

	// RVA: 0x22BA910 Offset: 0x22BAA11 VA: 0x22BA910
	public void set_Cloud2FadePosition(float value) { }

	// RVA: 0x22BA940 Offset: 0x22BAA41 VA: 0x22BA940
	public float get_CloudFadeAmount() { }

	// RVA: 0x22BA950 Offset: 0x22BAA51 VA: 0x22BA950
	public void set_CloudFadeAmount(float value) { }

	// RVA: 0x22BA980 Offset: 0x22BAA81 VA: 0x22BA980
	public float get_Cloud2FadeAmount() { }

	// RVA: 0x22BA990 Offset: 0x22BAA91 VA: 0x22BA990
	public void set_Cloud2FadeAmount(float value) { }

	// RVA: 0x22BA9C0 Offset: 0x22BAAC1 VA: 0x22BA9C0
	public Texture get_CloudCubemap() { }

	// RVA: 0x22BA9D0 Offset: 0x22BAAD1 VA: 0x22BA9D0
	public void set_CloudCubemap(Texture value) { }

	// RVA: 0x22BAA10 Offset: 0x22BAB11 VA: 0x22BAA10
	public float get_CloudCubemapRotationSpeed() { }

	// RVA: 0x22BAA20 Offset: 0x22BAB21 VA: 0x22BAA20
	public void set_CloudCubemapRotationSpeed(float value) { }

	// RVA: 0x22BAA50 Offset: 0x22BAB51 VA: 0x22BAA50
	public Texture get_CloudCubemapDoubleLayerCustomTexture() { }

	// RVA: 0x22BAA60 Offset: 0x22BAB61 VA: 0x22BAA60
	public void set_CloudCubemapDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x22BAAA0 Offset: 0x22BABA1 VA: 0x22BAAA0
	public float get_CloudCubemapDoubleLayerRotationSpeed() { }

	// RVA: 0x22BAAB0 Offset: 0x22BABB1 VA: 0x22BAAB0
	public void set_CloudCubemapDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x22BAAE0 Offset: 0x22BABE1 VA: 0x22BAAE0
	public float get_CloudCubemapDoubleLayerHeight() { }

	// RVA: 0x22BAAF0 Offset: 0x22BABF1 VA: 0x22BAAF0
	public void set_CloudCubemapDoubleLayerHeight(float value) { }

	// RVA: 0x22BAB20 Offset: 0x22BAC21 VA: 0x22BAB20
	public Color get_CloudCubemapDoubleLayerTintColor() { }

	// RVA: 0x22BAB40 Offset: 0x22BAC41 VA: 0x22BAB40
	public void set_CloudCubemapDoubleLayerTintColor(Color value) { }

	// RVA: 0x22BAB80 Offset: 0x22BAC81 VA: 0x22BAB80
	public Color get_CloudCubemapTintColor() { }

	// RVA: 0x22BABA0 Offset: 0x22BACA1 VA: 0x22BABA0
	public void set_CloudCubemapTintColor(Color value) { }

	// RVA: 0x22BABE0 Offset: 0x22BACE1 VA: 0x22BABE0
	public float get_CloudCubemapHeight() { }

	// RVA: 0x22BABF0 Offset: 0x22BACF1 VA: 0x22BABF0
	public void set_CloudCubemapHeight(float value) { }

	// RVA: 0x22BAC20 Offset: 0x22BAD21 VA: 0x22BAC20
	public Texture get_CloudCubemapNormalTexture() { }

	// RVA: 0x22BAC30 Offset: 0x22BAD31 VA: 0x22BAC30
	public void set_CloudCubemapNormalTexture(Texture value) { }

	// RVA: 0x22BAC70 Offset: 0x22BAD71 VA: 0x22BAC70
	public Color get_CloudCubemapNormalLitColor() { }

	// RVA: 0x22BAC90 Offset: 0x22BAD91 VA: 0x22BAC90
	public void set_CloudCubemapNormalLitColor(Color value) { }

	// RVA: 0x22BACD0 Offset: 0x22BADD1 VA: 0x22BACD0
	public Color get_CloudCubemapNormalShadowColor() { }

	// RVA: 0x22BACF0 Offset: 0x22BADF1 VA: 0x22BACF0
	public void set_CloudCubemapNormalShadowColor(Color value) { }

	// RVA: 0x22BAD30 Offset: 0x22BAE31 VA: 0x22BAD30
	public float get_CloudCubemapNormalRotationSpeed() { }

	// RVA: 0x22BAD40 Offset: 0x22BAE41 VA: 0x22BAD40
	public void set_CloudCubemapNormalRotationSpeed(float value) { }

	// RVA: 0x22BAD70 Offset: 0x22BAE71 VA: 0x22BAD70
	public float get_CloudCubemapNormalHeight() { }

	// RVA: 0x22BAD80 Offset: 0x22BAE81 VA: 0x22BAD80
	public void set_CloudCubemapNormalHeight(float value) { }

	// RVA: 0x22BADB0 Offset: 0x22BAEB1 VA: 0x22BADB0
	public float get_CloudCubemapNormalAmbientIntensity() { }

	// RVA: 0x22BADC0 Offset: 0x22BAEC1 VA: 0x22BADC0
	public void set_CloudCubemapNormalAmbientIntensity(float value) { }

	// RVA: 0x22BADF0 Offset: 0x22BAEF1 VA: 0x22BADF0
	public Texture get_CloudCubemapNormalDoubleLayerCustomTexture() { }

	// RVA: 0x22BAE00 Offset: 0x22BAF01 VA: 0x22BAE00
	public void set_CloudCubemapNormalDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x22BAE40 Offset: 0x22BAF41 VA: 0x22BAE40
	public float get_CloudCubemapNormalDoubleLayerRotationSpeed() { }

	// RVA: 0x22BAE50 Offset: 0x22BAF51 VA: 0x22BAE50
	public void set_CloudCubemapNormalDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x22BAE80 Offset: 0x22BAF81 VA: 0x22BAE80
	public float get_CloudCubemapNormalDoubleLayerHeight() { }

	// RVA: 0x22BAE90 Offset: 0x22BAF91 VA: 0x22BAE90
	public void set_CloudCubemapNormalDoubleLayerHeight(float value) { }

	// RVA: 0x22BAEC0 Offset: 0x22BAFC1 VA: 0x22BAEC0
	public Color get_CloudCubemapNormalDoubleLayerLitColor() { }

	// RVA: 0x22BAEE0 Offset: 0x22BAFE1 VA: 0x22BAEE0
	public void set_CloudCubemapNormalDoubleLayerLitColor(Color value) { }

	// RVA: 0x22BAF20 Offset: 0x22BB021 VA: 0x22BAF20
	public Color get_CloudCubemapNormalDoubleLayerShadowColor() { }

	// RVA: 0x22BAF40 Offset: 0x22BB041 VA: 0x22BAF40
	public void set_CloudCubemapNormalDoubleLayerShadowColor(Color value) { }

	// RVA: 0x22BAF80 Offset: 0x22BB081 VA: 0x22BAF80
	public Vector3 get_CloudCubemapNormalLightDirection() { }

	// RVA: 0x22BAF90 Offset: 0x22BB091 VA: 0x22BAF90
	public void set_CloudCubemapNormalLightDirection(Vector3 value) { }

	// RVA: 0x22BB050 Offset: 0x22BB151 VA: 0x22BB050
	public Color get_FogColor() { }

	// RVA: 0x22BB070 Offset: 0x22BB171 VA: 0x22BB070
	public void set_FogColor(Color value) { }

	// RVA: 0x22BB0B0 Offset: 0x22BB1B1 VA: 0x22BB0B0
	public float get_FogDensity() { }

	// RVA: 0x22BB0C0 Offset: 0x22BB1C1 VA: 0x22BB0C0
	public void set_FogDensity(float value) { }

	// RVA: 0x22BB0F0 Offset: 0x22BB1F1 VA: 0x22BB0F0
	public float get_FogHeight() { }

	// RVA: 0x22BB100 Offset: 0x22BB201 VA: 0x22BB100
	public void set_FogHeight(float value) { }

	// RVA: 0x22B8970 Offset: 0x22B8A71 VA: 0x22B8970
	private void ApplyGradientValuesOnMaterial() { }

	// RVA: 0x22B8B10 Offset: 0x22B8C11 VA: 0x22B8B10
	private void ApplyStarFadeValuesOnMaterial() { }

	// RVA: 0x22BB130 Offset: 0x22BB231 VA: 0x22BB130
	public void .ctor() { }
}

public class SkyMaterialController // TypeDefIndex: 9676
{
	// Fields
	[SerializeField] // RVA: 0x17D840 Offset: 0x17D941 VA: 0x17D840
	private Material _skyboxMaterial; // 0x10
	[SerializeField] // RVA: 0x17D850 Offset: 0x17D951 VA: 0x17D850
	private Color _skyColor; // 0x18
	[SerializeField] // RVA: 0x17D860 Offset: 0x17D961 VA: 0x17D860
	private Color _skyMiddleColor; // 0x28
	[SerializeField] // RVA: 0x17D870 Offset: 0x17D971 VA: 0x17D870
	private Color _horizonColor; // 0x38
	[SerializeField] // RVA: 0x17D880 Offset: 0x17D981 VA: 0x17D880
	[RangeAttribute] // RVA: 0x17D880 Offset: 0x17D981 VA: 0x17D880
	private float _gradientFadeBegin; // 0x48
	[SerializeField] // RVA: 0x17D8C0 Offset: 0x17D9C1 VA: 0x17D8C0
	[RangeAttribute] // RVA: 0x17D8C0 Offset: 0x17D9C1 VA: 0x17D8C0
	private float _gradientFadeLength; // 0x4C
	[SerializeField] // RVA: 0x17D900 Offset: 0x17DA01 VA: 0x17D900
	[RangeAttribute] // RVA: 0x17D900 Offset: 0x17DA01 VA: 0x17D900
	private float _skyMiddlePosition; // 0x50
	[SerializeField] // RVA: 0x17D940 Offset: 0x17DA41 VA: 0x17D940
	private Cubemap _backgroundCubemap; // 0x58
	[SerializeField] // RVA: 0x17D950 Offset: 0x17DA51 VA: 0x17D950
	[RangeAttribute] // RVA: 0x17D950 Offset: 0x17DA51 VA: 0x17D950
	private float _starFadeBegin; // 0x60
	[SerializeField] // RVA: 0x17D990 Offset: 0x17DA91 VA: 0x17D990
	[RangeAttribute] // RVA: 0x17D990 Offset: 0x17DA91 VA: 0x17D990
	private float _starFadeLength; // 0x64
	[SerializeField] // RVA: 0x17D9D0 Offset: 0x17DAD1 VA: 0x17D9D0
	[RangeAttribute] // RVA: 0x17D9D0 Offset: 0x17DAD1 VA: 0x17D9D0
	private float _horizonDistanceScale; // 0x68
	[SerializeField] // RVA: 0x17DA10 Offset: 0x17DB11 VA: 0x17DA10
	private Texture _starBasicCubemap; // 0x70
	[SerializeField] // RVA: 0x17DA20 Offset: 0x17DB21 VA: 0x17DA20
	private float _starBasicTwinkleSpeed; // 0x78
	[SerializeField] // RVA: 0x17DA30 Offset: 0x17DB31 VA: 0x17DA30
	private float _starBasicTwinkleAmount; // 0x7C
	[SerializeField] // RVA: 0x17DA40 Offset: 0x17DB41 VA: 0x17DA40
	private float _starBasicOpacity; // 0x80
	[SerializeField] // RVA: 0x17DA50 Offset: 0x17DB51 VA: 0x17DA50
	private Color _starBasicTintColor; // 0x84
	[SerializeField] // RVA: 0x17DA60 Offset: 0x17DB61 VA: 0x17DA60
	private float _starBasicExponent; // 0x94
	[SerializeField] // RVA: 0x17DA70 Offset: 0x17DB71 VA: 0x17DA70
	private float _starBasicIntensity; // 0x98
	[SerializeField] // RVA: 0x17DA80 Offset: 0x17DB81 VA: 0x17DA80
	private Texture _starLayer1Texture; // 0xA0
	[SerializeField] // RVA: 0x17DA90 Offset: 0x17DB91 VA: 0x17DA90
	private Texture2D _starLayer1DataTexture; // 0xA8
	[SerializeField] // RVA: 0x17DAA0 Offset: 0x17DBA1 VA: 0x17DAA0
	private Color _starLayer1Color; // 0xB0
	[SerializeField] // RVA: 0x17DAB0 Offset: 0x17DBB1 VA: 0x17DAB0
	[RangeAttribute] // RVA: 0x17DAB0 Offset: 0x17DBB1 VA: 0x17DAB0
	private float _starLayer1MaxRadius; // 0xC0
	[SerializeField] // RVA: 0x17DB00 Offset: 0x17DC01 VA: 0x17DB00
	[RangeAttribute] // RVA: 0x17DB00 Offset: 0x17DC01 VA: 0x17DB00
	private float _starLayer1TwinkleAmount; // 0xC4
	[SerializeField] // RVA: 0x17DB40 Offset: 0x17DC41 VA: 0x17DB40
	[RangeAttribute] // RVA: 0x17DB40 Offset: 0x17DC41 VA: 0x17DB40
	private float _starLayer1TwinkleSpeed; // 0xC8
	[SerializeField] // RVA: 0x17DB80 Offset: 0x17DC81 VA: 0x17DB80
	[RangeAttribute] // RVA: 0x17DB80 Offset: 0x17DC81 VA: 0x17DB80
	private float _starLayer1RotationSpeed; // 0xCC
	[SerializeField] // RVA: 0x17DBC0 Offset: 0x17DCC1 VA: 0x17DBC0
	[RangeAttribute] // RVA: 0x17DBC0 Offset: 0x17DCC1 VA: 0x17DBC0
	private float _starLayer1EdgeFeathering; // 0xD0
	[SerializeField] // RVA: 0x17DC10 Offset: 0x17DD11 VA: 0x17DC10
	[RangeAttribute] // RVA: 0x17DC10 Offset: 0x17DD11 VA: 0x17DC10
	private float _starLayer1BloomFilterBoost; // 0xD4
	[SerializeField] // RVA: 0x17DC50 Offset: 0x17DD51 VA: 0x17DC50
	private Vector4 _starLayer1SpriteDimensions; // 0xD8
	[SerializeField] // RVA: 0x17DC60 Offset: 0x17DD61 VA: 0x17DC60
	private int _starLayer1SpriteItemCount; // 0xE8
	[SerializeField] // RVA: 0x17DC70 Offset: 0x17DD71 VA: 0x17DC70
	[RangeAttribute] // RVA: 0x17DC70 Offset: 0x17DD71 VA: 0x17DC70
	private float _starLayer1SpriteAnimationSpeed; // 0xEC
	[SerializeField] // RVA: 0x17DCB0 Offset: 0x17DDB1 VA: 0x17DCB0
	private Texture _starLayer2Texture; // 0xF0
	[SerializeField] // RVA: 0x17DCC0 Offset: 0x17DDC1 VA: 0x17DCC0
	private Texture2D _starLayer2DataTexture; // 0xF8
	[SerializeField] // RVA: 0x17DCD0 Offset: 0x17DDD1 VA: 0x17DCD0
	private Color _starLayer2Color; // 0x100
	[SerializeField] // RVA: 0x17DCE0 Offset: 0x17DDE1 VA: 0x17DCE0
	[RangeAttribute] // RVA: 0x17DCE0 Offset: 0x17DDE1 VA: 0x17DCE0
	private float _starLayer2MaxRadius; // 0x110
	[SerializeField] // RVA: 0x17DD30 Offset: 0x17DE31 VA: 0x17DD30
	[RangeAttribute] // RVA: 0x17DD30 Offset: 0x17DE31 VA: 0x17DD30
	private float _starLayer2TwinkleAmount; // 0x114
	[SerializeField] // RVA: 0x17DD70 Offset: 0x17DE71 VA: 0x17DD70
	[RangeAttribute] // RVA: 0x17DD70 Offset: 0x17DE71 VA: 0x17DD70
	private float _starLayer2TwinkleSpeed; // 0x118
	[SerializeField] // RVA: 0x17DDB0 Offset: 0x17DEB1 VA: 0x17DDB0
	[RangeAttribute] // RVA: 0x17DDB0 Offset: 0x17DEB1 VA: 0x17DDB0
	private float _starLayer2RotationSpeed; // 0x11C
	[SerializeField] // RVA: 0x17DDF0 Offset: 0x17DEF1 VA: 0x17DDF0
	[RangeAttribute] // RVA: 0x17DDF0 Offset: 0x17DEF1 VA: 0x17DDF0
	private float _starLayer2EdgeFeathering; // 0x120
	[SerializeField] // RVA: 0x17DE40 Offset: 0x17DF41 VA: 0x17DE40
	[RangeAttribute] // RVA: 0x17DE40 Offset: 0x17DF41 VA: 0x17DE40
	private float _starLayer2BloomFilterBoost; // 0x124
	[SerializeField] // RVA: 0x17DE80 Offset: 0x17DF81 VA: 0x17DE80
	private Vector4 _starLayer2SpriteDimensions; // 0x128
	[SerializeField] // RVA: 0x17DE90 Offset: 0x17DF91 VA: 0x17DE90
	private int _starLayer2SpriteItemCount; // 0x138
	[SerializeField] // RVA: 0x17DEA0 Offset: 0x17DFA1 VA: 0x17DEA0
	[RangeAttribute] // RVA: 0x17DEA0 Offset: 0x17DFA1 VA: 0x17DEA0
	private float _starLayer2SpriteAnimationSpeed; // 0x13C
	[SerializeField] // RVA: 0x17DEE0 Offset: 0x17DFE1 VA: 0x17DEE0
	private Texture _starLayer3Texture; // 0x140
	[SerializeField] // RVA: 0x17DEF0 Offset: 0x17DFF1 VA: 0x17DEF0
	private Texture2D _starLayer3DataTexture; // 0x148
	[SerializeField] // RVA: 0x17DF00 Offset: 0x17E001 VA: 0x17DF00
	private Color _starLayer3Color; // 0x150
	[SerializeField] // RVA: 0x17DF10 Offset: 0x17E011 VA: 0x17DF10
	[RangeAttribute] // RVA: 0x17DF10 Offset: 0x17E011 VA: 0x17DF10
	private float _starLayer3MaxRadius; // 0x160
	[SerializeField] // RVA: 0x17DF60 Offset: 0x17E061 VA: 0x17DF60
	[RangeAttribute] // RVA: 0x17DF60 Offset: 0x17E061 VA: 0x17DF60
	private float _starLayer3TwinkleAmount; // 0x164
	[SerializeField] // RVA: 0x17DFA0 Offset: 0x17E0A1 VA: 0x17DFA0
	[RangeAttribute] // RVA: 0x17DFA0 Offset: 0x17E0A1 VA: 0x17DFA0
	private float _starLayer3TwinkleSpeed; // 0x168
	[SerializeField] // RVA: 0x17DFE0 Offset: 0x17E0E1 VA: 0x17DFE0
	[RangeAttribute] // RVA: 0x17DFE0 Offset: 0x17E0E1 VA: 0x17DFE0
	private float _starLayer3RotationSpeed; // 0x16C
	[SerializeField] // RVA: 0x17E020 Offset: 0x17E121 VA: 0x17E020
	[RangeAttribute] // RVA: 0x17E020 Offset: 0x17E121 VA: 0x17E020
	private float _starLayer3EdgeFeathering; // 0x170
	[SerializeField] // RVA: 0x17E070 Offset: 0x17E171 VA: 0x17E070
	[RangeAttribute] // RVA: 0x17E070 Offset: 0x17E171 VA: 0x17E070
	private float _starLayer3BloomFilterBoost; // 0x174
	[SerializeField] // RVA: 0x17E0B0 Offset: 0x17E1B1 VA: 0x17E0B0
	private Vector4 _starLayer3SpriteDimensions; // 0x178
	[SerializeField] // RVA: 0x17E0C0 Offset: 0x17E1C1 VA: 0x17E0C0
	private int _starLayer3SpriteItemCount; // 0x188
	[SerializeField] // RVA: 0x17E0D0 Offset: 0x17E1D1 VA: 0x17E0D0
	[RangeAttribute] // RVA: 0x17E0D0 Offset: 0x17E1D1 VA: 0x17E0D0
	private float _starLayer3SpriteAnimationSpeed; // 0x18C
	[SerializeField] // RVA: 0x17E110 Offset: 0x17E211 VA: 0x17E110
	private Texture _moonTexture; // 0x190
	[SerializeField] // RVA: 0x17E120 Offset: 0x17E221 VA: 0x17E120
	private float _moonRotationSpeed; // 0x198
	[SerializeField] // RVA: 0x17E130 Offset: 0x17E231 VA: 0x17E130
	private Color _moonColor; // 0x19C
	[SerializeField] // RVA: 0x17E140 Offset: 0x17E241 VA: 0x17E140
	private Vector3 _moonDirection; // 0x1AC
	[SerializeField] // RVA: 0x17E150 Offset: 0x17E251 VA: 0x17E150
	private Matrix4x4 _moonWorldToLocalMatrix; // 0x1B8
	[SerializeField] // RVA: 0x17E160 Offset: 0x17E261 VA: 0x17E160
	[RangeAttribute] // RVA: 0x17E160 Offset: 0x17E261 VA: 0x17E160
	private float _moonSize; // 0x1F8
	[SerializeField] // RVA: 0x17E1A0 Offset: 0x17E2A1 VA: 0x17E1A0
	[RangeAttribute] // RVA: 0x17E1A0 Offset: 0x17E2A1 VA: 0x17E1A0
	private float _moonEdgeFeathering; // 0x1FC
	[SerializeField] // RVA: 0x17E1F0 Offset: 0x17E2F1 VA: 0x17E1F0
	[RangeAttribute] // RVA: 0x17E1F0 Offset: 0x17E2F1 VA: 0x17E1F0
	private float _moonBloomFilterBoost; // 0x200
	[SerializeField] // RVA: 0x17E230 Offset: 0x17E331 VA: 0x17E230
	private Vector4 _moonSpriteDimensions; // 0x204
	[SerializeField] // RVA: 0x17E240 Offset: 0x17E341 VA: 0x17E240
	private int _moonSpriteItemCount; // 0x214
	[SerializeField] // RVA: 0x17E250 Offset: 0x17E351 VA: 0x17E250
	[RangeAttribute] // RVA: 0x17E250 Offset: 0x17E351 VA: 0x17E250
	private float _moonSpriteAnimationSpeed; // 0x218
	[SerializeField] // RVA: 0x17E290 Offset: 0x17E391 VA: 0x17E290
	private Texture _sunTexture; // 0x220
	[SerializeField] // RVA: 0x17E2A0 Offset: 0x17E3A1 VA: 0x17E2A0
	private Color _sunColor; // 0x228
	[SerializeField] // RVA: 0x17E2B0 Offset: 0x17E3B1 VA: 0x17E2B0
	private float _sunRotationSpeed; // 0x238
	[SerializeField] // RVA: 0x17E2C0 Offset: 0x17E3C1 VA: 0x17E2C0
	private Vector3 _sunDirection; // 0x23C
	[SerializeField] // RVA: 0x17E2D0 Offset: 0x17E3D1 VA: 0x17E2D0
	private Matrix4x4 _sunWorldToLocalMatrix; // 0x248
	[SerializeField] // RVA: 0x17E2E0 Offset: 0x17E3E1 VA: 0x17E2E0
	[RangeAttribute] // RVA: 0x17E2E0 Offset: 0x17E3E1 VA: 0x17E2E0
	private float _sunSize; // 0x288
	[SerializeField] // RVA: 0x17E320 Offset: 0x17E421 VA: 0x17E320
	[RangeAttribute] // RVA: 0x17E320 Offset: 0x17E421 VA: 0x17E320
	private float _sunEdgeFeathering; // 0x28C
	[SerializeField] // RVA: 0x17E370 Offset: 0x17E471 VA: 0x17E370
	[RangeAttribute] // RVA: 0x17E370 Offset: 0x17E471 VA: 0x17E370
	private float _sunBloomFilterBoost; // 0x290
	[SerializeField] // RVA: 0x17E3B0 Offset: 0x17E4B1 VA: 0x17E3B0
	private Vector4 _sunSpriteDimensions; // 0x294
	[SerializeField] // RVA: 0x17E3C0 Offset: 0x17E4C1 VA: 0x17E3C0
	private int _sunSpriteItemCount; // 0x2A4
	[SerializeField] // RVA: 0x17E3D0 Offset: 0x17E4D1 VA: 0x17E3D0
	[RangeAttribute] // RVA: 0x17E3D0 Offset: 0x17E4D1 VA: 0x17E3D0
	private float _sunSpriteAnimationSpeed; // 0x2A8
	[SerializeField] // RVA: 0x17E410 Offset: 0x17E511 VA: 0x17E410
	[RangeAttribute] // RVA: 0x17E410 Offset: 0x17E511 VA: 0x17E410
	private float _cloudBegin; // 0x2AC
	private float _cloudTextureTiling; // 0x2B0
	private float _cloud2TextureTiling; // 0x2B4
	[SerializeField] // RVA: 0x17E450 Offset: 0x17E551 VA: 0x17E450
	private Color _cloudColor; // 0x2B8
	[SerializeField] // RVA: 0x17E460 Offset: 0x17E561 VA: 0x17E460
	private Texture _cloudTexture; // 0x2C8
	[SerializeField] // RVA: 0x17E470 Offset: 0x17E571 VA: 0x17E470
	private Texture _cloud2Texture; // 0x2D0
	[SerializeField] // RVA: 0x17E480 Offset: 0x17E581 VA: 0x17E480
	private Texture _artCloudCustomTexture; // 0x2D8
	[SerializeField] // RVA: 0x17E490 Offset: 0x17E591 VA: 0x17E490
	private float _cloudDensity; // 0x2E0
	[SerializeField] // RVA: 0x17E4A0 Offset: 0x17E5A1 VA: 0x17E4A0
	private float _cloud2Density; // 0x2E4
	[SerializeField] // RVA: 0x17E4B0 Offset: 0x17E5B1 VA: 0x17E4B0
	private float _cloudSpeed; // 0x2E8
	[SerializeField] // RVA: 0x17E4C0 Offset: 0x17E5C1 VA: 0x17E4C0
	private float _cloud2Speed; // 0x2EC
	[SerializeField] // RVA: 0x17E4D0 Offset: 0x17E5D1 VA: 0x17E4D0
	private float _cloudDirection; // 0x2F0
	[SerializeField] // RVA: 0x17E4E0 Offset: 0x17E5E1 VA: 0x17E4E0
	private float _cloud2Direction; // 0x2F4
	[SerializeField] // RVA: 0x17E4F0 Offset: 0x17E5F1 VA: 0x17E4F0
	private float _cloudHeight; // 0x2F8
	[SerializeField] // RVA: 0x17E500 Offset: 0x17E601 VA: 0x17E500
	private float _cloud2Height; // 0x2FC
	[SerializeField] // RVA: 0x17E510 Offset: 0x17E611 VA: 0x17E510
	private Color _cloudColor1; // 0x300
	[SerializeField] // RVA: 0x17E520 Offset: 0x17E621 VA: 0x17E520
	private Color _cloud2Color1; // 0x310
	[SerializeField] // RVA: 0x17E530 Offset: 0x17E631 VA: 0x17E530
	private Color _cloudColor2; // 0x320
	[SerializeField] // RVA: 0x17E540 Offset: 0x17E641 VA: 0x17E540
	private Color _cloud2Color2; // 0x330
	[SerializeField] // RVA: 0x17E550 Offset: 0x17E651 VA: 0x17E550
	private float _cloudFadePosition; // 0x340
	[SerializeField] // RVA: 0x17E560 Offset: 0x17E661 VA: 0x17E560
	private float _cloud2FadePosition; // 0x344
	[SerializeField] // RVA: 0x17E570 Offset: 0x17E671 VA: 0x17E570
	private float _cloudFadeAmount; // 0x348
	[SerializeField] // RVA: 0x17E580 Offset: 0x17E681 VA: 0x17E580
	private float _cloud2FadeAmount; // 0x34C
	[SerializeField] // RVA: 0x17E590 Offset: 0x17E691 VA: 0x17E590
	private Texture _cloudCubemap; // 0x350
	[SerializeField] // RVA: 0x17E5A0 Offset: 0x17E6A1 VA: 0x17E5A0
	private float _cloudCubemapRotationSpeed; // 0x358
	[SerializeField] // RVA: 0x17E5B0 Offset: 0x17E6B1 VA: 0x17E5B0
	private Texture _cloudCubemapDoubleLayerCustomTexture; // 0x360
	[SerializeField] // RVA: 0x17E5C0 Offset: 0x17E6C1 VA: 0x17E5C0
	private float _cloudCubemapDoubleLayerRotationSpeed; // 0x368
	[SerializeField] // RVA: 0x17E5D0 Offset: 0x17E6D1 VA: 0x17E5D0
	private float _cloudCubemapDoubleLayerHeight; // 0x36C
	[SerializeField] // RVA: 0x17E5E0 Offset: 0x17E6E1 VA: 0x17E5E0
	private Color _cloudCubemapDoubleLayerTintColor; // 0x370
	[SerializeField] // RVA: 0x17E5F0 Offset: 0x17E6F1 VA: 0x17E5F0
	private Color _cloudCubemapTintColor; // 0x380
	[SerializeField] // RVA: 0x17E600 Offset: 0x17E701 VA: 0x17E600
	private float _cloudCubemapHeight; // 0x390
	[SerializeField] // RVA: 0x17E610 Offset: 0x17E711 VA: 0x17E610
	private Texture _cloudCubemapNormalTexture; // 0x398
	[SerializeField] // RVA: 0x17E620 Offset: 0x17E721 VA: 0x17E620
	private Color _cloudCubemapNormalLitColor; // 0x3A0
	[SerializeField] // RVA: 0x17E630 Offset: 0x17E731 VA: 0x17E630
	private Color _cloudCubemapNormalShadowColor; // 0x3B0
	[SerializeField] // RVA: 0x17E640 Offset: 0x17E741 VA: 0x17E640
	private float _cloudCubemapNormalRotationSpeed; // 0x3C0
	[SerializeField] // RVA: 0x17E650 Offset: 0x17E751 VA: 0x17E650
	private float _cloudCubemapNormalHeight; // 0x3C4
	[SerializeField] // RVA: 0x17E660 Offset: 0x17E761 VA: 0x17E660
	private float _cloudCubemapNormalAmbientItensity; // 0x3C8
	[SerializeField] // RVA: 0x17E670 Offset: 0x17E771 VA: 0x17E670
	private Texture _cloudCubemapNormalDoubleLayerCustomTexture; // 0x3D0
	[SerializeField] // RVA: 0x17E680 Offset: 0x17E781 VA: 0x17E680
	private float _cloudCubemapNormalDoubleLayerRotationSpeed; // 0x3D8
	[SerializeField] // RVA: 0x17E690 Offset: 0x17E791 VA: 0x17E690
	private float _cloudCubemapNormalDoubleLayerHeight; // 0x3DC
	[SerializeField] // RVA: 0x17E6A0 Offset: 0x17E7A1 VA: 0x17E6A0
	private Color _cloudCubemapNormalDoubleLayerLitColor; // 0x3E0
	[SerializeField] // RVA: 0x17E6B0 Offset: 0x17E7B1 VA: 0x17E6B0
	private Color _cloudCubemapNormalDoubleLayerShadowColor; // 0x3F0
	[SerializeField] // RVA: 0x17E6C0 Offset: 0x17E7C1 VA: 0x17E6C0
	private Vector3 _cloudCubemapNormalLightDirection; // 0x400
	[SerializeField] // RVA: 0x17E6D0 Offset: 0x17E7D1 VA: 0x17E6D0
	private Color _fogColor; // 0x40C
	[SerializeField] // RVA: 0x17E6E0 Offset: 0x17E7E1 VA: 0x17E6E0
	private float _fogDensity; // 0x41C
	[SerializeField] // RVA: 0x17E6F0 Offset: 0x17E7F1 VA: 0x17E6F0
	private float _fogHeight; // 0x420
	private int _GradientSkyUpperColorId; // 0x424
	private int _GradientSkyMiddleColorId; // 0x428
	private int _GradientSkyLowerColorId; // 0x42C
	private int _GradientFadeMiddlePositionId; // 0x430
	private int _MainTexId; // 0x434
	private int _HorizonScaleFactorId; // 0x438
	private int _StarBasicCubemapId; // 0x43C
	private int _StarBasicTwinkleSpeedId; // 0x440
	private int _StarBasicTwinkleAmountId; // 0x444
	private int _StarBasicOpacityId; // 0x448
	private int _StarBasicTintColorId; // 0x44C
	private int _StarBasicExponentId; // 0x450
	private int _StarBasicHDRBoostId; // 0x454
	private int _StarLayer1TexId; // 0x458
	private int _StarLayer1DataTexId; // 0x45C
	private int _StarLayer1ColorId; // 0x460
	private int _StarLayer1MaxRadiusId; // 0x464
	private int _StarLayer1TwinkleAmountId; // 0x468
	private int _StarLayer1TwinkleSpeedId; // 0x46C
	private int _StarLayer1RotationSpeedId; // 0x470
	private int _StarLayer1EdgeFadeId; // 0x474
	private int _StarLayer1HDRBoostId; // 0x478
	private int _StarLayer1SpriteDimensionsId; // 0x47C
	private int _StarLayer1SpriteItemCountId; // 0x480
	private int _StarLayer1SpriteAnimationSpeedId; // 0x484
	private int _StarLayer2TexId; // 0x488
	private int _StarLayer2DataTexId; // 0x48C
	private int _StarLayer2ColorId; // 0x490
	private int _StarLayer2MaxRadiusId; // 0x494
	private int _StarLayer2TwinkleAmountId; // 0x498
	private int _StarLayer2TwinkleSpeedId; // 0x49C
	private int _StarLayer2RotationSpeedId; // 0x4A0
	private int _StarLayer2EdgeFadeId; // 0x4A4
	private int _StarLayer2HDRBoostId; // 0x4A8
	private int _StarLayer2SpriteDimensionsId; // 0x4AC
	private int _StarLayer2SpriteItemCountId; // 0x4B0
	private int _StarLayer2SpriteAnimationSpeedId; // 0x4B4
	private int _StarLayer3TexId; // 0x4B8
	private int _StarLayer3DataTexId; // 0x4BC
	private int _StarLayer3ColorId; // 0x4C0
	private int _StarLayer3MaxRadiusId; // 0x4C4
	private int _StarLayer3TwinkleAmountId; // 0x4C8
	private int _StarLayer3TwinkleSpeedId; // 0x4CC
	private int _StarLayer3RotationSpeedId; // 0x4D0
	private int _StarLayer3EdgeFadeId; // 0x4D4
	private int _StarLayer3HDRBoostId; // 0x4D8
	private int _StarLayer3SpriteDimensionsId; // 0x4DC
	private int _StarLayer3SpriteItemCountId; // 0x4E0
	private int _StarLayer3SpriteAnimationSpeedId; // 0x4E4
	private int _MoonTexId; // 0x4E8
	private int _MoonRotationSpeedId; // 0x4EC
	private int _MoonColorId; // 0x4F0
	private int _MoonPositionId; // 0x4F4
	private int _MoonWorldToLocalMatId; // 0x4F8
	private int _MoonRadiusId; // 0x4FC
	private int _MoonEdgeFadeId; // 0x500
	private int _MoonHDRBoostId; // 0x504
	private int _MoonSpriteDimensionsId; // 0x508
	private int _MoonSpriteItemCountId; // 0x50C
	private int _MoonSpriteAnimationSpeedId; // 0x510
	private int _SunTexId; // 0x514
	private int _SunColorId; // 0x518
	private int _SunRotationSpeedId; // 0x51C
	private int _SunPositionId; // 0x520
	private int _SunWorldToLocalMatId; // 0x524
	private int _SunRadiusId; // 0x528
	private int _SunEdgeFadeId; // 0x52C
	private int _SunHDRBoostId; // 0x530
	private int _SunSpriteDimensionsId; // 0x534
	private int _SunSpriteItemCountId; // 0x538
	private int _SunSpriteAnimationSpeedId; // 0x53C
	private int _CloudBeginId; // 0x540
	private int _CloudTextureTilingId; // 0x544
	private int _Cloud2TextureTilingId; // 0x548
	private int _CloudColorId; // 0x54C
	private int _CloudNoiseTextureId; // 0x550
	private int _Cloud2NoiseTextureId; // 0x554
	private int _ArtCloudCustomTextureId; // 0x558
	private int _CloudDensityId; // 0x55C
	private int _Cloud2DensityId; // 0x560
	private int _CloudSpeedId; // 0x564
	private int _Cloud2SpeedId; // 0x568
	private int _CloudDirectionId; // 0x56C
	private int _Cloud2DirectionId; // 0x570
	private int _CloudHeightId; // 0x574
	private int _Cloud2HeightId; // 0x578
	private int _CloudColor1Id; // 0x57C
	private int _Cloud2Color1Id; // 0x580
	private int _CloudColor2Id; // 0x584
	private int _Cloud2Color2Id; // 0x588
	private int _CloudFadePositionId; // 0x58C
	private int _Cloud2FadePositionId; // 0x590
	private int _CloudFadeAmountId; // 0x594
	private int _Cloud2FadeAmountId; // 0x598
	private int _CloudCubemapTextureId; // 0x59C
	private int _CloudCubemapRotationSpeedId; // 0x5A0
	private int _CloudCubemapDoubleTextureId; // 0x5A4
	private int _CloudCubemapDoubleLayerRotationSpeedId; // 0x5A8
	private int _CloudCubemapDoubleLayerHeightId; // 0x5AC
	private int _CloudCubemapDoubleLayerTintColorId; // 0x5B0
	private int _CloudCubemapTintColorId; // 0x5B4
	private int _CloudCubemapHeightId; // 0x5B8
	private int _CloudCubemapNormalTextureId; // 0x5BC
	private int _CloudCubemapNormalLitColorId; // 0x5C0
	private int _CloudCubemapNormalShadowColorId; // 0x5C4
	private int _CloudCubemapNormalRotationSpeedId; // 0x5C8
	private int _CloudCubemapNormalHeightId; // 0x5CC
	private int _CloudCubemapNormalAmbientIntensityId; // 0x5D0
	private int _CloudCubemapNormalDoubleTextureId; // 0x5D4
	private int _CloudCubemapNormalDoubleLayerRotationSpeedId; // 0x5D8
	private int _CloudCubemapNormalDoubleLayerHeightId; // 0x5DC
	private int _CloudCubemapNormalDoubleLitColorId; // 0x5E0
	private int _CloudCubemapNormalDoubleShadowColorId; // 0x5E4
	private int _CloudCubemapNormalToLightId; // 0x5E8
	private int _HorizonFogColorId; // 0x5EC
	private int _HorizonFogDensityId; // 0x5F0
	private int _HorizonFogLengthId; // 0x5F4
	private int _GradientFadeBeginId; // 0x5F8
	private int _GradientFadeEndId; // 0x5FC
	private int _StarFadeBeginId; // 0x600
	private int _StarFadeEndId; // 0x604

	// Properties
	public Material SkyboxMaterial { get; set; }
	public Color SkyColor { get; set; }
	public Color SkyMiddleColor { get; set; }
	public Color HorizonColor { get; set; }
	public float GradientFadeBegin { get; set; }
	public float GradientFadeLength { get; set; }
	public float SkyMiddlePosition { get; set; }
	public Cubemap BackgroundCubemap { get; set; }
	public float StarFadeBegin { get; set; }
	public float StarFadeLength { get; set; }
	public float HorizonDistanceScale { get; set; }
	public Texture StarBasicCubemap { get; set; }
	public float StarBasicTwinkleSpeed { get; set; }
	public float StarBasicTwinkleAmount { get; set; }
	public float StarBasicOpacity { get; set; }
	public Color StarBasicTintColor { get; set; }
	public float StarBasicExponent { get; set; }
	public float StarBasicIntensity { get; set; }
	public Texture StarLayer1Texture { get; set; }
	public Texture2D StarLayer1DataTexture { get; set; }
	public Color StarLayer1Color { get; set; }
	public float StarLayer1MaxRadius { get; set; }
	public float StarLayer1TwinkleAmount { get; set; }
	public float StarLayer1TwinkleSpeed { get; set; }
	public float StarLayer1RotationSpeed { get; set; }
	public float StarLayer1EdgeFeathering { get; set; }
	public float StarLayer1BloomFilterBoost { get; set; }
	public int StarLayer1SpriteItemCount { get; set; }
	public float StarLayer1SpriteAnimationSpeed { get; set; }
	public Texture StarLayer2Texture { get; set; }
	public Texture2D StarLayer2DataTexture { get; set; }
	public Color StarLayer2Color { get; set; }
	public float StarLayer2MaxRadius { get; set; }
	public float StarLayer2TwinkleAmount { get; set; }
	public float StarLayer2TwinkleSpeed { get; set; }
	public float StarLayer2RotationSpeed { get; set; }
	public float StarLayer2EdgeFeathering { get; set; }
	public float StarLayer2BloomFilterBoost { get; set; }
	public int StarLayer2SpriteItemCount { get; set; }
	public float StarLayer2SpriteAnimationSpeed { get; set; }
	public Texture StarLayer3Texture { get; set; }
	public Texture2D StarLayer3DataTexture { get; set; }
	public Color StarLayer3Color { get; set; }
	public float StarLayer3MaxRadius { get; set; }
	public float StarLayer3TwinkleAmount { get; set; }
	public float StarLayer3TwinkleSpeed { get; set; }
	public float StarLayer3RotationSpeed { get; set; }
	public float StarLayer3EdgeFeathering { get; set; }
	public float StarLayer3BloomFilterBoost { get; set; }
	public int StarLayer3SpriteItemCount { get; set; }
	public float StarLayer3SpriteAnimationSpeed { get; set; }
	public Texture MoonTexture { get; set; }
	public float MoonRotationSpeed { get; set; }
	public Color MoonColor { get; set; }
	public Vector3 MoonDirection { get; set; }
	public Matrix4x4 MoonWorldToLocalMatrix { get; set; }
	public float MoonSize { get; set; }
	public float MoonEdgeFeathering { get; set; }
	public float MoonBloomFilterBoost { get; set; }
	public int MoonSpriteItemCount { get; set; }
	public float MoonSpriteAnimationSpeed { get; set; }
	public Texture SunTexture { get; set; }
	public Color SunColor { get; set; }
	public float SunRotationSpeed { get; set; }
	public Vector3 SunDirection { get; set; }
	public Matrix4x4 SunWorldToLocalMatrix { get; set; }
	public float SunSize { get; set; }
	public float SunEdgeFeathering { get; set; }
	public float SunBloomFilterBoost { get; set; }
	public int SunSpriteItemCount { get; set; }
	public float SunSpriteAnimationSpeed { get; set; }
	public float CloudBegin { get; set; }
	public float CloudTextureTiling { get; set; }
	public float Cloud2TextureTiling { get; set; }
	public Color CloudColor { get; set; }
	public Texture CloudTexture { get; set; }
	public Texture Cloud2Texture { get; set; }
	public Texture ArtCloudCustomTexture { get; set; }
	public float CloudDensity { get; set; }
	public float Cloud2Density { get; set; }
	public float CloudSpeed { get; set; }
	public float Cloud2Speed { get; set; }
	public float CloudDirection { get; set; }
	public float Cloud2Direction { get; set; }
	public float CloudHeight { get; set; }
	public float Cloud2Height { get; set; }
	public Color CloudColor1 { get; set; }
	public Color Cloud2Color1 { get; set; }
	public Color CloudColor2 { get; set; }
	public Color Cloud2Color2 { get; set; }
	public float CloudFadePosition { get; set; }
	public float Cloud2FadePosition { get; set; }
	public float CloudFadeAmount { get; set; }
	public float Cloud2FadeAmount { get; set; }
	public Texture CloudCubemap { get; set; }
	public float CloudCubemapRotationSpeed { get; set; }
	public Texture CloudCubemapDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapDoubleLayerHeight { get; set; }
	public Color CloudCubemapDoubleLayerTintColor { get; set; }
	public Color CloudCubemapTintColor { get; set; }
	public float CloudCubemapHeight { get; set; }
	public Texture CloudCubemapNormalTexture { get; set; }
	public Color CloudCubemapNormalLitColor { get; set; }
	public Color CloudCubemapNormalShadowColor { get; set; }
	public float CloudCubemapNormalRotationSpeed { get; set; }
	public float CloudCubemapNormalHeight { get; set; }
	public float CloudCubemapNormalAmbientIntensity { get; set; }
	public Texture CloudCubemapNormalDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapNormalDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapNormalDoubleLayerHeight { get; set; }
	public Color CloudCubemapNormalDoubleLayerLitColor { get; set; }
	public Color CloudCubemapNormalDoubleLayerShadowColor { get; set; }
	public Vector3 CloudCubemapNormalLightDirection { get; set; }
	public Color FogColor { get; set; }
	public float FogDensity { get; set; }
	public float FogHeight { get; set; }

	// Methods

	// RVA: 0x22B8820 Offset: 0x22B8921 VA: 0x22B8820
	public Material get_SkyboxMaterial() { }

	// RVA: 0x22B8830 Offset: 0x22B8931 VA: 0x22B8830
	public void set_SkyboxMaterial(Material value) { }

	// RVA: 0x22B8860 Offset: 0x22B8961 VA: 0x22B8860
	public Color get_SkyColor() { }

	// RVA: 0x22B8870 Offset: 0x22B8971 VA: 0x22B8870
	public void set_SkyColor(Color value) { }

	// RVA: 0x22B88B0 Offset: 0x22B89B1 VA: 0x22B88B0
	public Color get_SkyMiddleColor() { }

	// RVA: 0x22B88C0 Offset: 0x22B89C1 VA: 0x22B88C0
	public void set_SkyMiddleColor(Color value) { }

	// RVA: 0x22B8900 Offset: 0x22B8A01 VA: 0x22B8900
	public Color get_HorizonColor() { }

	// RVA: 0x22B8910 Offset: 0x22B8A11 VA: 0x22B8910
	public void set_HorizonColor(Color value) { }

	// RVA: 0x22B8950 Offset: 0x22B8A51 VA: 0x22B8950
	public float get_GradientFadeBegin() { }

	// RVA: 0x22B8960 Offset: 0x22B8A61 VA: 0x22B8960
	public void set_GradientFadeBegin(float value) { }

	// RVA: 0x22B8A30 Offset: 0x22B8B31 VA: 0x22B8A30
	public float get_GradientFadeLength() { }

	// RVA: 0x22B8A40 Offset: 0x22B8B41 VA: 0x22B8A40
	public void set_GradientFadeLength(float value) { }

	// RVA: 0x22B8A50 Offset: 0x22B8B51 VA: 0x22B8A50
	public float get_SkyMiddlePosition() { }

	// RVA: 0x22B8A60 Offset: 0x22B8B61 VA: 0x22B8A60
	public void set_SkyMiddlePosition(float value) { }

	// RVA: 0x22B8A90 Offset: 0x22B8B91 VA: 0x22B8A90
	public Cubemap get_BackgroundCubemap() { }

	// RVA: 0x22B8AA0 Offset: 0x22B8BA1 VA: 0x22B8AA0
	public void set_BackgroundCubemap(Cubemap value) { }

	// RVA: 0x22B8AF0 Offset: 0x22B8BF1 VA: 0x22B8AF0
	public float get_StarFadeBegin() { }

	// RVA: 0x22B8B00 Offset: 0x22B8C01 VA: 0x22B8B00
	public void set_StarFadeBegin(float value) { }

	// RVA: 0x22B8BD0 Offset: 0x22B8CD1 VA: 0x22B8BD0
	public float get_StarFadeLength() { }

	// RVA: 0x22B8BE0 Offset: 0x22B8CE1 VA: 0x22B8BE0
	public void set_StarFadeLength(float value) { }

	// RVA: 0x22B8BF0 Offset: 0x22B8CF1 VA: 0x22B8BF0
	public float get_HorizonDistanceScale() { }

	// RVA: 0x22B8C00 Offset: 0x22B8D01 VA: 0x22B8C00
	public void set_HorizonDistanceScale(float value) { }

	// RVA: 0x22B8C30 Offset: 0x22B8D31 VA: 0x22B8C30
	public Texture get_StarBasicCubemap() { }

	// RVA: 0x22B8C40 Offset: 0x22B8D41 VA: 0x22B8C40
	public void set_StarBasicCubemap(Texture value) { }

	// RVA: 0x22B8C90 Offset: 0x22B8D91 VA: 0x22B8C90
	public float get_StarBasicTwinkleSpeed() { }

	// RVA: 0x22B8CA0 Offset: 0x22B8DA1 VA: 0x22B8CA0
	public void set_StarBasicTwinkleSpeed(float value) { }

	// RVA: 0x22B8CD0 Offset: 0x22B8DD1 VA: 0x22B8CD0
	public float get_StarBasicTwinkleAmount() { }

	// RVA: 0x22B8CE0 Offset: 0x22B8DE1 VA: 0x22B8CE0
	public void set_StarBasicTwinkleAmount(float value) { }

	// RVA: 0x22B8D10 Offset: 0x22B8E11 VA: 0x22B8D10
	public float get_StarBasicOpacity() { }

	// RVA: 0x22B8D20 Offset: 0x22B8E21 VA: 0x22B8D20
	public void set_StarBasicOpacity(float value) { }

	// RVA: 0x22B8D50 Offset: 0x22B8E51 VA: 0x22B8D50
	public Color get_StarBasicTintColor() { }

	// RVA: 0x22B8D60 Offset: 0x22B8E61 VA: 0x22B8D60
	public void set_StarBasicTintColor(Color value) { }

	// RVA: 0x22B8DA0 Offset: 0x22B8EA1 VA: 0x22B8DA0
	public float get_StarBasicExponent() { }

	// RVA: 0x22B8DB0 Offset: 0x22B8EB1 VA: 0x22B8DB0
	public void set_StarBasicExponent(float value) { }

	// RVA: 0x22B8DE0 Offset: 0x22B8EE1 VA: 0x22B8DE0
	public float get_StarBasicIntensity() { }

	// RVA: 0x22B8DF0 Offset: 0x22B8EF1 VA: 0x22B8DF0
	public void set_StarBasicIntensity(float value) { }

	// RVA: 0x22B8E20 Offset: 0x22B8F21 VA: 0x22B8E20
	public Texture get_StarLayer1Texture() { }

	// RVA: 0x22B8E30 Offset: 0x22B8F31 VA: 0x22B8E30
	public void set_StarLayer1Texture(Texture value) { }

	// RVA: 0x22B8E80 Offset: 0x22B8F81 VA: 0x22B8E80
	public Texture2D get_StarLayer1DataTexture() { }

	// RVA: 0x22B8E90 Offset: 0x22B8F91 VA: 0x22B8E90
	public void set_StarLayer1DataTexture(Texture2D value) { }

	// RVA: 0x22B8EE0 Offset: 0x22B8FE1 VA: 0x22B8EE0
	public Color get_StarLayer1Color() { }

	// RVA: 0x22B8EF0 Offset: 0x22B8FF1 VA: 0x22B8EF0
	public void set_StarLayer1Color(Color value) { }

	// RVA: 0x22B8F30 Offset: 0x22B9031 VA: 0x22B8F30
	public float get_StarLayer1MaxRadius() { }

	// RVA: 0x22B8F40 Offset: 0x22B9041 VA: 0x22B8F40
	public void set_StarLayer1MaxRadius(float value) { }

	// RVA: 0x22B8F70 Offset: 0x22B9071 VA: 0x22B8F70
	public float get_StarLayer1TwinkleAmount() { }

	// RVA: 0x22B8F80 Offset: 0x22B9081 VA: 0x22B8F80
	public void set_StarLayer1TwinkleAmount(float value) { }

	// RVA: 0x22B8FB0 Offset: 0x22B90B1 VA: 0x22B8FB0
	public float get_StarLayer1TwinkleSpeed() { }

	// RVA: 0x22B8FC0 Offset: 0x22B90C1 VA: 0x22B8FC0
	public void set_StarLayer1TwinkleSpeed(float value) { }

	// RVA: 0x22B8FF0 Offset: 0x22B90F1 VA: 0x22B8FF0
	public float get_StarLayer1RotationSpeed() { }

	// RVA: 0x22B9000 Offset: 0x22B9101 VA: 0x22B9000
	public void set_StarLayer1RotationSpeed(float value) { }

	// RVA: 0x22B9030 Offset: 0x22B9131 VA: 0x22B9030
	public float get_StarLayer1EdgeFeathering() { }

	// RVA: 0x22B9040 Offset: 0x22B9141 VA: 0x22B9040
	public void set_StarLayer1EdgeFeathering(float value) { }

	// RVA: 0x22B9070 Offset: 0x22B9171 VA: 0x22B9070
	public float get_StarLayer1BloomFilterBoost() { }

	// RVA: 0x22B9080 Offset: 0x22B9181 VA: 0x22B9080
	public void set_StarLayer1BloomFilterBoost(float value) { }

	// RVA: 0x22B90B0 Offset: 0x22B91B1 VA: 0x22B90B0
	public void SetStarLayer1SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B90F0 Offset: 0x22B91F1 VA: 0x22B90F0
	public Vector2 GetStarLayer1SpriteDimensions() { }

	// RVA: 0x22B9120 Offset: 0x22B9221 VA: 0x22B9120
	public int get_StarLayer1SpriteItemCount() { }

	// RVA: 0x22B9130 Offset: 0x22B9231 VA: 0x22B9130
	public void set_StarLayer1SpriteItemCount(int value) { }

	// RVA: 0x22B9160 Offset: 0x22B9261 VA: 0x22B9160
	public float get_StarLayer1SpriteAnimationSpeed() { }

	// RVA: 0x22B9170 Offset: 0x22B9271 VA: 0x22B9170
	public void set_StarLayer1SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B91A0 Offset: 0x22B92A1 VA: 0x22B91A0
	public Texture get_StarLayer2Texture() { }

	// RVA: 0x22B91B0 Offset: 0x22B92B1 VA: 0x22B91B0
	public void set_StarLayer2Texture(Texture value) { }

	// RVA: 0x22B9200 Offset: 0x22B9301 VA: 0x22B9200
	public Texture2D get_StarLayer2DataTexture() { }

	// RVA: 0x22B9210 Offset: 0x22B9311 VA: 0x22B9210
	public void set_StarLayer2DataTexture(Texture2D value) { }

	// RVA: 0x22B9260 Offset: 0x22B9361 VA: 0x22B9260
	public Color get_StarLayer2Color() { }

	// RVA: 0x22B9280 Offset: 0x22B9381 VA: 0x22B9280
	public void set_StarLayer2Color(Color value) { }

	// RVA: 0x22B92C0 Offset: 0x22B93C1 VA: 0x22B92C0
	public float get_StarLayer2MaxRadius() { }

	// RVA: 0x22B92D0 Offset: 0x22B93D1 VA: 0x22B92D0
	public void set_StarLayer2MaxRadius(float value) { }

	// RVA: 0x22B9300 Offset: 0x22B9401 VA: 0x22B9300
	public float get_StarLayer2TwinkleAmount() { }

	// RVA: 0x22B9310 Offset: 0x22B9411 VA: 0x22B9310
	public void set_StarLayer2TwinkleAmount(float value) { }

	// RVA: 0x22B9340 Offset: 0x22B9441 VA: 0x22B9340
	public float get_StarLayer2TwinkleSpeed() { }

	// RVA: 0x22B9350 Offset: 0x22B9451 VA: 0x22B9350
	public void set_StarLayer2TwinkleSpeed(float value) { }

	// RVA: 0x22B9380 Offset: 0x22B9481 VA: 0x22B9380
	public float get_StarLayer2RotationSpeed() { }

	// RVA: 0x22B9390 Offset: 0x22B9491 VA: 0x22B9390
	public void set_StarLayer2RotationSpeed(float value) { }

	// RVA: 0x22B93C0 Offset: 0x22B94C1 VA: 0x22B93C0
	public float get_StarLayer2EdgeFeathering() { }

	// RVA: 0x22B93D0 Offset: 0x22B94D1 VA: 0x22B93D0
	public void set_StarLayer2EdgeFeathering(float value) { }

	// RVA: 0x22B9400 Offset: 0x22B9501 VA: 0x22B9400
	public float get_StarLayer2BloomFilterBoost() { }

	// RVA: 0x22B9410 Offset: 0x22B9511 VA: 0x22B9410
	public void set_StarLayer2BloomFilterBoost(float value) { }

	// RVA: 0x22B9440 Offset: 0x22B9541 VA: 0x22B9440
	public void SetStarLayer2SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9480 Offset: 0x22B9581 VA: 0x22B9480
	public Vector2 GetStarLayer2SpriteDimensions() { }

	// RVA: 0x22B94C0 Offset: 0x22B95C1 VA: 0x22B94C0
	public int get_StarLayer2SpriteItemCount() { }

	// RVA: 0x22B94D0 Offset: 0x22B95D1 VA: 0x22B94D0
	public void set_StarLayer2SpriteItemCount(int value) { }

	// RVA: 0x22B9500 Offset: 0x22B9601 VA: 0x22B9500
	public float get_StarLayer2SpriteAnimationSpeed() { }

	// RVA: 0x22B9510 Offset: 0x22B9611 VA: 0x22B9510
	public void set_StarLayer2SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B9540 Offset: 0x22B9641 VA: 0x22B9540
	public Texture get_StarLayer3Texture() { }

	// RVA: 0x22B9550 Offset: 0x22B9651 VA: 0x22B9550
	public void set_StarLayer3Texture(Texture value) { }

	// RVA: 0x22B9590 Offset: 0x22B9691 VA: 0x22B9590
	public Texture2D get_StarLayer3DataTexture() { }

	// RVA: 0x22B95A0 Offset: 0x22B96A1 VA: 0x22B95A0
	public void set_StarLayer3DataTexture(Texture2D value) { }

	// RVA: 0x22B95F0 Offset: 0x22B96F1 VA: 0x22B95F0
	public Color get_StarLayer3Color() { }

	// RVA: 0x22B9610 Offset: 0x22B9711 VA: 0x22B9610
	public void set_StarLayer3Color(Color value) { }

	// RVA: 0x22B9650 Offset: 0x22B9751 VA: 0x22B9650
	public float get_StarLayer3MaxRadius() { }

	// RVA: 0x22B9660 Offset: 0x22B9761 VA: 0x22B9660
	public void set_StarLayer3MaxRadius(float value) { }

	// RVA: 0x22B9690 Offset: 0x22B9791 VA: 0x22B9690
	public float get_StarLayer3TwinkleAmount() { }

	// RVA: 0x22B96A0 Offset: 0x22B97A1 VA: 0x22B96A0
	public void set_StarLayer3TwinkleAmount(float value) { }

	// RVA: 0x22B96D0 Offset: 0x22B97D1 VA: 0x22B96D0
	public float get_StarLayer3TwinkleSpeed() { }

	// RVA: 0x22B96E0 Offset: 0x22B97E1 VA: 0x22B96E0
	public void set_StarLayer3TwinkleSpeed(float value) { }

	// RVA: 0x22B9710 Offset: 0x22B9811 VA: 0x22B9710
	public float get_StarLayer3RotationSpeed() { }

	// RVA: 0x22B9720 Offset: 0x22B9821 VA: 0x22B9720
	public void set_StarLayer3RotationSpeed(float value) { }

	// RVA: 0x22B9750 Offset: 0x22B9851 VA: 0x22B9750
	public float get_StarLayer3EdgeFeathering() { }

	// RVA: 0x22B9760 Offset: 0x22B9861 VA: 0x22B9760
	public void set_StarLayer3EdgeFeathering(float value) { }

	// RVA: 0x22B9790 Offset: 0x22B9891 VA: 0x22B9790
	public float get_StarLayer3BloomFilterBoost() { }

	// RVA: 0x22B97A0 Offset: 0x22B98A1 VA: 0x22B97A0
	public void set_StarLayer3BloomFilterBoost(float value) { }

	// RVA: 0x22B97D0 Offset: 0x22B98D1 VA: 0x22B97D0
	public void SetStarLayer3SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9810 Offset: 0x22B9911 VA: 0x22B9810
	public Vector2 GetStarLayer3SpriteDimensions() { }

	// RVA: 0x22B9850 Offset: 0x22B9951 VA: 0x22B9850
	public int get_StarLayer3SpriteItemCount() { }

	// RVA: 0x22B9860 Offset: 0x22B9961 VA: 0x22B9860
	public void set_StarLayer3SpriteItemCount(int value) { }

	// RVA: 0x22B9890 Offset: 0x22B9991 VA: 0x22B9890
	public float get_StarLayer3SpriteAnimationSpeed() { }

	// RVA: 0x22B98A0 Offset: 0x22B99A1 VA: 0x22B98A0
	public void set_StarLayer3SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B98D0 Offset: 0x22B99D1 VA: 0x22B98D0
	public Texture get_MoonTexture() { }

	// RVA: 0x22B98E0 Offset: 0x22B99E1 VA: 0x22B98E0
	public void set_MoonTexture(Texture value) { }

	// RVA: 0x22B9920 Offset: 0x22B9A21 VA: 0x22B9920
	public float get_MoonRotationSpeed() { }

	// RVA: 0x22B9930 Offset: 0x22B9A31 VA: 0x22B9930
	public void set_MoonRotationSpeed(float value) { }

	// RVA: 0x22B9960 Offset: 0x22B9A61 VA: 0x22B9960
	public Color get_MoonColor() { }

	// RVA: 0x22B9980 Offset: 0x22B9A81 VA: 0x22B9980
	public void set_MoonColor(Color value) { }

	// RVA: 0x22B99C0 Offset: 0x22B9AC1 VA: 0x22B99C0
	public Vector3 get_MoonDirection() { }

	// RVA: 0x22B99D0 Offset: 0x22B9AD1 VA: 0x22B99D0
	public void set_MoonDirection(Vector3 value) { }

	// RVA: 0x22B9AB0 Offset: 0x22B9BB1 VA: 0x22B9AB0
	public Matrix4x4 get_MoonWorldToLocalMatrix() { }

	// RVA: 0x22B9AE0 Offset: 0x22B9BE1 VA: 0x22B9AE0
	public void set_MoonWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x22B9B70 Offset: 0x22B9C71 VA: 0x22B9B70
	public float get_MoonSize() { }

	// RVA: 0x22B9B80 Offset: 0x22B9C81 VA: 0x22B9B80
	public void set_MoonSize(float value) { }

	// RVA: 0x22B9BB0 Offset: 0x22B9CB1 VA: 0x22B9BB0
	public float get_MoonEdgeFeathering() { }

	// RVA: 0x22B9BC0 Offset: 0x22B9CC1 VA: 0x22B9BC0
	public void set_MoonEdgeFeathering(float value) { }

	// RVA: 0x22B9BF0 Offset: 0x22B9CF1 VA: 0x22B9BF0
	public float get_MoonBloomFilterBoost() { }

	// RVA: 0x22B9C00 Offset: 0x22B9D01 VA: 0x22B9C00
	public void set_MoonBloomFilterBoost(float value) { }

	// RVA: 0x22B9C30 Offset: 0x22B9D31 VA: 0x22B9C30
	public void SetMoonSpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9C70 Offset: 0x22B9D71 VA: 0x22B9C70
	public Vector2 GetMoonSpriteDimensions() { }

	// RVA: 0x22B9CB0 Offset: 0x22B9DB1 VA: 0x22B9CB0
	public int get_MoonSpriteItemCount() { }

	// RVA: 0x22B9CC0 Offset: 0x22B9DC1 VA: 0x22B9CC0
	public void set_MoonSpriteItemCount(int value) { }

	// RVA: 0x22B9CF0 Offset: 0x22B9DF1 VA: 0x22B9CF0
	public float get_MoonSpriteAnimationSpeed() { }

	// RVA: 0x22B9D00 Offset: 0x22B9E01 VA: 0x22B9D00
	public void set_MoonSpriteAnimationSpeed(float value) { }

	// RVA: 0x22B9D30 Offset: 0x22B9E31 VA: 0x22B9D30
	public Texture get_SunTexture() { }

	// RVA: 0x22B9D40 Offset: 0x22B9E41 VA: 0x22B9D40
	public void set_SunTexture(Texture value) { }

	// RVA: 0x22B9D80 Offset: 0x22B9E81 VA: 0x22B9D80
	public Color get_SunColor() { }

	// RVA: 0x22B9DA0 Offset: 0x22B9EA1 VA: 0x22B9DA0
	public void set_SunColor(Color value) { }

	// RVA: 0x22B9DE0 Offset: 0x22B9EE1 VA: 0x22B9DE0
	public float get_SunRotationSpeed() { }

	// RVA: 0x22B9DF0 Offset: 0x22B9EF1 VA: 0x22B9DF0
	public void set_SunRotationSpeed(float value) { }

	// RVA: 0x22B9E20 Offset: 0x22B9F21 VA: 0x22B9E20
	public Vector3 get_SunDirection() { }

	// RVA: 0x22B9E30 Offset: 0x22B9F31 VA: 0x22B9E30
	public void set_SunDirection(Vector3 value) { }

	// RVA: 0x22B9F10 Offset: 0x22BA011 VA: 0x22B9F10
	public Matrix4x4 get_SunWorldToLocalMatrix() { }

	// RVA: 0x22B9F50 Offset: 0x22BA051 VA: 0x22B9F50
	public void set_SunWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x22B9FF0 Offset: 0x22BA0F1 VA: 0x22B9FF0
	public float get_SunSize() { }

	// RVA: 0x22BA000 Offset: 0x22BA101 VA: 0x22BA000
	public void set_SunSize(float value) { }

	// RVA: 0x22BA030 Offset: 0x22BA131 VA: 0x22BA030
	public float get_SunEdgeFeathering() { }

	// RVA: 0x22BA040 Offset: 0x22BA141 VA: 0x22BA040
	public void set_SunEdgeFeathering(float value) { }

	// RVA: 0x22BA070 Offset: 0x22BA171 VA: 0x22BA070
	public float get_SunBloomFilterBoost() { }

	// RVA: 0x22BA080 Offset: 0x22BA181 VA: 0x22BA080
	public void set_SunBloomFilterBoost(float value) { }

	// RVA: 0x22BA0B0 Offset: 0x22BA1B1 VA: 0x22BA0B0
	public void SetSunSpriteDimensions(int columns, int rows) { }

	// RVA: 0x22BA0F0 Offset: 0x22BA1F1 VA: 0x22BA0F0
	public Vector2 GetSunSpriteDimensions() { }

	// RVA: 0x22BA130 Offset: 0x22BA231 VA: 0x22BA130
	public int get_SunSpriteItemCount() { }

	// RVA: 0x22BA140 Offset: 0x22BA241 VA: 0x22BA140
	public void set_SunSpriteItemCount(int value) { }

	// RVA: 0x22BA170 Offset: 0x22BA271 VA: 0x22BA170
	public float get_SunSpriteAnimationSpeed() { }

	// RVA: 0x22BA180 Offset: 0x22BA281 VA: 0x22BA180
	public void set_SunSpriteAnimationSpeed(float value) { }

	// RVA: 0x22BA1B0 Offset: 0x22BA2B1 VA: 0x22BA1B0
	public float get_CloudBegin() { }

	// RVA: 0x22BA1C0 Offset: 0x22BA2C1 VA: 0x22BA1C0
	public void set_CloudBegin(float value) { }

	// RVA: 0x22BA1F0 Offset: 0x22BA2F1 VA: 0x22BA1F0
	public float get_CloudTextureTiling() { }

	// RVA: 0x22BA200 Offset: 0x22BA301 VA: 0x22BA200
	public void set_CloudTextureTiling(float value) { }

	// RVA: 0x22BA230 Offset: 0x22BA331 VA: 0x22BA230
	public float get_Cloud2TextureTiling() { }

	// RVA: 0x22BA240 Offset: 0x22BA341 VA: 0x22BA240
	public void set_Cloud2TextureTiling(float value) { }

	// RVA: 0x22BA270 Offset: 0x22BA371 VA: 0x22BA270
	public Color get_CloudColor() { }

	// RVA: 0x22BA290 Offset: 0x22BA391 VA: 0x22BA290
	public void set_CloudColor(Color value) { }

	// RVA: 0x22BA2D0 Offset: 0x22BA3D1 VA: 0x22BA2D0
	public Texture get_CloudTexture() { }

	// RVA: 0x22BA360 Offset: 0x22BA461 VA: 0x22BA360
	public void set_CloudTexture(Texture value) { }

	// RVA: 0x22BA3A0 Offset: 0x22BA4A1 VA: 0x22BA3A0
	public Texture get_Cloud2Texture() { }

	// RVA: 0x22BA430 Offset: 0x22BA531 VA: 0x22BA430
	public void set_Cloud2Texture(Texture value) { }

	// RVA: 0x22BA470 Offset: 0x22BA571 VA: 0x22BA470
	public Texture get_ArtCloudCustomTexture() { }

	// RVA: 0x22BA500 Offset: 0x22BA601 VA: 0x22BA500
	public void set_ArtCloudCustomTexture(Texture value) { }

	// RVA: 0x22BA540 Offset: 0x22BA641 VA: 0x22BA540
	public float get_CloudDensity() { }

	// RVA: 0x22BA550 Offset: 0x22BA651 VA: 0x22BA550
	public void set_CloudDensity(float value) { }

	// RVA: 0x22BA580 Offset: 0x22BA681 VA: 0x22BA580
	public float get_Cloud2Density() { }

	// RVA: 0x22BA590 Offset: 0x22BA691 VA: 0x22BA590
	public void set_Cloud2Density(float value) { }

	// RVA: 0x22BA5C0 Offset: 0x22BA6C1 VA: 0x22BA5C0
	public float get_CloudSpeed() { }

	// RVA: 0x22BA5D0 Offset: 0x22BA6D1 VA: 0x22BA5D0
	public void set_CloudSpeed(float value) { }

	// RVA: 0x22BA600 Offset: 0x22BA701 VA: 0x22BA600
	public float get_Cloud2Speed() { }

	// RVA: 0x22BA610 Offset: 0x22BA711 VA: 0x22BA610
	public void set_Cloud2Speed(float value) { }

	// RVA: 0x22BA640 Offset: 0x22BA741 VA: 0x22BA640
	public float get_CloudDirection() { }

	// RVA: 0x22BA650 Offset: 0x22BA751 VA: 0x22BA650
	public void set_CloudDirection(float value) { }

	// RVA: 0x22BA680 Offset: 0x22BA781 VA: 0x22BA680
	public float get_Cloud2Direction() { }

	// RVA: 0x22BA690 Offset: 0x22BA791 VA: 0x22BA690
	public void set_Cloud2Direction(float value) { }

	// RVA: 0x22BA6C0 Offset: 0x22BA7C1 VA: 0x22BA6C0
	public float get_CloudHeight() { }

	// RVA: 0x22BA6D0 Offset: 0x22BA7D1 VA: 0x22BA6D0
	public void set_CloudHeight(float value) { }

	// RVA: 0x22BA700 Offset: 0x22BA801 VA: 0x22BA700
	public float get_Cloud2Height() { }

	// RVA: 0x22BA710 Offset: 0x22BA811 VA: 0x22BA710
	public void set_Cloud2Height(float value) { }

	// RVA: 0x22BA740 Offset: 0x22BA841 VA: 0x22BA740
	public Color get_CloudColor1() { }

	// RVA: 0x22BA760 Offset: 0x22BA861 VA: 0x22BA760
	public void set_CloudColor1(Color value) { }

	// RVA: 0x22BA7A0 Offset: 0x22BA8A1 VA: 0x22BA7A0
	public Color get_Cloud2Color1() { }

	// RVA: 0x22BA7C0 Offset: 0x22BA8C1 VA: 0x22BA7C0
	public void set_Cloud2Color1(Color value) { }

	// RVA: 0x22BA800 Offset: 0x22BA901 VA: 0x22BA800
	public Color get_CloudColor2() { }

	// RVA: 0x22BA820 Offset: 0x22BA921 VA: 0x22BA820
	public void set_CloudColor2(Color value) { }

	// RVA: 0x22BA860 Offset: 0x22BA961 VA: 0x22BA860
	public Color get_Cloud2Color2() { }

	// RVA: 0x22BA880 Offset: 0x22BA981 VA: 0x22BA880
	public void set_Cloud2Color2(Color value) { }

	// RVA: 0x22BA8C0 Offset: 0x22BA9C1 VA: 0x22BA8C0
	public float get_CloudFadePosition() { }

	// RVA: 0x22BA8D0 Offset: 0x22BA9D1 VA: 0x22BA8D0
	public void set_CloudFadePosition(float value) { }

	// RVA: 0x22BA900 Offset: 0x22BAA01 VA: 0x22BA900
	public float get_Cloud2FadePosition() { }

	// RVA: 0x22BA910 Offset: 0x22BAA11 VA: 0x22BA910
	public void set_Cloud2FadePosition(float value) { }

	// RVA: 0x22BA940 Offset: 0x22BAA41 VA: 0x22BA940
	public float get_CloudFadeAmount() { }

	// RVA: 0x22BA950 Offset: 0x22BAA51 VA: 0x22BA950
	public void set_CloudFadeAmount(float value) { }

	// RVA: 0x22BA980 Offset: 0x22BAA81 VA: 0x22BA980
	public float get_Cloud2FadeAmount() { }

	// RVA: 0x22BA990 Offset: 0x22BAA91 VA: 0x22BA990
	public void set_Cloud2FadeAmount(float value) { }

	// RVA: 0x22BA9C0 Offset: 0x22BAAC1 VA: 0x22BA9C0
	public Texture get_CloudCubemap() { }

	// RVA: 0x22BA9D0 Offset: 0x22BAAD1 VA: 0x22BA9D0
	public void set_CloudCubemap(Texture value) { }

	// RVA: 0x22BAA10 Offset: 0x22BAB11 VA: 0x22BAA10
	public float get_CloudCubemapRotationSpeed() { }

	// RVA: 0x22BAA20 Offset: 0x22BAB21 VA: 0x22BAA20
	public void set_CloudCubemapRotationSpeed(float value) { }

	// RVA: 0x22BAA50 Offset: 0x22BAB51 VA: 0x22BAA50
	public Texture get_CloudCubemapDoubleLayerCustomTexture() { }

	// RVA: 0x22BAA60 Offset: 0x22BAB61 VA: 0x22BAA60
	public void set_CloudCubemapDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x22BAAA0 Offset: 0x22BABA1 VA: 0x22BAAA0
	public float get_CloudCubemapDoubleLayerRotationSpeed() { }

	// RVA: 0x22BAAB0 Offset: 0x22BABB1 VA: 0x22BAAB0
	public void set_CloudCubemapDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x22BAAE0 Offset: 0x22BABE1 VA: 0x22BAAE0
	public float get_CloudCubemapDoubleLayerHeight() { }

	// RVA: 0x22BAAF0 Offset: 0x22BABF1 VA: 0x22BAAF0
	public void set_CloudCubemapDoubleLayerHeight(float value) { }

	// RVA: 0x22BAB20 Offset: 0x22BAC21 VA: 0x22BAB20
	public Color get_CloudCubemapDoubleLayerTintColor() { }

	// RVA: 0x22BAB40 Offset: 0x22BAC41 VA: 0x22BAB40
	public void set_CloudCubemapDoubleLayerTintColor(Color value) { }

	// RVA: 0x22BAB80 Offset: 0x22BAC81 VA: 0x22BAB80
	public Color get_CloudCubemapTintColor() { }

	// RVA: 0x22BABA0 Offset: 0x22BACA1 VA: 0x22BABA0
	public void set_CloudCubemapTintColor(Color value) { }

	// RVA: 0x22BABE0 Offset: 0x22BACE1 VA: 0x22BABE0
	public float get_CloudCubemapHeight() { }

	// RVA: 0x22BABF0 Offset: 0x22BACF1 VA: 0x22BABF0
	public void set_CloudCubemapHeight(float value) { }

	// RVA: 0x22BAC20 Offset: 0x22BAD21 VA: 0x22BAC20
	public Texture get_CloudCubemapNormalTexture() { }

	// RVA: 0x22BAC30 Offset: 0x22BAD31 VA: 0x22BAC30
	public void set_CloudCubemapNormalTexture(Texture value) { }

	// RVA: 0x22BAC70 Offset: 0x22BAD71 VA: 0x22BAC70
	public Color get_CloudCubemapNormalLitColor() { }

	// RVA: 0x22BAC90 Offset: 0x22BAD91 VA: 0x22BAC90
	public void set_CloudCubemapNormalLitColor(Color value) { }

	// RVA: 0x22BACD0 Offset: 0x22BADD1 VA: 0x22BACD0
	public Color get_CloudCubemapNormalShadowColor() { }

	// RVA: 0x22BACF0 Offset: 0x22BADF1 VA: 0x22BACF0
	public void set_CloudCubemapNormalShadowColor(Color value) { }

	// RVA: 0x22BAD30 Offset: 0x22BAE31 VA: 0x22BAD30
	public float get_CloudCubemapNormalRotationSpeed() { }

	// RVA: 0x22BAD40 Offset: 0x22BAE41 VA: 0x22BAD40
	public void set_CloudCubemapNormalRotationSpeed(float value) { }

	// RVA: 0x22BAD70 Offset: 0x22BAE71 VA: 0x22BAD70
	public float get_CloudCubemapNormalHeight() { }

	// RVA: 0x22BAD80 Offset: 0x22BAE81 VA: 0x22BAD80
	public void set_CloudCubemapNormalHeight(float value) { }

	// RVA: 0x22BADB0 Offset: 0x22BAEB1 VA: 0x22BADB0
	public float get_CloudCubemapNormalAmbientIntensity() { }

	// RVA: 0x22BADC0 Offset: 0x22BAEC1 VA: 0x22BADC0
	public void set_CloudCubemapNormalAmbientIntensity(float value) { }

	// RVA: 0x22BADF0 Offset: 0x22BAEF1 VA: 0x22BADF0
	public Texture get_CloudCubemapNormalDoubleLayerCustomTexture() { }

	// RVA: 0x22BAE00 Offset: 0x22BAF01 VA: 0x22BAE00
	public void set_CloudCubemapNormalDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x22BAE40 Offset: 0x22BAF41 VA: 0x22BAE40
	public float get_CloudCubemapNormalDoubleLayerRotationSpeed() { }

	// RVA: 0x22BAE50 Offset: 0x22BAF51 VA: 0x22BAE50
	public void set_CloudCubemapNormalDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x22BAE80 Offset: 0x22BAF81 VA: 0x22BAE80
	public float get_CloudCubemapNormalDoubleLayerHeight() { }

	// RVA: 0x22BAE90 Offset: 0x22BAF91 VA: 0x22BAE90
	public void set_CloudCubemapNormalDoubleLayerHeight(float value) { }

	// RVA: 0x22BAEC0 Offset: 0x22BAFC1 VA: 0x22BAEC0
	public Color get_CloudCubemapNormalDoubleLayerLitColor() { }

	// RVA: 0x22BAEE0 Offset: 0x22BAFE1 VA: 0x22BAEE0
	public void set_CloudCubemapNormalDoubleLayerLitColor(Color value) { }

	// RVA: 0x22BAF20 Offset: 0x22BB021 VA: 0x22BAF20
	public Color get_CloudCubemapNormalDoubleLayerShadowColor() { }

	// RVA: 0x22BAF40 Offset: 0x22BB041 VA: 0x22BAF40
	public void set_CloudCubemapNormalDoubleLayerShadowColor(Color value) { }

	// RVA: 0x22BAF80 Offset: 0x22BB081 VA: 0x22BAF80
	public Vector3 get_CloudCubemapNormalLightDirection() { }

	// RVA: 0x22BAF90 Offset: 0x22BB091 VA: 0x22BAF90
	public void set_CloudCubemapNormalLightDirection(Vector3 value) { }

	// RVA: 0x22BB050 Offset: 0x22BB151 VA: 0x22BB050
	public Color get_FogColor() { }

	// RVA: 0x22BB070 Offset: 0x22BB171 VA: 0x22BB070
	public void set_FogColor(Color value) { }

	// RVA: 0x22BB0B0 Offset: 0x22BB1B1 VA: 0x22BB0B0
	public float get_FogDensity() { }

	// RVA: 0x22BB0C0 Offset: 0x22BB1C1 VA: 0x22BB0C0
	public void set_FogDensity(float value) { }

	// RVA: 0x22BB0F0 Offset: 0x22BB1F1 VA: 0x22BB0F0
	public float get_FogHeight() { }

	// RVA: 0x22BB100 Offset: 0x22BB201 VA: 0x22BB100
	public void set_FogHeight(float value) { }

	// RVA: 0x22B8970 Offset: 0x22B8A71 VA: 0x22B8970
	private void ApplyGradientValuesOnMaterial() { }

	// RVA: 0x22B8B10 Offset: 0x22B8C11 VA: 0x22B8B10
	private void ApplyStarFadeValuesOnMaterial() { }

	// RVA: 0x22BB130 Offset: 0x22BB231 VA: 0x22BB130
	public void .ctor() { }
}

public class SkyMaterialController // TypeDefIndex: 9676
{
	// Fields
	[SerializeField] // RVA: 0x17D840 Offset: 0x17D941 VA: 0x17D840
	private Material _skyboxMaterial; // 0x10
	[SerializeField] // RVA: 0x17D850 Offset: 0x17D951 VA: 0x17D850
	private Color _skyColor; // 0x18
	[SerializeField] // RVA: 0x17D860 Offset: 0x17D961 VA: 0x17D860
	private Color _skyMiddleColor; // 0x28
	[SerializeField] // RVA: 0x17D870 Offset: 0x17D971 VA: 0x17D870
	private Color _horizonColor; // 0x38
	[SerializeField] // RVA: 0x17D880 Offset: 0x17D981 VA: 0x17D880
	[RangeAttribute] // RVA: 0x17D880 Offset: 0x17D981 VA: 0x17D880
	private float _gradientFadeBegin; // 0x48
	[SerializeField] // RVA: 0x17D8C0 Offset: 0x17D9C1 VA: 0x17D8C0
	[RangeAttribute] // RVA: 0x17D8C0 Offset: 0x17D9C1 VA: 0x17D8C0
	private float _gradientFadeLength; // 0x4C
	[SerializeField] // RVA: 0x17D900 Offset: 0x17DA01 VA: 0x17D900
	[RangeAttribute] // RVA: 0x17D900 Offset: 0x17DA01 VA: 0x17D900
	private float _skyMiddlePosition; // 0x50
	[SerializeField] // RVA: 0x17D940 Offset: 0x17DA41 VA: 0x17D940
	private Cubemap _backgroundCubemap; // 0x58
	[SerializeField] // RVA: 0x17D950 Offset: 0x17DA51 VA: 0x17D950
	[RangeAttribute] // RVA: 0x17D950 Offset: 0x17DA51 VA: 0x17D950
	private float _starFadeBegin; // 0x60
	[SerializeField] // RVA: 0x17D990 Offset: 0x17DA91 VA: 0x17D990
	[RangeAttribute] // RVA: 0x17D990 Offset: 0x17DA91 VA: 0x17D990
	private float _starFadeLength; // 0x64
	[SerializeField] // RVA: 0x17D9D0 Offset: 0x17DAD1 VA: 0x17D9D0
	[RangeAttribute] // RVA: 0x17D9D0 Offset: 0x17DAD1 VA: 0x17D9D0
	private float _horizonDistanceScale; // 0x68
	[SerializeField] // RVA: 0x17DA10 Offset: 0x17DB11 VA: 0x17DA10
	private Texture _starBasicCubemap; // 0x70
	[SerializeField] // RVA: 0x17DA20 Offset: 0x17DB21 VA: 0x17DA20
	private float _starBasicTwinkleSpeed; // 0x78
	[SerializeField] // RVA: 0x17DA30 Offset: 0x17DB31 VA: 0x17DA30
	private float _starBasicTwinkleAmount; // 0x7C
	[SerializeField] // RVA: 0x17DA40 Offset: 0x17DB41 VA: 0x17DA40
	private float _starBasicOpacity; // 0x80
	[SerializeField] // RVA: 0x17DA50 Offset: 0x17DB51 VA: 0x17DA50
	private Color _starBasicTintColor; // 0x84
	[SerializeField] // RVA: 0x17DA60 Offset: 0x17DB61 VA: 0x17DA60
	private float _starBasicExponent; // 0x94
	[SerializeField] // RVA: 0x17DA70 Offset: 0x17DB71 VA: 0x17DA70
	private float _starBasicIntensity; // 0x98
	[SerializeField] // RVA: 0x17DA80 Offset: 0x17DB81 VA: 0x17DA80
	private Texture _starLayer1Texture; // 0xA0
	[SerializeField] // RVA: 0x17DA90 Offset: 0x17DB91 VA: 0x17DA90
	private Texture2D _starLayer1DataTexture; // 0xA8
	[SerializeField] // RVA: 0x17DAA0 Offset: 0x17DBA1 VA: 0x17DAA0
	private Color _starLayer1Color; // 0xB0
	[SerializeField] // RVA: 0x17DAB0 Offset: 0x17DBB1 VA: 0x17DAB0
	[RangeAttribute] // RVA: 0x17DAB0 Offset: 0x17DBB1 VA: 0x17DAB0
	private float _starLayer1MaxRadius; // 0xC0
	[SerializeField] // RVA: 0x17DB00 Offset: 0x17DC01 VA: 0x17DB00
	[RangeAttribute] // RVA: 0x17DB00 Offset: 0x17DC01 VA: 0x17DB00
	private float _starLayer1TwinkleAmount; // 0xC4
	[SerializeField] // RVA: 0x17DB40 Offset: 0x17DC41 VA: 0x17DB40
	[RangeAttribute] // RVA: 0x17DB40 Offset: 0x17DC41 VA: 0x17DB40
	private float _starLayer1TwinkleSpeed; // 0xC8
	[SerializeField] // RVA: 0x17DB80 Offset: 0x17DC81 VA: 0x17DB80
	[RangeAttribute] // RVA: 0x17DB80 Offset: 0x17DC81 VA: 0x17DB80
	private float _starLayer1RotationSpeed; // 0xCC
	[SerializeField] // RVA: 0x17DBC0 Offset: 0x17DCC1 VA: 0x17DBC0
	[RangeAttribute] // RVA: 0x17DBC0 Offset: 0x17DCC1 VA: 0x17DBC0
	private float _starLayer1EdgeFeathering; // 0xD0
	[SerializeField] // RVA: 0x17DC10 Offset: 0x17DD11 VA: 0x17DC10
	[RangeAttribute] // RVA: 0x17DC10 Offset: 0x17DD11 VA: 0x17DC10
	private float _starLayer1BloomFilterBoost; // 0xD4
	[SerializeField] // RVA: 0x17DC50 Offset: 0x17DD51 VA: 0x17DC50
	private Vector4 _starLayer1SpriteDimensions; // 0xD8
	[SerializeField] // RVA: 0x17DC60 Offset: 0x17DD61 VA: 0x17DC60
	private int _starLayer1SpriteItemCount; // 0xE8
	[SerializeField] // RVA: 0x17DC70 Offset: 0x17DD71 VA: 0x17DC70
	[RangeAttribute] // RVA: 0x17DC70 Offset: 0x17DD71 VA: 0x17DC70
	private float _starLayer1SpriteAnimationSpeed; // 0xEC
	[SerializeField] // RVA: 0x17DCB0 Offset: 0x17DDB1 VA: 0x17DCB0
	private Texture _starLayer2Texture; // 0xF0
	[SerializeField] // RVA: 0x17DCC0 Offset: 0x17DDC1 VA: 0x17DCC0
	private Texture2D _starLayer2DataTexture; // 0xF8
	[SerializeField] // RVA: 0x17DCD0 Offset: 0x17DDD1 VA: 0x17DCD0
	private Color _starLayer2Color; // 0x100
	[SerializeField] // RVA: 0x17DCE0 Offset: 0x17DDE1 VA: 0x17DCE0
	[RangeAttribute] // RVA: 0x17DCE0 Offset: 0x17DDE1 VA: 0x17DCE0
	private float _starLayer2MaxRadius; // 0x110
	[SerializeField] // RVA: 0x17DD30 Offset: 0x17DE31 VA: 0x17DD30
	[RangeAttribute] // RVA: 0x17DD30 Offset: 0x17DE31 VA: 0x17DD30
	private float _starLayer2TwinkleAmount; // 0x114
	[SerializeField] // RVA: 0x17DD70 Offset: 0x17DE71 VA: 0x17DD70
	[RangeAttribute] // RVA: 0x17DD70 Offset: 0x17DE71 VA: 0x17DD70
	private float _starLayer2TwinkleSpeed; // 0x118
	[SerializeField] // RVA: 0x17DDB0 Offset: 0x17DEB1 VA: 0x17DDB0
	[RangeAttribute] // RVA: 0x17DDB0 Offset: 0x17DEB1 VA: 0x17DDB0
	private float _starLayer2RotationSpeed; // 0x11C
	[SerializeField] // RVA: 0x17DDF0 Offset: 0x17DEF1 VA: 0x17DDF0
	[RangeAttribute] // RVA: 0x17DDF0 Offset: 0x17DEF1 VA: 0x17DDF0
	private float _starLayer2EdgeFeathering; // 0x120
	[SerializeField] // RVA: 0x17DE40 Offset: 0x17DF41 VA: 0x17DE40
	[RangeAttribute] // RVA: 0x17DE40 Offset: 0x17DF41 VA: 0x17DE40
	private float _starLayer2BloomFilterBoost; // 0x124
	[SerializeField] // RVA: 0x17DE80 Offset: 0x17DF81 VA: 0x17DE80
	private Vector4 _starLayer2SpriteDimensions; // 0x128
	[SerializeField] // RVA: 0x17DE90 Offset: 0x17DF91 VA: 0x17DE90
	private int _starLayer2SpriteItemCount; // 0x138
	[SerializeField] // RVA: 0x17DEA0 Offset: 0x17DFA1 VA: 0x17DEA0
	[RangeAttribute] // RVA: 0x17DEA0 Offset: 0x17DFA1 VA: 0x17DEA0
	private float _starLayer2SpriteAnimationSpeed; // 0x13C
	[SerializeField] // RVA: 0x17DEE0 Offset: 0x17DFE1 VA: 0x17DEE0
	private Texture _starLayer3Texture; // 0x140
	[SerializeField] // RVA: 0x17DEF0 Offset: 0x17DFF1 VA: 0x17DEF0
	private Texture2D _starLayer3DataTexture; // 0x148
	[SerializeField] // RVA: 0x17DF00 Offset: 0x17E001 VA: 0x17DF00
	private Color _starLayer3Color; // 0x150
	[SerializeField] // RVA: 0x17DF10 Offset: 0x17E011 VA: 0x17DF10
	[RangeAttribute] // RVA: 0x17DF10 Offset: 0x17E011 VA: 0x17DF10
	private float _starLayer3MaxRadius; // 0x160
	[SerializeField] // RVA: 0x17DF60 Offset: 0x17E061 VA: 0x17DF60
	[RangeAttribute] // RVA: 0x17DF60 Offset: 0x17E061 VA: 0x17DF60
	private float _starLayer3TwinkleAmount; // 0x164
	[SerializeField] // RVA: 0x17DFA0 Offset: 0x17E0A1 VA: 0x17DFA0
	[RangeAttribute] // RVA: 0x17DFA0 Offset: 0x17E0A1 VA: 0x17DFA0
	private float _starLayer3TwinkleSpeed; // 0x168
	[SerializeField] // RVA: 0x17DFE0 Offset: 0x17E0E1 VA: 0x17DFE0
	[RangeAttribute] // RVA: 0x17DFE0 Offset: 0x17E0E1 VA: 0x17DFE0
	private float _starLayer3RotationSpeed; // 0x16C
	[SerializeField] // RVA: 0x17E020 Offset: 0x17E121 VA: 0x17E020
	[RangeAttribute] // RVA: 0x17E020 Offset: 0x17E121 VA: 0x17E020
	private float _starLayer3EdgeFeathering; // 0x170
	[SerializeField] // RVA: 0x17E070 Offset: 0x17E171 VA: 0x17E070
	[RangeAttribute] // RVA: 0x17E070 Offset: 0x17E171 VA: 0x17E070
	private float _starLayer3BloomFilterBoost; // 0x174
	[SerializeField] // RVA: 0x17E0B0 Offset: 0x17E1B1 VA: 0x17E0B0
	private Vector4 _starLayer3SpriteDimensions; // 0x178
	[SerializeField] // RVA: 0x17E0C0 Offset: 0x17E1C1 VA: 0x17E0C0
	private int _starLayer3SpriteItemCount; // 0x188
	[SerializeField] // RVA: 0x17E0D0 Offset: 0x17E1D1 VA: 0x17E0D0
	[RangeAttribute] // RVA: 0x17E0D0 Offset: 0x17E1D1 VA: 0x17E0D0
	private float _starLayer3SpriteAnimationSpeed; // 0x18C
	[SerializeField] // RVA: 0x17E110 Offset: 0x17E211 VA: 0x17E110
	private Texture _moonTexture; // 0x190
	[SerializeField] // RVA: 0x17E120 Offset: 0x17E221 VA: 0x17E120
	private float _moonRotationSpeed; // 0x198
	[SerializeField] // RVA: 0x17E130 Offset: 0x17E231 VA: 0x17E130
	private Color _moonColor; // 0x19C
	[SerializeField] // RVA: 0x17E140 Offset: 0x17E241 VA: 0x17E140
	private Vector3 _moonDirection; // 0x1AC
	[SerializeField] // RVA: 0x17E150 Offset: 0x17E251 VA: 0x17E150
	private Matrix4x4 _moonWorldToLocalMatrix; // 0x1B8
	[SerializeField] // RVA: 0x17E160 Offset: 0x17E261 VA: 0x17E160
	[RangeAttribute] // RVA: 0x17E160 Offset: 0x17E261 VA: 0x17E160
	private float _moonSize; // 0x1F8
	[SerializeField] // RVA: 0x17E1A0 Offset: 0x17E2A1 VA: 0x17E1A0
	[RangeAttribute] // RVA: 0x17E1A0 Offset: 0x17E2A1 VA: 0x17E1A0
	private float _moonEdgeFeathering; // 0x1FC
	[SerializeField] // RVA: 0x17E1F0 Offset: 0x17E2F1 VA: 0x17E1F0
	[RangeAttribute] // RVA: 0x17E1F0 Offset: 0x17E2F1 VA: 0x17E1F0
	private float _moonBloomFilterBoost; // 0x200
	[SerializeField] // RVA: 0x17E230 Offset: 0x17E331 VA: 0x17E230
	private Vector4 _moonSpriteDimensions; // 0x204
	[SerializeField] // RVA: 0x17E240 Offset: 0x17E341 VA: 0x17E240
	private int _moonSpriteItemCount; // 0x214
	[SerializeField] // RVA: 0x17E250 Offset: 0x17E351 VA: 0x17E250
	[RangeAttribute] // RVA: 0x17E250 Offset: 0x17E351 VA: 0x17E250
	private float _moonSpriteAnimationSpeed; // 0x218
	[SerializeField] // RVA: 0x17E290 Offset: 0x17E391 VA: 0x17E290
	private Texture _sunTexture; // 0x220
	[SerializeField] // RVA: 0x17E2A0 Offset: 0x17E3A1 VA: 0x17E2A0
	private Color _sunColor; // 0x228
	[SerializeField] // RVA: 0x17E2B0 Offset: 0x17E3B1 VA: 0x17E2B0
	private float _sunRotationSpeed; // 0x238
	[SerializeField] // RVA: 0x17E2C0 Offset: 0x17E3C1 VA: 0x17E2C0
	private Vector3 _sunDirection; // 0x23C
	[SerializeField] // RVA: 0x17E2D0 Offset: 0x17E3D1 VA: 0x17E2D0
	private Matrix4x4 _sunWorldToLocalMatrix; // 0x248
	[SerializeField] // RVA: 0x17E2E0 Offset: 0x17E3E1 VA: 0x17E2E0
	[RangeAttribute] // RVA: 0x17E2E0 Offset: 0x17E3E1 VA: 0x17E2E0
	private float _sunSize; // 0x288
	[SerializeField] // RVA: 0x17E320 Offset: 0x17E421 VA: 0x17E320
	[RangeAttribute] // RVA: 0x17E320 Offset: 0x17E421 VA: 0x17E320
	private float _sunEdgeFeathering; // 0x28C
	[SerializeField] // RVA: 0x17E370 Offset: 0x17E471 VA: 0x17E370
	[RangeAttribute] // RVA: 0x17E370 Offset: 0x17E471 VA: 0x17E370
	private float _sunBloomFilterBoost; // 0x290
	[SerializeField] // RVA: 0x17E3B0 Offset: 0x17E4B1 VA: 0x17E3B0
	private Vector4 _sunSpriteDimensions; // 0x294
	[SerializeField] // RVA: 0x17E3C0 Offset: 0x17E4C1 VA: 0x17E3C0
	private int _sunSpriteItemCount; // 0x2A4
	[SerializeField] // RVA: 0x17E3D0 Offset: 0x17E4D1 VA: 0x17E3D0
	[RangeAttribute] // RVA: 0x17E3D0 Offset: 0x17E4D1 VA: 0x17E3D0
	private float _sunSpriteAnimationSpeed; // 0x2A8
	[SerializeField] // RVA: 0x17E410 Offset: 0x17E511 VA: 0x17E410
	[RangeAttribute] // RVA: 0x17E410 Offset: 0x17E511 VA: 0x17E410
	private float _cloudBegin; // 0x2AC
	private float _cloudTextureTiling; // 0x2B0
	private float _cloud2TextureTiling; // 0x2B4
	[SerializeField] // RVA: 0x17E450 Offset: 0x17E551 VA: 0x17E450
	private Color _cloudColor; // 0x2B8
	[SerializeField] // RVA: 0x17E460 Offset: 0x17E561 VA: 0x17E460
	private Texture _cloudTexture; // 0x2C8
	[SerializeField] // RVA: 0x17E470 Offset: 0x17E571 VA: 0x17E470
	private Texture _cloud2Texture; // 0x2D0
	[SerializeField] // RVA: 0x17E480 Offset: 0x17E581 VA: 0x17E480
	private Texture _artCloudCustomTexture; // 0x2D8
	[SerializeField] // RVA: 0x17E490 Offset: 0x17E591 VA: 0x17E490
	private float _cloudDensity; // 0x2E0
	[SerializeField] // RVA: 0x17E4A0 Offset: 0x17E5A1 VA: 0x17E4A0
	private float _cloud2Density; // 0x2E4
	[SerializeField] // RVA: 0x17E4B0 Offset: 0x17E5B1 VA: 0x17E4B0
	private float _cloudSpeed; // 0x2E8
	[SerializeField] // RVA: 0x17E4C0 Offset: 0x17E5C1 VA: 0x17E4C0
	private float _cloud2Speed; // 0x2EC
	[SerializeField] // RVA: 0x17E4D0 Offset: 0x17E5D1 VA: 0x17E4D0
	private float _cloudDirection; // 0x2F0
	[SerializeField] // RVA: 0x17E4E0 Offset: 0x17E5E1 VA: 0x17E4E0
	private float _cloud2Direction; // 0x2F4
	[SerializeField] // RVA: 0x17E4F0 Offset: 0x17E5F1 VA: 0x17E4F0
	private float _cloudHeight; // 0x2F8
	[SerializeField] // RVA: 0x17E500 Offset: 0x17E601 VA: 0x17E500
	private float _cloud2Height; // 0x2FC
	[SerializeField] // RVA: 0x17E510 Offset: 0x17E611 VA: 0x17E510
	private Color _cloudColor1; // 0x300
	[SerializeField] // RVA: 0x17E520 Offset: 0x17E621 VA: 0x17E520
	private Color _cloud2Color1; // 0x310
	[SerializeField] // RVA: 0x17E530 Offset: 0x17E631 VA: 0x17E530
	private Color _cloudColor2; // 0x320
	[SerializeField] // RVA: 0x17E540 Offset: 0x17E641 VA: 0x17E540
	private Color _cloud2Color2; // 0x330
	[SerializeField] // RVA: 0x17E550 Offset: 0x17E651 VA: 0x17E550
	private float _cloudFadePosition; // 0x340
	[SerializeField] // RVA: 0x17E560 Offset: 0x17E661 VA: 0x17E560
	private float _cloud2FadePosition; // 0x344
	[SerializeField] // RVA: 0x17E570 Offset: 0x17E671 VA: 0x17E570
	private float _cloudFadeAmount; // 0x348
	[SerializeField] // RVA: 0x17E580 Offset: 0x17E681 VA: 0x17E580
	private float _cloud2FadeAmount; // 0x34C
	[SerializeField] // RVA: 0x17E590 Offset: 0x17E691 VA: 0x17E590
	private Texture _cloudCubemap; // 0x350
	[SerializeField] // RVA: 0x17E5A0 Offset: 0x17E6A1 VA: 0x17E5A0
	private float _cloudCubemapRotationSpeed; // 0x358
	[SerializeField] // RVA: 0x17E5B0 Offset: 0x17E6B1 VA: 0x17E5B0
	private Texture _cloudCubemapDoubleLayerCustomTexture; // 0x360
	[SerializeField] // RVA: 0x17E5C0 Offset: 0x17E6C1 VA: 0x17E5C0
	private float _cloudCubemapDoubleLayerRotationSpeed; // 0x368
	[SerializeField] // RVA: 0x17E5D0 Offset: 0x17E6D1 VA: 0x17E5D0
	private float _cloudCubemapDoubleLayerHeight; // 0x36C
	[SerializeField] // RVA: 0x17E5E0 Offset: 0x17E6E1 VA: 0x17E5E0
	private Color _cloudCubemapDoubleLayerTintColor; // 0x370
	[SerializeField] // RVA: 0x17E5F0 Offset: 0x17E6F1 VA: 0x17E5F0
	private Color _cloudCubemapTintColor; // 0x380
	[SerializeField] // RVA: 0x17E600 Offset: 0x17E701 VA: 0x17E600
	private float _cloudCubemapHeight; // 0x390
	[SerializeField] // RVA: 0x17E610 Offset: 0x17E711 VA: 0x17E610
	private Texture _cloudCubemapNormalTexture; // 0x398
	[SerializeField] // RVA: 0x17E620 Offset: 0x17E721 VA: 0x17E620
	private Color _cloudCubemapNormalLitColor; // 0x3A0
	[SerializeField] // RVA: 0x17E630 Offset: 0x17E731 VA: 0x17E630
	private Color _cloudCubemapNormalShadowColor; // 0x3B0
	[SerializeField] // RVA: 0x17E640 Offset: 0x17E741 VA: 0x17E640
	private float _cloudCubemapNormalRotationSpeed; // 0x3C0
	[SerializeField] // RVA: 0x17E650 Offset: 0x17E751 VA: 0x17E650
	private float _cloudCubemapNormalHeight; // 0x3C4
	[SerializeField] // RVA: 0x17E660 Offset: 0x17E761 VA: 0x17E660
	private float _cloudCubemapNormalAmbientItensity; // 0x3C8
	[SerializeField] // RVA: 0x17E670 Offset: 0x17E771 VA: 0x17E670
	private Texture _cloudCubemapNormalDoubleLayerCustomTexture; // 0x3D0
	[SerializeField] // RVA: 0x17E680 Offset: 0x17E781 VA: 0x17E680
	private float _cloudCubemapNormalDoubleLayerRotationSpeed; // 0x3D8
	[SerializeField] // RVA: 0x17E690 Offset: 0x17E791 VA: 0x17E690
	private float _cloudCubemapNormalDoubleLayerHeight; // 0x3DC
	[SerializeField] // RVA: 0x17E6A0 Offset: 0x17E7A1 VA: 0x17E6A0
	private Color _cloudCubemapNormalDoubleLayerLitColor; // 0x3E0
	[SerializeField] // RVA: 0x17E6B0 Offset: 0x17E7B1 VA: 0x17E6B0
	private Color _cloudCubemapNormalDoubleLayerShadowColor; // 0x3F0
	[SerializeField] // RVA: 0x17E6C0 Offset: 0x17E7C1 VA: 0x17E6C0
	private Vector3 _cloudCubemapNormalLightDirection; // 0x400
	[SerializeField] // RVA: 0x17E6D0 Offset: 0x17E7D1 VA: 0x17E6D0
	private Color _fogColor; // 0x40C
	[SerializeField] // RVA: 0x17E6E0 Offset: 0x17E7E1 VA: 0x17E6E0
	private float _fogDensity; // 0x41C
	[SerializeField] // RVA: 0x17E6F0 Offset: 0x17E7F1 VA: 0x17E6F0
	private float _fogHeight; // 0x420
	private int _GradientSkyUpperColorId; // 0x424
	private int _GradientSkyMiddleColorId; // 0x428
	private int _GradientSkyLowerColorId; // 0x42C
	private int _GradientFadeMiddlePositionId; // 0x430
	private int _MainTexId; // 0x434
	private int _HorizonScaleFactorId; // 0x438
	private int _StarBasicCubemapId; // 0x43C
	private int _StarBasicTwinkleSpeedId; // 0x440
	private int _StarBasicTwinkleAmountId; // 0x444
	private int _StarBasicOpacityId; // 0x448
	private int _StarBasicTintColorId; // 0x44C
	private int _StarBasicExponentId; // 0x450
	private int _StarBasicHDRBoostId; // 0x454
	private int _StarLayer1TexId; // 0x458
	private int _StarLayer1DataTexId; // 0x45C
	private int _StarLayer1ColorId; // 0x460
	private int _StarLayer1MaxRadiusId; // 0x464
	private int _StarLayer1TwinkleAmountId; // 0x468
	private int _StarLayer1TwinkleSpeedId; // 0x46C
	private int _StarLayer1RotationSpeedId; // 0x470
	private int _StarLayer1EdgeFadeId; // 0x474
	private int _StarLayer1HDRBoostId; // 0x478
	private int _StarLayer1SpriteDimensionsId; // 0x47C
	private int _StarLayer1SpriteItemCountId; // 0x480
	private int _StarLayer1SpriteAnimationSpeedId; // 0x484
	private int _StarLayer2TexId; // 0x488
	private int _StarLayer2DataTexId; // 0x48C
	private int _StarLayer2ColorId; // 0x490
	private int _StarLayer2MaxRadiusId; // 0x494
	private int _StarLayer2TwinkleAmountId; // 0x498
	private int _StarLayer2TwinkleSpeedId; // 0x49C
	private int _StarLayer2RotationSpeedId; // 0x4A0
	private int _StarLayer2EdgeFadeId; // 0x4A4
	private int _StarLayer2HDRBoostId; // 0x4A8
	private int _StarLayer2SpriteDimensionsId; // 0x4AC
	private int _StarLayer2SpriteItemCountId; // 0x4B0
	private int _StarLayer2SpriteAnimationSpeedId; // 0x4B4
	private int _StarLayer3TexId; // 0x4B8
	private int _StarLayer3DataTexId; // 0x4BC
	private int _StarLayer3ColorId; // 0x4C0
	private int _StarLayer3MaxRadiusId; // 0x4C4
	private int _StarLayer3TwinkleAmountId; // 0x4C8
	private int _StarLayer3TwinkleSpeedId; // 0x4CC
	private int _StarLayer3RotationSpeedId; // 0x4D0
	private int _StarLayer3EdgeFadeId; // 0x4D4
	private int _StarLayer3HDRBoostId; // 0x4D8
	private int _StarLayer3SpriteDimensionsId; // 0x4DC
	private int _StarLayer3SpriteItemCountId; // 0x4E0
	private int _StarLayer3SpriteAnimationSpeedId; // 0x4E4
	private int _MoonTexId; // 0x4E8
	private int _MoonRotationSpeedId; // 0x4EC
	private int _MoonColorId; // 0x4F0
	private int _MoonPositionId; // 0x4F4
	private int _MoonWorldToLocalMatId; // 0x4F8
	private int _MoonRadiusId; // 0x4FC
	private int _MoonEdgeFadeId; // 0x500
	private int _MoonHDRBoostId; // 0x504
	private int _MoonSpriteDimensionsId; // 0x508
	private int _MoonSpriteItemCountId; // 0x50C
	private int _MoonSpriteAnimationSpeedId; // 0x510
	private int _SunTexId; // 0x514
	private int _SunColorId; // 0x518
	private int _SunRotationSpeedId; // 0x51C
	private int _SunPositionId; // 0x520
	private int _SunWorldToLocalMatId; // 0x524
	private int _SunRadiusId; // 0x528
	private int _SunEdgeFadeId; // 0x52C
	private int _SunHDRBoostId; // 0x530
	private int _SunSpriteDimensionsId; // 0x534
	private int _SunSpriteItemCountId; // 0x538
	private int _SunSpriteAnimationSpeedId; // 0x53C
	private int _CloudBeginId; // 0x540
	private int _CloudTextureTilingId; // 0x544
	private int _Cloud2TextureTilingId; // 0x548
	private int _CloudColorId; // 0x54C
	private int _CloudNoiseTextureId; // 0x550
	private int _Cloud2NoiseTextureId; // 0x554
	private int _ArtCloudCustomTextureId; // 0x558
	private int _CloudDensityId; // 0x55C
	private int _Cloud2DensityId; // 0x560
	private int _CloudSpeedId; // 0x564
	private int _Cloud2SpeedId; // 0x568
	private int _CloudDirectionId; // 0x56C
	private int _Cloud2DirectionId; // 0x570
	private int _CloudHeightId; // 0x574
	private int _Cloud2HeightId; // 0x578
	private int _CloudColor1Id; // 0x57C
	private int _Cloud2Color1Id; // 0x580
	private int _CloudColor2Id; // 0x584
	private int _Cloud2Color2Id; // 0x588
	private int _CloudFadePositionId; // 0x58C
	private int _Cloud2FadePositionId; // 0x590
	private int _CloudFadeAmountId; // 0x594
	private int _Cloud2FadeAmountId; // 0x598
	private int _CloudCubemapTextureId; // 0x59C
	private int _CloudCubemapRotationSpeedId; // 0x5A0
	private int _CloudCubemapDoubleTextureId; // 0x5A4
	private int _CloudCubemapDoubleLayerRotationSpeedId; // 0x5A8
	private int _CloudCubemapDoubleLayerHeightId; // 0x5AC
	private int _CloudCubemapDoubleLayerTintColorId; // 0x5B0
	private int _CloudCubemapTintColorId; // 0x5B4
	private int _CloudCubemapHeightId; // 0x5B8
	private int _CloudCubemapNormalTextureId; // 0x5BC
	private int _CloudCubemapNormalLitColorId; // 0x5C0
	private int _CloudCubemapNormalShadowColorId; // 0x5C4
	private int _CloudCubemapNormalRotationSpeedId; // 0x5C8
	private int _CloudCubemapNormalHeightId; // 0x5CC
	private int _CloudCubemapNormalAmbientIntensityId; // 0x5D0
	private int _CloudCubemapNormalDoubleTextureId; // 0x5D4
	private int _CloudCubemapNormalDoubleLayerRotationSpeedId; // 0x5D8
	private int _CloudCubemapNormalDoubleLayerHeightId; // 0x5DC
	private int _CloudCubemapNormalDoubleLitColorId; // 0x5E0
	private int _CloudCubemapNormalDoubleShadowColorId; // 0x5E4
	private int _CloudCubemapNormalToLightId; // 0x5E8
	private int _HorizonFogColorId; // 0x5EC
	private int _HorizonFogDensityId; // 0x5F0
	private int _HorizonFogLengthId; // 0x5F4
	private int _GradientFadeBeginId; // 0x5F8
	private int _GradientFadeEndId; // 0x5FC
	private int _StarFadeBeginId; // 0x600
	private int _StarFadeEndId; // 0x604

	// Properties
	public Material SkyboxMaterial { get; set; }
	public Color SkyColor { get; set; }
	public Color SkyMiddleColor { get; set; }
	public Color HorizonColor { get; set; }
	public float GradientFadeBegin { get; set; }
	public float GradientFadeLength { get; set; }
	public float SkyMiddlePosition { get; set; }
	public Cubemap BackgroundCubemap { get; set; }
	public float StarFadeBegin { get; set; }
	public float StarFadeLength { get; set; }
	public float HorizonDistanceScale { get; set; }
	public Texture StarBasicCubemap { get; set; }
	public float StarBasicTwinkleSpeed { get; set; }
	public float StarBasicTwinkleAmount { get; set; }
	public float StarBasicOpacity { get; set; }
	public Color StarBasicTintColor { get; set; }
	public float StarBasicExponent { get; set; }
	public float StarBasicIntensity { get; set; }
	public Texture StarLayer1Texture { get; set; }
	public Texture2D StarLayer1DataTexture { get; set; }
	public Color StarLayer1Color { get; set; }
	public float StarLayer1MaxRadius { get; set; }
	public float StarLayer1TwinkleAmount { get; set; }
	public float StarLayer1TwinkleSpeed { get; set; }
	public float StarLayer1RotationSpeed { get; set; }
	public float StarLayer1EdgeFeathering { get; set; }
	public float StarLayer1BloomFilterBoost { get; set; }
	public int StarLayer1SpriteItemCount { get; set; }
	public float StarLayer1SpriteAnimationSpeed { get; set; }
	public Texture StarLayer2Texture { get; set; }
	public Texture2D StarLayer2DataTexture { get; set; }
	public Color StarLayer2Color { get; set; }
	public float StarLayer2MaxRadius { get; set; }
	public float StarLayer2TwinkleAmount { get; set; }
	public float StarLayer2TwinkleSpeed { get; set; }
	public float StarLayer2RotationSpeed { get; set; }
	public float StarLayer2EdgeFeathering { get; set; }
	public float StarLayer2BloomFilterBoost { get; set; }
	public int StarLayer2SpriteItemCount { get; set; }
	public float StarLayer2SpriteAnimationSpeed { get; set; }
	public Texture StarLayer3Texture { get; set; }
	public Texture2D StarLayer3DataTexture { get; set; }
	public Color StarLayer3Color { get; set; }
	public float StarLayer3MaxRadius { get; set; }
	public float StarLayer3TwinkleAmount { get; set; }
	public float StarLayer3TwinkleSpeed { get; set; }
	public float StarLayer3RotationSpeed { get; set; }
	public float StarLayer3EdgeFeathering { get; set; }
	public float StarLayer3BloomFilterBoost { get; set; }
	public int StarLayer3SpriteItemCount { get; set; }
	public float StarLayer3SpriteAnimationSpeed { get; set; }
	public Texture MoonTexture { get; set; }
	public float MoonRotationSpeed { get; set; }
	public Color MoonColor { get; set; }
	public Vector3 MoonDirection { get; set; }
	public Matrix4x4 MoonWorldToLocalMatrix { get; set; }
	public float MoonSize { get; set; }
	public float MoonEdgeFeathering { get; set; }
	public float MoonBloomFilterBoost { get; set; }
	public int MoonSpriteItemCount { get; set; }
	public float MoonSpriteAnimationSpeed { get; set; }
	public Texture SunTexture { get; set; }
	public Color SunColor { get; set; }
	public float SunRotationSpeed { get; set; }
	public Vector3 SunDirection { get; set; }
	public Matrix4x4 SunWorldToLocalMatrix { get; set; }
	public float SunSize { get; set; }
	public float SunEdgeFeathering { get; set; }
	public float SunBloomFilterBoost { get; set; }
	public int SunSpriteItemCount { get; set; }
	public float SunSpriteAnimationSpeed { get; set; }
	public float CloudBegin { get; set; }
	public float CloudTextureTiling { get; set; }
	public float Cloud2TextureTiling { get; set; }
	public Color CloudColor { get; set; }
	public Texture CloudTexture { get; set; }
	public Texture Cloud2Texture { get; set; }
	public Texture ArtCloudCustomTexture { get; set; }
	public float CloudDensity { get; set; }
	public float Cloud2Density { get; set; }
	public float CloudSpeed { get; set; }
	public float Cloud2Speed { get; set; }
	public float CloudDirection { get; set; }
	public float Cloud2Direction { get; set; }
	public float CloudHeight { get; set; }
	public float Cloud2Height { get; set; }
	public Color CloudColor1 { get; set; }
	public Color Cloud2Color1 { get; set; }
	public Color CloudColor2 { get; set; }
	public Color Cloud2Color2 { get; set; }
	public float CloudFadePosition { get; set; }
	public float Cloud2FadePosition { get; set; }
	public float CloudFadeAmount { get; set; }
	public float Cloud2FadeAmount { get; set; }
	public Texture CloudCubemap { get; set; }
	public float CloudCubemapRotationSpeed { get; set; }
	public Texture CloudCubemapDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapDoubleLayerHeight { get; set; }
	public Color CloudCubemapDoubleLayerTintColor { get; set; }
	public Color CloudCubemapTintColor { get; set; }
	public float CloudCubemapHeight { get; set; }
	public Texture CloudCubemapNormalTexture { get; set; }
	public Color CloudCubemapNormalLitColor { get; set; }
	public Color CloudCubemapNormalShadowColor { get; set; }
	public float CloudCubemapNormalRotationSpeed { get; set; }
	public float CloudCubemapNormalHeight { get; set; }
	public float CloudCubemapNormalAmbientIntensity { get; set; }
	public Texture CloudCubemapNormalDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapNormalDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapNormalDoubleLayerHeight { get; set; }
	public Color CloudCubemapNormalDoubleLayerLitColor { get; set; }
	public Color CloudCubemapNormalDoubleLayerShadowColor { get; set; }
	public Vector3 CloudCubemapNormalLightDirection { get; set; }
	public Color FogColor { get; set; }
	public float FogDensity { get; set; }
	public float FogHeight { get; set; }

	// Methods

	// RVA: 0x22B8820 Offset: 0x22B8921 VA: 0x22B8820
	public Material get_SkyboxMaterial() { }

	// RVA: 0x22B8830 Offset: 0x22B8931 VA: 0x22B8830
	public void set_SkyboxMaterial(Material value) { }

	// RVA: 0x22B8860 Offset: 0x22B8961 VA: 0x22B8860
	public Color get_SkyColor() { }

	// RVA: 0x22B8870 Offset: 0x22B8971 VA: 0x22B8870
	public void set_SkyColor(Color value) { }

	// RVA: 0x22B88B0 Offset: 0x22B89B1 VA: 0x22B88B0
	public Color get_SkyMiddleColor() { }

	// RVA: 0x22B88C0 Offset: 0x22B89C1 VA: 0x22B88C0
	public void set_SkyMiddleColor(Color value) { }

	// RVA: 0x22B8900 Offset: 0x22B8A01 VA: 0x22B8900
	public Color get_HorizonColor() { }

	// RVA: 0x22B8910 Offset: 0x22B8A11 VA: 0x22B8910
	public void set_HorizonColor(Color value) { }

	// RVA: 0x22B8950 Offset: 0x22B8A51 VA: 0x22B8950
	public float get_GradientFadeBegin() { }

	// RVA: 0x22B8960 Offset: 0x22B8A61 VA: 0x22B8960
	public void set_GradientFadeBegin(float value) { }

	// RVA: 0x22B8A30 Offset: 0x22B8B31 VA: 0x22B8A30
	public float get_GradientFadeLength() { }

	// RVA: 0x22B8A40 Offset: 0x22B8B41 VA: 0x22B8A40
	public void set_GradientFadeLength(float value) { }

	// RVA: 0x22B8A50 Offset: 0x22B8B51 VA: 0x22B8A50
	public float get_SkyMiddlePosition() { }

	// RVA: 0x22B8A60 Offset: 0x22B8B61 VA: 0x22B8A60
	public void set_SkyMiddlePosition(float value) { }

	// RVA: 0x22B8A90 Offset: 0x22B8B91 VA: 0x22B8A90
	public Cubemap get_BackgroundCubemap() { }

	// RVA: 0x22B8AA0 Offset: 0x22B8BA1 VA: 0x22B8AA0
	public void set_BackgroundCubemap(Cubemap value) { }

	// RVA: 0x22B8AF0 Offset: 0x22B8BF1 VA: 0x22B8AF0
	public float get_StarFadeBegin() { }

	// RVA: 0x22B8B00 Offset: 0x22B8C01 VA: 0x22B8B00
	public void set_StarFadeBegin(float value) { }

	// RVA: 0x22B8BD0 Offset: 0x22B8CD1 VA: 0x22B8BD0
	public float get_StarFadeLength() { }

	// RVA: 0x22B8BE0 Offset: 0x22B8CE1 VA: 0x22B8BE0
	public void set_StarFadeLength(float value) { }

	// RVA: 0x22B8BF0 Offset: 0x22B8CF1 VA: 0x22B8BF0
	public float get_HorizonDistanceScale() { }

	// RVA: 0x22B8C00 Offset: 0x22B8D01 VA: 0x22B8C00
	public void set_HorizonDistanceScale(float value) { }

	// RVA: 0x22B8C30 Offset: 0x22B8D31 VA: 0x22B8C30
	public Texture get_StarBasicCubemap() { }

	// RVA: 0x22B8C40 Offset: 0x22B8D41 VA: 0x22B8C40
	public void set_StarBasicCubemap(Texture value) { }

	// RVA: 0x22B8C90 Offset: 0x22B8D91 VA: 0x22B8C90
	public float get_StarBasicTwinkleSpeed() { }

	// RVA: 0x22B8CA0 Offset: 0x22B8DA1 VA: 0x22B8CA0
	public void set_StarBasicTwinkleSpeed(float value) { }

	// RVA: 0x22B8CD0 Offset: 0x22B8DD1 VA: 0x22B8CD0
	public float get_StarBasicTwinkleAmount() { }

	// RVA: 0x22B8CE0 Offset: 0x22B8DE1 VA: 0x22B8CE0
	public void set_StarBasicTwinkleAmount(float value) { }

	// RVA: 0x22B8D10 Offset: 0x22B8E11 VA: 0x22B8D10
	public float get_StarBasicOpacity() { }

	// RVA: 0x22B8D20 Offset: 0x22B8E21 VA: 0x22B8D20
	public void set_StarBasicOpacity(float value) { }

	// RVA: 0x22B8D50 Offset: 0x22B8E51 VA: 0x22B8D50
	public Color get_StarBasicTintColor() { }

	// RVA: 0x22B8D60 Offset: 0x22B8E61 VA: 0x22B8D60
	public void set_StarBasicTintColor(Color value) { }

	// RVA: 0x22B8DA0 Offset: 0x22B8EA1 VA: 0x22B8DA0
	public float get_StarBasicExponent() { }

	// RVA: 0x22B8DB0 Offset: 0x22B8EB1 VA: 0x22B8DB0
	public void set_StarBasicExponent(float value) { }

	// RVA: 0x22B8DE0 Offset: 0x22B8EE1 VA: 0x22B8DE0
	public float get_StarBasicIntensity() { }

	// RVA: 0x22B8DF0 Offset: 0x22B8EF1 VA: 0x22B8DF0
	public void set_StarBasicIntensity(float value) { }

	// RVA: 0x22B8E20 Offset: 0x22B8F21 VA: 0x22B8E20
	public Texture get_StarLayer1Texture() { }

	// RVA: 0x22B8E30 Offset: 0x22B8F31 VA: 0x22B8E30
	public void set_StarLayer1Texture(Texture value) { }

	// RVA: 0x22B8E80 Offset: 0x22B8F81 VA: 0x22B8E80
	public Texture2D get_StarLayer1DataTexture() { }

	// RVA: 0x22B8E90 Offset: 0x22B8F91 VA: 0x22B8E90
	public void set_StarLayer1DataTexture(Texture2D value) { }

	// RVA: 0x22B8EE0 Offset: 0x22B8FE1 VA: 0x22B8EE0
	public Color get_StarLayer1Color() { }

	// RVA: 0x22B8EF0 Offset: 0x22B8FF1 VA: 0x22B8EF0
	public void set_StarLayer1Color(Color value) { }

	// RVA: 0x22B8F30 Offset: 0x22B9031 VA: 0x22B8F30
	public float get_StarLayer1MaxRadius() { }

	// RVA: 0x22B8F40 Offset: 0x22B9041 VA: 0x22B8F40
	public void set_StarLayer1MaxRadius(float value) { }

	// RVA: 0x22B8F70 Offset: 0x22B9071 VA: 0x22B8F70
	public float get_StarLayer1TwinkleAmount() { }

	// RVA: 0x22B8F80 Offset: 0x22B9081 VA: 0x22B8F80
	public void set_StarLayer1TwinkleAmount(float value) { }

	// RVA: 0x22B8FB0 Offset: 0x22B90B1 VA: 0x22B8FB0
	public float get_StarLayer1TwinkleSpeed() { }

	// RVA: 0x22B8FC0 Offset: 0x22B90C1 VA: 0x22B8FC0
	public void set_StarLayer1TwinkleSpeed(float value) { }

	// RVA: 0x22B8FF0 Offset: 0x22B90F1 VA: 0x22B8FF0
	public float get_StarLayer1RotationSpeed() { }

	// RVA: 0x22B9000 Offset: 0x22B9101 VA: 0x22B9000
	public void set_StarLayer1RotationSpeed(float value) { }

	// RVA: 0x22B9030 Offset: 0x22B9131 VA: 0x22B9030
	public float get_StarLayer1EdgeFeathering() { }

	// RVA: 0x22B9040 Offset: 0x22B9141 VA: 0x22B9040
	public void set_StarLayer1EdgeFeathering(float value) { }

	// RVA: 0x22B9070 Offset: 0x22B9171 VA: 0x22B9070
	public float get_StarLayer1BloomFilterBoost() { }

	// RVA: 0x22B9080 Offset: 0x22B9181 VA: 0x22B9080
	public void set_StarLayer1BloomFilterBoost(float value) { }

	// RVA: 0x22B90B0 Offset: 0x22B91B1 VA: 0x22B90B0
	public void SetStarLayer1SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B90F0 Offset: 0x22B91F1 VA: 0x22B90F0
	public Vector2 GetStarLayer1SpriteDimensions() { }

	// RVA: 0x22B9120 Offset: 0x22B9221 VA: 0x22B9120
	public int get_StarLayer1SpriteItemCount() { }

	// RVA: 0x22B9130 Offset: 0x22B9231 VA: 0x22B9130
	public void set_StarLayer1SpriteItemCount(int value) { }

	// RVA: 0x22B9160 Offset: 0x22B9261 VA: 0x22B9160
	public float get_StarLayer1SpriteAnimationSpeed() { }

	// RVA: 0x22B9170 Offset: 0x22B9271 VA: 0x22B9170
	public void set_StarLayer1SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B91A0 Offset: 0x22B92A1 VA: 0x22B91A0
	public Texture get_StarLayer2Texture() { }

	// RVA: 0x22B91B0 Offset: 0x22B92B1 VA: 0x22B91B0
	public void set_StarLayer2Texture(Texture value) { }

	// RVA: 0x22B9200 Offset: 0x22B9301 VA: 0x22B9200
	public Texture2D get_StarLayer2DataTexture() { }

	// RVA: 0x22B9210 Offset: 0x22B9311 VA: 0x22B9210
	public void set_StarLayer2DataTexture(Texture2D value) { }

	// RVA: 0x22B9260 Offset: 0x22B9361 VA: 0x22B9260
	public Color get_StarLayer2Color() { }

	// RVA: 0x22B9280 Offset: 0x22B9381 VA: 0x22B9280
	public void set_StarLayer2Color(Color value) { }

	// RVA: 0x22B92C0 Offset: 0x22B93C1 VA: 0x22B92C0
	public float get_StarLayer2MaxRadius() { }

	// RVA: 0x22B92D0 Offset: 0x22B93D1 VA: 0x22B92D0
	public void set_StarLayer2MaxRadius(float value) { }

	// RVA: 0x22B9300 Offset: 0x22B9401 VA: 0x22B9300
	public float get_StarLayer2TwinkleAmount() { }

	// RVA: 0x22B9310 Offset: 0x22B9411 VA: 0x22B9310
	public void set_StarLayer2TwinkleAmount(float value) { }

	// RVA: 0x22B9340 Offset: 0x22B9441 VA: 0x22B9340
	public float get_StarLayer2TwinkleSpeed() { }

	// RVA: 0x22B9350 Offset: 0x22B9451 VA: 0x22B9350
	public void set_StarLayer2TwinkleSpeed(float value) { }

	// RVA: 0x22B9380 Offset: 0x22B9481 VA: 0x22B9380
	public float get_StarLayer2RotationSpeed() { }

	// RVA: 0x22B9390 Offset: 0x22B9491 VA: 0x22B9390
	public void set_StarLayer2RotationSpeed(float value) { }

	// RVA: 0x22B93C0 Offset: 0x22B94C1 VA: 0x22B93C0
	public float get_StarLayer2EdgeFeathering() { }

	// RVA: 0x22B93D0 Offset: 0x22B94D1 VA: 0x22B93D0
	public void set_StarLayer2EdgeFeathering(float value) { }

	// RVA: 0x22B9400 Offset: 0x22B9501 VA: 0x22B9400
	public float get_StarLayer2BloomFilterBoost() { }

	// RVA: 0x22B9410 Offset: 0x22B9511 VA: 0x22B9410
	public void set_StarLayer2BloomFilterBoost(float value) { }

	// RVA: 0x22B9440 Offset: 0x22B9541 VA: 0x22B9440
	public void SetStarLayer2SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9480 Offset: 0x22B9581 VA: 0x22B9480
	public Vector2 GetStarLayer2SpriteDimensions() { }

	// RVA: 0x22B94C0 Offset: 0x22B95C1 VA: 0x22B94C0
	public int get_StarLayer2SpriteItemCount() { }

	// RVA: 0x22B94D0 Offset: 0x22B95D1 VA: 0x22B94D0
	public void set_StarLayer2SpriteItemCount(int value) { }

	// RVA: 0x22B9500 Offset: 0x22B9601 VA: 0x22B9500
	public float get_StarLayer2SpriteAnimationSpeed() { }

	// RVA: 0x22B9510 Offset: 0x22B9611 VA: 0x22B9510
	public void set_StarLayer2SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B9540 Offset: 0x22B9641 VA: 0x22B9540
	public Texture get_StarLayer3Texture() { }

	// RVA: 0x22B9550 Offset: 0x22B9651 VA: 0x22B9550
	public void set_StarLayer3Texture(Texture value) { }

	// RVA: 0x22B9590 Offset: 0x22B9691 VA: 0x22B9590
	public Texture2D get_StarLayer3DataTexture() { }

	// RVA: 0x22B95A0 Offset: 0x22B96A1 VA: 0x22B95A0
	public void set_StarLayer3DataTexture(Texture2D value) { }

	// RVA: 0x22B95F0 Offset: 0x22B96F1 VA: 0x22B95F0
	public Color get_StarLayer3Color() { }

	// RVA: 0x22B9610 Offset: 0x22B9711 VA: 0x22B9610
	public void set_StarLayer3Color(Color value) { }

	// RVA: 0x22B9650 Offset: 0x22B9751 VA: 0x22B9650
	public float get_StarLayer3MaxRadius() { }

	// RVA: 0x22B9660 Offset: 0x22B9761 VA: 0x22B9660
	public void set_StarLayer3MaxRadius(float value) { }

	// RVA: 0x22B9690 Offset: 0x22B9791 VA: 0x22B9690
	public float get_StarLayer3TwinkleAmount() { }

	// RVA: 0x22B96A0 Offset: 0x22B97A1 VA: 0x22B96A0
	public void set_StarLayer3TwinkleAmount(float value) { }

	// RVA: 0x22B96D0 Offset: 0x22B97D1 VA: 0x22B96D0
	public float get_StarLayer3TwinkleSpeed() { }

	// RVA: 0x22B96E0 Offset: 0x22B97E1 VA: 0x22B96E0
	public void set_StarLayer3TwinkleSpeed(float value) { }

	// RVA: 0x22B9710 Offset: 0x22B9811 VA: 0x22B9710
	public float get_StarLayer3RotationSpeed() { }

	// RVA: 0x22B9720 Offset: 0x22B9821 VA: 0x22B9720
	public void set_StarLayer3RotationSpeed(float value) { }

	// RVA: 0x22B9750 Offset: 0x22B9851 VA: 0x22B9750
	public float get_StarLayer3EdgeFeathering() { }

	// RVA: 0x22B9760 Offset: 0x22B9861 VA: 0x22B9760
	public void set_StarLayer3EdgeFeathering(float value) { }

	// RVA: 0x22B9790 Offset: 0x22B9891 VA: 0x22B9790
	public float get_StarLayer3BloomFilterBoost() { }

	// RVA: 0x22B97A0 Offset: 0x22B98A1 VA: 0x22B97A0
	public void set_StarLayer3BloomFilterBoost(float value) { }

	// RVA: 0x22B97D0 Offset: 0x22B98D1 VA: 0x22B97D0
	public void SetStarLayer3SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9810 Offset: 0x22B9911 VA: 0x22B9810
	public Vector2 GetStarLayer3SpriteDimensions() { }

	// RVA: 0x22B9850 Offset: 0x22B9951 VA: 0x22B9850
	public int get_StarLayer3SpriteItemCount() { }

	// RVA: 0x22B9860 Offset: 0x22B9961 VA: 0x22B9860
	public void set_StarLayer3SpriteItemCount(int value) { }

	// RVA: 0x22B9890 Offset: 0x22B9991 VA: 0x22B9890
	public float get_StarLayer3SpriteAnimationSpeed() { }

	// RVA: 0x22B98A0 Offset: 0x22B99A1 VA: 0x22B98A0
	public void set_StarLayer3SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B98D0 Offset: 0x22B99D1 VA: 0x22B98D0
	public Texture get_MoonTexture() { }

	// RVA: 0x22B98E0 Offset: 0x22B99E1 VA: 0x22B98E0
	public void set_MoonTexture(Texture value) { }

	// RVA: 0x22B9920 Offset: 0x22B9A21 VA: 0x22B9920
	public float get_MoonRotationSpeed() { }

	// RVA: 0x22B9930 Offset: 0x22B9A31 VA: 0x22B9930
	public void set_MoonRotationSpeed(float value) { }

	// RVA: 0x22B9960 Offset: 0x22B9A61 VA: 0x22B9960
	public Color get_MoonColor() { }

	// RVA: 0x22B9980 Offset: 0x22B9A81 VA: 0x22B9980
	public void set_MoonColor(Color value) { }

	// RVA: 0x22B99C0 Offset: 0x22B9AC1 VA: 0x22B99C0
	public Vector3 get_MoonDirection() { }

	// RVA: 0x22B99D0 Offset: 0x22B9AD1 VA: 0x22B99D0
	public void set_MoonDirection(Vector3 value) { }

	// RVA: 0x22B9AB0 Offset: 0x22B9BB1 VA: 0x22B9AB0
	public Matrix4x4 get_MoonWorldToLocalMatrix() { }

	// RVA: 0x22B9AE0 Offset: 0x22B9BE1 VA: 0x22B9AE0
	public void set_MoonWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x22B9B70 Offset: 0x22B9C71 VA: 0x22B9B70
	public float get_MoonSize() { }

	// RVA: 0x22B9B80 Offset: 0x22B9C81 VA: 0x22B9B80
	public void set_MoonSize(float value) { }

	// RVA: 0x22B9BB0 Offset: 0x22B9CB1 VA: 0x22B9BB0
	public float get_MoonEdgeFeathering() { }

	// RVA: 0x22B9BC0 Offset: 0x22B9CC1 VA: 0x22B9BC0
	public void set_MoonEdgeFeathering(float value) { }

	// RVA: 0x22B9BF0 Offset: 0x22B9CF1 VA: 0x22B9BF0
	public float get_MoonBloomFilterBoost() { }

	// RVA: 0x22B9C00 Offset: 0x22B9D01 VA: 0x22B9C00
	public void set_MoonBloomFilterBoost(float value) { }

	// RVA: 0x22B9C30 Offset: 0x22B9D31 VA: 0x22B9C30
	public void SetMoonSpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9C70 Offset: 0x22B9D71 VA: 0x22B9C70
	public Vector2 GetMoonSpriteDimensions() { }

	// RVA: 0x22B9CB0 Offset: 0x22B9DB1 VA: 0x22B9CB0
	public int get_MoonSpriteItemCount() { }

	// RVA: 0x22B9CC0 Offset: 0x22B9DC1 VA: 0x22B9CC0
	public void set_MoonSpriteItemCount(int value) { }

	// RVA: 0x22B9CF0 Offset: 0x22B9DF1 VA: 0x22B9CF0
	public float get_MoonSpriteAnimationSpeed() { }

	// RVA: 0x22B9D00 Offset: 0x22B9E01 VA: 0x22B9D00
	public void set_MoonSpriteAnimationSpeed(float value) { }

	// RVA: 0x22B9D30 Offset: 0x22B9E31 VA: 0x22B9D30
	public Texture get_SunTexture() { }

	// RVA: 0x22B9D40 Offset: 0x22B9E41 VA: 0x22B9D40
	public void set_SunTexture(Texture value) { }

	// RVA: 0x22B9D80 Offset: 0x22B9E81 VA: 0x22B9D80
	public Color get_SunColor() { }

	// RVA: 0x22B9DA0 Offset: 0x22B9EA1 VA: 0x22B9DA0
	public void set_SunColor(Color value) { }

	// RVA: 0x22B9DE0 Offset: 0x22B9EE1 VA: 0x22B9DE0
	public float get_SunRotationSpeed() { }

	// RVA: 0x22B9DF0 Offset: 0x22B9EF1 VA: 0x22B9DF0
	public void set_SunRotationSpeed(float value) { }

	// RVA: 0x22B9E20 Offset: 0x22B9F21 VA: 0x22B9E20
	public Vector3 get_SunDirection() { }

	// RVA: 0x22B9E30 Offset: 0x22B9F31 VA: 0x22B9E30
	public void set_SunDirection(Vector3 value) { }

	// RVA: 0x22B9F10 Offset: 0x22BA011 VA: 0x22B9F10
	public Matrix4x4 get_SunWorldToLocalMatrix() { }

	// RVA: 0x22B9F50 Offset: 0x22BA051 VA: 0x22B9F50
	public void set_SunWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x22B9FF0 Offset: 0x22BA0F1 VA: 0x22B9FF0
	public float get_SunSize() { }

	// RVA: 0x22BA000 Offset: 0x22BA101 VA: 0x22BA000
	public void set_SunSize(float value) { }

	// RVA: 0x22BA030 Offset: 0x22BA131 VA: 0x22BA030
	public float get_SunEdgeFeathering() { }

	// RVA: 0x22BA040 Offset: 0x22BA141 VA: 0x22BA040
	public void set_SunEdgeFeathering(float value) { }

	// RVA: 0x22BA070 Offset: 0x22BA171 VA: 0x22BA070
	public float get_SunBloomFilterBoost() { }

	// RVA: 0x22BA080 Offset: 0x22BA181 VA: 0x22BA080
	public void set_SunBloomFilterBoost(float value) { }

	// RVA: 0x22BA0B0 Offset: 0x22BA1B1 VA: 0x22BA0B0
	public void SetSunSpriteDimensions(int columns, int rows) { }

	// RVA: 0x22BA0F0 Offset: 0x22BA1F1 VA: 0x22BA0F0
	public Vector2 GetSunSpriteDimensions() { }

	// RVA: 0x22BA130 Offset: 0x22BA231 VA: 0x22BA130
	public int get_SunSpriteItemCount() { }

	// RVA: 0x22BA140 Offset: 0x22BA241 VA: 0x22BA140
	public void set_SunSpriteItemCount(int value) { }

	// RVA: 0x22BA170 Offset: 0x22BA271 VA: 0x22BA170
	public float get_SunSpriteAnimationSpeed() { }

	// RVA: 0x22BA180 Offset: 0x22BA281 VA: 0x22BA180
	public void set_SunSpriteAnimationSpeed(float value) { }

	// RVA: 0x22BA1B0 Offset: 0x22BA2B1 VA: 0x22BA1B0
	public float get_CloudBegin() { }

	// RVA: 0x22BA1C0 Offset: 0x22BA2C1 VA: 0x22BA1C0
	public void set_CloudBegin(float value) { }

	// RVA: 0x22BA1F0 Offset: 0x22BA2F1 VA: 0x22BA1F0
	public float get_CloudTextureTiling() { }

	// RVA: 0x22BA200 Offset: 0x22BA301 VA: 0x22BA200
	public void set_CloudTextureTiling(float value) { }

	// RVA: 0x22BA230 Offset: 0x22BA331 VA: 0x22BA230
	public float get_Cloud2TextureTiling() { }

	// RVA: 0x22BA240 Offset: 0x22BA341 VA: 0x22BA240
	public void set_Cloud2TextureTiling(float value) { }

	// RVA: 0x22BA270 Offset: 0x22BA371 VA: 0x22BA270
	public Color get_CloudColor() { }

	// RVA: 0x22BA290 Offset: 0x22BA391 VA: 0x22BA290
	public void set_CloudColor(Color value) { }

	// RVA: 0x22BA2D0 Offset: 0x22BA3D1 VA: 0x22BA2D0
	public Texture get_CloudTexture() { }

	// RVA: 0x22BA360 Offset: 0x22BA461 VA: 0x22BA360
	public void set_CloudTexture(Texture value) { }

	// RVA: 0x22BA3A0 Offset: 0x22BA4A1 VA: 0x22BA3A0
	public Texture get_Cloud2Texture() { }

	// RVA: 0x22BA430 Offset: 0x22BA531 VA: 0x22BA430
	public void set_Cloud2Texture(Texture value) { }

	// RVA: 0x22BA470 Offset: 0x22BA571 VA: 0x22BA470
	public Texture get_ArtCloudCustomTexture() { }

	// RVA: 0x22BA500 Offset: 0x22BA601 VA: 0x22BA500
	public void set_ArtCloudCustomTexture(Texture value) { }

	// RVA: 0x22BA540 Offset: 0x22BA641 VA: 0x22BA540
	public float get_CloudDensity() { }

	// RVA: 0x22BA550 Offset: 0x22BA651 VA: 0x22BA550
	public void set_CloudDensity(float value) { }

	// RVA: 0x22BA580 Offset: 0x22BA681 VA: 0x22BA580
	public float get_Cloud2Density() { }

	// RVA: 0x22BA590 Offset: 0x22BA691 VA: 0x22BA590
	public void set_Cloud2Density(float value) { }

	// RVA: 0x22BA5C0 Offset: 0x22BA6C1 VA: 0x22BA5C0
	public float get_CloudSpeed() { }

	// RVA: 0x22BA5D0 Offset: 0x22BA6D1 VA: 0x22BA5D0
	public void set_CloudSpeed(float value) { }

	// RVA: 0x22BA600 Offset: 0x22BA701 VA: 0x22BA600
	public float get_Cloud2Speed() { }

	// RVA: 0x22BA610 Offset: 0x22BA711 VA: 0x22BA610
	public void set_Cloud2Speed(float value) { }

	// RVA: 0x22BA640 Offset: 0x22BA741 VA: 0x22BA640
	public float get_CloudDirection() { }

	// RVA: 0x22BA650 Offset: 0x22BA751 VA: 0x22BA650
	public void set_CloudDirection(float value) { }

	// RVA: 0x22BA680 Offset: 0x22BA781 VA: 0x22BA680
	public float get_Cloud2Direction() { }

	// RVA: 0x22BA690 Offset: 0x22BA791 VA: 0x22BA690
	public void set_Cloud2Direction(float value) { }

	// RVA: 0x22BA6C0 Offset: 0x22BA7C1 VA: 0x22BA6C0
	public float get_CloudHeight() { }

	// RVA: 0x22BA6D0 Offset: 0x22BA7D1 VA: 0x22BA6D0
	public void set_CloudHeight(float value) { }

	// RVA: 0x22BA700 Offset: 0x22BA801 VA: 0x22BA700
	public float get_Cloud2Height() { }

	// RVA: 0x22BA710 Offset: 0x22BA811 VA: 0x22BA710
	public void set_Cloud2Height(float value) { }

	// RVA: 0x22BA740 Offset: 0x22BA841 VA: 0x22BA740
	public Color get_CloudColor1() { }

	// RVA: 0x22BA760 Offset: 0x22BA861 VA: 0x22BA760
	public void set_CloudColor1(Color value) { }

	// RVA: 0x22BA7A0 Offset: 0x22BA8A1 VA: 0x22BA7A0
	public Color get_Cloud2Color1() { }

	// RVA: 0x22BA7C0 Offset: 0x22BA8C1 VA: 0x22BA7C0
	public void set_Cloud2Color1(Color value) { }

	// RVA: 0x22BA800 Offset: 0x22BA901 VA: 0x22BA800
	public Color get_CloudColor2() { }

	// RVA: 0x22BA820 Offset: 0x22BA921 VA: 0x22BA820
	public void set_CloudColor2(Color value) { }

	// RVA: 0x22BA860 Offset: 0x22BA961 VA: 0x22BA860
	public Color get_Cloud2Color2() { }

	// RVA: 0x22BA880 Offset: 0x22BA981 VA: 0x22BA880
	public void set_Cloud2Color2(Color value) { }

	// RVA: 0x22BA8C0 Offset: 0x22BA9C1 VA: 0x22BA8C0
	public float get_CloudFadePosition() { }

	// RVA: 0x22BA8D0 Offset: 0x22BA9D1 VA: 0x22BA8D0
	public void set_CloudFadePosition(float value) { }

	// RVA: 0x22BA900 Offset: 0x22BAA01 VA: 0x22BA900
	public float get_Cloud2FadePosition() { }

	// RVA: 0x22BA910 Offset: 0x22BAA11 VA: 0x22BA910
	public void set_Cloud2FadePosition(float value) { }

	// RVA: 0x22BA940 Offset: 0x22BAA41 VA: 0x22BA940
	public float get_CloudFadeAmount() { }

	// RVA: 0x22BA950 Offset: 0x22BAA51 VA: 0x22BA950
	public void set_CloudFadeAmount(float value) { }

	// RVA: 0x22BA980 Offset: 0x22BAA81 VA: 0x22BA980
	public float get_Cloud2FadeAmount() { }

	// RVA: 0x22BA990 Offset: 0x22BAA91 VA: 0x22BA990
	public void set_Cloud2FadeAmount(float value) { }

	// RVA: 0x22BA9C0 Offset: 0x22BAAC1 VA: 0x22BA9C0
	public Texture get_CloudCubemap() { }

	// RVA: 0x22BA9D0 Offset: 0x22BAAD1 VA: 0x22BA9D0
	public void set_CloudCubemap(Texture value) { }

	// RVA: 0x22BAA10 Offset: 0x22BAB11 VA: 0x22BAA10
	public float get_CloudCubemapRotationSpeed() { }

	// RVA: 0x22BAA20 Offset: 0x22BAB21 VA: 0x22BAA20
	public void set_CloudCubemapRotationSpeed(float value) { }

	// RVA: 0x22BAA50 Offset: 0x22BAB51 VA: 0x22BAA50
	public Texture get_CloudCubemapDoubleLayerCustomTexture() { }

	// RVA: 0x22BAA60 Offset: 0x22BAB61 VA: 0x22BAA60
	public void set_CloudCubemapDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x22BAAA0 Offset: 0x22BABA1 VA: 0x22BAAA0
	public float get_CloudCubemapDoubleLayerRotationSpeed() { }

	// RVA: 0x22BAAB0 Offset: 0x22BABB1 VA: 0x22BAAB0
	public void set_CloudCubemapDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x22BAAE0 Offset: 0x22BABE1 VA: 0x22BAAE0
	public float get_CloudCubemapDoubleLayerHeight() { }

	// RVA: 0x22BAAF0 Offset: 0x22BABF1 VA: 0x22BAAF0
	public void set_CloudCubemapDoubleLayerHeight(float value) { }

	// RVA: 0x22BAB20 Offset: 0x22BAC21 VA: 0x22BAB20
	public Color get_CloudCubemapDoubleLayerTintColor() { }

	// RVA: 0x22BAB40 Offset: 0x22BAC41 VA: 0x22BAB40
	public void set_CloudCubemapDoubleLayerTintColor(Color value) { }

	// RVA: 0x22BAB80 Offset: 0x22BAC81 VA: 0x22BAB80
	public Color get_CloudCubemapTintColor() { }

	// RVA: 0x22BABA0 Offset: 0x22BACA1 VA: 0x22BABA0
	public void set_CloudCubemapTintColor(Color value) { }

	// RVA: 0x22BABE0 Offset: 0x22BACE1 VA: 0x22BABE0
	public float get_CloudCubemapHeight() { }

	// RVA: 0x22BABF0 Offset: 0x22BACF1 VA: 0x22BABF0
	public void set_CloudCubemapHeight(float value) { }

	// RVA: 0x22BAC20 Offset: 0x22BAD21 VA: 0x22BAC20
	public Texture get_CloudCubemapNormalTexture() { }

	// RVA: 0x22BAC30 Offset: 0x22BAD31 VA: 0x22BAC30
	public void set_CloudCubemapNormalTexture(Texture value) { }

	// RVA: 0x22BAC70 Offset: 0x22BAD71 VA: 0x22BAC70
	public Color get_CloudCubemapNormalLitColor() { }

	// RVA: 0x22BAC90 Offset: 0x22BAD91 VA: 0x22BAC90
	public void set_CloudCubemapNormalLitColor(Color value) { }

	// RVA: 0x22BACD0 Offset: 0x22BADD1 VA: 0x22BACD0
	public Color get_CloudCubemapNormalShadowColor() { }

	// RVA: 0x22BACF0 Offset: 0x22BADF1 VA: 0x22BACF0
	public void set_CloudCubemapNormalShadowColor(Color value) { }

	// RVA: 0x22BAD30 Offset: 0x22BAE31 VA: 0x22BAD30
	public float get_CloudCubemapNormalRotationSpeed() { }

	// RVA: 0x22BAD40 Offset: 0x22BAE41 VA: 0x22BAD40
	public void set_CloudCubemapNormalRotationSpeed(float value) { }

	// RVA: 0x22BAD70 Offset: 0x22BAE71 VA: 0x22BAD70
	public float get_CloudCubemapNormalHeight() { }

	// RVA: 0x22BAD80 Offset: 0x22BAE81 VA: 0x22BAD80
	public void set_CloudCubemapNormalHeight(float value) { }

	// RVA: 0x22BADB0 Offset: 0x22BAEB1 VA: 0x22BADB0
	public float get_CloudCubemapNormalAmbientIntensity() { }

	// RVA: 0x22BADC0 Offset: 0x22BAEC1 VA: 0x22BADC0
	public void set_CloudCubemapNormalAmbientIntensity(float value) { }

	// RVA: 0x22BADF0 Offset: 0x22BAEF1 VA: 0x22BADF0
	public Texture get_CloudCubemapNormalDoubleLayerCustomTexture() { }

	// RVA: 0x22BAE00 Offset: 0x22BAF01 VA: 0x22BAE00
	public void set_CloudCubemapNormalDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x22BAE40 Offset: 0x22BAF41 VA: 0x22BAE40
	public float get_CloudCubemapNormalDoubleLayerRotationSpeed() { }

	// RVA: 0x22BAE50 Offset: 0x22BAF51 VA: 0x22BAE50
	public void set_CloudCubemapNormalDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x22BAE80 Offset: 0x22BAF81 VA: 0x22BAE80
	public float get_CloudCubemapNormalDoubleLayerHeight() { }

	// RVA: 0x22BAE90 Offset: 0x22BAF91 VA: 0x22BAE90
	public void set_CloudCubemapNormalDoubleLayerHeight(float value) { }

	// RVA: 0x22BAEC0 Offset: 0x22BAFC1 VA: 0x22BAEC0
	public Color get_CloudCubemapNormalDoubleLayerLitColor() { }

	// RVA: 0x22BAEE0 Offset: 0x22BAFE1 VA: 0x22BAEE0
	public void set_CloudCubemapNormalDoubleLayerLitColor(Color value) { }

	// RVA: 0x22BAF20 Offset: 0x22BB021 VA: 0x22BAF20
	public Color get_CloudCubemapNormalDoubleLayerShadowColor() { }

	// RVA: 0x22BAF40 Offset: 0x22BB041 VA: 0x22BAF40
	public void set_CloudCubemapNormalDoubleLayerShadowColor(Color value) { }

	// RVA: 0x22BAF80 Offset: 0x22BB081 VA: 0x22BAF80
	public Vector3 get_CloudCubemapNormalLightDirection() { }

	// RVA: 0x22BAF90 Offset: 0x22BB091 VA: 0x22BAF90
	public void set_CloudCubemapNormalLightDirection(Vector3 value) { }

	// RVA: 0x22BB050 Offset: 0x22BB151 VA: 0x22BB050
	public Color get_FogColor() { }

	// RVA: 0x22BB070 Offset: 0x22BB171 VA: 0x22BB070
	public void set_FogColor(Color value) { }

	// RVA: 0x22BB0B0 Offset: 0x22BB1B1 VA: 0x22BB0B0
	public float get_FogDensity() { }

	// RVA: 0x22BB0C0 Offset: 0x22BB1C1 VA: 0x22BB0C0
	public void set_FogDensity(float value) { }

	// RVA: 0x22BB0F0 Offset: 0x22BB1F1 VA: 0x22BB0F0
	public float get_FogHeight() { }

	// RVA: 0x22BB100 Offset: 0x22BB201 VA: 0x22BB100
	public void set_FogHeight(float value) { }

	// RVA: 0x22B8970 Offset: 0x22B8A71 VA: 0x22B8970
	private void ApplyGradientValuesOnMaterial() { }

	// RVA: 0x22B8B10 Offset: 0x22B8C11 VA: 0x22B8B10
	private void ApplyStarFadeValuesOnMaterial() { }

	// RVA: 0x22BB130 Offset: 0x22BB231 VA: 0x22BB130
	public void .ctor() { }
}

public class SkyMaterialController // TypeDefIndex: 9676
{
	// Fields
	[SerializeField] // RVA: 0x17D840 Offset: 0x17D941 VA: 0x17D840
	private Material _skyboxMaterial; // 0x10
	[SerializeField] // RVA: 0x17D850 Offset: 0x17D951 VA: 0x17D850
	private Color _skyColor; // 0x18
	[SerializeField] // RVA: 0x17D860 Offset: 0x17D961 VA: 0x17D860
	private Color _skyMiddleColor; // 0x28
	[SerializeField] // RVA: 0x17D870 Offset: 0x17D971 VA: 0x17D870
	private Color _horizonColor; // 0x38
	[SerializeField] // RVA: 0x17D880 Offset: 0x17D981 VA: 0x17D880
	[RangeAttribute] // RVA: 0x17D880 Offset: 0x17D981 VA: 0x17D880
	private float _gradientFadeBegin; // 0x48
	[SerializeField] // RVA: 0x17D8C0 Offset: 0x17D9C1 VA: 0x17D8C0
	[RangeAttribute] // RVA: 0x17D8C0 Offset: 0x17D9C1 VA: 0x17D8C0
	private float _gradientFadeLength; // 0x4C
	[SerializeField] // RVA: 0x17D900 Offset: 0x17DA01 VA: 0x17D900
	[RangeAttribute] // RVA: 0x17D900 Offset: 0x17DA01 VA: 0x17D900
	private float _skyMiddlePosition; // 0x50
	[SerializeField] // RVA: 0x17D940 Offset: 0x17DA41 VA: 0x17D940
	private Cubemap _backgroundCubemap; // 0x58
	[SerializeField] // RVA: 0x17D950 Offset: 0x17DA51 VA: 0x17D950
	[RangeAttribute] // RVA: 0x17D950 Offset: 0x17DA51 VA: 0x17D950
	private float _starFadeBegin; // 0x60
	[SerializeField] // RVA: 0x17D990 Offset: 0x17DA91 VA: 0x17D990
	[RangeAttribute] // RVA: 0x17D990 Offset: 0x17DA91 VA: 0x17D990
	private float _starFadeLength; // 0x64
	[SerializeField] // RVA: 0x17D9D0 Offset: 0x17DAD1 VA: 0x17D9D0
	[RangeAttribute] // RVA: 0x17D9D0 Offset: 0x17DAD1 VA: 0x17D9D0
	private float _horizonDistanceScale; // 0x68
	[SerializeField] // RVA: 0x17DA10 Offset: 0x17DB11 VA: 0x17DA10
	private Texture _starBasicCubemap; // 0x70
	[SerializeField] // RVA: 0x17DA20 Offset: 0x17DB21 VA: 0x17DA20
	private float _starBasicTwinkleSpeed; // 0x78
	[SerializeField] // RVA: 0x17DA30 Offset: 0x17DB31 VA: 0x17DA30
	private float _starBasicTwinkleAmount; // 0x7C
	[SerializeField] // RVA: 0x17DA40 Offset: 0x17DB41 VA: 0x17DA40
	private float _starBasicOpacity; // 0x80
	[SerializeField] // RVA: 0x17DA50 Offset: 0x17DB51 VA: 0x17DA50
	private Color _starBasicTintColor; // 0x84
	[SerializeField] // RVA: 0x17DA60 Offset: 0x17DB61 VA: 0x17DA60
	private float _starBasicExponent; // 0x94
	[SerializeField] // RVA: 0x17DA70 Offset: 0x17DB71 VA: 0x17DA70
	private float _starBasicIntensity; // 0x98
	[SerializeField] // RVA: 0x17DA80 Offset: 0x17DB81 VA: 0x17DA80
	private Texture _starLayer1Texture; // 0xA0
	[SerializeField] // RVA: 0x17DA90 Offset: 0x17DB91 VA: 0x17DA90
	private Texture2D _starLayer1DataTexture; // 0xA8
	[SerializeField] // RVA: 0x17DAA0 Offset: 0x17DBA1 VA: 0x17DAA0
	private Color _starLayer1Color; // 0xB0
	[SerializeField] // RVA: 0x17DAB0 Offset: 0x17DBB1 VA: 0x17DAB0
	[RangeAttribute] // RVA: 0x17DAB0 Offset: 0x17DBB1 VA: 0x17DAB0
	private float _starLayer1MaxRadius; // 0xC0
	[SerializeField] // RVA: 0x17DB00 Offset: 0x17DC01 VA: 0x17DB00
	[RangeAttribute] // RVA: 0x17DB00 Offset: 0x17DC01 VA: 0x17DB00
	private float _starLayer1TwinkleAmount; // 0xC4
	[SerializeField] // RVA: 0x17DB40 Offset: 0x17DC41 VA: 0x17DB40
	[RangeAttribute] // RVA: 0x17DB40 Offset: 0x17DC41 VA: 0x17DB40
	private float _starLayer1TwinkleSpeed; // 0xC8
	[SerializeField] // RVA: 0x17DB80 Offset: 0x17DC81 VA: 0x17DB80
	[RangeAttribute] // RVA: 0x17DB80 Offset: 0x17DC81 VA: 0x17DB80
	private float _starLayer1RotationSpeed; // 0xCC
	[SerializeField] // RVA: 0x17DBC0 Offset: 0x17DCC1 VA: 0x17DBC0
	[RangeAttribute] // RVA: 0x17DBC0 Offset: 0x17DCC1 VA: 0x17DBC0
	private float _starLayer1EdgeFeathering; // 0xD0
	[SerializeField] // RVA: 0x17DC10 Offset: 0x17DD11 VA: 0x17DC10
	[RangeAttribute] // RVA: 0x17DC10 Offset: 0x17DD11 VA: 0x17DC10
	private float _starLayer1BloomFilterBoost; // 0xD4
	[SerializeField] // RVA: 0x17DC50 Offset: 0x17DD51 VA: 0x17DC50
	private Vector4 _starLayer1SpriteDimensions; // 0xD8
	[SerializeField] // RVA: 0x17DC60 Offset: 0x17DD61 VA: 0x17DC60
	private int _starLayer1SpriteItemCount; // 0xE8
	[SerializeField] // RVA: 0x17DC70 Offset: 0x17DD71 VA: 0x17DC70
	[RangeAttribute] // RVA: 0x17DC70 Offset: 0x17DD71 VA: 0x17DC70
	private float _starLayer1SpriteAnimationSpeed; // 0xEC
	[SerializeField] // RVA: 0x17DCB0 Offset: 0x17DDB1 VA: 0x17DCB0
	private Texture _starLayer2Texture; // 0xF0
	[SerializeField] // RVA: 0x17DCC0 Offset: 0x17DDC1 VA: 0x17DCC0
	private Texture2D _starLayer2DataTexture; // 0xF8
	[SerializeField] // RVA: 0x17DCD0 Offset: 0x17DDD1 VA: 0x17DCD0
	private Color _starLayer2Color; // 0x100
	[SerializeField] // RVA: 0x17DCE0 Offset: 0x17DDE1 VA: 0x17DCE0
	[RangeAttribute] // RVA: 0x17DCE0 Offset: 0x17DDE1 VA: 0x17DCE0
	private float _starLayer2MaxRadius; // 0x110
	[SerializeField] // RVA: 0x17DD30 Offset: 0x17DE31 VA: 0x17DD30
	[RangeAttribute] // RVA: 0x17DD30 Offset: 0x17DE31 VA: 0x17DD30
	private float _starLayer2TwinkleAmount; // 0x114
	[SerializeField] // RVA: 0x17DD70 Offset: 0x17DE71 VA: 0x17DD70
	[RangeAttribute] // RVA: 0x17DD70 Offset: 0x17DE71 VA: 0x17DD70
	private float _starLayer2TwinkleSpeed; // 0x118
	[SerializeField] // RVA: 0x17DDB0 Offset: 0x17DEB1 VA: 0x17DDB0
	[RangeAttribute] // RVA: 0x17DDB0 Offset: 0x17DEB1 VA: 0x17DDB0
	private float _starLayer2RotationSpeed; // 0x11C
	[SerializeField] // RVA: 0x17DDF0 Offset: 0x17DEF1 VA: 0x17DDF0
	[RangeAttribute] // RVA: 0x17DDF0 Offset: 0x17DEF1 VA: 0x17DDF0
	private float _starLayer2EdgeFeathering; // 0x120
	[SerializeField] // RVA: 0x17DE40 Offset: 0x17DF41 VA: 0x17DE40
	[RangeAttribute] // RVA: 0x17DE40 Offset: 0x17DF41 VA: 0x17DE40
	private float _starLayer2BloomFilterBoost; // 0x124
	[SerializeField] // RVA: 0x17DE80 Offset: 0x17DF81 VA: 0x17DE80
	private Vector4 _starLayer2SpriteDimensions; // 0x128
	[SerializeField] // RVA: 0x17DE90 Offset: 0x17DF91 VA: 0x17DE90
	private int _starLayer2SpriteItemCount; // 0x138
	[SerializeField] // RVA: 0x17DEA0 Offset: 0x17DFA1 VA: 0x17DEA0
	[RangeAttribute] // RVA: 0x17DEA0 Offset: 0x17DFA1 VA: 0x17DEA0
	private float _starLayer2SpriteAnimationSpeed; // 0x13C
	[SerializeField] // RVA: 0x17DEE0 Offset: 0x17DFE1 VA: 0x17DEE0
	private Texture _starLayer3Texture; // 0x140
	[SerializeField] // RVA: 0x17DEF0 Offset: 0x17DFF1 VA: 0x17DEF0
	private Texture2D _starLayer3DataTexture; // 0x148
	[SerializeField] // RVA: 0x17DF00 Offset: 0x17E001 VA: 0x17DF00
	private Color _starLayer3Color; // 0x150
	[SerializeField] // RVA: 0x17DF10 Offset: 0x17E011 VA: 0x17DF10
	[RangeAttribute] // RVA: 0x17DF10 Offset: 0x17E011 VA: 0x17DF10
	private float _starLayer3MaxRadius; // 0x160
	[SerializeField] // RVA: 0x17DF60 Offset: 0x17E061 VA: 0x17DF60
	[RangeAttribute] // RVA: 0x17DF60 Offset: 0x17E061 VA: 0x17DF60
	private float _starLayer3TwinkleAmount; // 0x164
	[SerializeField] // RVA: 0x17DFA0 Offset: 0x17E0A1 VA: 0x17DFA0
	[RangeAttribute] // RVA: 0x17DFA0 Offset: 0x17E0A1 VA: 0x17DFA0
	private float _starLayer3TwinkleSpeed; // 0x168
	[SerializeField] // RVA: 0x17DFE0 Offset: 0x17E0E1 VA: 0x17DFE0
	[RangeAttribute] // RVA: 0x17DFE0 Offset: 0x17E0E1 VA: 0x17DFE0
	private float _starLayer3RotationSpeed; // 0x16C
	[SerializeField] // RVA: 0x17E020 Offset: 0x17E121 VA: 0x17E020
	[RangeAttribute] // RVA: 0x17E020 Offset: 0x17E121 VA: 0x17E020
	private float _starLayer3EdgeFeathering; // 0x170
	[SerializeField] // RVA: 0x17E070 Offset: 0x17E171 VA: 0x17E070
	[RangeAttribute] // RVA: 0x17E070 Offset: 0x17E171 VA: 0x17E070
	private float _starLayer3BloomFilterBoost; // 0x174
	[SerializeField] // RVA: 0x17E0B0 Offset: 0x17E1B1 VA: 0x17E0B0
	private Vector4 _starLayer3SpriteDimensions; // 0x178
	[SerializeField] // RVA: 0x17E0C0 Offset: 0x17E1C1 VA: 0x17E0C0
	private int _starLayer3SpriteItemCount; // 0x188
	[SerializeField] // RVA: 0x17E0D0 Offset: 0x17E1D1 VA: 0x17E0D0
	[RangeAttribute] // RVA: 0x17E0D0 Offset: 0x17E1D1 VA: 0x17E0D0
	private float _starLayer3SpriteAnimationSpeed; // 0x18C
	[SerializeField] // RVA: 0x17E110 Offset: 0x17E211 VA: 0x17E110
	private Texture _moonTexture; // 0x190
	[SerializeField] // RVA: 0x17E120 Offset: 0x17E221 VA: 0x17E120
	private float _moonRotationSpeed; // 0x198
	[SerializeField] // RVA: 0x17E130 Offset: 0x17E231 VA: 0x17E130
	private Color _moonColor; // 0x19C
	[SerializeField] // RVA: 0x17E140 Offset: 0x17E241 VA: 0x17E140
	private Vector3 _moonDirection; // 0x1AC
	[SerializeField] // RVA: 0x17E150 Offset: 0x17E251 VA: 0x17E150
	private Matrix4x4 _moonWorldToLocalMatrix; // 0x1B8
	[SerializeField] // RVA: 0x17E160 Offset: 0x17E261 VA: 0x17E160
	[RangeAttribute] // RVA: 0x17E160 Offset: 0x17E261 VA: 0x17E160
	private float _moonSize; // 0x1F8
	[SerializeField] // RVA: 0x17E1A0 Offset: 0x17E2A1 VA: 0x17E1A0
	[RangeAttribute] // RVA: 0x17E1A0 Offset: 0x17E2A1 VA: 0x17E1A0
	private float _moonEdgeFeathering; // 0x1FC
	[SerializeField] // RVA: 0x17E1F0 Offset: 0x17E2F1 VA: 0x17E1F0
	[RangeAttribute] // RVA: 0x17E1F0 Offset: 0x17E2F1 VA: 0x17E1F0
	private float _moonBloomFilterBoost; // 0x200
	[SerializeField] // RVA: 0x17E230 Offset: 0x17E331 VA: 0x17E230
	private Vector4 _moonSpriteDimensions; // 0x204
	[SerializeField] // RVA: 0x17E240 Offset: 0x17E341 VA: 0x17E240
	private int _moonSpriteItemCount; // 0x214
	[SerializeField] // RVA: 0x17E250 Offset: 0x17E351 VA: 0x17E250
	[RangeAttribute] // RVA: 0x17E250 Offset: 0x17E351 VA: 0x17E250
	private float _moonSpriteAnimationSpeed; // 0x218
	[SerializeField] // RVA: 0x17E290 Offset: 0x17E391 VA: 0x17E290
	private Texture _sunTexture; // 0x220
	[SerializeField] // RVA: 0x17E2A0 Offset: 0x17E3A1 VA: 0x17E2A0
	private Color _sunColor; // 0x228
	[SerializeField] // RVA: 0x17E2B0 Offset: 0x17E3B1 VA: 0x17E2B0
	private float _sunRotationSpeed; // 0x238
	[SerializeField] // RVA: 0x17E2C0 Offset: 0x17E3C1 VA: 0x17E2C0
	private Vector3 _sunDirection; // 0x23C
	[SerializeField] // RVA: 0x17E2D0 Offset: 0x17E3D1 VA: 0x17E2D0
	private Matrix4x4 _sunWorldToLocalMatrix; // 0x248
	[SerializeField] // RVA: 0x17E2E0 Offset: 0x17E3E1 VA: 0x17E2E0
	[RangeAttribute] // RVA: 0x17E2E0 Offset: 0x17E3E1 VA: 0x17E2E0
	private float _sunSize; // 0x288
	[SerializeField] // RVA: 0x17E320 Offset: 0x17E421 VA: 0x17E320
	[RangeAttribute] // RVA: 0x17E320 Offset: 0x17E421 VA: 0x17E320
	private float _sunEdgeFeathering; // 0x28C
	[SerializeField] // RVA: 0x17E370 Offset: 0x17E471 VA: 0x17E370
	[RangeAttribute] // RVA: 0x17E370 Offset: 0x17E471 VA: 0x17E370
	private float _sunBloomFilterBoost; // 0x290
	[SerializeField] // RVA: 0x17E3B0 Offset: 0x17E4B1 VA: 0x17E3B0
	private Vector4 _sunSpriteDimensions; // 0x294
	[SerializeField] // RVA: 0x17E3C0 Offset: 0x17E4C1 VA: 0x17E3C0
	private int _sunSpriteItemCount; // 0x2A4
	[SerializeField] // RVA: 0x17E3D0 Offset: 0x17E4D1 VA: 0x17E3D0
	[RangeAttribute] // RVA: 0x17E3D0 Offset: 0x17E4D1 VA: 0x17E3D0
	private float _sunSpriteAnimationSpeed; // 0x2A8
	[SerializeField] // RVA: 0x17E410 Offset: 0x17E511 VA: 0x17E410
	[RangeAttribute] // RVA: 0x17E410 Offset: 0x17E511 VA: 0x17E410
	private float _cloudBegin; // 0x2AC
	private float _cloudTextureTiling; // 0x2B0
	private float _cloud2TextureTiling; // 0x2B4
	[SerializeField] // RVA: 0x17E450 Offset: 0x17E551 VA: 0x17E450
	private Color _cloudColor; // 0x2B8
	[SerializeField] // RVA: 0x17E460 Offset: 0x17E561 VA: 0x17E460
	private Texture _cloudTexture; // 0x2C8
	[SerializeField] // RVA: 0x17E470 Offset: 0x17E571 VA: 0x17E470
	private Texture _cloud2Texture; // 0x2D0
	[SerializeField] // RVA: 0x17E480 Offset: 0x17E581 VA: 0x17E480
	private Texture _artCloudCustomTexture; // 0x2D8
	[SerializeField] // RVA: 0x17E490 Offset: 0x17E591 VA: 0x17E490
	private float _cloudDensity; // 0x2E0
	[SerializeField] // RVA: 0x17E4A0 Offset: 0x17E5A1 VA: 0x17E4A0
	private float _cloud2Density; // 0x2E4
	[SerializeField] // RVA: 0x17E4B0 Offset: 0x17E5B1 VA: 0x17E4B0
	private float _cloudSpeed; // 0x2E8
	[SerializeField] // RVA: 0x17E4C0 Offset: 0x17E5C1 VA: 0x17E4C0
	private float _cloud2Speed; // 0x2EC
	[SerializeField] // RVA: 0x17E4D0 Offset: 0x17E5D1 VA: 0x17E4D0
	private float _cloudDirection; // 0x2F0
	[SerializeField] // RVA: 0x17E4E0 Offset: 0x17E5E1 VA: 0x17E4E0
	private float _cloud2Direction; // 0x2F4
	[SerializeField] // RVA: 0x17E4F0 Offset: 0x17E5F1 VA: 0x17E4F0
	private float _cloudHeight; // 0x2F8
	[SerializeField] // RVA: 0x17E500 Offset: 0x17E601 VA: 0x17E500
	private float _cloud2Height; // 0x2FC
	[SerializeField] // RVA: 0x17E510 Offset: 0x17E611 VA: 0x17E510
	private Color _cloudColor1; // 0x300
	[SerializeField] // RVA: 0x17E520 Offset: 0x17E621 VA: 0x17E520
	private Color _cloud2Color1; // 0x310
	[SerializeField] // RVA: 0x17E530 Offset: 0x17E631 VA: 0x17E530
	private Color _cloudColor2; // 0x320
	[SerializeField] // RVA: 0x17E540 Offset: 0x17E641 VA: 0x17E540
	private Color _cloud2Color2; // 0x330
	[SerializeField] // RVA: 0x17E550 Offset: 0x17E651 VA: 0x17E550
	private float _cloudFadePosition; // 0x340
	[SerializeField] // RVA: 0x17E560 Offset: 0x17E661 VA: 0x17E560
	private float _cloud2FadePosition; // 0x344
	[SerializeField] // RVA: 0x17E570 Offset: 0x17E671 VA: 0x17E570
	private float _cloudFadeAmount; // 0x348
	[SerializeField] // RVA: 0x17E580 Offset: 0x17E681 VA: 0x17E580
	private float _cloud2FadeAmount; // 0x34C
	[SerializeField] // RVA: 0x17E590 Offset: 0x17E691 VA: 0x17E590
	private Texture _cloudCubemap; // 0x350
	[SerializeField] // RVA: 0x17E5A0 Offset: 0x17E6A1 VA: 0x17E5A0
	private float _cloudCubemapRotationSpeed; // 0x358
	[SerializeField] // RVA: 0x17E5B0 Offset: 0x17E6B1 VA: 0x17E5B0
	private Texture _cloudCubemapDoubleLayerCustomTexture; // 0x360
	[SerializeField] // RVA: 0x17E5C0 Offset: 0x17E6C1 VA: 0x17E5C0
	private float _cloudCubemapDoubleLayerRotationSpeed; // 0x368
	[SerializeField] // RVA: 0x17E5D0 Offset: 0x17E6D1 VA: 0x17E5D0
	private float _cloudCubemapDoubleLayerHeight; // 0x36C
	[SerializeField] // RVA: 0x17E5E0 Offset: 0x17E6E1 VA: 0x17E5E0
	private Color _cloudCubemapDoubleLayerTintColor; // 0x370
	[SerializeField] // RVA: 0x17E5F0 Offset: 0x17E6F1 VA: 0x17E5F0
	private Color _cloudCubemapTintColor; // 0x380
	[SerializeField] // RVA: 0x17E600 Offset: 0x17E701 VA: 0x17E600
	private float _cloudCubemapHeight; // 0x390
	[SerializeField] // RVA: 0x17E610 Offset: 0x17E711 VA: 0x17E610
	private Texture _cloudCubemapNormalTexture; // 0x398
	[SerializeField] // RVA: 0x17E620 Offset: 0x17E721 VA: 0x17E620
	private Color _cloudCubemapNormalLitColor; // 0x3A0
	[SerializeField] // RVA: 0x17E630 Offset: 0x17E731 VA: 0x17E630
	private Color _cloudCubemapNormalShadowColor; // 0x3B0
	[SerializeField] // RVA: 0x17E640 Offset: 0x17E741 VA: 0x17E640
	private float _cloudCubemapNormalRotationSpeed; // 0x3C0
	[SerializeField] // RVA: 0x17E650 Offset: 0x17E751 VA: 0x17E650
	private float _cloudCubemapNormalHeight; // 0x3C4
	[SerializeField] // RVA: 0x17E660 Offset: 0x17E761 VA: 0x17E660
	private float _cloudCubemapNormalAmbientItensity; // 0x3C8
	[SerializeField] // RVA: 0x17E670 Offset: 0x17E771 VA: 0x17E670
	private Texture _cloudCubemapNormalDoubleLayerCustomTexture; // 0x3D0
	[SerializeField] // RVA: 0x17E680 Offset: 0x17E781 VA: 0x17E680
	private float _cloudCubemapNormalDoubleLayerRotationSpeed; // 0x3D8
	[SerializeField] // RVA: 0x17E690 Offset: 0x17E791 VA: 0x17E690
	private float _cloudCubemapNormalDoubleLayerHeight; // 0x3DC
	[SerializeField] // RVA: 0x17E6A0 Offset: 0x17E7A1 VA: 0x17E6A0
	private Color _cloudCubemapNormalDoubleLayerLitColor; // 0x3E0
	[SerializeField] // RVA: 0x17E6B0 Offset: 0x17E7B1 VA: 0x17E6B0
	private Color _cloudCubemapNormalDoubleLayerShadowColor; // 0x3F0
	[SerializeField] // RVA: 0x17E6C0 Offset: 0x17E7C1 VA: 0x17E6C0
	private Vector3 _cloudCubemapNormalLightDirection; // 0x400
	[SerializeField] // RVA: 0x17E6D0 Offset: 0x17E7D1 VA: 0x17E6D0
	private Color _fogColor; // 0x40C
	[SerializeField] // RVA: 0x17E6E0 Offset: 0x17E7E1 VA: 0x17E6E0
	private float _fogDensity; // 0x41C
	[SerializeField] // RVA: 0x17E6F0 Offset: 0x17E7F1 VA: 0x17E6F0
	private float _fogHeight; // 0x420
	private int _GradientSkyUpperColorId; // 0x424
	private int _GradientSkyMiddleColorId; // 0x428
	private int _GradientSkyLowerColorId; // 0x42C
	private int _GradientFadeMiddlePositionId; // 0x430
	private int _MainTexId; // 0x434
	private int _HorizonScaleFactorId; // 0x438
	private int _StarBasicCubemapId; // 0x43C
	private int _StarBasicTwinkleSpeedId; // 0x440
	private int _StarBasicTwinkleAmountId; // 0x444
	private int _StarBasicOpacityId; // 0x448
	private int _StarBasicTintColorId; // 0x44C
	private int _StarBasicExponentId; // 0x450
	private int _StarBasicHDRBoostId; // 0x454
	private int _StarLayer1TexId; // 0x458
	private int _StarLayer1DataTexId; // 0x45C
	private int _StarLayer1ColorId; // 0x460
	private int _StarLayer1MaxRadiusId; // 0x464
	private int _StarLayer1TwinkleAmountId; // 0x468
	private int _StarLayer1TwinkleSpeedId; // 0x46C
	private int _StarLayer1RotationSpeedId; // 0x470
	private int _StarLayer1EdgeFadeId; // 0x474
	private int _StarLayer1HDRBoostId; // 0x478
	private int _StarLayer1SpriteDimensionsId; // 0x47C
	private int _StarLayer1SpriteItemCountId; // 0x480
	private int _StarLayer1SpriteAnimationSpeedId; // 0x484
	private int _StarLayer2TexId; // 0x488
	private int _StarLayer2DataTexId; // 0x48C
	private int _StarLayer2ColorId; // 0x490
	private int _StarLayer2MaxRadiusId; // 0x494
	private int _StarLayer2TwinkleAmountId; // 0x498
	private int _StarLayer2TwinkleSpeedId; // 0x49C
	private int _StarLayer2RotationSpeedId; // 0x4A0
	private int _StarLayer2EdgeFadeId; // 0x4A4
	private int _StarLayer2HDRBoostId; // 0x4A8
	private int _StarLayer2SpriteDimensionsId; // 0x4AC
	private int _StarLayer2SpriteItemCountId; // 0x4B0
	private int _StarLayer2SpriteAnimationSpeedId; // 0x4B4
	private int _StarLayer3TexId; // 0x4B8
	private int _StarLayer3DataTexId; // 0x4BC
	private int _StarLayer3ColorId; // 0x4C0
	private int _StarLayer3MaxRadiusId; // 0x4C4
	private int _StarLayer3TwinkleAmountId; // 0x4C8
	private int _StarLayer3TwinkleSpeedId; // 0x4CC
	private int _StarLayer3RotationSpeedId; // 0x4D0
	private int _StarLayer3EdgeFadeId; // 0x4D4
	private int _StarLayer3HDRBoostId; // 0x4D8
	private int _StarLayer3SpriteDimensionsId; // 0x4DC
	private int _StarLayer3SpriteItemCountId; // 0x4E0
	private int _StarLayer3SpriteAnimationSpeedId; // 0x4E4
	private int _MoonTexId; // 0x4E8
	private int _MoonRotationSpeedId; // 0x4EC
	private int _MoonColorId; // 0x4F0
	private int _MoonPositionId; // 0x4F4
	private int _MoonWorldToLocalMatId; // 0x4F8
	private int _MoonRadiusId; // 0x4FC
	private int _MoonEdgeFadeId; // 0x500
	private int _MoonHDRBoostId; // 0x504
	private int _MoonSpriteDimensionsId; // 0x508
	private int _MoonSpriteItemCountId; // 0x50C
	private int _MoonSpriteAnimationSpeedId; // 0x510
	private int _SunTexId; // 0x514
	private int _SunColorId; // 0x518
	private int _SunRotationSpeedId; // 0x51C
	private int _SunPositionId; // 0x520
	private int _SunWorldToLocalMatId; // 0x524
	private int _SunRadiusId; // 0x528
	private int _SunEdgeFadeId; // 0x52C
	private int _SunHDRBoostId; // 0x530
	private int _SunSpriteDimensionsId; // 0x534
	private int _SunSpriteItemCountId; // 0x538
	private int _SunSpriteAnimationSpeedId; // 0x53C
	private int _CloudBeginId; // 0x540
	private int _CloudTextureTilingId; // 0x544
	private int _Cloud2TextureTilingId; // 0x548
	private int _CloudColorId; // 0x54C
	private int _CloudNoiseTextureId; // 0x550
	private int _Cloud2NoiseTextureId; // 0x554
	private int _ArtCloudCustomTextureId; // 0x558
	private int _CloudDensityId; // 0x55C
	private int _Cloud2DensityId; // 0x560
	private int _CloudSpeedId; // 0x564
	private int _Cloud2SpeedId; // 0x568
	private int _CloudDirectionId; // 0x56C
	private int _Cloud2DirectionId; // 0x570
	private int _CloudHeightId; // 0x574
	private int _Cloud2HeightId; // 0x578
	private int _CloudColor1Id; // 0x57C
	private int _Cloud2Color1Id; // 0x580
	private int _CloudColor2Id; // 0x584
	private int _Cloud2Color2Id; // 0x588
	private int _CloudFadePositionId; // 0x58C
	private int _Cloud2FadePositionId; // 0x590
	private int _CloudFadeAmountId; // 0x594
	private int _Cloud2FadeAmountId; // 0x598
	private int _CloudCubemapTextureId; // 0x59C
	private int _CloudCubemapRotationSpeedId; // 0x5A0
	private int _CloudCubemapDoubleTextureId; // 0x5A4
	private int _CloudCubemapDoubleLayerRotationSpeedId; // 0x5A8
	private int _CloudCubemapDoubleLayerHeightId; // 0x5AC
	private int _CloudCubemapDoubleLayerTintColorId; // 0x5B0
	private int _CloudCubemapTintColorId; // 0x5B4
	private int _CloudCubemapHeightId; // 0x5B8
	private int _CloudCubemapNormalTextureId; // 0x5BC
	private int _CloudCubemapNormalLitColorId; // 0x5C0
	private int _CloudCubemapNormalShadowColorId; // 0x5C4
	private int _CloudCubemapNormalRotationSpeedId; // 0x5C8
	private int _CloudCubemapNormalHeightId; // 0x5CC
	private int _CloudCubemapNormalAmbientIntensityId; // 0x5D0
	private int _CloudCubemapNormalDoubleTextureId; // 0x5D4
	private int _CloudCubemapNormalDoubleLayerRotationSpeedId; // 0x5D8
	private int _CloudCubemapNormalDoubleLayerHeightId; // 0x5DC
	private int _CloudCubemapNormalDoubleLitColorId; // 0x5E0
	private int _CloudCubemapNormalDoubleShadowColorId; // 0x5E4
	private int _CloudCubemapNormalToLightId; // 0x5E8
	private int _HorizonFogColorId; // 0x5EC
	private int _HorizonFogDensityId; // 0x5F0
	private int _HorizonFogLengthId; // 0x5F4
	private int _GradientFadeBeginId; // 0x5F8
	private int _GradientFadeEndId; // 0x5FC
	private int _StarFadeBeginId; // 0x600
	private int _StarFadeEndId; // 0x604

	// Properties
	public Material SkyboxMaterial { get; set; }
	public Color SkyColor { get; set; }
	public Color SkyMiddleColor { get; set; }
	public Color HorizonColor { get; set; }
	public float GradientFadeBegin { get; set; }
	public float GradientFadeLength { get; set; }
	public float SkyMiddlePosition { get; set; }
	public Cubemap BackgroundCubemap { get; set; }
	public float StarFadeBegin { get; set; }
	public float StarFadeLength { get; set; }
	public float HorizonDistanceScale { get; set; }
	public Texture StarBasicCubemap { get; set; }
	public float StarBasicTwinkleSpeed { get; set; }
	public float StarBasicTwinkleAmount { get; set; }
	public float StarBasicOpacity { get; set; }
	public Color StarBasicTintColor { get; set; }
	public float StarBasicExponent { get; set; }
	public float StarBasicIntensity { get; set; }
	public Texture StarLayer1Texture { get; set; }
	public Texture2D StarLayer1DataTexture { get; set; }
	public Color StarLayer1Color { get; set; }
	public float StarLayer1MaxRadius { get; set; }
	public float StarLayer1TwinkleAmount { get; set; }
	public float StarLayer1TwinkleSpeed { get; set; }
	public float StarLayer1RotationSpeed { get; set; }
	public float StarLayer1EdgeFeathering { get; set; }
	public float StarLayer1BloomFilterBoost { get; set; }
	public int StarLayer1SpriteItemCount { get; set; }
	public float StarLayer1SpriteAnimationSpeed { get; set; }
	public Texture StarLayer2Texture { get; set; }
	public Texture2D StarLayer2DataTexture { get; set; }
	public Color StarLayer2Color { get; set; }
	public float StarLayer2MaxRadius { get; set; }
	public float StarLayer2TwinkleAmount { get; set; }
	public float StarLayer2TwinkleSpeed { get; set; }
	public float StarLayer2RotationSpeed { get; set; }
	public float StarLayer2EdgeFeathering { get; set; }
	public float StarLayer2BloomFilterBoost { get; set; }
	public int StarLayer2SpriteItemCount { get; set; }
	public float StarLayer2SpriteAnimationSpeed { get; set; }
	public Texture StarLayer3Texture { get; set; }
	public Texture2D StarLayer3DataTexture { get; set; }
	public Color StarLayer3Color { get; set; }
	public float StarLayer3MaxRadius { get; set; }
	public float StarLayer3TwinkleAmount { get; set; }
	public float StarLayer3TwinkleSpeed { get; set; }
	public float StarLayer3RotationSpeed { get; set; }
	public float StarLayer3EdgeFeathering { get; set; }
	public float StarLayer3BloomFilterBoost { get; set; }
	public int StarLayer3SpriteItemCount { get; set; }
	public float StarLayer3SpriteAnimationSpeed { get; set; }
	public Texture MoonTexture { get; set; }
	public float MoonRotationSpeed { get; set; }
	public Color MoonColor { get; set; }
	public Vector3 MoonDirection { get; set; }
	public Matrix4x4 MoonWorldToLocalMatrix { get; set; }
	public float MoonSize { get; set; }
	public float MoonEdgeFeathering { get; set; }
	public float MoonBloomFilterBoost { get; set; }
	public int MoonSpriteItemCount { get; set; }
	public float MoonSpriteAnimationSpeed { get; set; }
	public Texture SunTexture { get; set; }
	public Color SunColor { get; set; }
	public float SunRotationSpeed { get; set; }
	public Vector3 SunDirection { get; set; }
	public Matrix4x4 SunWorldToLocalMatrix { get; set; }
	public float SunSize { get; set; }
	public float SunEdgeFeathering { get; set; }
	public float SunBloomFilterBoost { get; set; }
	public int SunSpriteItemCount { get; set; }
	public float SunSpriteAnimationSpeed { get; set; }
	public float CloudBegin { get; set; }
	public float CloudTextureTiling { get; set; }
	public float Cloud2TextureTiling { get; set; }
	public Color CloudColor { get; set; }
	public Texture CloudTexture { get; set; }
	public Texture Cloud2Texture { get; set; }
	public Texture ArtCloudCustomTexture { get; set; }
	public float CloudDensity { get; set; }
	public float Cloud2Density { get; set; }
	public float CloudSpeed { get; set; }
	public float Cloud2Speed { get; set; }
	public float CloudDirection { get; set; }
	public float Cloud2Direction { get; set; }
	public float CloudHeight { get; set; }
	public float Cloud2Height { get; set; }
	public Color CloudColor1 { get; set; }
	public Color Cloud2Color1 { get; set; }
	public Color CloudColor2 { get; set; }
	public Color Cloud2Color2 { get; set; }
	public float CloudFadePosition { get; set; }
	public float Cloud2FadePosition { get; set; }
	public float CloudFadeAmount { get; set; }
	public float Cloud2FadeAmount { get; set; }
	public Texture CloudCubemap { get; set; }
	public float CloudCubemapRotationSpeed { get; set; }
	public Texture CloudCubemapDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapDoubleLayerHeight { get; set; }
	public Color CloudCubemapDoubleLayerTintColor { get; set; }
	public Color CloudCubemapTintColor { get; set; }
	public float CloudCubemapHeight { get; set; }
	public Texture CloudCubemapNormalTexture { get; set; }
	public Color CloudCubemapNormalLitColor { get; set; }
	public Color CloudCubemapNormalShadowColor { get; set; }
	public float CloudCubemapNormalRotationSpeed { get; set; }
	public float CloudCubemapNormalHeight { get; set; }
	public float CloudCubemapNormalAmbientIntensity { get; set; }
	public Texture CloudCubemapNormalDoubleLayerCustomTexture { get; set; }
	public float CloudCubemapNormalDoubleLayerRotationSpeed { get; set; }
	public float CloudCubemapNormalDoubleLayerHeight { get; set; }
	public Color CloudCubemapNormalDoubleLayerLitColor { get; set; }
	public Color CloudCubemapNormalDoubleLayerShadowColor { get; set; }
	public Vector3 CloudCubemapNormalLightDirection { get; set; }
	public Color FogColor { get; set; }
	public float FogDensity { get; set; }
	public float FogHeight { get; set; }

	// Methods

	// RVA: 0x22B8820 Offset: 0x22B8921 VA: 0x22B8820
	public Material get_SkyboxMaterial() { }

	// RVA: 0x22B8830 Offset: 0x22B8931 VA: 0x22B8830
	public void set_SkyboxMaterial(Material value) { }

	// RVA: 0x22B8860 Offset: 0x22B8961 VA: 0x22B8860
	public Color get_SkyColor() { }

	// RVA: 0x22B8870 Offset: 0x22B8971 VA: 0x22B8870
	public void set_SkyColor(Color value) { }

	// RVA: 0x22B88B0 Offset: 0x22B89B1 VA: 0x22B88B0
	public Color get_SkyMiddleColor() { }

	// RVA: 0x22B88C0 Offset: 0x22B89C1 VA: 0x22B88C0
	public void set_SkyMiddleColor(Color value) { }

	// RVA: 0x22B8900 Offset: 0x22B8A01 VA: 0x22B8900
	public Color get_HorizonColor() { }

	// RVA: 0x22B8910 Offset: 0x22B8A11 VA: 0x22B8910
	public void set_HorizonColor(Color value) { }

	// RVA: 0x22B8950 Offset: 0x22B8A51 VA: 0x22B8950
	public float get_GradientFadeBegin() { }

	// RVA: 0x22B8960 Offset: 0x22B8A61 VA: 0x22B8960
	public void set_GradientFadeBegin(float value) { }

	// RVA: 0x22B8A30 Offset: 0x22B8B31 VA: 0x22B8A30
	public float get_GradientFadeLength() { }

	// RVA: 0x22B8A40 Offset: 0x22B8B41 VA: 0x22B8A40
	public void set_GradientFadeLength(float value) { }

	// RVA: 0x22B8A50 Offset: 0x22B8B51 VA: 0x22B8A50
	public float get_SkyMiddlePosition() { }

	// RVA: 0x22B8A60 Offset: 0x22B8B61 VA: 0x22B8A60
	public void set_SkyMiddlePosition(float value) { }

	// RVA: 0x22B8A90 Offset: 0x22B8B91 VA: 0x22B8A90
	public Cubemap get_BackgroundCubemap() { }

	// RVA: 0x22B8AA0 Offset: 0x22B8BA1 VA: 0x22B8AA0
	public void set_BackgroundCubemap(Cubemap value) { }

	// RVA: 0x22B8AF0 Offset: 0x22B8BF1 VA: 0x22B8AF0
	public float get_StarFadeBegin() { }

	// RVA: 0x22B8B00 Offset: 0x22B8C01 VA: 0x22B8B00
	public void set_StarFadeBegin(float value) { }

	// RVA: 0x22B8BD0 Offset: 0x22B8CD1 VA: 0x22B8BD0
	public float get_StarFadeLength() { }

	// RVA: 0x22B8BE0 Offset: 0x22B8CE1 VA: 0x22B8BE0
	public void set_StarFadeLength(float value) { }

	// RVA: 0x22B8BF0 Offset: 0x22B8CF1 VA: 0x22B8BF0
	public float get_HorizonDistanceScale() { }

	// RVA: 0x22B8C00 Offset: 0x22B8D01 VA: 0x22B8C00
	public void set_HorizonDistanceScale(float value) { }

	// RVA: 0x22B8C30 Offset: 0x22B8D31 VA: 0x22B8C30
	public Texture get_StarBasicCubemap() { }

	// RVA: 0x22B8C40 Offset: 0x22B8D41 VA: 0x22B8C40
	public void set_StarBasicCubemap(Texture value) { }

	// RVA: 0x22B8C90 Offset: 0x22B8D91 VA: 0x22B8C90
	public float get_StarBasicTwinkleSpeed() { }

	// RVA: 0x22B8CA0 Offset: 0x22B8DA1 VA: 0x22B8CA0
	public void set_StarBasicTwinkleSpeed(float value) { }

	// RVA: 0x22B8CD0 Offset: 0x22B8DD1 VA: 0x22B8CD0
	public float get_StarBasicTwinkleAmount() { }

	// RVA: 0x22B8CE0 Offset: 0x22B8DE1 VA: 0x22B8CE0
	public void set_StarBasicTwinkleAmount(float value) { }

	// RVA: 0x22B8D10 Offset: 0x22B8E11 VA: 0x22B8D10
	public float get_StarBasicOpacity() { }

	// RVA: 0x22B8D20 Offset: 0x22B8E21 VA: 0x22B8D20
	public void set_StarBasicOpacity(float value) { }

	// RVA: 0x22B8D50 Offset: 0x22B8E51 VA: 0x22B8D50
	public Color get_StarBasicTintColor() { }

	// RVA: 0x22B8D60 Offset: 0x22B8E61 VA: 0x22B8D60
	public void set_StarBasicTintColor(Color value) { }

	// RVA: 0x22B8DA0 Offset: 0x22B8EA1 VA: 0x22B8DA0
	public float get_StarBasicExponent() { }

	// RVA: 0x22B8DB0 Offset: 0x22B8EB1 VA: 0x22B8DB0
	public void set_StarBasicExponent(float value) { }

	// RVA: 0x22B8DE0 Offset: 0x22B8EE1 VA: 0x22B8DE0
	public float get_StarBasicIntensity() { }

	// RVA: 0x22B8DF0 Offset: 0x22B8EF1 VA: 0x22B8DF0
	public void set_StarBasicIntensity(float value) { }

	// RVA: 0x22B8E20 Offset: 0x22B8F21 VA: 0x22B8E20
	public Texture get_StarLayer1Texture() { }

	// RVA: 0x22B8E30 Offset: 0x22B8F31 VA: 0x22B8E30
	public void set_StarLayer1Texture(Texture value) { }

	// RVA: 0x22B8E80 Offset: 0x22B8F81 VA: 0x22B8E80
	public Texture2D get_StarLayer1DataTexture() { }

	// RVA: 0x22B8E90 Offset: 0x22B8F91 VA: 0x22B8E90
	public void set_StarLayer1DataTexture(Texture2D value) { }

	// RVA: 0x22B8EE0 Offset: 0x22B8FE1 VA: 0x22B8EE0
	public Color get_StarLayer1Color() { }

	// RVA: 0x22B8EF0 Offset: 0x22B8FF1 VA: 0x22B8EF0
	public void set_StarLayer1Color(Color value) { }

	// RVA: 0x22B8F30 Offset: 0x22B9031 VA: 0x22B8F30
	public float get_StarLayer1MaxRadius() { }

	// RVA: 0x22B8F40 Offset: 0x22B9041 VA: 0x22B8F40
	public void set_StarLayer1MaxRadius(float value) { }

	// RVA: 0x22B8F70 Offset: 0x22B9071 VA: 0x22B8F70
	public float get_StarLayer1TwinkleAmount() { }

	// RVA: 0x22B8F80 Offset: 0x22B9081 VA: 0x22B8F80
	public void set_StarLayer1TwinkleAmount(float value) { }

	// RVA: 0x22B8FB0 Offset: 0x22B90B1 VA: 0x22B8FB0
	public float get_StarLayer1TwinkleSpeed() { }

	// RVA: 0x22B8FC0 Offset: 0x22B90C1 VA: 0x22B8FC0
	public void set_StarLayer1TwinkleSpeed(float value) { }

	// RVA: 0x22B8FF0 Offset: 0x22B90F1 VA: 0x22B8FF0
	public float get_StarLayer1RotationSpeed() { }

	// RVA: 0x22B9000 Offset: 0x22B9101 VA: 0x22B9000
	public void set_StarLayer1RotationSpeed(float value) { }

	// RVA: 0x22B9030 Offset: 0x22B9131 VA: 0x22B9030
	public float get_StarLayer1EdgeFeathering() { }

	// RVA: 0x22B9040 Offset: 0x22B9141 VA: 0x22B9040
	public void set_StarLayer1EdgeFeathering(float value) { }

	// RVA: 0x22B9070 Offset: 0x22B9171 VA: 0x22B9070
	public float get_StarLayer1BloomFilterBoost() { }

	// RVA: 0x22B9080 Offset: 0x22B9181 VA: 0x22B9080
	public void set_StarLayer1BloomFilterBoost(float value) { }

	// RVA: 0x22B90B0 Offset: 0x22B91B1 VA: 0x22B90B0
	public void SetStarLayer1SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B90F0 Offset: 0x22B91F1 VA: 0x22B90F0
	public Vector2 GetStarLayer1SpriteDimensions() { }

	// RVA: 0x22B9120 Offset: 0x22B9221 VA: 0x22B9120
	public int get_StarLayer1SpriteItemCount() { }

	// RVA: 0x22B9130 Offset: 0x22B9231 VA: 0x22B9130
	public void set_StarLayer1SpriteItemCount(int value) { }

	// RVA: 0x22B9160 Offset: 0x22B9261 VA: 0x22B9160
	public float get_StarLayer1SpriteAnimationSpeed() { }

	// RVA: 0x22B9170 Offset: 0x22B9271 VA: 0x22B9170
	public void set_StarLayer1SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B91A0 Offset: 0x22B92A1 VA: 0x22B91A0
	public Texture get_StarLayer2Texture() { }

	// RVA: 0x22B91B0 Offset: 0x22B92B1 VA: 0x22B91B0
	public void set_StarLayer2Texture(Texture value) { }

	// RVA: 0x22B9200 Offset: 0x22B9301 VA: 0x22B9200
	public Texture2D get_StarLayer2DataTexture() { }

	// RVA: 0x22B9210 Offset: 0x22B9311 VA: 0x22B9210
	public void set_StarLayer2DataTexture(Texture2D value) { }

	// RVA: 0x22B9260 Offset: 0x22B9361 VA: 0x22B9260
	public Color get_StarLayer2Color() { }

	// RVA: 0x22B9280 Offset: 0x22B9381 VA: 0x22B9280
	public void set_StarLayer2Color(Color value) { }

	// RVA: 0x22B92C0 Offset: 0x22B93C1 VA: 0x22B92C0
	public float get_StarLayer2MaxRadius() { }

	// RVA: 0x22B92D0 Offset: 0x22B93D1 VA: 0x22B92D0
	public void set_StarLayer2MaxRadius(float value) { }

	// RVA: 0x22B9300 Offset: 0x22B9401 VA: 0x22B9300
	public float get_StarLayer2TwinkleAmount() { }

	// RVA: 0x22B9310 Offset: 0x22B9411 VA: 0x22B9310
	public void set_StarLayer2TwinkleAmount(float value) { }

	// RVA: 0x22B9340 Offset: 0x22B9441 VA: 0x22B9340
	public float get_StarLayer2TwinkleSpeed() { }

	// RVA: 0x22B9350 Offset: 0x22B9451 VA: 0x22B9350
	public void set_StarLayer2TwinkleSpeed(float value) { }

	// RVA: 0x22B9380 Offset: 0x22B9481 VA: 0x22B9380
	public float get_StarLayer2RotationSpeed() { }

	// RVA: 0x22B9390 Offset: 0x22B9491 VA: 0x22B9390
	public void set_StarLayer2RotationSpeed(float value) { }

	// RVA: 0x22B93C0 Offset: 0x22B94C1 VA: 0x22B93C0
	public float get_StarLayer2EdgeFeathering() { }

	// RVA: 0x22B93D0 Offset: 0x22B94D1 VA: 0x22B93D0
	public void set_StarLayer2EdgeFeathering(float value) { }

	// RVA: 0x22B9400 Offset: 0x22B9501 VA: 0x22B9400
	public float get_StarLayer2BloomFilterBoost() { }

	// RVA: 0x22B9410 Offset: 0x22B9511 VA: 0x22B9410
	public void set_StarLayer2BloomFilterBoost(float value) { }

	// RVA: 0x22B9440 Offset: 0x22B9541 VA: 0x22B9440
	public void SetStarLayer2SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9480 Offset: 0x22B9581 VA: 0x22B9480
	public Vector2 GetStarLayer2SpriteDimensions() { }

	// RVA: 0x22B94C0 Offset: 0x22B95C1 VA: 0x22B94C0
	public int get_StarLayer2SpriteItemCount() { }

	// RVA: 0x22B94D0 Offset: 0x22B95D1 VA: 0x22B94D0
	public void set_StarLayer2SpriteItemCount(int value) { }

	// RVA: 0x22B9500 Offset: 0x22B9601 VA: 0x22B9500
	public float get_StarLayer2SpriteAnimationSpeed() { }

	// RVA: 0x22B9510 Offset: 0x22B9611 VA: 0x22B9510
	public void set_StarLayer2SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B9540 Offset: 0x22B9641 VA: 0x22B9540
	public Texture get_StarLayer3Texture() { }

	// RVA: 0x22B9550 Offset: 0x22B9651 VA: 0x22B9550
	public void set_StarLayer3Texture(Texture value) { }

	// RVA: 0x22B9590 Offset: 0x22B9691 VA: 0x22B9590
	public Texture2D get_StarLayer3DataTexture() { }

	// RVA: 0x22B95A0 Offset: 0x22B96A1 VA: 0x22B95A0
	public void set_StarLayer3DataTexture(Texture2D value) { }

	// RVA: 0x22B95F0 Offset: 0x22B96F1 VA: 0x22B95F0
	public Color get_StarLayer3Color() { }

	// RVA: 0x22B9610 Offset: 0x22B9711 VA: 0x22B9610
	public void set_StarLayer3Color(Color value) { }

	// RVA: 0x22B9650 Offset: 0x22B9751 VA: 0x22B9650
	public float get_StarLayer3MaxRadius() { }

	// RVA: 0x22B9660 Offset: 0x22B9761 VA: 0x22B9660
	public void set_StarLayer3MaxRadius(float value) { }

	// RVA: 0x22B9690 Offset: 0x22B9791 VA: 0x22B9690
	public float get_StarLayer3TwinkleAmount() { }

	// RVA: 0x22B96A0 Offset: 0x22B97A1 VA: 0x22B96A0
	public void set_StarLayer3TwinkleAmount(float value) { }

	// RVA: 0x22B96D0 Offset: 0x22B97D1 VA: 0x22B96D0
	public float get_StarLayer3TwinkleSpeed() { }

	// RVA: 0x22B96E0 Offset: 0x22B97E1 VA: 0x22B96E0
	public void set_StarLayer3TwinkleSpeed(float value) { }

	// RVA: 0x22B9710 Offset: 0x22B9811 VA: 0x22B9710
	public float get_StarLayer3RotationSpeed() { }

	// RVA: 0x22B9720 Offset: 0x22B9821 VA: 0x22B9720
	public void set_StarLayer3RotationSpeed(float value) { }

	// RVA: 0x22B9750 Offset: 0x22B9851 VA: 0x22B9750
	public float get_StarLayer3EdgeFeathering() { }

	// RVA: 0x22B9760 Offset: 0x22B9861 VA: 0x22B9760
	public void set_StarLayer3EdgeFeathering(float value) { }

	// RVA: 0x22B9790 Offset: 0x22B9891 VA: 0x22B9790
	public float get_StarLayer3BloomFilterBoost() { }

	// RVA: 0x22B97A0 Offset: 0x22B98A1 VA: 0x22B97A0
	public void set_StarLayer3BloomFilterBoost(float value) { }

	// RVA: 0x22B97D0 Offset: 0x22B98D1 VA: 0x22B97D0
	public void SetStarLayer3SpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9810 Offset: 0x22B9911 VA: 0x22B9810
	public Vector2 GetStarLayer3SpriteDimensions() { }

	// RVA: 0x22B9850 Offset: 0x22B9951 VA: 0x22B9850
	public int get_StarLayer3SpriteItemCount() { }

	// RVA: 0x22B9860 Offset: 0x22B9961 VA: 0x22B9860
	public void set_StarLayer3SpriteItemCount(int value) { }

	// RVA: 0x22B9890 Offset: 0x22B9991 VA: 0x22B9890
	public float get_StarLayer3SpriteAnimationSpeed() { }

	// RVA: 0x22B98A0 Offset: 0x22B99A1 VA: 0x22B98A0
	public void set_StarLayer3SpriteAnimationSpeed(float value) { }

	// RVA: 0x22B98D0 Offset: 0x22B99D1 VA: 0x22B98D0
	public Texture get_MoonTexture() { }

	// RVA: 0x22B98E0 Offset: 0x22B99E1 VA: 0x22B98E0
	public void set_MoonTexture(Texture value) { }

	// RVA: 0x22B9920 Offset: 0x22B9A21 VA: 0x22B9920
	public float get_MoonRotationSpeed() { }

	// RVA: 0x22B9930 Offset: 0x22B9A31 VA: 0x22B9930
	public void set_MoonRotationSpeed(float value) { }

	// RVA: 0x22B9960 Offset: 0x22B9A61 VA: 0x22B9960
	public Color get_MoonColor() { }

	// RVA: 0x22B9980 Offset: 0x22B9A81 VA: 0x22B9980
	public void set_MoonColor(Color value) { }

	// RVA: 0x22B99C0 Offset: 0x22B9AC1 VA: 0x22B99C0
	public Vector3 get_MoonDirection() { }

	// RVA: 0x22B99D0 Offset: 0x22B9AD1 VA: 0x22B99D0
	public void set_MoonDirection(Vector3 value) { }

	// RVA: 0x22B9AB0 Offset: 0x22B9BB1 VA: 0x22B9AB0
	public Matrix4x4 get_MoonWorldToLocalMatrix() { }

	// RVA: 0x22B9AE0 Offset: 0x22B9BE1 VA: 0x22B9AE0
	public void set_MoonWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x22B9B70 Offset: 0x22B9C71 VA: 0x22B9B70
	public float get_MoonSize() { }

	// RVA: 0x22B9B80 Offset: 0x22B9C81 VA: 0x22B9B80
	public void set_MoonSize(float value) { }

	// RVA: 0x22B9BB0 Offset: 0x22B9CB1 VA: 0x22B9BB0
	public float get_MoonEdgeFeathering() { }

	// RVA: 0x22B9BC0 Offset: 0x22B9CC1 VA: 0x22B9BC0
	public void set_MoonEdgeFeathering(float value) { }

	// RVA: 0x22B9BF0 Offset: 0x22B9CF1 VA: 0x22B9BF0
	public float get_MoonBloomFilterBoost() { }

	// RVA: 0x22B9C00 Offset: 0x22B9D01 VA: 0x22B9C00
	public void set_MoonBloomFilterBoost(float value) { }

	// RVA: 0x22B9C30 Offset: 0x22B9D31 VA: 0x22B9C30
	public void SetMoonSpriteDimensions(int columns, int rows) { }

	// RVA: 0x22B9C70 Offset: 0x22B9D71 VA: 0x22B9C70
	public Vector2 GetMoonSpriteDimensions() { }

	// RVA: 0x22B9CB0 Offset: 0x22B9DB1 VA: 0x22B9CB0
	public int get_MoonSpriteItemCount() { }

	// RVA: 0x22B9CC0 Offset: 0x22B9DC1 VA: 0x22B9CC0
	public void set_MoonSpriteItemCount(int value) { }

	// RVA: 0x22B9CF0 Offset: 0x22B9DF1 VA: 0x22B9CF0
	public float get_MoonSpriteAnimationSpeed() { }

	// RVA: 0x22B9D00 Offset: 0x22B9E01 VA: 0x22B9D00
	public void set_MoonSpriteAnimationSpeed(float value) { }

	// RVA: 0x22B9D30 Offset: 0x22B9E31 VA: 0x22B9D30
	public Texture get_SunTexture() { }

	// RVA: 0x22B9D40 Offset: 0x22B9E41 VA: 0x22B9D40
	public void set_SunTexture(Texture value) { }

	// RVA: 0x22B9D80 Offset: 0x22B9E81 VA: 0x22B9D80
	public Color get_SunColor() { }

	// RVA: 0x22B9DA0 Offset: 0x22B9EA1 VA: 0x22B9DA0
	public void set_SunColor(Color value) { }

	// RVA: 0x22B9DE0 Offset: 0x22B9EE1 VA: 0x22B9DE0
	public float get_SunRotationSpeed() { }

	// RVA: 0x22B9DF0 Offset: 0x22B9EF1 VA: 0x22B9DF0
	public void set_SunRotationSpeed(float value) { }

	// RVA: 0x22B9E20 Offset: 0x22B9F21 VA: 0x22B9E20
	public Vector3 get_SunDirection() { }

	// RVA: 0x22B9E30 Offset: 0x22B9F31 VA: 0x22B9E30
	public void set_SunDirection(Vector3 value) { }

	// RVA: 0x22B9F10 Offset: 0x22BA011 VA: 0x22B9F10
	public Matrix4x4 get_SunWorldToLocalMatrix() { }

	// RVA: 0x22B9F50 Offset: 0x22BA051 VA: 0x22B9F50
	public void set_SunWorldToLocalMatrix(Matrix4x4 value) { }

	// RVA: 0x22B9FF0 Offset: 0x22BA0F1 VA: 0x22B9FF0
	public float get_SunSize() { }

	// RVA: 0x22BA000 Offset: 0x22BA101 VA: 0x22BA000
	public void set_SunSize(float value) { }

	// RVA: 0x22BA030 Offset: 0x22BA131 VA: 0x22BA030
	public float get_SunEdgeFeathering() { }

	// RVA: 0x22BA040 Offset: 0x22BA141 VA: 0x22BA040
	public void set_SunEdgeFeathering(float value) { }

	// RVA: 0x22BA070 Offset: 0x22BA171 VA: 0x22BA070
	public float get_SunBloomFilterBoost() { }

	// RVA: 0x22BA080 Offset: 0x22BA181 VA: 0x22BA080
	public void set_SunBloomFilterBoost(float value) { }

	// RVA: 0x22BA0B0 Offset: 0x22BA1B1 VA: 0x22BA0B0
	public void SetSunSpriteDimensions(int columns, int rows) { }

	// RVA: 0x22BA0F0 Offset: 0x22BA1F1 VA: 0x22BA0F0
	public Vector2 GetSunSpriteDimensions() { }

	// RVA: 0x22BA130 Offset: 0x22BA231 VA: 0x22BA130
	public int get_SunSpriteItemCount() { }

	// RVA: 0x22BA140 Offset: 0x22BA241 VA: 0x22BA140
	public void set_SunSpriteItemCount(int value) { }

	// RVA: 0x22BA170 Offset: 0x22BA271 VA: 0x22BA170
	public float get_SunSpriteAnimationSpeed() { }

	// RVA: 0x22BA180 Offset: 0x22BA281 VA: 0x22BA180
	public void set_SunSpriteAnimationSpeed(float value) { }

	// RVA: 0x22BA1B0 Offset: 0x22BA2B1 VA: 0x22BA1B0
	public float get_CloudBegin() { }

	// RVA: 0x22BA1C0 Offset: 0x22BA2C1 VA: 0x22BA1C0
	public void set_CloudBegin(float value) { }

	// RVA: 0x22BA1F0 Offset: 0x22BA2F1 VA: 0x22BA1F0
	public float get_CloudTextureTiling() { }

	// RVA: 0x22BA200 Offset: 0x22BA301 VA: 0x22BA200
	public void set_CloudTextureTiling(float value) { }

	// RVA: 0x22BA230 Offset: 0x22BA331 VA: 0x22BA230
	public float get_Cloud2TextureTiling() { }

	// RVA: 0x22BA240 Offset: 0x22BA341 VA: 0x22BA240
	public void set_Cloud2TextureTiling(float value) { }

	// RVA: 0x22BA270 Offset: 0x22BA371 VA: 0x22BA270
	public Color get_CloudColor() { }

	// RVA: 0x22BA290 Offset: 0x22BA391 VA: 0x22BA290
	public void set_CloudColor(Color value) { }

	// RVA: 0x22BA2D0 Offset: 0x22BA3D1 VA: 0x22BA2D0
	public Texture get_CloudTexture() { }

	// RVA: 0x22BA360 Offset: 0x22BA461 VA: 0x22BA360
	public void set_CloudTexture(Texture value) { }

	// RVA: 0x22BA3A0 Offset: 0x22BA4A1 VA: 0x22BA3A0
	public Texture get_Cloud2Texture() { }

	// RVA: 0x22BA430 Offset: 0x22BA531 VA: 0x22BA430
	public void set_Cloud2Texture(Texture value) { }

	// RVA: 0x22BA470 Offset: 0x22BA571 VA: 0x22BA470
	public Texture get_ArtCloudCustomTexture() { }

	// RVA: 0x22BA500 Offset: 0x22BA601 VA: 0x22BA500
	public void set_ArtCloudCustomTexture(Texture value) { }

	// RVA: 0x22BA540 Offset: 0x22BA641 VA: 0x22BA540
	public float get_CloudDensity() { }

	// RVA: 0x22BA550 Offset: 0x22BA651 VA: 0x22BA550
	public void set_CloudDensity(float value) { }

	// RVA: 0x22BA580 Offset: 0x22BA681 VA: 0x22BA580
	public float get_Cloud2Density() { }

	// RVA: 0x22BA590 Offset: 0x22BA691 VA: 0x22BA590
	public void set_Cloud2Density(float value) { }

	// RVA: 0x22BA5C0 Offset: 0x22BA6C1 VA: 0x22BA5C0
	public float get_CloudSpeed() { }

	// RVA: 0x22BA5D0 Offset: 0x22BA6D1 VA: 0x22BA5D0
	public void set_CloudSpeed(float value) { }

	// RVA: 0x22BA600 Offset: 0x22BA701 VA: 0x22BA600
	public float get_Cloud2Speed() { }

	// RVA: 0x22BA610 Offset: 0x22BA711 VA: 0x22BA610
	public void set_Cloud2Speed(float value) { }

	// RVA: 0x22BA640 Offset: 0x22BA741 VA: 0x22BA640
	public float get_CloudDirection() { }

	// RVA: 0x22BA650 Offset: 0x22BA751 VA: 0x22BA650
	public void set_CloudDirection(float value) { }

	// RVA: 0x22BA680 Offset: 0x22BA781 VA: 0x22BA680
	public float get_Cloud2Direction() { }

	// RVA: 0x22BA690 Offset: 0x22BA791 VA: 0x22BA690
	public void set_Cloud2Direction(float value) { }

	// RVA: 0x22BA6C0 Offset: 0x22BA7C1 VA: 0x22BA6C0
	public float get_CloudHeight() { }

	// RVA: 0x22BA6D0 Offset: 0x22BA7D1 VA: 0x22BA6D0
	public void set_CloudHeight(float value) { }

	// RVA: 0x22BA700 Offset: 0x22BA801 VA: 0x22BA700
	public float get_Cloud2Height() { }

	// RVA: 0x22BA710 Offset: 0x22BA811 VA: 0x22BA710
	public void set_Cloud2Height(float value) { }

	// RVA: 0x22BA740 Offset: 0x22BA841 VA: 0x22BA740
	public Color get_CloudColor1() { }

	// RVA: 0x22BA760 Offset: 0x22BA861 VA: 0x22BA760
	public void set_CloudColor1(Color value) { }

	// RVA: 0x22BA7A0 Offset: 0x22BA8A1 VA: 0x22BA7A0
	public Color get_Cloud2Color1() { }

	// RVA: 0x22BA7C0 Offset: 0x22BA8C1 VA: 0x22BA7C0
	public void set_Cloud2Color1(Color value) { }

	// RVA: 0x22BA800 Offset: 0x22BA901 VA: 0x22BA800
	public Color get_CloudColor2() { }

	// RVA: 0x22BA820 Offset: 0x22BA921 VA: 0x22BA820
	public void set_CloudColor2(Color value) { }

	// RVA: 0x22BA860 Offset: 0x22BA961 VA: 0x22BA860
	public Color get_Cloud2Color2() { }

	// RVA: 0x22BA880 Offset: 0x22BA981 VA: 0x22BA880
	public void set_Cloud2Color2(Color value) { }

	// RVA: 0x22BA8C0 Offset: 0x22BA9C1 VA: 0x22BA8C0
	public float get_CloudFadePosition() { }

	// RVA: 0x22BA8D0 Offset: 0x22BA9D1 VA: 0x22BA8D0
	public void set_CloudFadePosition(float value) { }

	// RVA: 0x22BA900 Offset: 0x22BAA01 VA: 0x22BA900
	public float get_Cloud2FadePosition() { }

	// RVA: 0x22BA910 Offset: 0x22BAA11 VA: 0x22BA910
	public void set_Cloud2FadePosition(float value) { }

	// RVA: 0x22BA940 Offset: 0x22BAA41 VA: 0x22BA940
	public float get_CloudFadeAmount() { }

	// RVA: 0x22BA950 Offset: 0x22BAA51 VA: 0x22BA950
	public void set_CloudFadeAmount(float value) { }

	// RVA: 0x22BA980 Offset: 0x22BAA81 VA: 0x22BA980
	public float get_Cloud2FadeAmount() { }

	// RVA: 0x22BA990 Offset: 0x22BAA91 VA: 0x22BA990
	public void set_Cloud2FadeAmount(float value) { }

	// RVA: 0x22BA9C0 Offset: 0x22BAAC1 VA: 0x22BA9C0
	public Texture get_CloudCubemap() { }

	// RVA: 0x22BA9D0 Offset: 0x22BAAD1 VA: 0x22BA9D0
	public void set_CloudCubemap(Texture value) { }

	// RVA: 0x22BAA10 Offset: 0x22BAB11 VA: 0x22BAA10
	public float get_CloudCubemapRotationSpeed() { }

	// RVA: 0x22BAA20 Offset: 0x22BAB21 VA: 0x22BAA20
	public void set_CloudCubemapRotationSpeed(float value) { }

	// RVA: 0x22BAA50 Offset: 0x22BAB51 VA: 0x22BAA50
	public Texture get_CloudCubemapDoubleLayerCustomTexture() { }

	// RVA: 0x22BAA60 Offset: 0x22BAB61 VA: 0x22BAA60
	public void set_CloudCubemapDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x22BAAA0 Offset: 0x22BABA1 VA: 0x22BAAA0
	public float get_CloudCubemapDoubleLayerRotationSpeed() { }

	// RVA: 0x22BAAB0 Offset: 0x22BABB1 VA: 0x22BAAB0
	public void set_CloudCubemapDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x22BAAE0 Offset: 0x22BABE1 VA: 0x22BAAE0
	public float get_CloudCubemapDoubleLayerHeight() { }

	// RVA: 0x22BAAF0 Offset: 0x22BABF1 VA: 0x22BAAF0
	public void set_CloudCubemapDoubleLayerHeight(float value) { }

	// RVA: 0x22BAB20 Offset: 0x22BAC21 VA: 0x22BAB20
	public Color get_CloudCubemapDoubleLayerTintColor() { }

	// RVA: 0x22BAB40 Offset: 0x22BAC41 VA: 0x22BAB40
	public void set_CloudCubemapDoubleLayerTintColor(Color value) { }

	// RVA: 0x22BAB80 Offset: 0x22BAC81 VA: 0x22BAB80
	public Color get_CloudCubemapTintColor() { }

	// RVA: 0x22BABA0 Offset: 0x22BACA1 VA: 0x22BABA0
	public void set_CloudCubemapTintColor(Color value) { }

	// RVA: 0x22BABE0 Offset: 0x22BACE1 VA: 0x22BABE0
	public float get_CloudCubemapHeight() { }

	// RVA: 0x22BABF0 Offset: 0x22BACF1 VA: 0x22BABF0
	public void set_CloudCubemapHeight(float value) { }

	// RVA: 0x22BAC20 Offset: 0x22BAD21 VA: 0x22BAC20
	public Texture get_CloudCubemapNormalTexture() { }

	// RVA: 0x22BAC30 Offset: 0x22BAD31 VA: 0x22BAC30
	public void set_CloudCubemapNormalTexture(Texture value) { }

	// RVA: 0x22BAC70 Offset: 0x22BAD71 VA: 0x22BAC70
	public Color get_CloudCubemapNormalLitColor() { }

	// RVA: 0x22BAC90 Offset: 0x22BAD91 VA: 0x22BAC90
	public void set_CloudCubemapNormalLitColor(Color value) { }

	// RVA: 0x22BACD0 Offset: 0x22BADD1 VA: 0x22BACD0
	public Color get_CloudCubemapNormalShadowColor() { }

	// RVA: 0x22BACF0 Offset: 0x22BADF1 VA: 0x22BACF0
	public void set_CloudCubemapNormalShadowColor(Color value) { }

	// RVA: 0x22BAD30 Offset: 0x22BAE31 VA: 0x22BAD30
	public float get_CloudCubemapNormalRotationSpeed() { }

	// RVA: 0x22BAD40 Offset: 0x22BAE41 VA: 0x22BAD40
	public void set_CloudCubemapNormalRotationSpeed(float value) { }

	// RVA: 0x22BAD70 Offset: 0x22BAE71 VA: 0x22BAD70
	public float get_CloudCubemapNormalHeight() { }

	// RVA: 0x22BAD80 Offset: 0x22BAE81 VA: 0x22BAD80
	public void set_CloudCubemapNormalHeight(float value) { }

	// RVA: 0x22BADB0 Offset: 0x22BAEB1 VA: 0x22BADB0
	public float get_CloudCubemapNormalAmbientIntensity() { }

	// RVA: 0x22BADC0 Offset: 0x22BAEC1 VA: 0x22BADC0
	public void set_CloudCubemapNormalAmbientIntensity(float value) { }

	// RVA: 0x22BADF0 Offset: 0x22BAEF1 VA: 0x22BADF0
	public Texture get_CloudCubemapNormalDoubleLayerCustomTexture() { }

	// RVA: 0x22BAE00 Offset: 0x22BAF01 VA: 0x22BAE00
	public void set_CloudCubemapNormalDoubleLayerCustomTexture(Texture value) { }

	// RVA: 0x22BAE40 Offset: 0x22BAF41 VA: 0x22BAE40
	public float get_CloudCubemapNormalDoubleLayerRotationSpeed() { }

	// RVA: 0x22BAE50 Offset: 0x22BAF51 VA: 0x22BAE50
	public void set_CloudCubemapNormalDoubleLayerRotationSpeed(float value) { }

	// RVA: 0x22BAE80 Offset: 0x22BAF81 VA: 0x22BAE80
	public float get_CloudCubemapNormalDoubleLayerHeight() { }

	// RVA: 0x22BAE90 Offset: 0x22BAF91 VA: 0x22BAE90
	public void set_CloudCubemapNormalDoubleLayerHeight(float value) { }

	// RVA: 0x22BAEC0 Offset: 0x22BAFC1 VA: 0x22BAEC0
	public Color get_CloudCubemapNormalDoubleLayerLitColor() { }

	// RVA: 0x22BAEE0 Offset: 0x22BAFE1 VA: 0x22BAEE0
	public void set_CloudCubemapNormalDoubleLayerLitColor(Color value) { }

	// RVA: 0x22BAF20 Offset: 0x22BB021 VA: 0x22BAF20
	public Color get_CloudCubemapNormalDoubleLayerShadowColor() { }

	// RVA: 0x22BAF40 Offset: 0x22BB041 VA: 0x22BAF40
	public void set_CloudCubemapNormalDoubleLayerShadowColor(Color value) { }

	// RVA: 0x22BAF80 Offset: 0x22BB081 VA: 0x22BAF80
	public Vector3 get_CloudCubemapNormalLightDirection() { }

	// RVA: 0x22BAF90 Offset: 0x22BB091 VA: 0x22BAF90
	public void set_CloudCubemapNormalLightDirection(Vector3 value) { }

	// RVA: 0x22BB050 Offset: 0x22BB151 VA: 0x22BB050
	public Color get_FogColor() { }

	// RVA: 0x22BB070 Offset: 0x22BB171 VA: 0x22BB070
	public void set_FogColor(Color value) { }

	// RVA: 0x22BB0B0 Offset: 0x22BB1B1 VA: 0x22BB0B0
	public float get_FogDensity() { }

	// RVA: 0x22BB0C0 Offset: 0x22BB1C1 VA: 0x22BB0C0
	public void set_FogDensity(float value) { }

	// RVA: 0x22BB0F0 Offset: 0x22BB1F1 VA: 0x22BB0F0
	public float get_FogHeight() { }

	// RVA: 0x22BB100 Offset: 0x22BB201 VA: 0x22BB100
	public void set_FogHeight(float value) { }

	// RVA: 0x22B8970 Offset: 0x22B8A71 VA: 0x22B8970
	private void ApplyGradientValuesOnMaterial() { }

	// RVA: 0x22B8B10 Offset: 0x22B8C11 VA: 0x22B8B10
	private void ApplyStarFadeValuesOnMaterial() { }

	// RVA: 0x22BB130 Offset: 0x22BB231 VA: 0x22BB130
	public void .ctor() { }
}

