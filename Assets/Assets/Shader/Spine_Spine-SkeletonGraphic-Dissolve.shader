Shader "Spine/Spine-SkeletonGraphic-Dissolve" {
	Properties {
		[PerRendererData] _Tex ("Base (RGB)", 2D) = "white" {}
		_DissolveNoiseTex ("Dissolve Noise Texture", 2D) = "black" {}
		_DissolveAmount ("Dissolve Amount", Range(0, 1)) = 0
		_DissolveColor ("Dissolve Color", Vector) = (0,0,0,1)
		_Cutoff ("Dissolve Cutoff", Range(0, 1)) = 0
		[Toggle(_STRAIGHT_ALPHA_INPUT)] _StraightAlphaInput ("Straight Alpha Texture", Float) = 0
		[Toggle(_CANVAS_GROUP_COMPATIBLE)] _CanvasGroupCompatible ("CanvasGroup Compatible", Float) = 1
		[Enum(UnityEngine.Rendering.CompareFunction)] [HideInInspector] _StencilComp ("Stencil Comparison", Float) = 8
		[HideInInspector] _Stencil ("Stencil ID", Float) = 0
		[Enum(UnityEngine.Rendering.StencilOp)] [HideInInspector] _StencilOp ("Stencil Operation", Float) = 0
		[HideInInspector] _StencilWriteMask ("Stencil Write Mask", Float) = 255
		[HideInInspector] _StencilReadMask ("Stencil Read Mask", Float) = 255
		[HideInInspector] _ColorMask ("Color Mask", Float) = 15
		[Toggle(UNITY_UI_ALPHACLIP)] _UseUIAlphaClip ("Use Alpha Clip", Float) = 0
		[HideInInspector] _OutlineWidth ("Outline Width", Range(0, 8)) = 3
		[HideInInspector] _OutlineColor ("Outline Color", Vector) = (1,1,0,1)
		[HideInInspector] _OutlineReferenceTexWidth ("Reference Texture Width", Float) = 1024
		[HideInInspector] _ThresholdEnd ("Outline Threshold", Range(0, 1)) = 0.25
		[HideInInspector] _OutlineSmoothness ("Outline Smoothness", Range(0, 1)) = 1
		[MaterialToggle(_USE8NEIGHBOURHOOD_ON)] [HideInInspector] _Use8Neighbourhood ("Sample 8 Neighbours", Float) = 1
		[HideInInspector] _OutlineMipLevel ("Outline Mip Level", Range(0, 3)) = 0
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200
		CGPROGRAM
#pragma surface surf Standard
#pragma target 3.0

		struct Input
		{
			float2 uv_MainTex;
		};

		void surf(Input IN, inout SurfaceOutputStandard o)
		{
			o.Albedo = 1;
		}
		ENDCG
	}
	//CustomEditor "SpineShaderWithOutlineGUI"
}