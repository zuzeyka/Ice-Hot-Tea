namespace Slush.Data.Entity
{
    public class MaximumSystemRequirement : SystemRequirement
    {
        public MaximumSystemRequirement() { }
        public MaximumSystemRequirement(Guid id,
                                        String gameId,
                                        String OS,
                                        String processor,
                                        String RAM,
                                        String video,
                                        String freeDiskSpace,
                                        DateTime createdAt)
        {
            this.id = id;
            this.gameId = gameId;
            this.OS = OS;
            this.processor = processor;
            this.RAM = RAM;
            this.video = video;
            this.freeDiskSpace = freeDiskSpace;
            this.createdAt = createdAt;
        }
    }
}
