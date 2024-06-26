using Robust.Shared.GameStates;
using Robust.Shared.Serialization.TypeSerializers.Implementations.Custom;

namespace Content.Shared._CM14.Xenos.Projectile.Spit.Slowing;

[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(XenoSpitSystem))]
public sealed partial class SlowedBySpitComponent : Component
{
    [DataField, AutoNetworkedField]
    public float Multiplier = 0.5f;

    [DataField(customTypeSerializer: typeof(TimeOffsetSerializer)), AutoNetworkedField]
    public TimeSpan ExpiresAt;
}
