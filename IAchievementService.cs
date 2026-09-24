namespace GameServicesAndComponentsExercise;

/// <summary>
/// a service for managring achievements
/// </summary>
public interface IAchievementService
{
    /// <summary>
    /// updates an achievement
    /// </summary>
    /// <param name="achievement">theachievement name</param>
    /// <param name="progress">the achievement progress</param>
    public void UpdateAcheievement(string achievement, uint progress);
}