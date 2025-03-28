Shader "NamTV/MoveAndFade"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _Color ("Color", Color) = (1,1,1,1)
        _AnimSpeedX("Anim Speed (X)", Range(-10,10)) = 1.3
        _AnimSpeedY("Anim Speed (Y)", Range(-10,10)) = 1.3
        [MaterialToggle] _MoveX("Move X", Int ) = 0
        [MaterialToggle] _MoveY("Move Y", Int ) = 0
        _SmoothAlpha("Smooth alpha", Range(0,1)) = 0.5
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" "Queue"= "Transparent" }
        Blend SrcAlpha OneMinusSrcAlpha
        ZWrite off
        LOD 100

        Pass
        {
            CGPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            // make fog work
            #pragma multi_compile_fog

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv : TEXCOORD0;
                UNITY_FOG_COORDS(1)
                float4 vertex : SV_POSITION;
                //float4 color : COLOR;
            };
            sampler2D _MainTex;
            float4 _MainTex_ST;
            fixed4 _Color;
            half _AnimSpeedX;
            half _AnimSpeedY;
            half _MoveX;
            half _MoveY;
            half _SmoothAlpha;
            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _MainTex);
                UNITY_TRANSFER_FOG(o,o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float edgeFactor = 1;
                if(_MoveX)
                {
                    edgeFactor = lerp(1.0, _SmoothAlpha, smoothstep(0.0, 1.0, abs(i.uv.x * 2 - 1)));
                    i.uv.x -= _Time.y * _AnimSpeedX;
                }
                if(_MoveY)
                {
                    edgeFactor = lerp(1.0, _SmoothAlpha, smoothstep(0.0, 1.0, abs(i.uv.y * 2 - 1)));
                    i.uv.y -= _Time.y * _AnimSpeedY;
                }

                // sample the texture
                fixed4 col = tex2D(_MainTex, i.uv) * _Color;
                col.a *= edgeFactor;

                // apply fog
                UNITY_APPLY_FOG(i.fogCoord, col);
                return col;
            }
            ENDCG
        }
    }
}
