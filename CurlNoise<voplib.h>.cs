#include <voplib.h>
//DEFAULT VALUES//
noise = vop_curlNoiseVV({ 0, 0, 0 }, { 1, 1, 1 }, { 0, 0, 0 }, { 0, 0, 0 }, "pnoise", "", 3, 0, 1, 0.5, 1, 1, 1, 0.0001);
//EXPLAINING//
noise = vop_curlNoiseVV(Position, Frequency, Offset, SurfaceNormal, "NoiseType", "CollisionSDF", Turbulence, EnableBouncingSDF, Amplitude, Roughness, Attenuation, Distance_to_Surface, SurfaceFX_Radius, StepSize);
vector = Position, Frequency, Offset, SurfaceNormal;
int = Turbulence, EnableBouncingSDF;
float = Amplitude, Roughness, Attenuation, StepSize, SurfaceFX_Radius, Distance_to_Surface;
string = NoiseType, CollisionSDF;
//EnableBouncingSDF - ('0 or 1 only, 0 - off, 1 - on')
