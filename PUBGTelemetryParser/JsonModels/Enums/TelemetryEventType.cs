namespace PUBGTelemetryParser.Enums
{
    /// <summary>
    /// Telemetry event types that can happen during a match
    /// </summary>
    public enum TelemetryEventType
    {
        PlayerLogin,
        PlayerCreate,
        PlayerPosition,
        PlayerAttack,
        ItemPickup,
        ItemEquip,
        ItemUnequip,
        VehicleRide,
        MatchDefinition,
        MatchStart,
        GameStatePeriodic,
        VehicleLeave,
        PlayerTakeDamage,
        PlayerLogout,
        ItemAttach,
        ItemDrop,
        PlayerKill,
        ItemDetach,
        ItemUse,
        CarePackageSpawn,
        VehicleDestroy,
        CarePackageLand,
        MatchEnd,
        Unknown
    }
}
