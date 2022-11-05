using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace PrincessStudio_Scaffold.Models.Db
{
    public partial class masterContext : DbContext
    {
        public masterContext()
        {
        }

        public masterContext(DbContextOptions<masterContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActualUnitBackground> ActualUnitBackground { get; set; }
        public virtual DbSet<AilmentData> AilmentData { get; set; }
        public virtual DbSet<AlbumProductionList> AlbumProductionList { get; set; }
        public virtual DbSet<AlbumVoiceList> AlbumVoiceList { get; set; }
        public virtual DbSet<ApaSchedule> ApaSchedule { get; set; }
        public virtual DbSet<AppIcon> AppIcon { get; set; }
        public virtual DbSet<ArcadeDescription> ArcadeDescription { get; set; }
        public virtual DbSet<ArcadeList> ArcadeList { get; set; }
        public virtual DbSet<ArcadeStoryList> ArcadeStoryList { get; set; }
        public virtual DbSet<ArenaDailyRankReward> ArenaDailyRankReward { get; set; }
        public virtual DbSet<ArenaDefenceReward> ArenaDefenceReward { get; set; }
        public virtual DbSet<ArenaMaxRankReward> ArenaMaxRankReward { get; set; }
        public virtual DbSet<ArenaMaxSeasonRankReward> ArenaMaxSeasonRankReward { get; set; }
        public virtual DbSet<Banner> Banner { get; set; }
        public virtual DbSet<BgData> BgData { get; set; }
        public virtual DbSet<BirthdayLoginBonusData> BirthdayLoginBonusData { get; set; }
        public virtual DbSet<BirthdayLoginBonusDetail> BirthdayLoginBonusDetail { get; set; }
        public virtual DbSet<BirthdayLoginBonusDramaScript> BirthdayLoginBonusDramaScript { get; set; }
        public virtual DbSet<BroadcastSchedule> BroadcastSchedule { get; set; }
        public virtual DbSet<CampaignBeginnerData> CampaignBeginnerData { get; set; }
        public virtual DbSet<CampaignFreegacha> CampaignFreegacha { get; set; }
        public virtual DbSet<CampaignFreegachaData> CampaignFreegachaData { get; set; }
        public virtual DbSet<CampaignFreegachaSp> CampaignFreegachaSp { get; set; }
        public virtual DbSet<CampaignLevelData> CampaignLevelData { get; set; }
        public virtual DbSet<CampaignMissionCategory> CampaignMissionCategory { get; set; }
        public virtual DbSet<CampaignMissionData> CampaignMissionData { get; set; }
        public virtual DbSet<CampaignMissionRewardData> CampaignMissionRewardData { get; set; }
        public virtual DbSet<CampaignMissionSchedule> CampaignMissionSchedule { get; set; }
        public virtual DbSet<CampaignSchedule> CampaignSchedule { get; set; }
        public virtual DbSet<CampaignShioriGroup> CampaignShioriGroup { get; set; }
        public virtual DbSet<CggCompletionData> CggCompletionData { get; set; }
        public virtual DbSet<CggCompletionRewardData> CggCompletionRewardData { get; set; }
        public virtual DbSet<CggDrama> CggDrama { get; set; }
        public virtual DbSet<CggGachaInfo> CggGachaInfo { get; set; }
        public virtual DbSet<CggGachaLineup> CggGachaLineup { get; set; }
        public virtual DbSet<CggGameSettings> CggGameSettings { get; set; }
        public virtual DbSet<CggGoodsData> CggGoodsData { get; set; }
        public virtual DbSet<CharaETicketData> CharaETicketData { get; set; }
        public virtual DbSet<CharaFortuneRail> CharaFortuneRail { get; set; }
        public virtual DbSet<CharaFortuneReward> CharaFortuneReward { get; set; }
        public virtual DbSet<CharaFortuneScenario> CharaFortuneScenario { get; set; }
        public virtual DbSet<CharaFortuneSchedule> CharaFortuneSchedule { get; set; }
        public virtual DbSet<CharaIdentity> CharaIdentity { get; set; }
        public virtual DbSet<CharaStoryStatus> CharaStoryStatus { get; set; }
        public virtual DbSet<CharacterLoveRankupText> CharacterLoveRankupText { get; set; }
        public virtual DbSet<ClanBattle2BossData> ClanBattle2BossData { get; set; }
        public virtual DbSet<ClanBattle2MapData> ClanBattle2MapData { get; set; }
        public virtual DbSet<ClanBattleArchiveClanRank> ClanBattleArchiveClanRank { get; set; }
        public virtual DbSet<ClanBattleArchivePersonRank> ClanBattleArchivePersonRank { get; set; }
        public virtual DbSet<ClanBattleBattleMissionData> ClanBattleBattleMissionData { get; set; }
        public virtual DbSet<ClanBattleBossDamageRank> ClanBattleBossDamageRank { get; set; }
        public virtual DbSet<ClanBattleBossFixReward> ClanBattleBossFixReward { get; set; }
        public virtual DbSet<ClanBattleLastAttackReward> ClanBattleLastAttackReward { get; set; }
        public virtual DbSet<ClanBattleOddsData> ClanBattleOddsData { get; set; }
        public virtual DbSet<ClanBattleParamAdjust> ClanBattleParamAdjust { get; set; }
        public virtual DbSet<ClanBattlePeriod> ClanBattlePeriod { get; set; }
        public virtual DbSet<ClanBattlePeriodLapReward> ClanBattlePeriodLapReward { get; set; }
        public virtual DbSet<ClanBattlePeriodRankReward> ClanBattlePeriodRankReward { get; set; }
        public virtual DbSet<ClanBattleRecommendData> ClanBattleRecommendData { get; set; }
        public virtual DbSet<ClanBattleSBossData> ClanBattleSBossData { get; set; }
        public virtual DbSet<ClanBattleSBossFixReward> ClanBattleSBossFixReward { get; set; }
        public virtual DbSet<ClanBattleSMapData> ClanBattleSMapData { get; set; }
        public virtual DbSet<ClanBattleSParamAdjust> ClanBattleSParamAdjust { get; set; }
        public virtual DbSet<ClanBattleSchedule> ClanBattleSchedule { get; set; }
        public virtual DbSet<ClanBattleTrainingData> ClanBattleTrainingData { get; set; }
        public virtual DbSet<ClanBattleTrainingSchedule> ClanBattleTrainingSchedule { get; set; }
        public virtual DbSet<ClanCostGroup> ClanCostGroup { get; set; }
        public virtual DbSet<ClanGrade> ClanGrade { get; set; }
        public virtual DbSet<ClanInviteLevelGroup> ClanInviteLevelGroup { get; set; }
        public virtual DbSet<ClanprofileContent> ClanprofileContent { get; set; }
        public virtual DbSet<CombinedResultMotion> CombinedResultMotion { get; set; }
        public virtual DbSet<ContentMapData> ContentMapData { get; set; }
        public virtual DbSet<ContentReleaseData> ContentReleaseData { get; set; }
        public virtual DbSet<CooperationQuestData> CooperationQuestData { get; set; }
        public virtual DbSet<CustomMypage> CustomMypage { get; set; }
        public virtual DbSet<CustomMypageGroup> CustomMypageGroup { get; set; }
        public virtual DbSet<DailyMissionData> DailyMissionData { get; set; }
        public virtual DbSet<DearChara> DearChara { get; set; }
        public virtual DbSet<DearReward> DearReward { get; set; }
        public virtual DbSet<DearSetting> DearSetting { get; set; }
        public virtual DbSet<DearStoryData> DearStoryData { get; set; }
        public virtual DbSet<DearStoryDetail> DearStoryDetail { get; set; }
        public virtual DbSet<DefineSpskill> DefineSpskill { get; set; }
        public virtual DbSet<DodgeTpRecovery> DodgeTpRecovery { get; set; }
        public virtual DbSet<DungeonArea> DungeonArea { get; set; }
        public virtual DbSet<DungeonAreaData> DungeonAreaData { get; set; }
        public virtual DbSet<DungeonQuestData> DungeonQuestData { get; set; }
        public virtual DbSet<DungeonSkipData> DungeonSkipData { get; set; }
        public virtual DbSet<DungeonSpecialBattle> DungeonSpecialBattle { get; set; }
        public virtual DbSet<DungeonSpecialEnemySetting> DungeonSpecialEnemySetting { get; set; }
        public virtual DbSet<EReduction> EReduction { get; set; }
        public virtual DbSet<EmblemData> EmblemData { get; set; }
        public virtual DbSet<EmblemMissionData> EmblemMissionData { get; set; }
        public virtual DbSet<EmblemMissionRewardData> EmblemMissionRewardData { get; set; }
        public virtual DbSet<EnemyEnableVoice> EnemyEnableVoice { get; set; }
        public virtual DbSet<EnemyIgnoreSkillRf> EnemyIgnoreSkillRf { get; set; }
        public virtual DbSet<EnemyMParts> EnemyMParts { get; set; }
        public virtual DbSet<EnemyParameter> EnemyParameter { get; set; }
        public virtual DbSet<EnemyRewardData> EnemyRewardData { get; set; }
        public virtual DbSet<EquipmentCraft> EquipmentCraft { get; set; }
        public virtual DbSet<EquipmentData> EquipmentData { get; set; }
        public virtual DbSet<EquipmentDonation> EquipmentDonation { get; set; }
        public virtual DbSet<EquipmentEnhanceData> EquipmentEnhanceData { get; set; }
        public virtual DbSet<EquipmentEnhanceRate> EquipmentEnhanceRate { get; set; }
        public virtual DbSet<EventBgData> EventBgData { get; set; }
        public virtual DbSet<EventBossTreasureBox> EventBossTreasureBox { get; set; }
        public virtual DbSet<EventBossTreasureContent> EventBossTreasureContent { get; set; }
        public virtual DbSet<EventEffectSetting> EventEffectSetting { get; set; }
        public virtual DbSet<EventEnemyParameter> EventEnemyParameter { get; set; }
        public virtual DbSet<EventEnemyRewardGroup> EventEnemyRewardGroup { get; set; }
        public virtual DbSet<EventGachaData> EventGachaData { get; set; }
        public virtual DbSet<EventIntroduction> EventIntroduction { get; set; }
        public virtual DbSet<EventNaviComment> EventNaviComment { get; set; }
        public virtual DbSet<EventNaviCommentCondition> EventNaviCommentCondition { get; set; }
        public virtual DbSet<EventReminder> EventReminder { get; set; }
        public virtual DbSet<EventReminderCondition> EventReminderCondition { get; set; }
        public virtual DbSet<EventRevivalSeriesWaveGroupData> EventRevivalSeriesWaveGroupData { get; set; }
        public virtual DbSet<EventRevivalWaveGroupData> EventRevivalWaveGroupData { get; set; }
        public virtual DbSet<EventSeriesWaveGroupData> EventSeriesWaveGroupData { get; set; }
        public virtual DbSet<EventStoryData> EventStoryData { get; set; }
        public virtual DbSet<EventStoryDetail> EventStoryDetail { get; set; }
        public virtual DbSet<EventTopAdv> EventTopAdv { get; set; }
        public virtual DbSet<EventWaveGroupData> EventWaveGroupData { get; set; }
        public virtual DbSet<ExEquipmentCategory> ExEquipmentCategory { get; set; }
        public virtual DbSet<ExEquipmentData> ExEquipmentData { get; set; }
        public virtual DbSet<ExEquipmentEnhanceData> ExEquipmentEnhanceData { get; set; }
        public virtual DbSet<ExEquipmentRankupData> ExEquipmentRankupData { get; set; }
        public virtual DbSet<ExEquipmentRecycleReward> ExEquipmentRecycleReward { get; set; }
        public virtual DbSet<ExEquipmentRestrictionUnit> ExEquipmentRestrictionUnit { get; set; }
        public virtual DbSet<ExceedLevelStage> ExceedLevelStage { get; set; }
        public virtual DbSet<ExceedLevelUnit> ExceedLevelUnit { get; set; }
        public virtual DbSet<ExceptEr> ExceptEr { get; set; }
        public virtual DbSet<ExperienceTeam> ExperienceTeam { get; set; }
        public virtual DbSet<ExperienceUnit> ExperienceUnit { get; set; }
        public virtual DbSet<FixLineupGroupSet> FixLineupGroupSet { get; set; }
        public virtual DbSet<FixLineupGroupSetData> FixLineupGroupSetData { get; set; }
        public virtual DbSet<FkeHappeningList> FkeHappeningList { get; set; }
        public virtual DbSet<FkeReward> FkeReward { get; set; }
        public virtual DbSet<GachaData> GachaData { get; set; }
        public virtual DbSet<GachaExchangeLineup> GachaExchangeLineup { get; set; }
        public virtual DbSet<GiftMessage> GiftMessage { get; set; }
        public virtual DbSet<GlossaryDetail> GlossaryDetail { get; set; }
        public virtual DbSet<GoldsetData> GoldsetData { get; set; }
        public virtual DbSet<GoldsetData2> GoldsetData2 { get; set; }
        public virtual DbSet<GoldsetDataTeamlevel> GoldsetDataTeamlevel { get; set; }
        public virtual DbSet<GrandArenaDailyRankReward> GrandArenaDailyRankReward { get; set; }
        public virtual DbSet<GrandArenaDefenceReward> GrandArenaDefenceReward { get; set; }
        public virtual DbSet<GrandArenaMaxRankReward> GrandArenaMaxRankReward { get; set; }
        public virtual DbSet<GrandArenaMaxSeasonRankReward> GrandArenaMaxSeasonRankReward { get; set; }
        public virtual DbSet<GrowthParameter> GrowthParameter { get; set; }
        public virtual DbSet<GrowthParameterUnique> GrowthParameterUnique { get; set; }
        public virtual DbSet<GrowthRestrictionUnit> GrowthRestrictionUnit { get; set; }
        public virtual DbSet<Guild> Guild { get; set; }
        public virtual DbSet<GuildAdditionalMember> GuildAdditionalMember { get; set; }
        public virtual DbSet<HatsuneBattleMissionData> HatsuneBattleMissionData { get; set; }
        public virtual DbSet<HatsuneBgChange> HatsuneBgChange { get; set; }
        public virtual DbSet<HatsuneBgChangeData> HatsuneBgChangeData { get; set; }
        public virtual DbSet<HatsuneBoss> HatsuneBoss { get; set; }
        public virtual DbSet<HatsuneBossCondition> HatsuneBossCondition { get; set; }
        public virtual DbSet<HatsuneBossEnemySetting> HatsuneBossEnemySetting { get; set; }
        public virtual DbSet<HatsuneDailyMissionData> HatsuneDailyMissionData { get; set; }
        public virtual DbSet<HatsuneDescription> HatsuneDescription { get; set; }
        public virtual DbSet<HatsuneDiaryData> HatsuneDiaryData { get; set; }
        public virtual DbSet<HatsuneDiaryLetterScript> HatsuneDiaryLetterScript { get; set; }
        public virtual DbSet<HatsuneDiaryScript> HatsuneDiaryScript { get; set; }
        public virtual DbSet<HatsuneDiarySetting> HatsuneDiarySetting { get; set; }
        public virtual DbSet<HatsuneEmblemMission> HatsuneEmblemMission { get; set; }
        public virtual DbSet<HatsuneEmblemMissionReward> HatsuneEmblemMissionReward { get; set; }
        public virtual DbSet<HatsuneItem> HatsuneItem { get; set; }
        public virtual DbSet<HatsuneLimitChara> HatsuneLimitChara { get; set; }
        public virtual DbSet<HatsuneMap> HatsuneMap { get; set; }
        public virtual DbSet<HatsuneMapEvent> HatsuneMapEvent { get; set; }
        public virtual DbSet<HatsuneMissionRewardData> HatsuneMissionRewardData { get; set; }
        public virtual DbSet<HatsuneMultiRouteParameter> HatsuneMultiRouteParameter { get; set; }
        public virtual DbSet<HatsunePresent> HatsunePresent { get; set; }
        public virtual DbSet<HatsuneQuest> HatsuneQuest { get; set; }
        public virtual DbSet<HatsuneQuestArea> HatsuneQuestArea { get; set; }
        public virtual DbSet<HatsuneQuestCondition> HatsuneQuestCondition { get; set; }
        public virtual DbSet<HatsuneQuiz> HatsuneQuiz { get; set; }
        public virtual DbSet<HatsuneQuizCondition> HatsuneQuizCondition { get; set; }
        public virtual DbSet<HatsuneQuizReward> HatsuneQuizReward { get; set; }
        public virtual DbSet<HatsuneRelayData> HatsuneRelayData { get; set; }
        public virtual DbSet<HatsuneSchedule> HatsuneSchedule { get; set; }
        public virtual DbSet<HatsuneSeriesGachaReference> HatsuneSeriesGachaReference { get; set; }
        public virtual DbSet<HatsuneSpecialBattle> HatsuneSpecialBattle { get; set; }
        public virtual DbSet<HatsuneSpecialBossTicketCount> HatsuneSpecialBossTicketCount { get; set; }
        public virtual DbSet<HatsuneSpecialEnemy> HatsuneSpecialEnemy { get; set; }
        public virtual DbSet<HatsuneSpecialMissionData> HatsuneSpecialMissionData { get; set; }
        public virtual DbSet<HatsuneStationaryMissionData> HatsuneStationaryMissionData { get; set; }
        public virtual DbSet<HatsuneUnlockStoryCondition> HatsuneUnlockStoryCondition { get; set; }
        public virtual DbSet<HatsuneUnlockUnitCondition> HatsuneUnlockUnitCondition { get; set; }
        public virtual DbSet<HpDrainAt> HpDrainAt { get; set; }
        public virtual DbSet<ItemData> ItemData { get; set; }
        public virtual DbSet<ItemETicketData> ItemETicketData { get; set; }
        public virtual DbSet<KaiserAddTimesData> KaiserAddTimesData { get; set; }
        public virtual DbSet<KaiserExterminationReward> KaiserExterminationReward { get; set; }
        public virtual DbSet<KaiserQuestData> KaiserQuestData { get; set; }
        public virtual DbSet<KaiserRestrictionGroup> KaiserRestrictionGroup { get; set; }
        public virtual DbSet<KaiserSchedule> KaiserSchedule { get; set; }
        public virtual DbSet<KaiserSpecialBattle> KaiserSpecialBattle { get; set; }
        public virtual DbSet<KmkNaviComment> KmkNaviComment { get; set; }
        public virtual DbSet<KmkReward> KmkReward { get; set; }
        public virtual DbSet<LegionAddTimesData> LegionAddTimesData { get; set; }
        public virtual DbSet<LegionBattleBonus> LegionBattleBonus { get; set; }
        public virtual DbSet<LegionBattleBonusEffect> LegionBattleBonusEffect { get; set; }
        public virtual DbSet<LegionBossEnemySetting> LegionBossEnemySetting { get; set; }
        public virtual DbSet<LegionEffect> LegionEffect { get; set; }
        public virtual DbSet<LegionEffectiveUnit> LegionEffectiveUnit { get; set; }
        public virtual DbSet<LegionExterminationReward> LegionExterminationReward { get; set; }
        public virtual DbSet<LegionMissionCategoryData> LegionMissionCategoryData { get; set; }
        public virtual DbSet<LegionMissionData> LegionMissionData { get; set; }
        public virtual DbSet<LegionMissionRewardData> LegionMissionRewardData { get; set; }
        public virtual DbSet<LegionQuestData> LegionQuestData { get; set; }
        public virtual DbSet<LegionSchedule> LegionSchedule { get; set; }
        public virtual DbSet<LegionSpecialBattle> LegionSpecialBattle { get; set; }
        public virtual DbSet<LoginBonusAdv> LoginBonusAdv { get; set; }
        public virtual DbSet<LoginBonusData> LoginBonusData { get; set; }
        public virtual DbSet<LoginBonusDetail> LoginBonusDetail { get; set; }
        public virtual DbSet<LoginBonusMessageData> LoginBonusMessageData { get; set; }
        public virtual DbSet<LoveChara> LoveChara { get; set; }
        public virtual DbSet<LoveRankup> LoveRankup { get; set; }
        public virtual DbSet<LsvDramaScript> LsvDramaScript { get; set; }
        public virtual DbSet<LsvStoryData> LsvStoryData { get; set; }
        public virtual DbSet<LsvStoryScript> LsvStoryScript { get; set; }
        public virtual DbSet<LtoLetterScript> LtoLetterScript { get; set; }
        public virtual DbSet<LtoStoryData> LtoStoryData { get; set; }
        public virtual DbSet<Metamorphose> Metamorphose { get; set; }
        public virtual DbSet<MhpDramaScript> MhpDramaScript { get; set; }
        public virtual DbSet<MhpStoryData> MhpStoryData { get; set; }
        public virtual DbSet<Minigame> Minigame { get; set; }
        public virtual DbSet<MissionRewardData> MissionRewardData { get; set; }
        public virtual DbSet<Movie> Movie { get; set; }
        public virtual DbSet<MusicContent> MusicContent { get; set; }
        public virtual DbSet<MusicList> MusicList { get; set; }
        public virtual DbSet<MypageFrame> MypageFrame { get; set; }
        public virtual DbSet<MyprofileContent> MyprofileContent { get; set; }
        public virtual DbSet<NaviComment> NaviComment { get; set; }
        public virtual DbSet<NopDramaData> NopDramaData { get; set; }
        public virtual DbSet<NopDramaScript> NopDramaScript { get; set; }
        public virtual DbSet<NotifData> NotifData { get; set; }
        public virtual DbSet<NyxDramaData> NyxDramaData { get; set; }
        public virtual DbSet<NyxDramaScript> NyxDramaScript { get; set; }
        public virtual DbSet<NyxPhaseData> NyxPhaseData { get; set; }
        public virtual DbSet<NyxStoryData> NyxStoryData { get; set; }
        public virtual DbSet<NyxStoryScript> NyxStoryScript { get; set; }
        public virtual DbSet<OddsNameData> OddsNameData { get; set; }
        public virtual DbSet<OmpDrama> OmpDrama { get; set; }
        public virtual DbSet<OmpStoryData> OmpStoryData { get; set; }
        public virtual DbSet<PctComboCoefficient> PctComboCoefficient { get; set; }
        public virtual DbSet<PctEvaluation> PctEvaluation { get; set; }
        public virtual DbSet<PctGamingMotion> PctGamingMotion { get; set; }
        public virtual DbSet<PctItempoint> PctItempoint { get; set; }
        public virtual DbSet<PctResult> PctResult { get; set; }
        public virtual DbSet<PctReward> PctReward { get; set; }
        public virtual DbSet<PctSystem> PctSystem { get; set; }
        public virtual DbSet<PctSystemFruits> PctSystemFruits { get; set; }
        public virtual DbSet<PctTapSpeed> PctTapSpeed { get; set; }
        public virtual DbSet<PkbBatterCondition> PkbBatterCondition { get; set; }
        public virtual DbSet<PkbDrama> PkbDrama { get; set; }
        public virtual DbSet<PkbDramaData> PkbDramaData { get; set; }
        public virtual DbSet<PkbNaviComment> PkbNaviComment { get; set; }
        public virtual DbSet<PkbPitcherBallType> PkbPitcherBallType { get; set; }
        public virtual DbSet<PkbReward> PkbReward { get; set; }
        public virtual DbSet<PositionSetting> PositionSetting { get; set; }
        public virtual DbSet<PrizegachaData> PrizegachaData { get; set; }
        public virtual DbSet<PrizegachaSpData> PrizegachaSpData { get; set; }
        public virtual DbSet<PrizegachaSpDetail> PrizegachaSpDetail { get; set; }
        public virtual DbSet<ProfileFrame> ProfileFrame { get; set; }
        public virtual DbSet<PromotionBonus> PromotionBonus { get; set; }
        public virtual DbSet<PsyDrama> PsyDrama { get; set; }
        public virtual DbSet<PsyDramaScript> PsyDramaScript { get; set; }
        public virtual DbSet<PsyNote> PsyNote { get; set; }
        public virtual DbSet<PsyReward> PsyReward { get; set; }
        public virtual DbSet<QuestAnnihilation> QuestAnnihilation { get; set; }
        public virtual DbSet<QuestAreaData> QuestAreaData { get; set; }
        public virtual DbSet<QuestConditionData> QuestConditionData { get; set; }
        public virtual DbSet<QuestData> QuestData { get; set; }
        public virtual DbSet<QuestDefeatNotice> QuestDefeatNotice { get; set; }
        public virtual DbSet<QuestRewardData> QuestRewardData { get; set; }
        public virtual DbSet<Rarity6QuestData> Rarity6QuestData { get; set; }
        public virtual DbSet<RecoverStamina> RecoverStamina { get; set; }
        public virtual DbSet<RedeemStaticPriceGroup> RedeemStaticPriceGroup { get; set; }
        public virtual DbSet<RedeemUnit> RedeemUnit { get; set; }
        public virtual DbSet<RedeemUnitBg> RedeemUnitBg { get; set; }
        public virtual DbSet<ResistData> ResistData { get; set; }
        public virtual DbSet<ResistVariationData> ResistVariationData { get; set; }
        public virtual DbSet<ReturnSpecialfesBanner> ReturnSpecialfesBanner { get; set; }
        public virtual DbSet<RewardCollectGuide> RewardCollectGuide { get; set; }
        public virtual DbSet<RoomChange> RoomChange { get; set; }
        public virtual DbSet<RoomCharacterPersonality> RoomCharacterPersonality { get; set; }
        public virtual DbSet<RoomCharacterSkinColor> RoomCharacterSkinColor { get; set; }
        public virtual DbSet<RoomChatFormation> RoomChatFormation { get; set; }
        public virtual DbSet<RoomChatInfo> RoomChatInfo { get; set; }
        public virtual DbSet<RoomChatScenario> RoomChatScenario { get; set; }
        public virtual DbSet<RoomEffect> RoomEffect { get; set; }
        public virtual DbSet<RoomEffectRewardGet> RoomEffectRewardGet { get; set; }
        public virtual DbSet<RoomEmotionIcon> RoomEmotionIcon { get; set; }
        public virtual DbSet<RoomExclusiveCondition> RoomExclusiveCondition { get; set; }
        public virtual DbSet<RoomItem> RoomItem { get; set; }
        public virtual DbSet<RoomItemAnnouncement> RoomItemAnnouncement { get; set; }
        public virtual DbSet<RoomItemDetail> RoomItemDetail { get; set; }
        public virtual DbSet<RoomItemGetAnnouncement> RoomItemGetAnnouncement { get; set; }
        public virtual DbSet<RoomReleaseData> RoomReleaseData { get; set; }
        public virtual DbSet<RoomSetup> RoomSetup { get; set; }
        public virtual DbSet<RoomSkinColor> RoomSkinColor { get; set; }
        public virtual DbSet<RoomUnitComments> RoomUnitComments { get; set; }
        public virtual DbSet<SdNaviComment> SdNaviComment { get; set; }
        public virtual DbSet<SeasonPack> SeasonPack { get; set; }
        public virtual DbSet<SecretDungeonEmblemMission> SecretDungeonEmblemMission { get; set; }
        public virtual DbSet<SecretDungeonEmblemReward> SecretDungeonEmblemReward { get; set; }
        public virtual DbSet<SecretDungeonEnemyInfo> SecretDungeonEnemyInfo { get; set; }
        public virtual DbSet<SecretDungeonFloorReward> SecretDungeonFloorReward { get; set; }
        public virtual DbSet<SecretDungeonFloorSetting> SecretDungeonFloorSetting { get; set; }
        public virtual DbSet<SecretDungeonQuestData> SecretDungeonQuestData { get; set; }
        public virtual DbSet<SecretDungeonSchedule> SecretDungeonSchedule { get; set; }
        public virtual DbSet<SekaiAddTimesData> SekaiAddTimesData { get; set; }
        public virtual DbSet<SekaiBossDamageRankReward> SekaiBossDamageRankReward { get; set; }
        public virtual DbSet<SekaiBossFixReward> SekaiBossFixReward { get; set; }
        public virtual DbSet<SekaiBossMode> SekaiBossMode { get; set; }
        public virtual DbSet<SekaiEnemyParameter> SekaiEnemyParameter { get; set; }
        public virtual DbSet<SekaiSchedule> SekaiSchedule { get; set; }
        public virtual DbSet<SekaiTopData> SekaiTopData { get; set; }
        public virtual DbSet<SekaiTopStoryData> SekaiTopStoryData { get; set; }
        public virtual DbSet<SekaiUnlockStoryCondition> SekaiUnlockStoryCondition { get; set; }
        public virtual DbSet<SerialCodeData> SerialCodeData { get; set; }
        public virtual DbSet<SerialGroupData> SerialGroupData { get; set; }
        public virtual DbSet<SeriesUnlockCondition> SeriesUnlockCondition { get; set; }
        public virtual DbSet<ShioriBattleMissionData> ShioriBattleMissionData { get; set; }
        public virtual DbSet<ShioriBoss> ShioriBoss { get; set; }
        public virtual DbSet<ShioriBossCondition> ShioriBossCondition { get; set; }
        public virtual DbSet<ShioriDescription> ShioriDescription { get; set; }
        public virtual DbSet<ShioriEnemyParameter> ShioriEnemyParameter { get; set; }
        public virtual DbSet<ShioriEventList> ShioriEventList { get; set; }
        public virtual DbSet<ShioriItem> ShioriItem { get; set; }
        public virtual DbSet<ShioriMissionRewardData> ShioriMissionRewardData { get; set; }
        public virtual DbSet<ShioriQuest> ShioriQuest { get; set; }
        public virtual DbSet<ShioriQuestArea> ShioriQuestArea { get; set; }
        public virtual DbSet<ShioriQuestCondition> ShioriQuestCondition { get; set; }
        public virtual DbSet<ShioriStationaryMissionData> ShioriStationaryMissionData { get; set; }
        public virtual DbSet<ShioriUnlockUnitCondition> ShioriUnlockUnitCondition { get; set; }
        public virtual DbSet<ShioriWaveGroupData> ShioriWaveGroupData { get; set; }
        public virtual DbSet<ShopStaticPriceGroup> ShopStaticPriceGroup { get; set; }
        public virtual DbSet<SjrChara> SjrChara { get; set; }
        public virtual DbSet<SjrCourse> SjrCourse { get; set; }
        public virtual DbSet<SjrDramaScript> SjrDramaScript { get; set; }
        public virtual DbSet<SjrEmblem> SjrEmblem { get; set; }
        public virtual DbSet<SjrFeatureGroup> SjrFeatureGroup { get; set; }
        public virtual DbSet<SjrNameFormer> SjrNameFormer { get; set; }
        public virtual DbSet<SjrNameLater> SjrNameLater { get; set; }
        public virtual DbSet<SjrNpcActionOdds> SjrNpcActionOdds { get; set; }
        public virtual DbSet<SjrParameterEvaluation> SjrParameterEvaluation { get; set; }
        public virtual DbSet<SjrProperEvaluation> SjrProperEvaluation { get; set; }
        public virtual DbSet<SjrProperFeature> SjrProperFeature { get; set; }
        public virtual DbSet<SjrRail> SjrRail { get; set; }
        public virtual DbSet<SjrReward> SjrReward { get; set; }
        public virtual DbSet<SjrScore> SjrScore { get; set; }
        public virtual DbSet<SjrUbData> SjrUbData { get; set; }
        public virtual DbSet<SkeStoryData> SkeStoryData { get; set; }
        public virtual DbSet<SkeStoryScript> SkeStoryScript { get; set; }
        public virtual DbSet<SkillAction> SkillAction { get; set; }
        public virtual DbSet<SkillCost> SkillCost { get; set; }
        public virtual DbSet<SkillData> SkillData { get; set; }
        public virtual DbSet<SkipBossData> SkipBossData { get; set; }
        public virtual DbSet<SkipMonsterData> SkipMonsterData { get; set; }
        public virtual DbSet<SpBattleVoice> SpBattleVoice { get; set; }
        public virtual DbSet<SpDetailVoice> SpDetailVoice { get; set; }
        public virtual DbSet<SpLoseVoice> SpLoseVoice { get; set; }
        public virtual DbSet<SpLoseVoiceGroup> SpLoseVoiceGroup { get; set; }
        public virtual DbSet<SpaceBattleData> SpaceBattleData { get; set; }
        public virtual DbSet<SpaceSchedule> SpaceSchedule { get; set; }
        public virtual DbSet<SpaceTopData> SpaceTopData { get; set; }
        public virtual DbSet<SpecialStill> SpecialStill { get; set; }
        public virtual DbSet<SpecialStoryBanner> SpecialStoryBanner { get; set; }
        public virtual DbSet<SpecialfesBanner> SpecialfesBanner { get; set; }
        public virtual DbSet<SpskillLabelData> SpskillLabelData { get; set; }
        public virtual DbSet<SpskillLvInitializeData> SpskillLvInitializeData { get; set; }
        public virtual DbSet<SrtAction> SrtAction { get; set; }
        public virtual DbSet<SrtPanel> SrtPanel { get; set; }
        public virtual DbSet<SrtReward> SrtReward { get; set; }
        public virtual DbSet<SrtScore> SrtScore { get; set; }
        public virtual DbSet<SrtTopTalk> SrtTopTalk { get; set; }
        public virtual DbSet<SspStoryData> SspStoryData { get; set; }
        public virtual DbSet<Stamp> Stamp { get; set; }
        public virtual DbSet<StationaryMissionData> StationaryMissionData { get; set; }
        public virtual DbSet<Still> Still { get; set; }
        public virtual DbSet<StoryCharacterMask> StoryCharacterMask { get; set; }
        public virtual DbSet<StoryData> StoryData { get; set; }
        public virtual DbSet<StoryDetail> StoryDetail { get; set; }
        public virtual DbSet<StoryQuestData> StoryQuestData { get; set; }
        public virtual DbSet<SvdDramaScript> SvdDramaScript { get; set; }
        public virtual DbSet<SvdStoryData> SvdStoryData { get; set; }
        public virtual DbSet<SvdStoryScript> SvdStoryScript { get; set; }
        public virtual DbSet<TaqCompletionRewards> TaqCompletionRewards { get; set; }
        public virtual DbSet<TaqData> TaqData { get; set; }
        public virtual DbSet<TaqDramaScript> TaqDramaScript { get; set; }
        public virtual DbSet<TaqGameSetting> TaqGameSetting { get; set; }
        public virtual DbSet<TaqGenre> TaqGenre { get; set; }
        public virtual DbSet<TaqGoodUnit> TaqGoodUnit { get; set; }
        public virtual DbSet<TaqIncorrectWord> TaqIncorrectWord { get; set; }
        public virtual DbSet<TaqKanjiList> TaqKanjiList { get; set; }
        public virtual DbSet<TaqNecessaryWord> TaqNecessaryWord { get; set; }
        public virtual DbSet<TaqRewards> TaqRewards { get; set; }
        public virtual DbSet<TaqUnit> TaqUnit { get; set; }
        public virtual DbSet<ThumbnailHideCondition> ThumbnailHideCondition { get; set; }
        public virtual DbSet<TicketGachaData> TicketGachaData { get; set; }
        public virtual DbSet<Tips> Tips { get; set; }
        public virtual DbSet<TmeMapData> TmeMapData { get; set; }
        public virtual DbSet<TowerAreaData> TowerAreaData { get; set; }
        public virtual DbSet<TowerCloisterQuestData> TowerCloisterQuestData { get; set; }
        public virtual DbSet<TowerEnemyParameter> TowerEnemyParameter { get; set; }
        public virtual DbSet<TowerExQuestData> TowerExQuestData { get; set; }
        public virtual DbSet<TowerQuestData> TowerQuestData { get; set; }
        public virtual DbSet<TowerQuestFixRewardGroup> TowerQuestFixRewardGroup { get; set; }
        public virtual DbSet<TowerQuestOddsGroup> TowerQuestOddsGroup { get; set; }
        public virtual DbSet<TowerSchedule> TowerSchedule { get; set; }
        public virtual DbSet<TowerStoryData> TowerStoryData { get; set; }
        public virtual DbSet<TowerStoryDetail> TowerStoryDetail { get; set; }
        public virtual DbSet<TowerWaveGroupData> TowerWaveGroupData { get; set; }
        public virtual DbSet<TpRecoveryAt> TpRecoveryAt { get; set; }
        public virtual DbSet<TrainingQuestData> TrainingQuestData { get; set; }
        public virtual DbSet<TravelAreaData> TravelAreaData { get; set; }
        public virtual DbSet<TravelDecreaseTimeCost> TravelDecreaseTimeCost { get; set; }
        public virtual DbSet<TravelExEventData> TravelExEventData { get; set; }
        public virtual DbSet<TravelExEventDrama> TravelExEventDrama { get; set; }
        public virtual DbSet<TravelQuestData> TravelQuestData { get; set; }
        public virtual DbSet<TravelQuestResult> TravelQuestResult { get; set; }
        public virtual DbSet<TravelQuestResultGroup> TravelQuestResultGroup { get; set; }
        public virtual DbSet<TravelQuestSubReward> TravelQuestSubReward { get; set; }
        public virtual DbSet<TravelStartDrama> TravelStartDrama { get; set; }
        public virtual DbSet<TravelTopEventData> TravelTopEventData { get; set; }
        public virtual DbSet<TravelTopEventDrama> TravelTopEventDrama { get; set; }
        public virtual DbSet<TravelTopEventPosDetail> TravelTopEventPosDetail { get; set; }
        public virtual DbSet<TrialBattleCategory> TrialBattleCategory { get; set; }
        public virtual DbSet<TrialBattleData> TrialBattleData { get; set; }
        public virtual DbSet<TrialBattleMissionData> TrialBattleMissionData { get; set; }
        public virtual DbSet<TrialBattleMissionReward> TrialBattleMissionReward { get; set; }
        public virtual DbSet<TrialBattleRewardData> TrialBattleRewardData { get; set; }
        public virtual DbSet<TtkDrama> TtkDrama { get; set; }
        public virtual DbSet<TtkEnemy> TtkEnemy { get; set; }
        public virtual DbSet<TtkNaviComment> TtkNaviComment { get; set; }
        public virtual DbSet<TtkReward> TtkReward { get; set; }
        public virtual DbSet<TtkScore> TtkScore { get; set; }
        public virtual DbSet<TtkStory> TtkStory { get; set; }
        public virtual DbSet<TtkStoryScript> TtkStoryScript { get; set; }
        public virtual DbSet<TtkWeapon> TtkWeapon { get; set; }
        public virtual DbSet<UbAutoData> UbAutoData { get; set; }
        public virtual DbSet<UbAutoDefine> UbAutoDefine { get; set; }
        public virtual DbSet<UekBoss> UekBoss { get; set; }
        public virtual DbSet<UekDrama> UekDrama { get; set; }
        public virtual DbSet<UekMission> UekMission { get; set; }
        public virtual DbSet<UekSpineAnimLink> UekSpineAnimLink { get; set; }
        public virtual DbSet<UniqueEquipEnhanceRate> UniqueEquipEnhanceRate { get; set; }
        public virtual DbSet<UniqueEquipmentBonus> UniqueEquipmentBonus { get; set; }
        public virtual DbSet<UniqueEquipmentCraft> UniqueEquipmentCraft { get; set; }
        public virtual DbSet<UniqueEquipmentData> UniqueEquipmentData { get; set; }
        public virtual DbSet<UniqueEquipmentEnhanceData> UniqueEquipmentEnhanceData { get; set; }
        public virtual DbSet<UniqueEquipmentEnhanceRate> UniqueEquipmentEnhanceRate { get; set; }
        public virtual DbSet<UniqueEquipmentRankup> UniqueEquipmentRankup { get; set; }
        public virtual DbSet<UnitAttackPattern> UnitAttackPattern { get; set; }
        public virtual DbSet<UnitBackground> UnitBackground { get; set; }
        public virtual DbSet<UnitClipSetting> UnitClipSetting { get; set; }
        public virtual DbSet<UnitComments> UnitComments { get; set; }
        public virtual DbSet<UnitConversion> UnitConversion { get; set; }
        public virtual DbSet<UnitData> UnitData { get; set; }
        public virtual DbSet<UnitEnemyData> UnitEnemyData { get; set; }
        public virtual DbSet<UnitExEquipmentSlot> UnitExEquipmentSlot { get; set; }
        public virtual DbSet<UnitIntroduction> UnitIntroduction { get; set; }
        public virtual DbSet<UnitMotionList> UnitMotionList { get; set; }
        public virtual DbSet<UnitMypagePos> UnitMypagePos { get; set; }
        public virtual DbSet<UnitPosAdjustment> UnitPosAdjustment { get; set; }
        public virtual DbSet<UnitProfile> UnitProfile { get; set; }
        public virtual DbSet<UnitPromotion> UnitPromotion { get; set; }
        public virtual DbSet<UnitPromotionStatus> UnitPromotionStatus { get; set; }
        public virtual DbSet<UnitRarity> UnitRarity { get; set; }
        public virtual DbSet<UnitSkillData> UnitSkillData { get; set; }
        public virtual DbSet<UnitSkillDataRf> UnitSkillDataRf { get; set; }
        public virtual DbSet<UnitStatusCoefficient> UnitStatusCoefficient { get; set; }
        public virtual DbSet<UnitUniqueEquip> UnitUniqueEquip { get; set; }
        public virtual DbSet<UnlockRarity6> UnlockRarity6 { get; set; }
        public virtual DbSet<UnlockSkillData> UnlockSkillData { get; set; }
        public virtual DbSet<UnlockUnitCondition> UnlockUnitCondition { get; set; }
        public virtual DbSet<VisualCustomize> VisualCustomize { get; set; }
        public virtual DbSet<VoiceGroup> VoiceGroup { get; set; }
        public virtual DbSet<VoiceGroupChara> VoiceGroupChara { get; set; }
        public virtual DbSet<VoteData> VoteData { get; set; }
        public virtual DbSet<VoteInfo> VoteInfo { get; set; }
        public virtual DbSet<VoteUnit> VoteUnit { get; set; }
        public virtual DbSet<WacBirthdayDramaScript> WacBirthdayDramaScript { get; set; }
        public virtual DbSet<WacData> WacData { get; set; }
        public virtual DbSet<WacDramaScript> WacDramaScript { get; set; }
        public virtual DbSet<WacMuralBgData> WacMuralBgData { get; set; }
        public virtual DbSet<WacMuralData> WacMuralData { get; set; }
        public virtual DbSet<WacPresentStillData> WacPresentStillData { get; set; }
        public virtual DbSet<WacUnitSearchData> WacUnitSearchData { get; set; }
        public virtual DbSet<WaveGroupData> WaveGroupData { get; set; }
        public virtual DbSet<Worldmap> Worldmap { get; set; }
        public virtual DbSet<YsnStoryData> YsnStoryData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlite("data source=Data\\master.db");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActualUnitBackground>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("actual_unit_background");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasColumnName("unit_name");
            });

            modelBuilder.Entity<AilmentData>(entity =>
            {
                entity.HasKey(e => e.AilmentId);

                entity.ToTable("ailment_data");

                entity.Property(e => e.AilmentId)
                    .HasColumnName("ailment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AilmentAction).HasColumnName("ailment_action");

                entity.Property(e => e.AilmentDetail1).HasColumnName("ailment_detail_1");

                entity.Property(e => e.AilmentName)
                    .IsRequired()
                    .HasColumnName("ailment_name");
            });

            modelBuilder.Entity<AlbumProductionList>(entity =>
            {
                entity.ToTable("album_production_list");

                entity.HasIndex(e => e.UnitId)
                    .HasName("album_production_list_0_unit_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<AlbumVoiceList>(entity =>
            {
                entity.ToTable("album_voice_list");

                entity.HasIndex(e => e.UnitId)
                    .HasName("album_voice_list_0_unit_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.VoiceId)
                    .IsRequired()
                    .HasColumnName("voice_id");
            });

            modelBuilder.Entity<ApaSchedule>(entity =>
            {
                entity.HasKey(e => e.ApaId);

                entity.ToTable("apa_schedule");

                entity.Property(e => e.ApaId)
                    .HasColumnName("apa_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CloseTime)
                    .IsRequired()
                    .HasColumnName("close_time");

                entity.Property(e => e.CountStartTime)
                    .IsRequired()
                    .HasColumnName("count_start_time");

                entity.Property(e => e.EdStoryId).HasColumnName("ed_story_id");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.OpStoryId).HasColumnName("op_story_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.Url1)
                    .IsRequired()
                    .HasColumnName("url_1");

                entity.Property(e => e.Url2)
                    .IsRequired()
                    .HasColumnName("url_2");

                entity.Property(e => e.Url3)
                    .IsRequired()
                    .HasColumnName("url_3");
            });

            modelBuilder.Entity<AppIcon>(entity =>
            {
                entity.ToTable("app_icon");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ArcadeDescription>(entity =>
            {
                entity.ToTable("arcade_description");

                entity.HasIndex(e => e.ArcadeId)
                    .HasName("arcade_description_0_arcade_id");

                entity.HasIndex(e => new { e.ArcadeId, e.Type })
                    .HasName("arcade_description_0_arcade_id_1_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArcadeId).HasColumnName("arcade_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<ArcadeList>(entity =>
            {
                entity.HasKey(e => e.ArcadeId);

                entity.ToTable("arcade_list");

                entity.Property(e => e.ArcadeId)
                    .HasColumnName("arcade_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BannerEndTime)
                    .IsRequired()
                    .HasColumnName("banner_end_time");

                entity.Property(e => e.BannerStartTime)
                    .IsRequired()
                    .HasColumnName("banner_start_time");

                entity.Property(e => e.CueId)
                    .IsRequired()
                    .HasColumnName("cue_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<ArcadeStoryList>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("arcade_story_list");

                entity.HasIndex(e => e.ArcadeId)
                    .HasName("arcade_story_list_0_arcade_id");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ArcadeId).HasColumnName("arcade_id");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");
            });

            modelBuilder.Entity<ArenaDailyRankReward>(entity =>
            {
                entity.ToTable("arena_daily_rank_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ArenaDefenceReward>(entity =>
            {
                entity.ToTable("arena_defence_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LimitCount).HasColumnName("limit_count");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ArenaMaxRankReward>(entity =>
            {
                entity.ToTable("arena_max_rank_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ArenaMaxSeasonRankReward>(entity =>
            {
                entity.ToTable("arena_max_season_rank_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<Banner>(entity =>
            {
                entity.ToTable("banner");

                entity.Property(e => e.BannerId)
                    .HasColumnName("banner_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");

                entity.Property(e => e.IsShowRoom).HasColumnName("is_show_room");

                entity.Property(e => e.Priority).HasColumnName("priority");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");

                entity.Property(e => e.SubBannerId1).HasColumnName("sub_banner_id_1");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<BgData>(entity =>
            {
                entity.HasKey(e => e.ViewName);

                entity.ToTable("bg_data");

                entity.Property(e => e.ViewName).HasColumnName("view_name");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");
            });

            modelBuilder.Entity<BirthdayLoginBonusData>(entity =>
            {
                entity.HasKey(e => e.LoginBonusId);

                entity.ToTable("birthday_login_bonus_data");

                entity.Property(e => e.LoginBonusId)
                    .HasColumnName("login_bonus_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdvId).HasColumnName("adv_id");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.LoginBonusType).HasColumnName("login_bonus_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<BirthdayLoginBonusDetail>(entity =>
            {
                entity.ToTable("birthday_login_bonus_detail");

                entity.HasIndex(e => e.LoginBonusId)
                    .HasName("birthday_login_bonus_detail_0_login_bonus_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LoginBonusId).HasColumnName("login_bonus_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<BirthdayLoginBonusDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("birthday_login_bonus_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("birthday_login_bonus_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<BroadcastSchedule>(entity =>
            {
                entity.HasKey(e => e.BroadcastId);

                entity.ToTable("broadcast_schedule");

                entity.Property(e => e.BroadcastId)
                    .HasColumnName("broadcast_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.TeaserTime)
                    .IsRequired()
                    .HasColumnName("teaser_time");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url");
            });

            modelBuilder.Entity<CampaignBeginnerData>(entity =>
            {
                entity.HasKey(e => e.BeginnerId);

                entity.ToTable("campaign_beginner_data");

                entity.Property(e => e.BeginnerId)
                    .HasColumnName("beginner_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IdFrom).HasColumnName("id_from");

                entity.Property(e => e.IdTo).HasColumnName("id_to");
            });

            modelBuilder.Entity<CampaignFreegacha>(entity =>
            {
                entity.ToTable("campaign_freegacha");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.Freegacha1).HasColumnName("freegacha_1");

                entity.Property(e => e.Freegacha10).HasColumnName("freegacha_10");

                entity.Property(e => e.RelationCount).HasColumnName("relation_count");

                entity.Property(e => e.RelationId).HasColumnName("relation_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.Stock10Flag).HasColumnName("stock_10_flag");
            });

            modelBuilder.Entity<CampaignFreegachaData>(entity =>
            {
                entity.ToTable("campaign_freegacha_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");
            });

            modelBuilder.Entity<CampaignFreegachaSp>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.ToTable("campaign_freegacha_sp");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.MaxExecCount).HasColumnName("max_exec_count");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<CampaignLevelData>(entity =>
            {
                entity.ToTable("campaign_level_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FrameColor)
                    .IsRequired()
                    .HasColumnName("frame_color");

                entity.Property(e => e.LabelColor)
                    .IsRequired()
                    .HasColumnName("label_color");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.LvFrom).HasColumnName("lv_from");

                entity.Property(e => e.LvTo).HasColumnName("lv_to");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<CampaignMissionCategory>(entity =>
            {
                entity.ToTable("campaign_mission_category");

                entity.HasIndex(e => new { e.CampaignId, e.Type })
                    .HasName("campaign_mission_category_0_campaign_id_1_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.LvFrom).HasColumnName("lv_from");

                entity.Property(e => e.LvTo).HasColumnName("lv_to");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<CampaignMissionData>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("campaign_mission_data");

                entity.HasIndex(e => e.CampaignId)
                    .HasName("campaign_mission_data_0_campaign_id");

                entity.HasIndex(e => new { e.CampaignId, e.Type })
                    .HasName("campaign_mission_data_0_campaign_id_1_type");

                entity.Property(e => e.MissionId)
                    .HasColumnName("mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignId).HasColumnName("campaign_id");

                entity.Property(e => e.CampaignMissionRewardId).HasColumnName("campaign_mission_reward_id");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue10).HasColumnName("condition_value_10");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.ConditionValue6).HasColumnName("condition_value_6");

                entity.Property(e => e.ConditionValue7).HasColumnName("condition_value_7");

                entity.Property(e => e.ConditionValue8).HasColumnName("condition_value_8");

                entity.Property(e => e.ConditionValue9).HasColumnName("condition_value_9");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.MarkFlag).HasColumnName("mark_flag");

                entity.Property(e => e.MaxLevel).HasColumnName("max_level");

                entity.Property(e => e.MinLevel).HasColumnName("min_level");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.TitleColorId).HasColumnName("title_color_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<CampaignMissionRewardData>(entity =>
            {
                entity.ToTable("campaign_mission_reward_data");

                entity.HasIndex(e => e.CampaignMissionRewardId)
                    .HasName("campaign_mission_reward_data_0_campaign_mission_reward_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignMissionRewardId).HasColumnName("campaign_mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<CampaignMissionSchedule>(entity =>
            {
                entity.HasKey(e => e.CampaignId);

                entity.ToTable("campaign_mission_schedule");

                entity.Property(e => e.CampaignId)
                    .HasColumnName("campaign_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CloseTime)
                    .IsRequired()
                    .HasColumnName("close_time");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<CampaignSchedule>(entity =>
            {
                entity.ToTable("campaign_schedule");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BeginnerId).HasColumnName("beginner_id");

                entity.Property(e => e.CampaignCategory).HasColumnName("campaign_category");

                entity.Property(e => e.DuplicationOrder).HasColumnName("duplication_order");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.IconImage).HasColumnName("icon_image");

                entity.Property(e => e.LevelId).HasColumnName("level_id");

                entity.Property(e => e.ShioriGroupId).HasColumnName("shiori_group_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<CampaignShioriGroup>(entity =>
            {
                entity.ToTable("campaign_shiori_group");

                entity.HasIndex(e => e.ShioriGroupId)
                    .HasName("campaign_shiori_group_0_shiori_group_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ShioriGroupId).HasColumnName("shiori_group_id");
            });

            modelBuilder.Entity<CggCompletionData>(entity =>
            {
                entity.HasKey(e => e.CompletionId);

                entity.ToTable("cgg_completion_data");

                entity.Property(e => e.CompletionId)
                    .HasColumnName("completion_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompletionEmblemId).HasColumnName("completion_emblem_id");

                entity.Property(e => e.CompletionNum).HasColumnName("completion_num");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.GachaType).HasColumnName("gacha_type");

                entity.Property(e => e.ReceiveDescription)
                    .IsRequired()
                    .HasColumnName("receive_description");

                entity.Property(e => e.SecretGoodsId1).HasColumnName("secret_goods_id_1");

                entity.Property(e => e.SecretGoodsId2).HasColumnName("secret_goods_id_2");

                entity.Property(e => e.SecretGoodsId3).HasColumnName("secret_goods_id_3");
            });

            modelBuilder.Entity<CggCompletionRewardData>(entity =>
            {
                entity.ToTable("cgg_completion_reward_data");

                entity.HasIndex(e => e.CompletionId)
                    .HasName("cgg_completion_reward_data_0_completion_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompletionId).HasColumnName("completion_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<CggDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("cgg_drama");

                entity.HasIndex(e => e.DramaId)
                    .HasName("cgg_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<CggGachaInfo>(entity =>
            {
                entity.HasKey(e => e.GachaType);

                entity.ToTable("cgg_gacha_info");

                entity.HasIndex(e => e.CggId)
                    .HasName("cgg_gacha_info_0_cgg_id");

                entity.Property(e => e.GachaType)
                    .HasColumnName("gacha_type")
                    .ValueGeneratedNever();

                entity.Property(e => e.CggId).HasColumnName("cgg_id");

                entity.Property(e => e.CostCurrencyNum).HasColumnName("cost_currency_num");

                entity.Property(e => e.GachaDescription)
                    .IsRequired()
                    .HasColumnName("gacha_description");

                entity.Property(e => e.GachaIntro)
                    .IsRequired()
                    .HasColumnName("gacha_intro");

                entity.Property(e => e.GachaName)
                    .IsRequired()
                    .HasColumnName("gacha_name");
            });

            modelBuilder.Entity<CggGachaLineup>(entity =>
            {
                entity.ToTable("cgg_gacha_lineup");

                entity.HasIndex(e => e.GachaType)
                    .HasName("cgg_gacha_lineup_0_gacha_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GachaType).HasColumnName("gacha_type");

                entity.Property(e => e.GoodsId).HasColumnName("goods_id");

                entity.Property(e => e.GoodsNum).HasColumnName("goods_num");

                entity.Property(e => e.LineupId).HasColumnName("lineup_id");
            });

            modelBuilder.Entity<CggGameSettings>(entity =>
            {
                entity.HasKey(e => e.CggId);

                entity.ToTable("cgg_game_settings");

                entity.Property(e => e.CggId)
                    .HasColumnName("cgg_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CggGachaCurrencyId).HasColumnName("cgg_gacha_currency_id");

                entity.Property(e => e.ExchangeLuppiRate).HasColumnName("exchange_luppi_rate");

                entity.Property(e => e.FirstCurrencyRewardNum).HasColumnName("first_currency_reward_num");

                entity.Property(e => e.FirstGoodsShelfRewardNum).HasColumnName("first_goods_shelf_reward_num");

                entity.Property(e => e.GoodsShelfId).HasColumnName("goods_shelf_id");

                entity.Property(e => e.MaxGachaExchangeCount).HasColumnName("max_gacha_exchange_count");

                entity.Property(e => e.MaxGoodsCount).HasColumnName("max_goods_count");
            });

            modelBuilder.Entity<CggGoodsData>(entity =>
            {
                entity.HasKey(e => e.GoodsId);

                entity.ToTable("cgg_goods_data");

                entity.Property(e => e.GoodsId)
                    .HasColumnName("goods_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DetailScaleX).HasColumnName("detail_scale_x");

                entity.Property(e => e.DetailScaleY).HasColumnName("detail_scale_y");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ShelfPositionId).HasColumnName("shelf_position_id");
            });

            modelBuilder.Entity<CharaETicketData>(entity =>
            {
                entity.HasKey(e => e.TicketId);

                entity.ToTable("chara_e_ticket_data");

                entity.HasIndex(e => e.JewelStoreId)
                    .HasName("chara_e_ticket_data_0_jewel_store_id")
                    .IsUnique();

                entity.Property(e => e.TicketId)
                    .HasColumnName("ticket_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.JewelStoreId).HasColumnName("jewel_store_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<CharaFortuneRail>(entity =>
            {
                entity.HasKey(e => e.RailId);

                entity.ToTable("chara_fortune_rail");

                entity.Property(e => e.RailId)
                    .HasColumnName("rail_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Gimmick10Id)
                    .IsRequired()
                    .HasColumnName("gimmick_10_id");

                entity.Property(e => e.Gimmick10X).HasColumnName("gimmick_10_x");

                entity.Property(e => e.Gimmick1Id)
                    .IsRequired()
                    .HasColumnName("gimmick_1_id");

                entity.Property(e => e.Gimmick1X).HasColumnName("gimmick_1_x");

                entity.Property(e => e.Gimmick2Id)
                    .IsRequired()
                    .HasColumnName("gimmick_2_id");

                entity.Property(e => e.Gimmick2X).HasColumnName("gimmick_2_x");

                entity.Property(e => e.Gimmick3Id)
                    .IsRequired()
                    .HasColumnName("gimmick_3_id");

                entity.Property(e => e.Gimmick3X).HasColumnName("gimmick_3_x");

                entity.Property(e => e.Gimmick4Id)
                    .IsRequired()
                    .HasColumnName("gimmick_4_id");

                entity.Property(e => e.Gimmick4X).HasColumnName("gimmick_4_x");

                entity.Property(e => e.Gimmick5Id)
                    .IsRequired()
                    .HasColumnName("gimmick_5_id");

                entity.Property(e => e.Gimmick5X).HasColumnName("gimmick_5_x");

                entity.Property(e => e.Gimmick6Id)
                    .IsRequired()
                    .HasColumnName("gimmick_6_id");

                entity.Property(e => e.Gimmick6X).HasColumnName("gimmick_6_x");

                entity.Property(e => e.Gimmick7Id)
                    .IsRequired()
                    .HasColumnName("gimmick_7_id");

                entity.Property(e => e.Gimmick7X).HasColumnName("gimmick_7_x");

                entity.Property(e => e.Gimmick8Id)
                    .IsRequired()
                    .HasColumnName("gimmick_8_id");

                entity.Property(e => e.Gimmick8X).HasColumnName("gimmick_8_x");

                entity.Property(e => e.Gimmick9Id)
                    .IsRequired()
                    .HasColumnName("gimmick_9_id");

                entity.Property(e => e.Gimmick9X).HasColumnName("gimmick_9_x");
            });

            modelBuilder.Entity<CharaFortuneReward>(entity =>
            {
                entity.ToTable("chara_fortune_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Count1).HasColumnName("count_1");

                entity.Property(e => e.Count2).HasColumnName("count_2");

                entity.Property(e => e.Count3).HasColumnName("count_3");

                entity.Property(e => e.Count4).HasColumnName("count_4");

                entity.Property(e => e.Count5).HasColumnName("count_5");

                entity.Property(e => e.FortuneId).HasColumnName("fortune_id");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<CharaFortuneScenario>(entity =>
            {
                entity.HasKey(e => e.ScenarioId);

                entity.ToTable("chara_fortune_scenario");

                entity.Property(e => e.ScenarioId)
                    .HasColumnName("scenario_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Rail1).HasColumnName("rail_1");

                entity.Property(e => e.Rail2).HasColumnName("rail_2");

                entity.Property(e => e.Rail3).HasColumnName("rail_3");

                entity.Property(e => e.Rail4).HasColumnName("rail_4");
            });

            modelBuilder.Entity<CharaFortuneSchedule>(entity =>
            {
                entity.HasKey(e => e.FortuneId);

                entity.ToTable("chara_fortune_schedule");

                entity.Property(e => e.FortuneId)
                    .HasColumnName("fortune_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<CharaIdentity>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("chara_identity");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharaType).HasColumnName("chara_type");

                entity.Property(e => e.CharaType2).HasColumnName("chara_type_2");

                entity.Property(e => e.CharaType3).HasColumnName("chara_type_3");
            });

            modelBuilder.Entity<CharaStoryStatus>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("chara_story_status");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharaId1).HasColumnName("chara_id_1");

                entity.Property(e => e.CharaId10).HasColumnName("chara_id_10");

                entity.Property(e => e.CharaId2).HasColumnName("chara_id_2");

                entity.Property(e => e.CharaId3).HasColumnName("chara_id_3");

                entity.Property(e => e.CharaId4).HasColumnName("chara_id_4");

                entity.Property(e => e.CharaId5).HasColumnName("chara_id_5");

                entity.Property(e => e.CharaId6).HasColumnName("chara_id_6");

                entity.Property(e => e.CharaId7).HasColumnName("chara_id_7");

                entity.Property(e => e.CharaId8).HasColumnName("chara_id_8");

                entity.Property(e => e.CharaId9).HasColumnName("chara_id_9");

                entity.Property(e => e.StatusRate1).HasColumnName("status_rate_1");

                entity.Property(e => e.StatusRate2).HasColumnName("status_rate_2");

                entity.Property(e => e.StatusRate3).HasColumnName("status_rate_3");

                entity.Property(e => e.StatusRate4).HasColumnName("status_rate_4");

                entity.Property(e => e.StatusRate5).HasColumnName("status_rate_5");

                entity.Property(e => e.StatusType1).HasColumnName("status_type_1");

                entity.Property(e => e.StatusType2).HasColumnName("status_type_2");

                entity.Property(e => e.StatusType3).HasColumnName("status_type_3");

                entity.Property(e => e.StatusType4).HasColumnName("status_type_4");

                entity.Property(e => e.StatusType5).HasColumnName("status_type_5");

                entity.Property(e => e.UnlockStoryName)
                    .IsRequired()
                    .HasColumnName("unlock_story_name");
            });

            modelBuilder.Entity<CharacterLoveRankupText>(entity =>
            {
                entity.HasKey(e => e.CharaId);

                entity.ToTable("character_love_rankup_text");

                entity.Property(e => e.CharaId)
                    .HasColumnName("chara_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Face1).HasColumnName("face_1");

                entity.Property(e => e.Face2).HasColumnName("face_2");

                entity.Property(e => e.Face3).HasColumnName("face_3");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.Scale).HasColumnName("scale");

                entity.Property(e => e.Serif1)
                    .IsRequired()
                    .HasColumnName("serif_1");

                entity.Property(e => e.Serif2)
                    .IsRequired()
                    .HasColumnName("serif_2");

                entity.Property(e => e.Serif3)
                    .IsRequired()
                    .HasColumnName("serif_3");

                entity.Property(e => e.VoiceId1).HasColumnName("voice_id_1");

                entity.Property(e => e.VoiceId2).HasColumnName("voice_id_2");

                entity.Property(e => e.VoiceId3).HasColumnName("voice_id_3");
            });

            modelBuilder.Entity<ClanBattle2BossData>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("clan_battle_2_boss_data");

                entity.Property(e => e.BossId)
                    .HasColumnName("boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BattleReportMonsterHeight).HasColumnName("battle_report_monster_height");

                entity.Property(e => e.BattleReportMonsterSize).HasColumnName("battle_report_monster_size");

                entity.Property(e => e.BossThumbId).HasColumnName("boss_thumb_id");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.CursorPosition).HasColumnName("cursor_position");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.MapPositionX).HasColumnName("map_position_x");

                entity.Property(e => e.MapPositionY).HasColumnName("map_position_y");

                entity.Property(e => e.OrderNum).HasColumnName("order_num");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestDetailMonsterHeight).HasColumnName("quest_detail_monster_height");

                entity.Property(e => e.QuestDetailMonsterSize).HasColumnName("quest_detail_monster_size");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.ScaleRatio).HasColumnName("scale_ratio");

                entity.Property(e => e.TapHeightRatio).HasColumnName("tap_height_ratio");

                entity.Property(e => e.TapWidthRatio).HasColumnName("tap_width_ratio");

                entity.Property(e => e.WaveBgm)
                    .IsRequired()
                    .HasColumnName("wave_bgm");
            });

            modelBuilder.Entity<ClanBattle2MapData>(entity =>
            {
                entity.ToTable("clan_battle_2_map_data");

                entity.HasIndex(e => e.ClanBattleId)
                    .HasName("clan_battle_2_map_data_0_clan_battle_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuraEffect).HasColumnName("aura_effect");

                entity.Property(e => e.BossId1).HasColumnName("boss_id_1");

                entity.Property(e => e.BossId2).HasColumnName("boss_id_2");

                entity.Property(e => e.BossId3).HasColumnName("boss_id_3");

                entity.Property(e => e.BossId4).HasColumnName("boss_id_4");

                entity.Property(e => e.BossId5).HasColumnName("boss_id_5");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.DamageRankId1).HasColumnName("damage_rank_id_1");

                entity.Property(e => e.DamageRankId2).HasColumnName("damage_rank_id_2");

                entity.Property(e => e.DamageRankId3).HasColumnName("damage_rank_id_3");

                entity.Property(e => e.DamageRankId4).HasColumnName("damage_rank_id_4");

                entity.Property(e => e.DamageRankId5).HasColumnName("damage_rank_id_5");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.FixRewardId1).HasColumnName("fix_reward_id_1");

                entity.Property(e => e.FixRewardId2).HasColumnName("fix_reward_id_2");

                entity.Property(e => e.FixRewardId3).HasColumnName("fix_reward_id_3");

                entity.Property(e => e.FixRewardId4).HasColumnName("fix_reward_id_4");

                entity.Property(e => e.FixRewardId5).HasColumnName("fix_reward_id_5");

                entity.Property(e => e.LapNumFrom).HasColumnName("lap_num_from");

                entity.Property(e => e.LapNumTo).HasColumnName("lap_num_to");

                entity.Property(e => e.LastAttackRewardId).HasColumnName("last_attack_reward_id");

                entity.Property(e => e.LimitedMana).HasColumnName("limited_mana");

                entity.Property(e => e.MapBg).HasColumnName("map_bg");

                entity.Property(e => e.ParamAdjustId).HasColumnName("param_adjust_id");

                entity.Property(e => e.ParamAdjustInterval).HasColumnName("param_adjust_interval");

                entity.Property(e => e.Phase).HasColumnName("phase");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.RslUnlockLap).HasColumnName("rsl_unlock_lap");

                entity.Property(e => e.ScoreCoefficient1).HasColumnName("score_coefficient_1");

                entity.Property(e => e.ScoreCoefficient2).HasColumnName("score_coefficient_2");

                entity.Property(e => e.ScoreCoefficient3).HasColumnName("score_coefficient_3");

                entity.Property(e => e.ScoreCoefficient4).HasColumnName("score_coefficient_4");

                entity.Property(e => e.ScoreCoefficient5).HasColumnName("score_coefficient_5");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");

                entity.Property(e => e.WaveGroupId4).HasColumnName("wave_group_id_4");

                entity.Property(e => e.WaveGroupId5).HasColumnName("wave_group_id_5");
            });

            modelBuilder.Entity<ClanBattleArchiveClanRank>(entity =>
            {
                entity.ToTable("clan_battle_archive_clan_rank");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");
            });

            modelBuilder.Entity<ClanBattleArchivePersonRank>(entity =>
            {
                entity.ToTable("clan_battle_archive_person_rank");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");
            });

            modelBuilder.Entity<ClanBattleBattleMissionData>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("clan_battle_battle_mission_data");

                entity.Property(e => e.MissionId)
                    .HasColumnName("mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue10).HasColumnName("condition_value_10");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.ConditionValue6).HasColumnName("condition_value_6");

                entity.Property(e => e.ConditionValue7).HasColumnName("condition_value_7");

                entity.Property(e => e.ConditionValue8).HasColumnName("condition_value_8");

                entity.Property(e => e.ConditionValue9).HasColumnName("condition_value_9");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<ClanBattleBossDamageRank>(entity =>
            {
                entity.HasKey(e => new { e.DamageRankId, e.RankingFrom, e.RankingTo });

                entity.ToTable("clan_battle_boss_damage_rank");

                entity.HasIndex(e => e.DamageRankId)
                    .HasName("clan_battle_boss_damage_rank_0_damage_rank_id");

                entity.Property(e => e.DamageRankId).HasColumnName("damage_rank_id");

                entity.Property(e => e.RankingFrom).HasColumnName("ranking_from");

                entity.Property(e => e.RankingTo).HasColumnName("ranking_to");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattleBossFixReward>(entity =>
            {
                entity.HasKey(e => e.FixRewardId);

                entity.ToTable("clan_battle_boss_fix_reward");

                entity.Property(e => e.FixRewardId)
                    .HasColumnName("fix_reward_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattleLastAttackReward>(entity =>
            {
                entity.HasKey(e => e.LastAttackRewardId);

                entity.ToTable("clan_battle_last_attack_reward");

                entity.Property(e => e.LastAttackRewardId)
                    .HasColumnName("last_attack_reward_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattleOddsData>(entity =>
            {
                entity.HasKey(e => new { e.OddsGroupId, e.TeamLevelFrom, e.TeamLevelTo });

                entity.ToTable("clan_battle_odds_data");

                entity.HasIndex(e => e.OddsGroupId)
                    .HasName("clan_battle_odds_data_0_odds_group_id");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.TeamLevelFrom).HasColumnName("team_level_from");

                entity.Property(e => e.TeamLevelTo).HasColumnName("team_level_to");

                entity.Property(e => e.OddsCsv1)
                    .IsRequired()
                    .HasColumnName("odds_csv_1");

                entity.Property(e => e.OddsCsv10)
                    .IsRequired()
                    .HasColumnName("odds_csv_10");

                entity.Property(e => e.OddsCsv2)
                    .IsRequired()
                    .HasColumnName("odds_csv_2");

                entity.Property(e => e.OddsCsv3)
                    .IsRequired()
                    .HasColumnName("odds_csv_3");

                entity.Property(e => e.OddsCsv4)
                    .IsRequired()
                    .HasColumnName("odds_csv_4");

                entity.Property(e => e.OddsCsv5)
                    .IsRequired()
                    .HasColumnName("odds_csv_5");

                entity.Property(e => e.OddsCsv6)
                    .IsRequired()
                    .HasColumnName("odds_csv_6");

                entity.Property(e => e.OddsCsv7)
                    .IsRequired()
                    .HasColumnName("odds_csv_7");

                entity.Property(e => e.OddsCsv8)
                    .IsRequired()
                    .HasColumnName("odds_csv_8");

                entity.Property(e => e.OddsCsv9)
                    .IsRequired()
                    .HasColumnName("odds_csv_9");
            });

            modelBuilder.Entity<ClanBattleParamAdjust>(entity =>
            {
                entity.HasKey(e => e.ParamAdjustId);

                entity.ToTable("clan_battle_param_adjust");

                entity.Property(e => e.ParamAdjustId)
                    .HasColumnName("param_adjust_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.NormalAtkCastTime).HasColumnName("normal_atk_cast_time");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.ScoreCoefficient).HasColumnName("score_coefficient");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");
            });

            modelBuilder.Entity<ClanBattlePeriod>(entity =>
            {
                entity.HasKey(e => new { e.ClanBattleId, e.Period });

                entity.ToTable("clan_battle_period");

                entity.HasIndex(e => e.ClanBattleId)
                    .HasName("clan_battle_period_0_clan_battle_id");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.CalcStart)
                    .IsRequired()
                    .HasColumnName("calc_start");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.IntervalEnd)
                    .IsRequired()
                    .HasColumnName("interval_end");

                entity.Property(e => e.IntervalStart)
                    .IsRequired()
                    .HasColumnName("interval_start");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.MinCarryOverTime).HasColumnName("min_carry_over_time");

                entity.Property(e => e.PeriodDetail)
                    .IsRequired()
                    .HasColumnName("period_detail");

                entity.Property(e => e.PeriodDetailBg).HasColumnName("period_detail_bg");

                entity.Property(e => e.PeriodDetailBgPosition).HasColumnName("period_detail_bg_position");

                entity.Property(e => e.PeriodDetailBgS).HasColumnName("period_detail_bg_s");

                entity.Property(e => e.PeriodDetailBossPositionX).HasColumnName("period_detail_boss_position_x");

                entity.Property(e => e.PeriodDetailBossPositionY).HasColumnName("period_detail_boss_position_y");

                entity.Property(e => e.PeriodDetailS)
                    .IsRequired()
                    .HasColumnName("period_detail_s");

                entity.Property(e => e.QuestDetailRehearsalLabelHeight).HasColumnName("quest_detail_rehearsal_label_height");

                entity.Property(e => e.ResultEnd)
                    .IsRequired()
                    .HasColumnName("result_end");

                entity.Property(e => e.ResultStart)
                    .IsRequired()
                    .HasColumnName("result_start");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<ClanBattlePeriodLapReward>(entity =>
            {
                entity.ToTable("clan_battle_period_lap_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.LapNumFrom).HasColumnName("lap_num_from");

                entity.Property(e => e.LapNumTo).HasColumnName("lap_num_to");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.RankingBonusGroup).HasColumnName("ranking_bonus_group");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattlePeriodRankReward>(entity =>
            {
                entity.ToTable("clan_battle_period_rank_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.Period).HasColumnName("period");

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RankingBonusGroup).HasColumnName("ranking_bonus_group");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattleRecommendData>(entity =>
            {
                entity.HasKey(e => e.LevelId);

                entity.ToTable("clan_battle_recommend_data");

                entity.HasIndex(e => e.RecommendGroup)
                    .HasName("clan_battle_recommend_data_0_recommend_group");

                entity.Property(e => e.LevelId)
                    .HasColumnName("level_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtackPartyCount).HasColumnName("atack_party_count");

                entity.Property(e => e.LevelFrom).HasColumnName("level_from");

                entity.Property(e => e.LevelTo).HasColumnName("level_to");

                entity.Property(e => e.MagicPartyCount).HasColumnName("magic_party_count");

                entity.Property(e => e.RecommendGroup).HasColumnName("recommend_group");
            });

            modelBuilder.Entity<ClanBattleSBossData>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("clan_battle_s_boss_data");

                entity.Property(e => e.BossId)
                    .HasColumnName("boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BattleReportMonsterHeight).HasColumnName("battle_report_monster_height");

                entity.Property(e => e.BattleReportMonsterSize).HasColumnName("battle_report_monster_size");

                entity.Property(e => e.BossThumbId).HasColumnName("boss_thumb_id");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.CursorPosition).HasColumnName("cursor_position");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.MapPositionX).HasColumnName("map_position_x");

                entity.Property(e => e.MapPositionY).HasColumnName("map_position_y");

                entity.Property(e => e.OrderNum).HasColumnName("order_num");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestDetailMonsterHeight).HasColumnName("quest_detail_monster_height");

                entity.Property(e => e.QuestDetailMonsterSize).HasColumnName("quest_detail_monster_size");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.ScaleRatio).HasColumnName("scale_ratio");

                entity.Property(e => e.TapHeightRatio).HasColumnName("tap_height_ratio");

                entity.Property(e => e.TapWidthRatio).HasColumnName("tap_width_ratio");

                entity.Property(e => e.WaveBgm)
                    .IsRequired()
                    .HasColumnName("wave_bgm");
            });

            modelBuilder.Entity<ClanBattleSBossFixReward>(entity =>
            {
                entity.HasKey(e => e.FixRewardId);

                entity.ToTable("clan_battle_s_boss_fix_reward");

                entity.Property(e => e.FixRewardId)
                    .HasColumnName("fix_reward_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ClanBattleSMapData>(entity =>
            {
                entity.ToTable("clan_battle_s_map_data");

                entity.HasIndex(e => e.ClanBattleId)
                    .HasName("clan_battle_s_map_data_0_clan_battle_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AuraEffect).HasColumnName("aura_effect");

                entity.Property(e => e.BossId1).HasColumnName("boss_id_1");

                entity.Property(e => e.BossId2).HasColumnName("boss_id_2");

                entity.Property(e => e.BossId3).HasColumnName("boss_id_3");

                entity.Property(e => e.BossId4).HasColumnName("boss_id_4");

                entity.Property(e => e.BossId5).HasColumnName("boss_id_5");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.DamageRankId1).HasColumnName("damage_rank_id_1");

                entity.Property(e => e.DamageRankId2).HasColumnName("damage_rank_id_2");

                entity.Property(e => e.DamageRankId3).HasColumnName("damage_rank_id_3");

                entity.Property(e => e.DamageRankId4).HasColumnName("damage_rank_id_4");

                entity.Property(e => e.DamageRankId5).HasColumnName("damage_rank_id_5");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.ExtraBattleFlag1).HasColumnName("extra_battle_flag1");

                entity.Property(e => e.ExtraBattleFlag2).HasColumnName("extra_battle_flag2");

                entity.Property(e => e.ExtraBattleFlag3).HasColumnName("extra_battle_flag3");

                entity.Property(e => e.ExtraBattleFlag4).HasColumnName("extra_battle_flag4");

                entity.Property(e => e.ExtraBattleFlag5).HasColumnName("extra_battle_flag5");

                entity.Property(e => e.FixRewardId1).HasColumnName("fix_reward_id_1");

                entity.Property(e => e.FixRewardId2).HasColumnName("fix_reward_id_2");

                entity.Property(e => e.FixRewardId3).HasColumnName("fix_reward_id_3");

                entity.Property(e => e.FixRewardId4).HasColumnName("fix_reward_id_4");

                entity.Property(e => e.FixRewardId5).HasColumnName("fix_reward_id_5");

                entity.Property(e => e.LapNumFrom).HasColumnName("lap_num_from");

                entity.Property(e => e.LapNumTo).HasColumnName("lap_num_to");

                entity.Property(e => e.LastAttackRewardId).HasColumnName("last_attack_reward_id");

                entity.Property(e => e.LimitedMana).HasColumnName("limited_mana");

                entity.Property(e => e.MapBg).HasColumnName("map_bg");

                entity.Property(e => e.ParamAdjustId).HasColumnName("param_adjust_id");

                entity.Property(e => e.ParamAdjustInterval).HasColumnName("param_adjust_interval");

                entity.Property(e => e.Phase).HasColumnName("phase");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.RslUnlockLap).HasColumnName("rsl_unlock_lap");

                entity.Property(e => e.ScoreCoefficient1).HasColumnName("score_coefficient_1");

                entity.Property(e => e.ScoreCoefficient2).HasColumnName("score_coefficient_2");

                entity.Property(e => e.ScoreCoefficient3).HasColumnName("score_coefficient_3");

                entity.Property(e => e.ScoreCoefficient4).HasColumnName("score_coefficient_4");

                entity.Property(e => e.ScoreCoefficient5).HasColumnName("score_coefficient_5");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");

                entity.Property(e => e.WaveGroupId4).HasColumnName("wave_group_id_4");

                entity.Property(e => e.WaveGroupId5).HasColumnName("wave_group_id_5");
            });

            modelBuilder.Entity<ClanBattleSParamAdjust>(entity =>
            {
                entity.HasKey(e => e.ParamAdjustId);

                entity.ToTable("clan_battle_s_param_adjust");

                entity.Property(e => e.ParamAdjustId)
                    .HasColumnName("param_adjust_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.NormalAtkCastTime).HasColumnName("normal_atk_cast_time");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.ScoreCoefficient).HasColumnName("score_coefficient");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");
            });

            modelBuilder.Entity<ClanBattleSchedule>(entity =>
            {
                entity.HasKey(e => e.ClanBattleId);

                entity.ToTable("clan_battle_schedule");

                entity.Property(e => e.ClanBattleId)
                    .HasColumnName("clan_battle_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CostGroupId).HasColumnName("cost_group_id");

                entity.Property(e => e.CostGroupIdS).HasColumnName("cost_group_id_s");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.LastClanBattleId).HasColumnName("last_clan_battle_id");

                entity.Property(e => e.MapBgm)
                    .IsRequired()
                    .HasColumnName("map_bgm");

                entity.Property(e => e.PointPerStamina).HasColumnName("point_per_stamina");

                entity.Property(e => e.ReleaseMonth).HasColumnName("release_month");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<ClanBattleTrainingData>(entity =>
            {
                entity.ToTable("clan_battle_training_data");

                entity.HasIndex(e => e.TrainingId)
                    .HasName("clan_battle_training_data_0_training_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MapDataId).HasColumnName("map_data_id");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.Phase).HasColumnName("phase");

                entity.Property(e => e.TrainingId).HasColumnName("training_id");
            });

            modelBuilder.Entity<ClanBattleTrainingSchedule>(entity =>
            {
                entity.HasKey(e => e.TrainingId);

                entity.ToTable("clan_battle_training_schedule");

                entity.HasIndex(e => e.ClanBattleId)
                    .HasName("clan_battle_training_schedule_0_clan_battle_id");

                entity.Property(e => e.TrainingId)
                    .HasColumnName("training_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BattleEndTime)
                    .IsRequired()
                    .HasColumnName("battle_end_time");

                entity.Property(e => e.BattleStartTime)
                    .IsRequired()
                    .HasColumnName("battle_start_time");

                entity.Property(e => e.ClanBattleId).HasColumnName("clan_battle_id");

                entity.Property(e => e.IntervalEndTime)
                    .IsRequired()
                    .HasColumnName("interval_end_time");

                entity.Property(e => e.IntervalStartTime)
                    .IsRequired()
                    .HasColumnName("interval_start_time");
            });

            modelBuilder.Entity<ClanCostGroup>(entity =>
            {
                entity.ToTable("clan_cost_group");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.CostGroupId).HasColumnName("cost_group_id");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");
            });

            modelBuilder.Entity<ClanGrade>(entity =>
            {
                entity.ToTable("clan_grade");

                entity.Property(e => e.ClanGradeId)
                    .HasColumnName("clan_grade_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");
            });

            modelBuilder.Entity<ClanInviteLevelGroup>(entity =>
            {
                entity.HasKey(e => e.LevelGroupId);

                entity.ToTable("clan_invite_level_group");

                entity.Property(e => e.LevelGroupId)
                    .HasColumnName("level_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TeamLevelFrom).HasColumnName("team_level_from");

                entity.Property(e => e.TeamLevelTo).HasColumnName("team_level_to");
            });

            modelBuilder.Entity<ClanprofileContent>(entity =>
            {
                entity.ToTable("clanprofile_content");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<CombinedResultMotion>(entity =>
            {
                entity.HasKey(e => e.ResultId);

                entity.ToTable("combined_result_motion");

                entity.Property(e => e.ResultId)
                    .HasColumnName("result_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispOrder1).HasColumnName("disp_order_1");

                entity.Property(e => e.DispOrder2).HasColumnName("disp_order_2");

                entity.Property(e => e.DispOrder3).HasColumnName("disp_order_3");

                entity.Property(e => e.DispOrder4).HasColumnName("disp_order_4");

                entity.Property(e => e.DispOrder5).HasColumnName("disp_order_5");

                entity.Property(e => e.UnitId1).HasColumnName("unit_id_1");

                entity.Property(e => e.UnitId2).HasColumnName("unit_id_2");

                entity.Property(e => e.UnitId3).HasColumnName("unit_id_3");

                entity.Property(e => e.UnitId4).HasColumnName("unit_id_4");

                entity.Property(e => e.UnitId5).HasColumnName("unit_id_5");
            });

            modelBuilder.Entity<ContentMapData>(entity =>
            {
                entity.HasKey(e => e.ContentMapId);

                entity.ToTable("content_map_data");

                entity.Property(e => e.ContentMapId)
                    .HasColumnName("content_map_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.QuestPositionX).HasColumnName("quest_position_x");

                entity.Property(e => e.QuestPositionY).HasColumnName("quest_position_y");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<ContentReleaseData>(entity =>
            {
                entity.HasKey(e => e.SystemId);

                entity.ToTable("content_release_data");

                entity.Property(e => e.SystemId)
                    .HasColumnName("system_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Dialog)
                    .IsRequired()
                    .HasColumnName("dialog");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.TeamLevel).HasColumnName("team_level");
            });

            modelBuilder.Entity<CooperationQuestData>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("cooperation_quest_data");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.ClearRewardGroupId).HasColumnName("clear_reward_group_id");

                entity.Property(e => e.CooperationQuestDetailBgId).HasColumnName("cooperation_quest_detail_bg_id");

                entity.Property(e => e.CooperationQuestDetailBgPosition).HasColumnName("cooperation_quest_detail_bg_position");

                entity.Property(e => e.DifficultyLevel).HasColumnName("difficulty_level");

                entity.Property(e => e.EnemyImage1).HasColumnName("enemy_image_1");

                entity.Property(e => e.EnemyImage2).HasColumnName("enemy_image_2");

                entity.Property(e => e.EnemyImage3).HasColumnName("enemy_image_3");

                entity.Property(e => e.EnemyImage4).HasColumnName("enemy_image_4");

                entity.Property(e => e.EnemyImage5).HasColumnName("enemy_image_5");

                entity.Property(e => e.Exp).HasColumnName("exp");

                entity.Property(e => e.FirstRewardImage1).HasColumnName("first_reward_image_1");

                entity.Property(e => e.FirstRewardImage2).HasColumnName("first_reward_image_2");

                entity.Property(e => e.FirstRewardImage3).HasColumnName("first_reward_image_3");

                entity.Property(e => e.FirstRewardImage4).HasColumnName("first_reward_image_4");

                entity.Property(e => e.FirstRewardImage5).HasColumnName("first_reward_image_5");

                entity.Property(e => e.LimitTeamLevel).HasColumnName("limit_team_level");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.LobbyBackground).HasColumnName("lobby_background");

                entity.Property(e => e.MainEnemyImageWave1).HasColumnName("main_enemy_image_wave_1");

                entity.Property(e => e.MainEnemyImageWave2).HasColumnName("main_enemy_image_wave_2");

                entity.Property(e => e.MainEnemyImageWave3).HasColumnName("main_enemy_image_wave_3");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.QuestComment)
                    .IsRequired()
                    .HasColumnName("quest_comment");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.RepeatRewardImage1).HasColumnName("repeat_reward_image_1");

                entity.Property(e => e.RepeatRewardImage2).HasColumnName("repeat_reward_image_2");

                entity.Property(e => e.RepeatRewardImage3).HasColumnName("repeat_reward_image_3");

                entity.Property(e => e.SubEnemyImageWave11).HasColumnName("sub_enemy_image_wave_1_1");

                entity.Property(e => e.SubEnemyImageWave12).HasColumnName("sub_enemy_image_wave_1_2");

                entity.Property(e => e.SubEnemyImageWave13).HasColumnName("sub_enemy_image_wave_1_3");

                entity.Property(e => e.SubEnemyImageWave14).HasColumnName("sub_enemy_image_wave_1_4");

                entity.Property(e => e.SubEnemyImageWave21).HasColumnName("sub_enemy_image_wave_2_1");

                entity.Property(e => e.SubEnemyImageWave22).HasColumnName("sub_enemy_image_wave_2_2");

                entity.Property(e => e.SubEnemyImageWave23).HasColumnName("sub_enemy_image_wave_2_3");

                entity.Property(e => e.SubEnemyImageWave24).HasColumnName("sub_enemy_image_wave_2_4");

                entity.Property(e => e.SubEnemyImageWave31).HasColumnName("sub_enemy_image_wave_3_1");

                entity.Property(e => e.SubEnemyImageWave32).HasColumnName("sub_enemy_image_wave_3_2");

                entity.Property(e => e.SubEnemyImageWave33).HasColumnName("sub_enemy_image_wave_3_3");

                entity.Property(e => e.SubEnemyImageWave34).HasColumnName("sub_enemy_image_wave_3_4");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.UnlockQuestId1).HasColumnName("unlock_quest_id_1");

                entity.Property(e => e.UnlockQuestId2).HasColumnName("unlock_quest_id_2");

                entity.Property(e => e.WaveBgmQueId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_3");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<CustomMypage>(entity =>
            {
                entity.HasKey(e => e.StillId);

                entity.ToTable("custom_mypage");

                entity.HasIndex(e => e.StillGroupId)
                    .HasName("custom_mypage_0_still_group_id");

                entity.Property(e => e.StillId)
                    .HasColumnName("still_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.MypageType).HasColumnName("mypage_type");

                entity.Property(e => e.ScrollDirection).HasColumnName("scroll_direction");

                entity.Property(e => e.StillGroupId).HasColumnName("still_group_id");

                entity.Property(e => e.StillName)
                    .IsRequired()
                    .HasColumnName("still_name");

                entity.Property(e => e.VerticalStillFlg).HasColumnName("vertical_still_flg");
            });

            modelBuilder.Entity<CustomMypageGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("custom_mypage_group");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupName)
                    .IsRequired()
                    .HasColumnName("group_name");
            });

            modelBuilder.Entity<DailyMissionData>(entity =>
            {
                entity.HasKey(e => e.DailyMissionId);

                entity.ToTable("daily_mission_data");

                entity.Property(e => e.DailyMissionId)
                    .HasColumnName("daily_mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.MaxLevel).HasColumnName("max_level");

                entity.Property(e => e.MinLevel).HasColumnName("min_level");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.TitleColorId).HasColumnName("title_color_id");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<DearChara>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.CharaIndex });

                entity.ToTable("dear_chara");

                entity.HasIndex(e => e.EventId)
                    .HasName("dear_chara_0_event_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.CharaIndex).HasColumnName("chara_index");

                entity.Property(e => e.CharaName)
                    .IsRequired()
                    .HasColumnName("chara_name");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.DearPointUpOffsetX).HasColumnName("dear_point_up_offset_x");

                entity.Property(e => e.DearPointUpOffsetY).HasColumnName("dear_point_up_offset_y");

                entity.Property(e => e.EpisodeUnlockOffsetX).HasColumnName("episode_unlock_offset_x");

                entity.Property(e => e.EpisodeUnlockOffsetY).HasColumnName("episode_unlock_offset_y");

                entity.Property(e => e.MaxDearPoint).HasColumnName("max_dear_point");

                entity.Property(e => e.ReferenceId).HasColumnName("reference_id");

                entity.Property(e => e.ReferenceType).HasColumnName("reference_type");
            });

            modelBuilder.Entity<DearReward>(entity =>
            {
                entity.ToTable("dear_reward");

                entity.HasIndex(e => new { e.EventId, e.CharaIndex })
                    .HasName("dear_reward_0_event_id_1_chara_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharaIndex).HasColumnName("chara_index");

                entity.Property(e => e.DearPoint).HasColumnName("dear_point");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionDetail)
                    .IsRequired()
                    .HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<DearSetting>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("dear_setting");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasColumnName("system_name");

                entity.Property(e => e.TutorialCharaIndex).HasColumnName("tutorial_chara_index");

                entity.Property(e => e.TutorialQuestId).HasColumnName("tutorial_quest_id");

                entity.Property(e => e.TutorialStoryId).HasColumnName("tutorial_story_id");
            });

            modelBuilder.Entity<DearStoryData>(entity =>
            {
                entity.HasKey(e => e.StoryGroupId);

                entity.ToTable("dear_story_data");

                entity.HasIndex(e => e.Value)
                    .HasName("dear_story_data_0_value");

                entity.Property(e => e.StoryGroupId)
                    .HasColumnName("story_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryType).HasColumnName("story_type");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<DearStoryDetail>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("dear_story_detail");

                entity.HasIndex(e => e.StoryGroupId)
                    .HasName("dear_story_detail_0_story_group_id");

                entity.HasIndex(e => new { e.StoryGroupId, e.CharaIndex })
                    .HasName("dear_story_detail_0_story_group_id_1_chara_index");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharaIndex).HasColumnName("chara_index");

                entity.Property(e => e.ConditionEventBossId).HasColumnName("condition_event_boss_id");

                entity.Property(e => e.ConditionEventQuestId).HasColumnName("condition_event_quest_id");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardValue1).HasColumnName("reward_value_1");

                entity.Property(e => e.RewardValue2).HasColumnName("reward_value_2");

                entity.Property(e => e.RewardValue3).HasColumnName("reward_value_3");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryEnd).HasColumnName("story_end");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryQuestId).HasColumnName("story_quest_id");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.UnlockQuestId).HasColumnName("unlock_quest_id");

                entity.Property(e => e.VisibleType).HasColumnName("visible_type");
            });

            modelBuilder.Entity<DefineSpskill>(entity =>
            {
                entity.HasKey(e => e.LinkSkillSlot);

                entity.ToTable("define_spskill");

                entity.HasIndex(e => e.SpSkillId)
                    .HasName("define_spskill_0_sp_skill_id");

                entity.Property(e => e.LinkSkillSlot)
                    .HasColumnName("link_skill_slot")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseSkillId).HasColumnName("base_skill_id");

                entity.Property(e => e.SkillCategory).HasColumnName("skill_category");

                entity.Property(e => e.SpSkillId).HasColumnName("sp_skill_id");
            });

            modelBuilder.Entity<DodgeTpRecovery>(entity =>
            {
                entity.HasKey(e => e.SystemId);

                entity.ToTable("dodge_tp_recovery");

                entity.Property(e => e.SystemId)
                    .HasColumnName("system_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RecoveryRatio).HasColumnName("recovery_ratio");
            });

            modelBuilder.Entity<DungeonArea>(entity =>
            {
                entity.ToTable("dungeon_area");

                entity.Property(e => e.DungeonAreaId)
                    .HasColumnName("dungeon_area_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContentReleaseStory).HasColumnName("content_release_story");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DungeonName)
                    .IsRequired()
                    .HasColumnName("dungeon_name");

                entity.Property(e => e.DungeonType).HasColumnName("dungeon_type");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.InitialClearStory).HasColumnName("initial_clear_story");

                entity.Property(e => e.OpenAreaId).HasColumnName("open_area_id");

                entity.Property(e => e.OpenQuestId).HasColumnName("open_quest_id");

                entity.Property(e => e.QuestPositionX).HasColumnName("quest_position_x");

                entity.Property(e => e.QuestPositionY).HasColumnName("quest_position_y");

                entity.Property(e => e.RecommendLevel).HasColumnName("recommend_level");

                entity.Property(e => e.RecoveryHpRate).HasColumnName("recovery_hp_rate");

                entity.Property(e => e.RecoveryTpRate).HasColumnName("recovery_tp_rate");

                entity.Property(e => e.RewardGroupId).HasColumnName("reward_group_id");
            });

            modelBuilder.Entity<DungeonAreaData>(entity =>
            {
                entity.HasKey(e => e.DungeonAreaId);

                entity.ToTable("dungeon_area_data");

                entity.Property(e => e.DungeonAreaId)
                    .HasColumnName("dungeon_area_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoinItemId).HasColumnName("coin_item_id");

                entity.Property(e => e.ContentReleaseStory).HasColumnName("content_release_story");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DungeonName)
                    .IsRequired()
                    .HasColumnName("dungeon_name");

                entity.Property(e => e.DungeonType).HasColumnName("dungeon_type");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EnemyImage1).HasColumnName("enemy_image_1");

                entity.Property(e => e.EnemyImage2).HasColumnName("enemy_image_2");

                entity.Property(e => e.EnemyImage3).HasColumnName("enemy_image_3");

                entity.Property(e => e.EnemyImage4).HasColumnName("enemy_image_4");

                entity.Property(e => e.EnemyImage5).HasColumnName("enemy_image_5");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.InitialClearStory).HasColumnName("initial_clear_story");

                entity.Property(e => e.OpenQuestId).HasColumnName("open_quest_id");

                entity.Property(e => e.QuestPositionX).HasColumnName("quest_position_x");

                entity.Property(e => e.QuestPositionY).HasColumnName("quest_position_y");

                entity.Property(e => e.RecommendLevel).HasColumnName("recommend_level");

                entity.Property(e => e.RecoveryHpRate).HasColumnName("recovery_hp_rate");

                entity.Property(e => e.RecoveryTpRate).HasColumnName("recovery_tp_rate");

                entity.Property(e => e.RewardGroupId).HasColumnName("reward_group_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.ViewRewardId1).HasColumnName("view_reward_id_1");

                entity.Property(e => e.ViewRewardId2).HasColumnName("view_reward_id_2");

                entity.Property(e => e.ViewRewardId3).HasColumnName("view_reward_id_3");

                entity.Property(e => e.ViewRewardId4).HasColumnName("view_reward_id_4");

                entity.Property(e => e.ViewRewardId5).HasColumnName("view_reward_id_5");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<DungeonQuestData>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("dungeon_quest_data");

                entity.HasIndex(e => e.DungeonAreaId)
                    .HasName("dungeon_quest_data_0_dungeon_area_id");

                entity.HasIndex(e => new { e.DungeonAreaId, e.FloorNum })
                    .HasName("dungeon_quest_data_0_dungeon_area_id_1_floor_num")
                    .IsUnique();

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.DungeonAreaId).HasColumnName("dungeon_area_id");

                entity.Property(e => e.DungeonQuestDetailBgId).HasColumnName("dungeon_quest_detail_bg_id");

                entity.Property(e => e.DungeonQuestDetailBgPosition).HasColumnName("dungeon_quest_detail_bg_position");

                entity.Property(e => e.DungeonQuestDetailMonsterHeight).HasColumnName("dungeon_quest_detail_monster_height");

                entity.Property(e => e.DungeonQuestDetailMonsterPositionX1).HasColumnName("dungeon_quest_detail_monster_position_x_1");

                entity.Property(e => e.DungeonQuestDetailMonsterPositionX2).HasColumnName("dungeon_quest_detail_monster_position_x_2");

                entity.Property(e => e.DungeonQuestDetailMonsterSize).HasColumnName("dungeon_quest_detail_monster_size");

                entity.Property(e => e.Emax).HasColumnName("emax");

                entity.Property(e => e.EnergyResetFlag).HasColumnName("energy_reset_flag");

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.MatchingCoefficient).HasColumnName("matching_coefficient");

                entity.Property(e => e.MultiTargetEffectTime).HasColumnName("multi_target_effect_time");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.PartsHpSaveFlag).HasColumnName("parts_hp_save_flag");

                entity.Property(e => e.QuestType).HasColumnName("quest_type");

                entity.Property(e => e.RewardCoin).HasColumnName("reward_coin");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.RewardImage6).HasColumnName("reward_image_6");

                entity.Property(e => e.WaveBgmQueId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmSheetId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<DungeonSkipData>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("dungeon_skip_data");

                entity.Property(e => e.AreaId)
                    .HasColumnName("area_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SkipBgId).HasColumnName("skip_bg_id");

                entity.Property(e => e.SkipMotionId).HasColumnName("skip_motion_id");

                entity.Property(e => e.SkipPositionX).HasColumnName("skip_position_x");

                entity.Property(e => e.SkipPositionY).HasColumnName("skip_position_y");

                entity.Property(e => e.SkipScaleX).HasColumnName("skip_scale_x");

                entity.Property(e => e.SkipScaleY).HasColumnName("skip_scale_y");
            });

            modelBuilder.Entity<DungeonSpecialBattle>(entity =>
            {
                entity.HasKey(e => e.SpecialBattleId);

                entity.ToTable("dungeon_special_battle");

                entity.HasIndex(e => e.QuestId)
                    .HasName("dungeon_special_battle_0_quest_id");

                entity.HasIndex(e => new { e.QuestId, e.Mode })
                    .HasName("dungeon_special_battle_0_quest_id_1_mode")
                    .IsUnique();

                entity.Property(e => e.SpecialBattleId)
                    .HasColumnName("special_battle_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionStartSecond).HasColumnName("action_start_second");

                entity.Property(e => e.AppearTime).HasColumnName("appear_time");

                entity.Property(e => e.DetailBossBgHeight).HasColumnName("detail_boss_bg_height");

                entity.Property(e => e.DetailBossBgSize).HasColumnName("detail_boss_bg_size");

                entity.Property(e => e.DetailBossMotion)
                    .IsRequired()
                    .HasColumnName("detail_boss_motion");

                entity.Property(e => e.HpGaugeColorFlag).HasColumnName("hp_gauge_color_flag");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.PartsHpSaveFlag).HasColumnName("parts_hp_save_flag");

                entity.Property(e => e.PurposeType).HasColumnName("purpose_type");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");

                entity.Property(e => e.StartIdleTrigger).HasColumnName("start_idle_trigger");

                entity.Property(e => e.TriggerHp).HasColumnName("trigger_hp");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<DungeonSpecialEnemySetting>(entity =>
            {
                entity.ToTable("dungeon_special_enemy_setting");

                entity.HasIndex(e => e.SpecialBattleId)
                    .HasName("dungeon_special_enemy_setting_0_special_battle_id");

                entity.HasIndex(e => new { e.SpecialBattleId, e.DispOrder })
                    .IsUnique();

                entity.HasIndex(e => new { e.SpecialBattleId, e.EnemyIdentify })
                    .HasName("dungeon_special_enemy_setting_0_special_battle_id_1_enemy_identify")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetailOffsetX).HasColumnName("detail_offset_x");

                entity.Property(e => e.DetailOffsetY).HasColumnName("detail_offset_y");

                entity.Property(e => e.DetailScale).HasColumnName("detail_scale");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EnemyIdentify).HasColumnName("enemy_identify");

                entity.Property(e => e.MustKillFlag).HasColumnName("must_kill_flag");

                entity.Property(e => e.SpecialBattleId).HasColumnName("special_battle_id");
            });

            modelBuilder.Entity<EReduction>(entity =>
            {
                entity.ToTable("e_reduction");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Border).HasColumnName("border");

                entity.Property(e => e.Threshold1).HasColumnName("threshold_1");

                entity.Property(e => e.Threshold2).HasColumnName("threshold_2");

                entity.Property(e => e.Threshold3).HasColumnName("threshold_3");

                entity.Property(e => e.Threshold4).HasColumnName("threshold_4");

                entity.Property(e => e.Threshold5).HasColumnName("threshold_5");

                entity.Property(e => e.Value1).HasColumnName("value_1");

                entity.Property(e => e.Value2).HasColumnName("value_2");

                entity.Property(e => e.Value3).HasColumnName("value_3");

                entity.Property(e => e.Value4).HasColumnName("value_4");

                entity.Property(e => e.Value5).HasColumnName("value_5");
            });

            modelBuilder.Entity<EmblemData>(entity =>
            {
                entity.HasKey(e => e.EmblemId);

                entity.ToTable("emblem_data");

                entity.Property(e => e.EmblemId)
                    .HasColumnName("emblem_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DescriptionMissionId).HasColumnName("description_mission_id");

                entity.Property(e => e.DispOder).HasColumnName("disp_oder");

                entity.Property(e => e.EmblemName)
                    .IsRequired()
                    .HasColumnName("emblem_name");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventEmblem).HasColumnName("event_emblem");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<EmblemMissionData>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("emblem_mission_data");

                entity.Property(e => e.MissionId)
                    .HasColumnName("mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<EmblemMissionRewardData>(entity =>
            {
                entity.ToTable("emblem_mission_reward_data");

                entity.HasIndex(e => e.MissionRewardId)
                    .HasName("emblem_mission_reward_data_0_mission_reward_id");

                entity.HasIndex(e => e.RewardId)
                    .HasName("emblem_mission_reward_data_0_reward_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IconType).HasColumnName("icon_type");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<EnemyEnableVoice>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("enemy_enable_voice");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");
            });

            modelBuilder.Entity<EnemyIgnoreSkillRf>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("enemy_ignore_skill_rf");

                entity.Property(e => e.EnemyId)
                    .HasColumnName("enemy_id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<EnemyMParts>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("enemy_m_parts");

                entity.Property(e => e.EnemyId)
                    .HasColumnName("enemy_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChildEnemyParameter1).HasColumnName("child_enemy_parameter_1");

                entity.Property(e => e.ChildEnemyParameter2).HasColumnName("child_enemy_parameter_2");

                entity.Property(e => e.ChildEnemyParameter3).HasColumnName("child_enemy_parameter_3");

                entity.Property(e => e.ChildEnemyParameter4).HasColumnName("child_enemy_parameter_4");

                entity.Property(e => e.ChildEnemyParameter5).HasColumnName("child_enemy_parameter_5");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<EnemyParameter>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("enemy_parameter");

                entity.Property(e => e.EnemyId)
                    .HasColumnName("enemy_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.BreakDurability).HasColumnName("break_durability");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.ExSkillLv1).HasColumnName("ex_skill_lv_1");

                entity.Property(e => e.ExSkillLv2).HasColumnName("ex_skill_lv_2");

                entity.Property(e => e.ExSkillLv3).HasColumnName("ex_skill_lv_3");

                entity.Property(e => e.ExSkillLv4).HasColumnName("ex_skill_lv_4");

                entity.Property(e => e.ExSkillLv5).HasColumnName("ex_skill_lv_5");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ResistStatusId).HasColumnName("resist_status_id");

                entity.Property(e => e.ResistVariationId).HasColumnName("resist_variation_id");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");

                entity.Property(e => e.UniqueEquipmentFlag1).HasColumnName("unique_equipment_flag_1");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.VirtualHp).HasColumnName("virtual_hp");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<EnemyRewardData>(entity =>
            {
                entity.HasKey(e => e.DropRewardId);

                entity.ToTable("enemy_reward_data");

                entity.Property(e => e.DropRewardId)
                    .HasColumnName("drop_reward_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DropCount).HasColumnName("drop_count");

                entity.Property(e => e.Odds1).HasColumnName("odds_1");

                entity.Property(e => e.Odds2).HasColumnName("odds_2");

                entity.Property(e => e.Odds3).HasColumnName("odds_3");

                entity.Property(e => e.Odds4).HasColumnName("odds_4");

                entity.Property(e => e.Odds5).HasColumnName("odds_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<EquipmentCraft>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("equipment_craft");

                entity.Property(e => e.EquipmentId)
                    .HasColumnName("equipment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionEquipmentId1).HasColumnName("condition_equipment_id_1");

                entity.Property(e => e.ConditionEquipmentId10).HasColumnName("condition_equipment_id_10");

                entity.Property(e => e.ConditionEquipmentId2).HasColumnName("condition_equipment_id_2");

                entity.Property(e => e.ConditionEquipmentId3).HasColumnName("condition_equipment_id_3");

                entity.Property(e => e.ConditionEquipmentId4).HasColumnName("condition_equipment_id_4");

                entity.Property(e => e.ConditionEquipmentId5).HasColumnName("condition_equipment_id_5");

                entity.Property(e => e.ConditionEquipmentId6).HasColumnName("condition_equipment_id_6");

                entity.Property(e => e.ConditionEquipmentId7).HasColumnName("condition_equipment_id_7");

                entity.Property(e => e.ConditionEquipmentId8).HasColumnName("condition_equipment_id_8");

                entity.Property(e => e.ConditionEquipmentId9).HasColumnName("condition_equipment_id_9");

                entity.Property(e => e.ConsumeNum1).HasColumnName("consume_num_1");

                entity.Property(e => e.ConsumeNum10).HasColumnName("consume_num_10");

                entity.Property(e => e.ConsumeNum2).HasColumnName("consume_num_2");

                entity.Property(e => e.ConsumeNum3).HasColumnName("consume_num_3");

                entity.Property(e => e.ConsumeNum4).HasColumnName("consume_num_4");

                entity.Property(e => e.ConsumeNum5).HasColumnName("consume_num_5");

                entity.Property(e => e.ConsumeNum6).HasColumnName("consume_num_6");

                entity.Property(e => e.ConsumeNum7).HasColumnName("consume_num_7");

                entity.Property(e => e.ConsumeNum8).HasColumnName("consume_num_8");

                entity.Property(e => e.ConsumeNum9).HasColumnName("consume_num_9");

                entity.Property(e => e.CraftedCost).HasColumnName("crafted_cost");
            });

            modelBuilder.Entity<EquipmentData>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("equipment_data");

                entity.Property(e => e.EquipmentId)
                    .HasColumnName("equipment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.CraftFlg).HasColumnName("craft_flg");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DisplayItem).HasColumnName("display_item");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnableDonation).HasColumnName("enable_donation");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EquipmentEnhancePoint).HasColumnName("equipment_enhance_point");

                entity.Property(e => e.EquipmentName)
                    .IsRequired()
                    .HasColumnName("equipment_name");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.RequireLevel).HasColumnName("require_level");

                entity.Property(e => e.SalePrice).HasColumnName("sale_price");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<EquipmentDonation>(entity =>
            {
                entity.HasKey(e => e.TeamLevel);

                entity.ToTable("equipment_donation");

                entity.Property(e => e.TeamLevel)
                    .HasColumnName("team_level")
                    .ValueGeneratedNever();

                entity.Property(e => e.DonationNumDaily).HasColumnName("donation_num_daily");

                entity.Property(e => e.DonationNumOnce).HasColumnName("donation_num_once");

                entity.Property(e => e.RequestNumOnce).HasColumnName("request_num_once");
            });

            modelBuilder.Entity<EquipmentEnhanceData>(entity =>
            {
                entity.HasKey(e => new { e.PromotionLevel, e.EquipmentEnhanceLevel });

                entity.ToTable("equipment_enhance_data");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.EquipmentEnhanceLevel).HasColumnName("equipment_enhance_level");

                entity.Property(e => e.NeededPoint).HasColumnName("needed_point");

                entity.Property(e => e.TotalPoint).HasColumnName("total_point");
            });

            modelBuilder.Entity<EquipmentEnhanceRate>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("equipment_enhance_rate");

                entity.Property(e => e.EquipmentId)
                    .HasColumnName("equipment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EquipmentName)
                    .IsRequired()
                    .HasColumnName("equipment_name");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<EventBgData>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("event_bg_data");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<EventBossTreasureBox>(entity =>
            {
                entity.ToTable("event_boss_treasure_box");

                entity.Property(e => e.EventBossTreasureBoxId)
                    .HasColumnName("event_boss_treasure_box_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EachOdds1).HasColumnName("each_odds_1");

                entity.Property(e => e.EachOdds10).HasColumnName("each_odds_10");

                entity.Property(e => e.EachOdds2).HasColumnName("each_odds_2");

                entity.Property(e => e.EachOdds3).HasColumnName("each_odds_3");

                entity.Property(e => e.EachOdds4).HasColumnName("each_odds_4");

                entity.Property(e => e.EachOdds5).HasColumnName("each_odds_5");

                entity.Property(e => e.EachOdds6).HasColumnName("each_odds_6");

                entity.Property(e => e.EachOdds7).HasColumnName("each_odds_7");

                entity.Property(e => e.EachOdds8).HasColumnName("each_odds_8");

                entity.Property(e => e.EachOdds9).HasColumnName("each_odds_9");

                entity.Property(e => e.EventBossTreasureContentId1).HasColumnName("event_boss_treasure_content_id_1");

                entity.Property(e => e.EventBossTreasureContentId10).HasColumnName("event_boss_treasure_content_id_10");

                entity.Property(e => e.EventBossTreasureContentId2).HasColumnName("event_boss_treasure_content_id_2");

                entity.Property(e => e.EventBossTreasureContentId3).HasColumnName("event_boss_treasure_content_id_3");

                entity.Property(e => e.EventBossTreasureContentId4).HasColumnName("event_boss_treasure_content_id_4");

                entity.Property(e => e.EventBossTreasureContentId5).HasColumnName("event_boss_treasure_content_id_5");

                entity.Property(e => e.EventBossTreasureContentId6).HasColumnName("event_boss_treasure_content_id_6");

                entity.Property(e => e.EventBossTreasureContentId7).HasColumnName("event_boss_treasure_content_id_7");

                entity.Property(e => e.EventBossTreasureContentId8).HasColumnName("event_boss_treasure_content_id_8");

                entity.Property(e => e.EventBossTreasureContentId9).HasColumnName("event_boss_treasure_content_id_9");

                entity.Property(e => e.TreasureType1).HasColumnName("treasure_type_1");

                entity.Property(e => e.TreasureType10).HasColumnName("treasure_type_10");

                entity.Property(e => e.TreasureType2).HasColumnName("treasure_type_2");

                entity.Property(e => e.TreasureType3).HasColumnName("treasure_type_3");

                entity.Property(e => e.TreasureType4).HasColumnName("treasure_type_4");

                entity.Property(e => e.TreasureType5).HasColumnName("treasure_type_5");

                entity.Property(e => e.TreasureType6).HasColumnName("treasure_type_6");

                entity.Property(e => e.TreasureType7).HasColumnName("treasure_type_7");

                entity.Property(e => e.TreasureType8).HasColumnName("treasure_type_8");

                entity.Property(e => e.TreasureType9).HasColumnName("treasure_type_9");
            });

            modelBuilder.Entity<EventBossTreasureContent>(entity =>
            {
                entity.ToTable("event_boss_treasure_content");

                entity.Property(e => e.EventBossTreasureContentId)
                    .HasColumnName("event_boss_treasure_content_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Odds1).HasColumnName("odds_1");

                entity.Property(e => e.Odds2).HasColumnName("odds_2");

                entity.Property(e => e.Odds3).HasColumnName("odds_3");

                entity.Property(e => e.Odds4).HasColumnName("odds_4");

                entity.Property(e => e.Odds5).HasColumnName("odds_5");

                entity.Property(e => e.OddsFile1)
                    .IsRequired()
                    .HasColumnName("odds_file_1");

                entity.Property(e => e.OddsFile2)
                    .IsRequired()
                    .HasColumnName("odds_file_2");

                entity.Property(e => e.OddsFile3)
                    .IsRequired()
                    .HasColumnName("odds_file_3");

                entity.Property(e => e.OddsFile4)
                    .IsRequired()
                    .HasColumnName("odds_file_4");

                entity.Property(e => e.OddsFile5)
                    .IsRequired()
                    .HasColumnName("odds_file_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<EventEffectSetting>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.Type });

                entity.ToTable("event_effect_setting");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<EventEnemyParameter>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("event_enemy_parameter");

                entity.Property(e => e.EnemyId)
                    .HasColumnName("enemy_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.ExSkillLv1).HasColumnName("ex_skill_lv_1");

                entity.Property(e => e.ExSkillLv2).HasColumnName("ex_skill_lv_2");

                entity.Property(e => e.ExSkillLv3).HasColumnName("ex_skill_lv_3");

                entity.Property(e => e.ExSkillLv4).HasColumnName("ex_skill_lv_4");

                entity.Property(e => e.ExSkillLv5).HasColumnName("ex_skill_lv_5");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ResistStatusId).HasColumnName("resist_status_id");

                entity.Property(e => e.ResistVariationId).HasColumnName("resist_variation_id");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<EventEnemyRewardGroup>(entity =>
            {
                entity.ToTable("event_enemy_reward_group");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Odds).HasColumnName("odds");

                entity.Property(e => e.RewardGroupId).HasColumnName("reward_group_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<EventGachaData>(entity =>
            {
                entity.HasKey(e => e.GachaId);

                entity.ToTable("event_gacha_data");

                entity.HasIndex(e => e.EventId)
                    .HasName("event_gacha_data_0_event_id");

                entity.Property(e => e.GachaId)
                    .HasColumnName("gacha_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.GachaName)
                    .IsRequired()
                    .HasColumnName("gacha_name");

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.RepeatStep).HasColumnName("repeat_step");
            });

            modelBuilder.Entity<EventIntroduction>(entity =>
            {
                entity.ToTable("event_introduction");

                entity.HasIndex(e => e.EventId)
                    .HasName("event_introduction_0_event_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IntroductionNumber).HasColumnName("introduction_number");

                entity.Property(e => e.MaximumChunkSize1).HasColumnName("maximum_chunk_size_1");

                entity.Property(e => e.MaximumChunkSize2).HasColumnName("maximum_chunk_size_2");

                entity.Property(e => e.MaximumChunkSize3).HasColumnName("maximum_chunk_size_3");

                entity.Property(e => e.MaximumChunkSizeLoop1).HasColumnName("maximum_chunk_size_loop_1");

                entity.Property(e => e.MaximumChunkSizeLoop2).HasColumnName("maximum_chunk_size_loop_2");

                entity.Property(e => e.MaximumChunkSizeLoop3).HasColumnName("maximum_chunk_size_loop_3");

                entity.Property(e => e.QueId)
                    .IsRequired()
                    .HasColumnName("que_id");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<EventNaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("event_navi_comment");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeFaceTime).HasColumnName("change_face_time");

                entity.Property(e => e.ChangeFaceType).HasColumnName("change_face_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasColumnName("character_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<EventNaviCommentCondition>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("event_navi_comment_condition");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionType1).HasColumnName("condition_type_1");

                entity.Property(e => e.ConditionType2).HasColumnName("condition_type_2");

                entity.Property(e => e.ConditionType3).HasColumnName("condition_type_3");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");
            });

            modelBuilder.Entity<EventReminder>(entity =>
            {
                entity.HasKey(e => e.ReminderId);

                entity.ToTable("event_reminder");

                entity.HasIndex(e => e.EventId)
                    .HasName("event_reminder_0_event_id");

                entity.Property(e => e.ReminderId)
                    .HasColumnName("reminder_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BtnText)
                    .IsRequired()
                    .HasColumnName("btn_text");

                entity.Property(e => e.DescriptionText)
                    .IsRequired()
                    .HasColumnName("description_text");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.NoticeText)
                    .IsRequired()
                    .HasColumnName("notice_text");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.TargetId).HasColumnName("target_id");

                entity.Property(e => e.TargetType).HasColumnName("target_type");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.TitleText)
                    .IsRequired()
                    .HasColumnName("title_text");
            });

            modelBuilder.Entity<EventReminderCondition>(entity =>
            {
                entity.ToTable("event_reminder_condition");

                entity.HasIndex(e => e.ReminderId)
                    .HasName("event_reminder_condition_0_reminder_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.ReminderId).HasColumnName("reminder_id");
            });

            modelBuilder.Entity<EventRevivalSeriesWaveGroupData>(entity =>
            {
                entity.ToTable("event_revival_series_wave_group_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispRewardId1).HasColumnName("disp_reward_id_1");

                entity.Property(e => e.DispRewardId2).HasColumnName("disp_reward_id_2");

                entity.Property(e => e.DispRewardId3).HasColumnName("disp_reward_id_3");

                entity.Property(e => e.DispRewardId4).HasColumnName("disp_reward_id_4");

                entity.Property(e => e.DispRewardId5).HasColumnName("disp_reward_id_5");

                entity.Property(e => e.DispRewardType1).HasColumnName("disp_reward_type_1");

                entity.Property(e => e.DispRewardType2).HasColumnName("disp_reward_type_2");

                entity.Property(e => e.DispRewardType3).HasColumnName("disp_reward_type_3");

                entity.Property(e => e.DispRewardType4).HasColumnName("disp_reward_type_4");

                entity.Property(e => e.DispRewardType5).HasColumnName("disp_reward_type_5");

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.MatchLvMax).HasColumnName("match_lv_max");

                entity.Property(e => e.MatchLvMin).HasColumnName("match_lv_min");

                entity.Property(e => e.RewardGroupId1).HasColumnName("reward_group_id_1");

                entity.Property(e => e.RewardGroupId2).HasColumnName("reward_group_id_2");

                entity.Property(e => e.RewardGroupId3).HasColumnName("reward_group_id_3");

                entity.Property(e => e.RewardGroupId4).HasColumnName("reward_group_id_4");

                entity.Property(e => e.RewardGroupId5).HasColumnName("reward_group_id_5");

                entity.Property(e => e.RewardLotCount1).HasColumnName("reward_lot_count_1");

                entity.Property(e => e.RewardLotCount2).HasColumnName("reward_lot_count_2");

                entity.Property(e => e.RewardLotCount3).HasColumnName("reward_lot_count_3");

                entity.Property(e => e.RewardLotCount4).HasColumnName("reward_lot_count_4");

                entity.Property(e => e.RewardLotCount5).HasColumnName("reward_lot_count_5");

                entity.Property(e => e.RewardOdds1).HasColumnName("reward_odds_1");

                entity.Property(e => e.RewardOdds2).HasColumnName("reward_odds_2");

                entity.Property(e => e.RewardOdds3).HasColumnName("reward_odds_3");

                entity.Property(e => e.RewardOdds4).HasColumnName("reward_odds_4");

                entity.Property(e => e.RewardOdds5).HasColumnName("reward_odds_5");

                entity.Property(e => e.Wave).HasColumnName("wave");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<EventRevivalWaveGroupData>(entity =>
            {
                entity.ToTable("event_revival_wave_group_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispRewardId1).HasColumnName("disp_reward_id_1");

                entity.Property(e => e.DispRewardId2).HasColumnName("disp_reward_id_2");

                entity.Property(e => e.DispRewardId3).HasColumnName("disp_reward_id_3");

                entity.Property(e => e.DispRewardId4).HasColumnName("disp_reward_id_4");

                entity.Property(e => e.DispRewardId5).HasColumnName("disp_reward_id_5");

                entity.Property(e => e.DispRewardType1).HasColumnName("disp_reward_type_1");

                entity.Property(e => e.DispRewardType2).HasColumnName("disp_reward_type_2");

                entity.Property(e => e.DispRewardType3).HasColumnName("disp_reward_type_3");

                entity.Property(e => e.DispRewardType4).HasColumnName("disp_reward_type_4");

                entity.Property(e => e.DispRewardType5).HasColumnName("disp_reward_type_5");

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.MatchLvMax).HasColumnName("match_lv_max");

                entity.Property(e => e.MatchLvMin).HasColumnName("match_lv_min");

                entity.Property(e => e.RewardGroupId1).HasColumnName("reward_group_id_1");

                entity.Property(e => e.RewardGroupId2).HasColumnName("reward_group_id_2");

                entity.Property(e => e.RewardGroupId3).HasColumnName("reward_group_id_3");

                entity.Property(e => e.RewardGroupId4).HasColumnName("reward_group_id_4");

                entity.Property(e => e.RewardGroupId5).HasColumnName("reward_group_id_5");

                entity.Property(e => e.RewardLotCount1).HasColumnName("reward_lot_count_1");

                entity.Property(e => e.RewardLotCount2).HasColumnName("reward_lot_count_2");

                entity.Property(e => e.RewardLotCount3).HasColumnName("reward_lot_count_3");

                entity.Property(e => e.RewardLotCount4).HasColumnName("reward_lot_count_4");

                entity.Property(e => e.RewardLotCount5).HasColumnName("reward_lot_count_5");

                entity.Property(e => e.RewardOdds1).HasColumnName("reward_odds_1");

                entity.Property(e => e.RewardOdds2).HasColumnName("reward_odds_2");

                entity.Property(e => e.RewardOdds3).HasColumnName("reward_odds_3");

                entity.Property(e => e.RewardOdds4).HasColumnName("reward_odds_4");

                entity.Property(e => e.RewardOdds5).HasColumnName("reward_odds_5");

                entity.Property(e => e.Wave).HasColumnName("wave");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<EventSeriesWaveGroupData>(entity =>
            {
                entity.ToTable("event_series_wave_group_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispRewardId1).HasColumnName("disp_reward_id_1");

                entity.Property(e => e.DispRewardId2).HasColumnName("disp_reward_id_2");

                entity.Property(e => e.DispRewardId3).HasColumnName("disp_reward_id_3");

                entity.Property(e => e.DispRewardId4).HasColumnName("disp_reward_id_4");

                entity.Property(e => e.DispRewardId5).HasColumnName("disp_reward_id_5");

                entity.Property(e => e.DispRewardType1).HasColumnName("disp_reward_type_1");

                entity.Property(e => e.DispRewardType2).HasColumnName("disp_reward_type_2");

                entity.Property(e => e.DispRewardType3).HasColumnName("disp_reward_type_3");

                entity.Property(e => e.DispRewardType4).HasColumnName("disp_reward_type_4");

                entity.Property(e => e.DispRewardType5).HasColumnName("disp_reward_type_5");

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.MatchLvMax).HasColumnName("match_lv_max");

                entity.Property(e => e.MatchLvMin).HasColumnName("match_lv_min");

                entity.Property(e => e.RewardGroupId1).HasColumnName("reward_group_id_1");

                entity.Property(e => e.RewardGroupId2).HasColumnName("reward_group_id_2");

                entity.Property(e => e.RewardGroupId3).HasColumnName("reward_group_id_3");

                entity.Property(e => e.RewardGroupId4).HasColumnName("reward_group_id_4");

                entity.Property(e => e.RewardGroupId5).HasColumnName("reward_group_id_5");

                entity.Property(e => e.RewardLotCount1).HasColumnName("reward_lot_count_1");

                entity.Property(e => e.RewardLotCount2).HasColumnName("reward_lot_count_2");

                entity.Property(e => e.RewardLotCount3).HasColumnName("reward_lot_count_3");

                entity.Property(e => e.RewardLotCount4).HasColumnName("reward_lot_count_4");

                entity.Property(e => e.RewardLotCount5).HasColumnName("reward_lot_count_5");

                entity.Property(e => e.RewardOdds1).HasColumnName("reward_odds_1");

                entity.Property(e => e.RewardOdds2).HasColumnName("reward_odds_2");

                entity.Property(e => e.RewardOdds3).HasColumnName("reward_odds_3");

                entity.Property(e => e.RewardOdds4).HasColumnName("reward_odds_4");

                entity.Property(e => e.RewardOdds5).HasColumnName("reward_odds_5");

                entity.Property(e => e.Wave).HasColumnName("wave");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<EventStoryData>(entity =>
            {
                entity.HasKey(e => e.StoryGroupId);

                entity.ToTable("event_story_data");

                entity.HasIndex(e => e.Value)
                    .HasName("event_story_data_0_value");

                entity.Property(e => e.StoryGroupId)
                    .HasColumnName("story_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryType).HasColumnName("story_type");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<EventStoryDetail>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("event_story_detail");

                entity.HasIndex(e => e.StoryGroupId)
                    .HasName("event_story_detail_0_story_group_id");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardValue1).HasColumnName("reward_value_1");

                entity.Property(e => e.RewardValue2).HasColumnName("reward_value_2");

                entity.Property(e => e.RewardValue3).HasColumnName("reward_value_3");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryEnd).HasColumnName("story_end");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryQuestId).HasColumnName("story_quest_id");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.UnlockQuestId).HasColumnName("unlock_quest_id");

                entity.Property(e => e.VisibleType).HasColumnName("visible_type");
            });

            modelBuilder.Entity<EventTopAdv>(entity =>
            {
                entity.ToTable("event_top_adv");

                entity.HasIndex(e => new { e.EventId, e.Type })
                    .HasName("event_top_adv_0_event_id_1_type");

                entity.Property(e => e.EventTopAdvId)
                    .HasColumnName("event_top_adv_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value1).HasColumnName("value_1");

                entity.Property(e => e.Value2).HasColumnName("value_2");

                entity.Property(e => e.Value3).HasColumnName("value_3");
            });

            modelBuilder.Entity<EventWaveGroupData>(entity =>
            {
                entity.ToTable("event_wave_group_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispRewardId1).HasColumnName("disp_reward_id_1");

                entity.Property(e => e.DispRewardId2).HasColumnName("disp_reward_id_2");

                entity.Property(e => e.DispRewardId3).HasColumnName("disp_reward_id_3");

                entity.Property(e => e.DispRewardId4).HasColumnName("disp_reward_id_4");

                entity.Property(e => e.DispRewardId5).HasColumnName("disp_reward_id_5");

                entity.Property(e => e.DispRewardType1).HasColumnName("disp_reward_type_1");

                entity.Property(e => e.DispRewardType2).HasColumnName("disp_reward_type_2");

                entity.Property(e => e.DispRewardType3).HasColumnName("disp_reward_type_3");

                entity.Property(e => e.DispRewardType4).HasColumnName("disp_reward_type_4");

                entity.Property(e => e.DispRewardType5).HasColumnName("disp_reward_type_5");

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.MatchLvMax).HasColumnName("match_lv_max");

                entity.Property(e => e.MatchLvMin).HasColumnName("match_lv_min");

                entity.Property(e => e.RewardGroupId1).HasColumnName("reward_group_id_1");

                entity.Property(e => e.RewardGroupId2).HasColumnName("reward_group_id_2");

                entity.Property(e => e.RewardGroupId3).HasColumnName("reward_group_id_3");

                entity.Property(e => e.RewardGroupId4).HasColumnName("reward_group_id_4");

                entity.Property(e => e.RewardGroupId5).HasColumnName("reward_group_id_5");

                entity.Property(e => e.RewardLotCount1).HasColumnName("reward_lot_count_1");

                entity.Property(e => e.RewardLotCount2).HasColumnName("reward_lot_count_2");

                entity.Property(e => e.RewardLotCount3).HasColumnName("reward_lot_count_3");

                entity.Property(e => e.RewardLotCount4).HasColumnName("reward_lot_count_4");

                entity.Property(e => e.RewardLotCount5).HasColumnName("reward_lot_count_5");

                entity.Property(e => e.RewardOdds1).HasColumnName("reward_odds_1");

                entity.Property(e => e.RewardOdds2).HasColumnName("reward_odds_2");

                entity.Property(e => e.RewardOdds3).HasColumnName("reward_odds_3");

                entity.Property(e => e.RewardOdds4).HasColumnName("reward_odds_4");

                entity.Property(e => e.RewardOdds5).HasColumnName("reward_odds_5");

                entity.Property(e => e.Wave).HasColumnName("wave");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<ExEquipmentCategory>(entity =>
            {
                entity.HasKey(e => e.Category);

                entity.ToTable("ex_equipment_category");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryBase)
                    .IsRequired()
                    .HasColumnName("category_base");

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name");

                entity.Property(e => e.Outline)
                    .IsRequired()
                    .HasColumnName("outline");

                entity.Property(e => e.RecycleItemId).HasColumnName("recycle_item_id");
            });

            modelBuilder.Entity<ExEquipmentData>(entity =>
            {
                entity.HasKey(e => e.ExEquipmentId);

                entity.ToTable("ex_equipment_data");

                entity.Property(e => e.ExEquipmentId)
                    .HasColumnName("ex_equipment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.ClanBattleEquipFlag).HasColumnName("clan_battle_equip_flag");

                entity.Property(e => e.DefaultAccuracy).HasColumnName("default_accuracy");

                entity.Property(e => e.DefaultAtk).HasColumnName("default_atk");

                entity.Property(e => e.DefaultDef).HasColumnName("default_def");

                entity.Property(e => e.DefaultDodge).HasColumnName("default_dodge");

                entity.Property(e => e.DefaultEnergyRecoveryRate).HasColumnName("default_energy_recovery_rate");

                entity.Property(e => e.DefaultEnergyReduceRate).HasColumnName("default_energy_reduce_rate");

                entity.Property(e => e.DefaultHp).HasColumnName("default_hp");

                entity.Property(e => e.DefaultHpRecoveryRate).HasColumnName("default_hp_recovery_rate");

                entity.Property(e => e.DefaultLifeSteal).HasColumnName("default_life_steal");

                entity.Property(e => e.DefaultMagicCritical).HasColumnName("default_magic_critical");

                entity.Property(e => e.DefaultMagicDef).HasColumnName("default_magic_def");

                entity.Property(e => e.DefaultMagicPenetrate).HasColumnName("default_magic_penetrate");

                entity.Property(e => e.DefaultMagicStr).HasColumnName("default_magic_str");

                entity.Property(e => e.DefaultPhysicalCritical).HasColumnName("default_physical_critical");

                entity.Property(e => e.DefaultPhysicalPenetrate).HasColumnName("default_physical_penetrate");

                entity.Property(e => e.DefaultWaveEnergyRecovery).HasColumnName("default_wave_energy_recovery");

                entity.Property(e => e.DefaultWaveHpRecovery).HasColumnName("default_wave_hp_recovery");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.MaxAccuracy).HasColumnName("max_accuracy");

                entity.Property(e => e.MaxAtk).HasColumnName("max_atk");

                entity.Property(e => e.MaxDef).HasColumnName("max_def");

                entity.Property(e => e.MaxDodge).HasColumnName("max_dodge");

                entity.Property(e => e.MaxEnergyRecoveryRate).HasColumnName("max_energy_recovery_rate");

                entity.Property(e => e.MaxEnergyReduceRate).HasColumnName("max_energy_reduce_rate");

                entity.Property(e => e.MaxHp).HasColumnName("max_hp");

                entity.Property(e => e.MaxHpRecoveryRate).HasColumnName("max_hp_recovery_rate");

                entity.Property(e => e.MaxLifeSteal).HasColumnName("max_life_steal");

                entity.Property(e => e.MaxMagicCritical).HasColumnName("max_magic_critical");

                entity.Property(e => e.MaxMagicDef).HasColumnName("max_magic_def");

                entity.Property(e => e.MaxMagicPenetrate).HasColumnName("max_magic_penetrate");

                entity.Property(e => e.MaxMagicStr).HasColumnName("max_magic_str");

                entity.Property(e => e.MaxPhysicalCritical).HasColumnName("max_physical_critical");

                entity.Property(e => e.MaxPhysicalPenetrate).HasColumnName("max_physical_penetrate");

                entity.Property(e => e.MaxWaveEnergyRecovery).HasColumnName("max_wave_energy_recovery");

                entity.Property(e => e.MaxWaveHpRecovery).HasColumnName("max_wave_hp_recovery");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.PassiveSkillId1).HasColumnName("passive_skill_id_1");

                entity.Property(e => e.PassiveSkillId2).HasColumnName("passive_skill_id_2");

                entity.Property(e => e.PassiveSkillPower).HasColumnName("passive_skill_power");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.RestrictionId).HasColumnName("restriction_id");
            });

            modelBuilder.Entity<ExEquipmentEnhanceData>(entity =>
            {
                entity.HasKey(e => new { e.Rarity, e.EnhanceLevel });

                entity.ToTable("ex_equipment_enhance_data");

                entity.HasIndex(e => e.Rarity)
                    .HasName("ex_equipment_enhance_data_0_rarity");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.EnhanceLevel).HasColumnName("enhance_level");

                entity.Property(e => e.NeededMana).HasColumnName("needed_mana");

                entity.Property(e => e.NeededPoint).HasColumnName("needed_point");

                entity.Property(e => e.RankupLevel).HasColumnName("rankup_level");

                entity.Property(e => e.TotalPoint).HasColumnName("total_point");
            });

            modelBuilder.Entity<ExEquipmentRankupData>(entity =>
            {
                entity.HasKey(e => new { e.Rarity, e.RankupLevel });

                entity.ToTable("ex_equipment_rankup_data");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.RankupLevel).HasColumnName("rankup_level");

                entity.Property(e => e.ConsumeGold).HasColumnName("consume_gold");

                entity.Property(e => e.ItemId).HasColumnName("item_id");
            });

            modelBuilder.Entity<ExEquipmentRecycleReward>(entity =>
            {
                entity.HasKey(e => e.Rarity);

                entity.ToTable("ex_equipment_recycle_reward");

                entity.Property(e => e.Rarity)
                    .HasColumnName("rarity")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoinCoefficient).HasColumnName("coin_coefficient");

                entity.Property(e => e.EnhancePtCoefficient).HasColumnName("enhance_pt_coefficient");
            });

            modelBuilder.Entity<ExEquipmentRestrictionUnit>(entity =>
            {
                entity.HasKey(e => new { e.RestrictionId, e.UnitId });

                entity.ToTable("ex_equipment_restriction_unit");

                entity.HasIndex(e => e.RestrictionId)
                    .HasName("ex_equipment_restriction_unit_0_restriction_id");

                entity.Property(e => e.RestrictionId).HasColumnName("restriction_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<ExceedLevelStage>(entity =>
            {
                entity.HasKey(e => e.ExceedStage);

                entity.ToTable("exceed_level_stage");

                entity.Property(e => e.ExceedStage)
                    .HasColumnName("exceed_stage")
                    .ValueGeneratedNever();

                entity.Property(e => e.GeneralExceedItemId).HasColumnName("general_exceed_item_id");

                entity.Property(e => e.IncreaseLevelLimit).HasColumnName("increase_level_limit");

                entity.Property(e => e.UnlockQuestId).HasColumnName("unlock_quest_id");

                entity.Property(e => e.UnlockTeamLevel).HasColumnName("unlock_team_level");
            });

            modelBuilder.Entity<ExceedLevelUnit>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.ExceedStage });

                entity.ToTable("exceed_level_unit");

                entity.HasIndex(e => e.UnitId)
                    .HasName("exceed_level_unit_0_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.ExceedStage).HasColumnName("exceed_stage");

                entity.Property(e => e.ConsumeNum1).HasColumnName("consume_num_1");

                entity.Property(e => e.ConsumeNum2).HasColumnName("consume_num_2");

                entity.Property(e => e.ConsumeNum3).HasColumnName("consume_num_3");

                entity.Property(e => e.ConsumeNum4).HasColumnName("consume_num_4");

                entity.Property(e => e.ConsumeNum5).HasColumnName("consume_num_5");

                entity.Property(e => e.ExceedItemId).HasColumnName("exceed_item_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemId2).HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3).HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4).HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5).HasColumnName("item_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<ExceptEr>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("except_er");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<ExperienceTeam>(entity =>
            {
                entity.HasKey(e => e.TeamLevel);

                entity.ToTable("experience_team");

                entity.Property(e => e.TeamLevel)
                    .HasColumnName("team_level")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxStamina).HasColumnName("max_stamina");

                entity.Property(e => e.OverLimitStamina).HasColumnName("over_limit_stamina");

                entity.Property(e => e.RecoverStaminaCount).HasColumnName("recover_stamina_count");

                entity.Property(e => e.TotalExp).HasColumnName("total_exp");
            });

            modelBuilder.Entity<ExperienceUnit>(entity =>
            {
                entity.HasKey(e => e.UnitLevel);

                entity.ToTable("experience_unit");

                entity.Property(e => e.UnitLevel)
                    .HasColumnName("unit_level")
                    .ValueGeneratedNever();

                entity.Property(e => e.TotalExp).HasColumnName("total_exp");
            });

            modelBuilder.Entity<FixLineupGroupSet>(entity =>
            {
                entity.HasKey(e => new { e.LineupGroupSetId, e.TeamLevelFrom, e.TeamLevelTo });

                entity.ToTable("fix_lineup_group_set");

                entity.HasIndex(e => new { e.TeamLevelFrom, e.TeamLevelTo })
                    .HasName("fix_lineup_group_set_0_team_level_from_1_team_level_to");

                entity.Property(e => e.LineupGroupSetId).HasColumnName("lineup_group_set_id");

                entity.Property(e => e.TeamLevelFrom).HasColumnName("team_level_from");

                entity.Property(e => e.TeamLevelTo).HasColumnName("team_level_to");

                entity.Property(e => e.CurrencyId1).HasColumnName("currency_id_1");

                entity.Property(e => e.CurrencyId10).HasColumnName("currency_id_10");

                entity.Property(e => e.CurrencyId11).HasColumnName("currency_id_11");

                entity.Property(e => e.CurrencyId12).HasColumnName("currency_id_12");

                entity.Property(e => e.CurrencyId13).HasColumnName("currency_id_13");

                entity.Property(e => e.CurrencyId14).HasColumnName("currency_id_14");

                entity.Property(e => e.CurrencyId15).HasColumnName("currency_id_15");

                entity.Property(e => e.CurrencyId16).HasColumnName("currency_id_16");

                entity.Property(e => e.CurrencyId17).HasColumnName("currency_id_17");

                entity.Property(e => e.CurrencyId18).HasColumnName("currency_id_18");

                entity.Property(e => e.CurrencyId19).HasColumnName("currency_id_19");

                entity.Property(e => e.CurrencyId2).HasColumnName("currency_id_2");

                entity.Property(e => e.CurrencyId20).HasColumnName("currency_id_20");

                entity.Property(e => e.CurrencyId3).HasColumnName("currency_id_3");

                entity.Property(e => e.CurrencyId4).HasColumnName("currency_id_4");

                entity.Property(e => e.CurrencyId5).HasColumnName("currency_id_5");

                entity.Property(e => e.CurrencyId6).HasColumnName("currency_id_6");

                entity.Property(e => e.CurrencyId7).HasColumnName("currency_id_7");

                entity.Property(e => e.CurrencyId8).HasColumnName("currency_id_8");

                entity.Property(e => e.CurrencyId9).HasColumnName("currency_id_9");

                entity.Property(e => e.Price1).HasColumnName("price_1");

                entity.Property(e => e.Price10).HasColumnName("price_10");

                entity.Property(e => e.Price11).HasColumnName("price_11");

                entity.Property(e => e.Price12).HasColumnName("price_12");

                entity.Property(e => e.Price13).HasColumnName("price_13");

                entity.Property(e => e.Price14).HasColumnName("price_14");

                entity.Property(e => e.Price15).HasColumnName("price_15");

                entity.Property(e => e.Price16).HasColumnName("price_16");

                entity.Property(e => e.Price17).HasColumnName("price_17");

                entity.Property(e => e.Price18).HasColumnName("price_18");

                entity.Property(e => e.Price19).HasColumnName("price_19");

                entity.Property(e => e.Price2).HasColumnName("price_2");

                entity.Property(e => e.Price20).HasColumnName("price_20");

                entity.Property(e => e.Price3).HasColumnName("price_3");

                entity.Property(e => e.Price4).HasColumnName("price_4");

                entity.Property(e => e.Price5).HasColumnName("price_5");

                entity.Property(e => e.Price6).HasColumnName("price_6");

                entity.Property(e => e.Price7).HasColumnName("price_7");

                entity.Property(e => e.Price8).HasColumnName("price_8");

                entity.Property(e => e.Price9).HasColumnName("price_9");

                entity.Property(e => e.PriceType1).HasColumnName("price_type_1");

                entity.Property(e => e.PriceType10).HasColumnName("price_type_10");

                entity.Property(e => e.PriceType11).HasColumnName("price_type_11");

                entity.Property(e => e.PriceType12).HasColumnName("price_type_12");

                entity.Property(e => e.PriceType13).HasColumnName("price_type_13");

                entity.Property(e => e.PriceType14).HasColumnName("price_type_14");

                entity.Property(e => e.PriceType15).HasColumnName("price_type_15");

                entity.Property(e => e.PriceType16).HasColumnName("price_type_16");

                entity.Property(e => e.PriceType17).HasColumnName("price_type_17");

                entity.Property(e => e.PriceType18).HasColumnName("price_type_18");

                entity.Property(e => e.PriceType19).HasColumnName("price_type_19");

                entity.Property(e => e.PriceType2).HasColumnName("price_type_2");

                entity.Property(e => e.PriceType20).HasColumnName("price_type_20");

                entity.Property(e => e.PriceType3).HasColumnName("price_type_3");

                entity.Property(e => e.PriceType4).HasColumnName("price_type_4");

                entity.Property(e => e.PriceType5).HasColumnName("price_type_5");

                entity.Property(e => e.PriceType6).HasColumnName("price_type_6");

                entity.Property(e => e.PriceType7).HasColumnName("price_type_7");

                entity.Property(e => e.PriceType8).HasColumnName("price_type_8");

                entity.Property(e => e.PriceType9).HasColumnName("price_type_9");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount10).HasColumnName("reward_count_10");

                entity.Property(e => e.RewardCount11).HasColumnName("reward_count_11");

                entity.Property(e => e.RewardCount12).HasColumnName("reward_count_12");

                entity.Property(e => e.RewardCount13).HasColumnName("reward_count_13");

                entity.Property(e => e.RewardCount14).HasColumnName("reward_count_14");

                entity.Property(e => e.RewardCount15).HasColumnName("reward_count_15");

                entity.Property(e => e.RewardCount16).HasColumnName("reward_count_16");

                entity.Property(e => e.RewardCount17).HasColumnName("reward_count_17");

                entity.Property(e => e.RewardCount18).HasColumnName("reward_count_18");

                entity.Property(e => e.RewardCount19).HasColumnName("reward_count_19");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount20).HasColumnName("reward_count_20");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardCount6).HasColumnName("reward_count_6");

                entity.Property(e => e.RewardCount7).HasColumnName("reward_count_7");

                entity.Property(e => e.RewardCount8).HasColumnName("reward_count_8");

                entity.Property(e => e.RewardCount9).HasColumnName("reward_count_9");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId10).HasColumnName("reward_id_10");

                entity.Property(e => e.RewardId11).HasColumnName("reward_id_11");

                entity.Property(e => e.RewardId12).HasColumnName("reward_id_12");

                entity.Property(e => e.RewardId13).HasColumnName("reward_id_13");

                entity.Property(e => e.RewardId14).HasColumnName("reward_id_14");

                entity.Property(e => e.RewardId15).HasColumnName("reward_id_15");

                entity.Property(e => e.RewardId16).HasColumnName("reward_id_16");

                entity.Property(e => e.RewardId17).HasColumnName("reward_id_17");

                entity.Property(e => e.RewardId18).HasColumnName("reward_id_18");

                entity.Property(e => e.RewardId19).HasColumnName("reward_id_19");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId20).HasColumnName("reward_id_20");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardId6).HasColumnName("reward_id_6");

                entity.Property(e => e.RewardId7).HasColumnName("reward_id_7");

                entity.Property(e => e.RewardId8).HasColumnName("reward_id_8");

                entity.Property(e => e.RewardId9).HasColumnName("reward_id_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType11).HasColumnName("reward_type_11");

                entity.Property(e => e.RewardType12).HasColumnName("reward_type_12");

                entity.Property(e => e.RewardType13).HasColumnName("reward_type_13");

                entity.Property(e => e.RewardType14).HasColumnName("reward_type_14");

                entity.Property(e => e.RewardType15).HasColumnName("reward_type_15");

                entity.Property(e => e.RewardType16).HasColumnName("reward_type_16");

                entity.Property(e => e.RewardType17).HasColumnName("reward_type_17");

                entity.Property(e => e.RewardType18).HasColumnName("reward_type_18");

                entity.Property(e => e.RewardType19).HasColumnName("reward_type_19");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType20).HasColumnName("reward_type_20");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");
            });

            modelBuilder.Entity<FixLineupGroupSetData>(entity =>
            {
                entity.ToTable("fix_lineup_group_set_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BoxCountFrom).HasColumnName("box_count_from");

                entity.Property(e => e.BoxCountTo).HasColumnName("box_count_to");

                entity.Property(e => e.CurrencyId1).HasColumnName("currency_id_1");

                entity.Property(e => e.CurrencyId10).HasColumnName("currency_id_10");

                entity.Property(e => e.CurrencyId11).HasColumnName("currency_id_11");

                entity.Property(e => e.CurrencyId12).HasColumnName("currency_id_12");

                entity.Property(e => e.CurrencyId13).HasColumnName("currency_id_13");

                entity.Property(e => e.CurrencyId14).HasColumnName("currency_id_14");

                entity.Property(e => e.CurrencyId15).HasColumnName("currency_id_15");

                entity.Property(e => e.CurrencyId16).HasColumnName("currency_id_16");

                entity.Property(e => e.CurrencyId17).HasColumnName("currency_id_17");

                entity.Property(e => e.CurrencyId18).HasColumnName("currency_id_18");

                entity.Property(e => e.CurrencyId19).HasColumnName("currency_id_19");

                entity.Property(e => e.CurrencyId2).HasColumnName("currency_id_2");

                entity.Property(e => e.CurrencyId20).HasColumnName("currency_id_20");

                entity.Property(e => e.CurrencyId3).HasColumnName("currency_id_3");

                entity.Property(e => e.CurrencyId4).HasColumnName("currency_id_4");

                entity.Property(e => e.CurrencyId5).HasColumnName("currency_id_5");

                entity.Property(e => e.CurrencyId6).HasColumnName("currency_id_6");

                entity.Property(e => e.CurrencyId7).HasColumnName("currency_id_7");

                entity.Property(e => e.CurrencyId8).HasColumnName("currency_id_8");

                entity.Property(e => e.CurrencyId9).HasColumnName("currency_id_9");

                entity.Property(e => e.LineupGroupSetId).HasColumnName("lineup_group_set_id");

                entity.Property(e => e.Price1).HasColumnName("price_1");

                entity.Property(e => e.Price10).HasColumnName("price_10");

                entity.Property(e => e.Price11).HasColumnName("price_11");

                entity.Property(e => e.Price12).HasColumnName("price_12");

                entity.Property(e => e.Price13).HasColumnName("price_13");

                entity.Property(e => e.Price14).HasColumnName("price_14");

                entity.Property(e => e.Price15).HasColumnName("price_15");

                entity.Property(e => e.Price16).HasColumnName("price_16");

                entity.Property(e => e.Price17).HasColumnName("price_17");

                entity.Property(e => e.Price18).HasColumnName("price_18");

                entity.Property(e => e.Price19).HasColumnName("price_19");

                entity.Property(e => e.Price2).HasColumnName("price_2");

                entity.Property(e => e.Price20).HasColumnName("price_20");

                entity.Property(e => e.Price3).HasColumnName("price_3");

                entity.Property(e => e.Price4).HasColumnName("price_4");

                entity.Property(e => e.Price5).HasColumnName("price_5");

                entity.Property(e => e.Price6).HasColumnName("price_6");

                entity.Property(e => e.Price7).HasColumnName("price_7");

                entity.Property(e => e.Price8).HasColumnName("price_8");

                entity.Property(e => e.Price9).HasColumnName("price_9");

                entity.Property(e => e.PriceType1).HasColumnName("price_type_1");

                entity.Property(e => e.PriceType10).HasColumnName("price_type_10");

                entity.Property(e => e.PriceType11).HasColumnName("price_type_11");

                entity.Property(e => e.PriceType12).HasColumnName("price_type_12");

                entity.Property(e => e.PriceType13).HasColumnName("price_type_13");

                entity.Property(e => e.PriceType14).HasColumnName("price_type_14");

                entity.Property(e => e.PriceType15).HasColumnName("price_type_15");

                entity.Property(e => e.PriceType16).HasColumnName("price_type_16");

                entity.Property(e => e.PriceType17).HasColumnName("price_type_17");

                entity.Property(e => e.PriceType18).HasColumnName("price_type_18");

                entity.Property(e => e.PriceType19).HasColumnName("price_type_19");

                entity.Property(e => e.PriceType2).HasColumnName("price_type_2");

                entity.Property(e => e.PriceType20).HasColumnName("price_type_20");

                entity.Property(e => e.PriceType3).HasColumnName("price_type_3");

                entity.Property(e => e.PriceType4).HasColumnName("price_type_4");

                entity.Property(e => e.PriceType5).HasColumnName("price_type_5");

                entity.Property(e => e.PriceType6).HasColumnName("price_type_6");

                entity.Property(e => e.PriceType7).HasColumnName("price_type_7");

                entity.Property(e => e.PriceType8).HasColumnName("price_type_8");

                entity.Property(e => e.PriceType9).HasColumnName("price_type_9");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount10).HasColumnName("reward_count_10");

                entity.Property(e => e.RewardCount11).HasColumnName("reward_count_11");

                entity.Property(e => e.RewardCount12).HasColumnName("reward_count_12");

                entity.Property(e => e.RewardCount13).HasColumnName("reward_count_13");

                entity.Property(e => e.RewardCount14).HasColumnName("reward_count_14");

                entity.Property(e => e.RewardCount15).HasColumnName("reward_count_15");

                entity.Property(e => e.RewardCount16).HasColumnName("reward_count_16");

                entity.Property(e => e.RewardCount17).HasColumnName("reward_count_17");

                entity.Property(e => e.RewardCount18).HasColumnName("reward_count_18");

                entity.Property(e => e.RewardCount19).HasColumnName("reward_count_19");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount20).HasColumnName("reward_count_20");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardCount6).HasColumnName("reward_count_6");

                entity.Property(e => e.RewardCount7).HasColumnName("reward_count_7");

                entity.Property(e => e.RewardCount8).HasColumnName("reward_count_8");

                entity.Property(e => e.RewardCount9).HasColumnName("reward_count_9");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId10).HasColumnName("reward_id_10");

                entity.Property(e => e.RewardId11).HasColumnName("reward_id_11");

                entity.Property(e => e.RewardId12).HasColumnName("reward_id_12");

                entity.Property(e => e.RewardId13).HasColumnName("reward_id_13");

                entity.Property(e => e.RewardId14).HasColumnName("reward_id_14");

                entity.Property(e => e.RewardId15).HasColumnName("reward_id_15");

                entity.Property(e => e.RewardId16).HasColumnName("reward_id_16");

                entity.Property(e => e.RewardId17).HasColumnName("reward_id_17");

                entity.Property(e => e.RewardId18).HasColumnName("reward_id_18");

                entity.Property(e => e.RewardId19).HasColumnName("reward_id_19");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId20).HasColumnName("reward_id_20");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardId6).HasColumnName("reward_id_6");

                entity.Property(e => e.RewardId7).HasColumnName("reward_id_7");

                entity.Property(e => e.RewardId8).HasColumnName("reward_id_8");

                entity.Property(e => e.RewardId9).HasColumnName("reward_id_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType11).HasColumnName("reward_type_11");

                entity.Property(e => e.RewardType12).HasColumnName("reward_type_12");

                entity.Property(e => e.RewardType13).HasColumnName("reward_type_13");

                entity.Property(e => e.RewardType14).HasColumnName("reward_type_14");

                entity.Property(e => e.RewardType15).HasColumnName("reward_type_15");

                entity.Property(e => e.RewardType16).HasColumnName("reward_type_16");

                entity.Property(e => e.RewardType17).HasColumnName("reward_type_17");

                entity.Property(e => e.RewardType18).HasColumnName("reward_type_18");

                entity.Property(e => e.RewardType19).HasColumnName("reward_type_19");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType20).HasColumnName("reward_type_20");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");

                entity.Property(e => e.TeamLevelFrom).HasColumnName("team_level_from");

                entity.Property(e => e.TeamLevelTo).HasColumnName("team_level_to");
            });

            modelBuilder.Entity<FkeHappeningList>(entity =>
            {
                entity.HasKey(e => e.HappeningId);

                entity.ToTable("fke_happening_list");

                entity.Property(e => e.HappeningId)
                    .HasColumnName("happening_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.HappeningName)
                    .IsRequired()
                    .HasColumnName("happening_name");
            });

            modelBuilder.Entity<FkeReward>(entity =>
            {
                entity.ToTable("fke_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FkePoint).HasColumnName("fke_point");

                entity.Property(e => e.MissionDetail)
                    .IsRequired()
                    .HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<GachaData>(entity =>
            {
                entity.HasKey(e => e.GachaId);

                entity.ToTable("gacha_data");

                entity.HasIndex(e => e.ExchangeId)
                    .HasName("gacha_data_0_exchange_id");

                entity.Property(e => e.GachaId)
                    .HasColumnName("gacha_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharaOddsStar1)
                    .IsRequired()
                    .HasColumnName("chara_odds_star1");

                entity.Property(e => e.CharaOddsStar2)
                    .IsRequired()
                    .HasColumnName("chara_odds_star2");

                entity.Property(e => e.CharaOddsStar3)
                    .IsRequired()
                    .HasColumnName("chara_odds_star3");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("description_2");

                entity.Property(e => e.DescriptionSp)
                    .IsRequired()
                    .HasColumnName("description_sp");

                entity.Property(e => e.DiscountPrice).HasColumnName("discount_price");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.ExchangeId).HasColumnName("exchange_id");

                entity.Property(e => e.FreeGachaCount).HasColumnName("free_gacha_count");

                entity.Property(e => e.FreeGachaIntervalTime).HasColumnName("free_gacha_interval_time");

                entity.Property(e => e.FreeGachaType).HasColumnName("free_gacha_type");

                entity.Property(e => e.Gacha10SpecialOddsStar1)
                    .IsRequired()
                    .HasColumnName("gacha10_special_odds_star1");

                entity.Property(e => e.Gacha10SpecialOddsStar2)
                    .IsRequired()
                    .HasColumnName("gacha10_special_odds_star2");

                entity.Property(e => e.Gacha10SpecialOddsStar3)
                    .IsRequired()
                    .HasColumnName("gacha10_special_odds_star3");

                entity.Property(e => e.GachaBonusId).HasColumnName("gacha_bonus_id");

                entity.Property(e => e.GachaCostType).HasColumnName("gacha_cost_type");

                entity.Property(e => e.GachaDetail).HasColumnName("gacha_detail");

                entity.Property(e => e.GachaName)
                    .IsRequired()
                    .HasColumnName("gacha_name");

                entity.Property(e => e.GachaOdds)
                    .IsRequired()
                    .HasColumnName("gacha_odds");

                entity.Property(e => e.GachaOddsStar2)
                    .IsRequired()
                    .HasColumnName("gacha_odds_star2");

                entity.Property(e => e.GachaTimesLimit10).HasColumnName("gacha_times_limit10");

                entity.Property(e => e.GachaType).HasColumnName("gacha_type");

                entity.Property(e => e.MovieId).HasColumnName("movie_id");

                entity.Property(e => e.ParallelId).HasColumnName("parallel_id");

                entity.Property(e => e.PickUpCharaText)
                    .IsRequired()
                    .HasColumnName("pick_up_chara_text");

                entity.Property(e => e.PickupBadge).HasColumnName("pickup_badge");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PrizegachaId).HasColumnName("prizegacha_id");

                entity.Property(e => e.RarityOdds)
                    .IsRequired()
                    .HasColumnName("rarity_odds");

                entity.Property(e => e.SpecialId).HasColumnName("special_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");

                entity.Property(e => e.TicketId10).HasColumnName("ticket_id_10");
            });

            modelBuilder.Entity<GachaExchangeLineup>(entity =>
            {
                entity.ToTable("gacha_exchange_lineup");

                entity.HasIndex(e => e.ExchangeId)
                    .HasName("gacha_exchange_lineup_0_exchange_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.ExchangeId).HasColumnName("exchange_id");

                entity.Property(e => e.GachaBonusId).HasColumnName("gacha_bonus_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<GiftMessage>(entity =>
            {
                entity.ToTable("gift_message");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Discription)
                    .IsRequired()
                    .HasColumnName("discription");

                entity.Property(e => e.Type1).HasColumnName("type_1");

                entity.Property(e => e.Type2).HasColumnName("type_2");

                entity.Property(e => e.Type3).HasColumnName("type_3");

                entity.Property(e => e.Type4).HasColumnName("type_4");
            });

            modelBuilder.Entity<GlossaryDetail>(entity =>
            {
                entity.HasKey(e => e.GlossaryId);

                entity.ToTable("glossary_detail");

                entity.Property(e => e.GlossaryId)
                    .HasColumnName("glossary_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryType).HasColumnName("category_type");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.GlossaryCategoryId).HasColumnName("glossary_category_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.UnlockStoryId).HasColumnName("unlock_story_id");
            });

            modelBuilder.Entity<GoldsetData>(entity =>
            {
                entity.HasKey(e => e.BuyCount);

                entity.ToTable("goldset_data");

                entity.Property(e => e.BuyCount)
                    .HasColumnName("buy_count")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalGoldMaxRate).HasColumnName("additional_gold_max_rate");

                entity.Property(e => e.AdditionalGoldMinRate).HasColumnName("additional_gold_min_rate");

                entity.Property(e => e.GetGoldCount).HasColumnName("get_gold_count");

                entity.Property(e => e.GoldsetOdds1).HasColumnName("goldset_odds_1");

                entity.Property(e => e.GoldsetOdds2).HasColumnName("goldset_odds_2");

                entity.Property(e => e.GoldsetOdds3).HasColumnName("goldset_odds_3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.UseJewelCount).HasColumnName("use_jewel_count");
            });

            modelBuilder.Entity<GoldsetData2>(entity =>
            {
                entity.HasKey(e => e.BuyCount);

                entity.ToTable("goldset_data_2");

                entity.Property(e => e.BuyCount)
                    .HasColumnName("buy_count")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalGoldMaxRate).HasColumnName("additional_gold_max_rate");

                entity.Property(e => e.AdditionalGoldMinRate).HasColumnName("additional_gold_min_rate");

                entity.Property(e => e.GetGoldCount).HasColumnName("get_gold_count");

                entity.Property(e => e.GoldsetOdds1).HasColumnName("goldset_odds_1");

                entity.Property(e => e.GoldsetOdds2).HasColumnName("goldset_odds_2");

                entity.Property(e => e.GoldsetOdds3).HasColumnName("goldset_odds_3");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.TrainingQuestCount).HasColumnName("training_quest_count");

                entity.Property(e => e.UseJewelCount).HasColumnName("use_jewel_count");
            });

            modelBuilder.Entity<GoldsetDataTeamlevel>(entity =>
            {
                entity.HasKey(e => e.TeamLevel);

                entity.ToTable("goldset_data_teamlevel");

                entity.Property(e => e.TeamLevel)
                    .HasColumnName("team_level")
                    .ValueGeneratedNever();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InitialGetGoldCount).HasColumnName("initial_get_gold_count");
            });

            modelBuilder.Entity<GrandArenaDailyRankReward>(entity =>
            {
                entity.ToTable("grand_arena_daily_rank_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<GrandArenaDefenceReward>(entity =>
            {
                entity.ToTable("grand_arena_defence_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LimitCount).HasColumnName("limit_count");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<GrandArenaMaxRankReward>(entity =>
            {
                entity.ToTable("grand_arena_max_rank_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<GrandArenaMaxSeasonRankReward>(entity =>
            {
                entity.ToTable("grand_arena_max_season_rank_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RankFrom).HasColumnName("rank_from");

                entity.Property(e => e.RankTo).HasColumnName("rank_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<GrowthParameter>(entity =>
            {
                entity.HasKey(e => e.GrowthId);

                entity.ToTable("growth_parameter");

                entity.Property(e => e.GrowthId)
                    .HasColumnName("growth_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Equipment1).HasColumnName("equipment_1");

                entity.Property(e => e.Equipment2).HasColumnName("equipment_2");

                entity.Property(e => e.Equipment3).HasColumnName("equipment_3");

                entity.Property(e => e.Equipment4).HasColumnName("equipment_4");

                entity.Property(e => e.Equipment5).HasColumnName("equipment_5");

                entity.Property(e => e.Equipment6).HasColumnName("equipment_6");

                entity.Property(e => e.GrowthType).HasColumnName("growth_type");

                entity.Property(e => e.IsRestriction).HasColumnName("is_restriction");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.SkillLevel).HasColumnName("skill_level");

                entity.Property(e => e.UnitLevel).HasColumnName("unit_level");

                entity.Property(e => e.UnitRarity).HasColumnName("unit_rarity");
            });

            modelBuilder.Entity<GrowthParameterUnique>(entity =>
            {
                entity.HasKey(e => e.GrowthId);

                entity.ToTable("growth_parameter_unique");

                entity.Property(e => e.GrowthId)
                    .HasColumnName("growth_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UniqueEquipRank1).HasColumnName("unique_equip_rank_1");

                entity.Property(e => e.UniqueEquipRank2).HasColumnName("unique_equip_rank_2");

                entity.Property(e => e.UniqueEquipStrengthPoint1).HasColumnName("unique_equip_strength_point_1");

                entity.Property(e => e.UniqueEquipStrengthPoint2).HasColumnName("unique_equip_strength_point_2");
            });

            modelBuilder.Entity<GrowthRestrictionUnit>(entity =>
            {
                entity.ToTable("growth_restriction_unit");

                entity.HasIndex(e => e.GrowthId)
                    .HasName("growth_restriction_unit_0_growth_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GrowthId).HasColumnName("growth_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<Guild>(entity =>
            {
                entity.ToTable("guild");

                entity.Property(e => e.GuildId)
                    .HasColumnName("guild_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.GuildMaster).HasColumnName("guild_master");

                entity.Property(e => e.GuildName)
                    .IsRequired()
                    .HasColumnName("guild_name");

                entity.Property(e => e.Member1).HasColumnName("member1");

                entity.Property(e => e.Member10).HasColumnName("member10");

                entity.Property(e => e.Member11).HasColumnName("member11");

                entity.Property(e => e.Member12).HasColumnName("member12");

                entity.Property(e => e.Member13).HasColumnName("member13");

                entity.Property(e => e.Member14).HasColumnName("member14");

                entity.Property(e => e.Member15).HasColumnName("member15");

                entity.Property(e => e.Member16).HasColumnName("member16");

                entity.Property(e => e.Member17).HasColumnName("member17");

                entity.Property(e => e.Member18).HasColumnName("member18");

                entity.Property(e => e.Member19).HasColumnName("member19");

                entity.Property(e => e.Member2).HasColumnName("member2");

                entity.Property(e => e.Member20).HasColumnName("member20");

                entity.Property(e => e.Member21).HasColumnName("member21");

                entity.Property(e => e.Member22).HasColumnName("member22");

                entity.Property(e => e.Member23).HasColumnName("member23");

                entity.Property(e => e.Member24).HasColumnName("member24");

                entity.Property(e => e.Member25).HasColumnName("member25");

                entity.Property(e => e.Member26).HasColumnName("member26");

                entity.Property(e => e.Member27).HasColumnName("member27");

                entity.Property(e => e.Member28).HasColumnName("member28");

                entity.Property(e => e.Member29).HasColumnName("member29");

                entity.Property(e => e.Member3).HasColumnName("member3");

                entity.Property(e => e.Member30).HasColumnName("member30");

                entity.Property(e => e.Member4).HasColumnName("member4");

                entity.Property(e => e.Member5).HasColumnName("member5");

                entity.Property(e => e.Member6).HasColumnName("member6");

                entity.Property(e => e.Member7).HasColumnName("member7");

                entity.Property(e => e.Member8).HasColumnName("member8");

                entity.Property(e => e.Member9).HasColumnName("member9");
            });

            modelBuilder.Entity<GuildAdditionalMember>(entity =>
            {
                entity.HasKey(e => e.GuildId);

                entity.ToTable("guild_additional_member");

                entity.Property(e => e.GuildId)
                    .HasColumnName("guild_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Member1).HasColumnName("member1");

                entity.Property(e => e.Member10).HasColumnName("member10");

                entity.Property(e => e.Member2).HasColumnName("member2");

                entity.Property(e => e.Member3).HasColumnName("member3");

                entity.Property(e => e.Member4).HasColumnName("member4");

                entity.Property(e => e.Member5).HasColumnName("member5");

                entity.Property(e => e.Member6).HasColumnName("member6");

                entity.Property(e => e.Member7).HasColumnName("member7");

                entity.Property(e => e.Member8).HasColumnName("member8");

                entity.Property(e => e.Member9).HasColumnName("member9");

                entity.Property(e => e.ThumbId).HasColumnName("thumb_id");

                entity.Property(e => e.UnlockStoryId).HasColumnName("unlock_story_id");
            });

            modelBuilder.Entity<HatsuneBattleMissionData>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("hatsune_battle_mission_data");

                entity.Property(e => e.MissionId)
                    .HasColumnName("mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue10).HasColumnName("condition_value_10");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.ConditionValue6).HasColumnName("condition_value_6");

                entity.Property(e => e.ConditionValue7).HasColumnName("condition_value_7");

                entity.Property(e => e.ConditionValue8).HasColumnName("condition_value_8");

                entity.Property(e => e.ConditionValue9).HasColumnName("condition_value_9");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<HatsuneBgChange>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("hatsune_bg_change");

                entity.Property(e => e.AreaId)
                    .HasColumnName("area_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.QuestId1).HasColumnName("quest_id_1");

                entity.Property(e => e.QuestId2).HasColumnName("quest_id_2");

                entity.Property(e => e.QuestId3).HasColumnName("quest_id_3");

                entity.Property(e => e.QuestId4).HasColumnName("quest_id_4");

                entity.Property(e => e.QuestId5).HasColumnName("quest_id_5");
            });

            modelBuilder.Entity<HatsuneBgChangeData>(entity =>
            {
                entity.ToTable("hatsune_bg_change_data");

                entity.HasIndex(e => new { e.TargetType, e.AreaId })
                    .HasName("hatsune_bg_change_data_0_target_type_1_area_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.BgAfterChangeId).HasColumnName("bg_after_change_id");

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.TargetType).HasColumnName("target_type");
            });

            modelBuilder.Entity<HatsuneBoss>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("hatsune_boss");

                entity.HasIndex(e => e.EventId)
                    .HasName("hatsune_boss_0_event_id");

                entity.HasIndex(e => e.WaveGroupId1)
                    .HasName("hatsune_boss_0_wave_group_id_1");

                entity.HasIndex(e => new { e.EventId, e.Difficulty })
                    .HasName("hatsune_boss_0_event_id_1_difficulty");

                entity.Property(e => e.BossId)
                    .HasColumnName("boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.BossPositionX).HasColumnName("boss_position_x");

                entity.Property(e => e.BossPositionY).HasColumnName("boss_position_y");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DailyLimit).HasColumnName("daily_limit");

                entity.Property(e => e.DeatailAuraSize).HasColumnName("deatail_aura_size");

                entity.Property(e => e.DetailBgId).HasColumnName("detail_bg_id");

                entity.Property(e => e.DetailBgPosition).HasColumnName("detail_bg_position");

                entity.Property(e => e.DetailBossBgHeight).HasColumnName("detail_boss_bg_height");

                entity.Property(e => e.DetailBossBgSize).HasColumnName("detail_boss_bg_size");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispOnBg).HasColumnName("disp_on_bg");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventBossTreasureBoxId1).HasColumnName("event_boss_treasure_box_id_1");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IconColliderScale).HasColumnName("icon_collider_scale");

                entity.Property(e => e.IconDisplayScale).HasColumnName("icon_display_scale");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.Love).HasColumnName("love");

                entity.Property(e => e.MapArrowOffset).HasColumnName("map_arrow_offset");

                entity.Property(e => e.MapAuraSize).HasColumnName("map_aura_size");

                entity.Property(e => e.MapPositionX).HasColumnName("map_position_x");

                entity.Property(e => e.MapPositionY).HasColumnName("map_position_y");

                entity.Property(e => e.MapSize).HasColumnName("map_size");

                entity.Property(e => e.OneblowCountOfSkipCondition).HasColumnName("oneblow_count_of_skip_condition");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QdMode).HasColumnName("qd_mode");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.RequiredSkipTicketCount).HasColumnName("required_skip_ticket_count");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.RetireFlag).HasColumnName("retire_flag");

                entity.Property(e => e.RewardGoldCoefficient)
                    .IsRequired()
                    .HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.RewardGoldLimit).HasColumnName("reward_gold_limit");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryIdWaveend1).HasColumnName("story_id_waveend_1");

                entity.Property(e => e.StoryIdWavestart1).HasColumnName("story_id_wavestart_1");

                entity.Property(e => e.TdMode).HasColumnName("td_mode");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.UnitExp).HasColumnName("unit_exp");

                entity.Property(e => e.UseTicketNum).HasColumnName("use_ticket_num");

                entity.Property(e => e.WaveBgmQueId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmSheetId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");
            });

            modelBuilder.Entity<HatsuneBossCondition>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("hatsune_boss_condition");

                entity.Property(e => e.BossId)
                    .HasColumnName("boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossId1).HasColumnName("condition_boss_id_1");

                entity.Property(e => e.ConditionBossId2).HasColumnName("condition_boss_id_2");

                entity.Property(e => e.ConditionGachaStep).HasColumnName("condition_gacha_step");

                entity.Property(e => e.ConditionQuestId1).HasColumnName("condition_quest_id_1");

                entity.Property(e => e.ConditionQuestId2).HasColumnName("condition_quest_id_2");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ForceUnlockTime)
                    .IsRequired()
                    .HasColumnName("force_unlock_time");

                entity.Property(e => e.ReleaseBossId1).HasColumnName("release_boss_id_1");

                entity.Property(e => e.ReleaseBossId2).HasColumnName("release_boss_id_2");

                entity.Property(e => e.ReleaseQuestId1).HasColumnName("release_quest_id_1");

                entity.Property(e => e.ReleaseQuestId2).HasColumnName("release_quest_id_2");
            });

            modelBuilder.Entity<HatsuneBossEnemySetting>(entity =>
            {
                entity.HasKey(e => new { e.BossId, e.EnemyIdentify });

                entity.ToTable("hatsune_boss_enemy_setting");

                entity.HasIndex(e => new { e.BossId, e.EventId })
                    .HasName("hatsune_boss_enemy_setting_0_boss_id_1_event_id");

                entity.Property(e => e.BossId).HasColumnName("boss_id");

                entity.Property(e => e.EnemyIdentify).HasColumnName("enemy_identify");

                entity.Property(e => e.DetailOffsetX).HasColumnName("detail_offset_x");

                entity.Property(e => e.DetailOffsetY).HasColumnName("detail_offset_y");

                entity.Property(e => e.DetailScale).HasColumnName("detail_scale");

                entity.Property(e => e.EventBossTreasureBoxId).HasColumnName("event_boss_treasure_box_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MapDepth).HasColumnName("map_depth");

                entity.Property(e => e.MapOffsetX).HasColumnName("map_offset_x");

                entity.Property(e => e.MapOffsetY).HasColumnName("map_offset_y");

                entity.Property(e => e.MapScale).HasColumnName("map_scale");

                entity.Property(e => e.MustKillFlag).HasColumnName("must_kill_flag");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.RewardGoldLimit).HasColumnName("reward_gold_limit");
            });

            modelBuilder.Entity<HatsuneDailyMissionData>(entity =>
            {
                entity.HasKey(e => e.DailyMissionId);

                entity.ToTable("hatsune_daily_mission_data");

                entity.Property(e => e.DailyMissionId)
                    .HasColumnName("daily_mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<HatsuneDescription>(entity =>
            {
                entity.ToTable("hatsune_description");

                entity.HasIndex(e => new { e.EventId, e.Type })
                    .HasName("hatsune_description_0_event_id_1_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HatsuneDiaryData>(entity =>
            {
                entity.HasKey(e => e.DiaryId);

                entity.ToTable("hatsune_diary_data");

                entity.HasIndex(e => e.ContentsType)
                    .HasName("hatsune_diary_data_0_contents_type");

                entity.Property(e => e.DiaryId)
                    .HasColumnName("diary_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossCount).HasColumnName("condition_boss_count");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.ConditionTime)
                    .IsRequired()
                    .HasColumnName("condition_time");

                entity.Property(e => e.ContentsType).HasColumnName("contents_type");

                entity.Property(e => e.DiaryDate).HasColumnName("diary_date");

                entity.Property(e => e.ForcedReleaseTime)
                    .IsRequired()
                    .HasColumnName("forced_release_time");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");
            });

            modelBuilder.Entity<HatsuneDiaryLetterScript>(entity =>
            {
                entity.ToTable("hatsune_diary_letter_script");

                entity.HasIndex(e => e.DiaryId)
                    .HasName("hatsune_diary_letter_script_0_diary_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.DiaryId).HasColumnName("diary_id");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HatsuneDiaryScript>(entity =>
            {
                entity.ToTable("hatsune_diary_script");

                entity.HasIndex(e => e.DiaryId)
                    .HasName("hatsune_diary_script_0_diary_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.DiaryId).HasColumnName("diary_id");

                entity.Property(e => e.DiaryText)
                    .IsRequired()
                    .HasColumnName("diary_text");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("sheet_name");

                entity.Property(e => e.TextAnimationSpeed).HasColumnName("text_animation_speed");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HatsuneDiarySetting>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("hatsune_diary_setting");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgmCueName)
                    .IsRequired()
                    .HasColumnName("bgm_cue_name");

                entity.Property(e => e.BgmSheetName)
                    .IsRequired()
                    .HasColumnName("bgm_sheet_name");
            });

            modelBuilder.Entity<HatsuneEmblemMission>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("hatsune_emblem_mission");

                entity.HasIndex(e => e.EventId)
                    .HasName("hatsune_emblem_mission_0_event_id");

                entity.Property(e => e.MissionId)
                    .HasColumnName("mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<HatsuneEmblemMissionReward>(entity =>
            {
                entity.ToTable("hatsune_emblem_mission_reward");

                entity.HasIndex(e => e.MissionRewardId)
                    .HasName("hatsune_emblem_mission_reward_0_mission_reward_id");

                entity.HasIndex(e => e.RewardId)
                    .HasName("hatsune_emblem_mission_reward_0_reward_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IconType).HasColumnName("icon_type");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<HatsuneItem>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("hatsune_item");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BossTicketId).HasColumnName("boss_ticket_id");

                entity.Property(e => e.GachaTicketId).HasColumnName("gacha_ticket_id");

                entity.Property(e => e.UnitMaterialId1).HasColumnName("unit_material_id_1");

                entity.Property(e => e.UnitMaterialId10).HasColumnName("unit_material_id_10");

                entity.Property(e => e.UnitMaterialId2).HasColumnName("unit_material_id_2");

                entity.Property(e => e.UnitMaterialId3).HasColumnName("unit_material_id_3");

                entity.Property(e => e.UnitMaterialId4).HasColumnName("unit_material_id_4");

                entity.Property(e => e.UnitMaterialId5).HasColumnName("unit_material_id_5");

                entity.Property(e => e.UnitMaterialId6).HasColumnName("unit_material_id_6");

                entity.Property(e => e.UnitMaterialId7).HasColumnName("unit_material_id_7");

                entity.Property(e => e.UnitMaterialId8).HasColumnName("unit_material_id_8");

                entity.Property(e => e.UnitMaterialId9).HasColumnName("unit_material_id_9");
            });

            modelBuilder.Entity<HatsuneLimitChara>(entity =>
            {
                entity.HasKey(e => e.EventBossId);

                entity.ToTable("hatsune_limit_chara");

                entity.Property(e => e.EventBossId)
                    .HasColumnName("event_boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.LimitCharaType1).HasColumnName("limit_chara_type_1");
            });

            modelBuilder.Entity<HatsuneMap>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("hatsune_map");

                entity.Property(e => e.CourseId)
                    .HasColumnName("course_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndAreaId).HasColumnName("end_area_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MapId).HasColumnName("map_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.QueId)
                    .IsRequired()
                    .HasColumnName("que_id");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.StartAreaId).HasColumnName("start_area_id");
            });

            modelBuilder.Entity<HatsuneMapEvent>(entity =>
            {
                entity.ToTable("hatsune_map_event");

                entity.HasIndex(e => e.TargetEventId)
                    .HasName("hatsune_map_event_0_target_event_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.EventType).HasColumnName("event_type");

                entity.Property(e => e.Param1).HasColumnName("param1");

                entity.Property(e => e.Param2).HasColumnName("param2");

                entity.Property(e => e.TargetEventId).HasColumnName("target_event_id");
            });

            modelBuilder.Entity<HatsuneMissionRewardData>(entity =>
            {
                entity.ToTable("hatsune_mission_reward_data");

                entity.HasIndex(e => e.MissionRewardId)
                    .HasName("hatsune_mission_reward_data_0_mission_reward_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<HatsuneMultiRouteParameter>(entity =>
            {
                entity.ToTable("hatsune_multi_route_parameter");

                entity.HasIndex(e => e.QuestId)
                    .HasName("hatsune_multi_route_parameter_0_quest_id");

                entity.HasIndex(e => e.Type)
                    .HasName("hatsune_multi_route_parameter_0_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Param1).HasColumnName("param_1");

                entity.Property(e => e.Param2).HasColumnName("param_2");

                entity.Property(e => e.Param3).HasColumnName("param_3");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");

                entity.Property(e => e.Text1)
                    .IsRequired()
                    .HasColumnName("text_1");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<HatsunePresent>(entity =>
            {
                entity.ToTable("hatsune_present");

                entity.HasIndex(e => e.EventId)
                    .HasName("hatsune_present_0_event_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdvId).HasColumnName("adv_id");

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionMissionId).HasColumnName("condition_mission_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.DialogText)
                    .IsRequired()
                    .HasColumnName("dialog_text");

                entity.Property(e => e.DialogTitle)
                    .IsRequired()
                    .HasColumnName("dialog_title");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemId2).HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3).HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4).HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5).HasColumnName("item_id_5");

                entity.Property(e => e.ItemNum1).HasColumnName("item_num_1");

                entity.Property(e => e.ItemNum2).HasColumnName("item_num_2");

                entity.Property(e => e.ItemNum3).HasColumnName("item_num_3");

                entity.Property(e => e.ItemNum4).HasColumnName("item_num_4");

                entity.Property(e => e.ItemNum5).HasColumnName("item_num_5");

                entity.Property(e => e.ItemType1).HasColumnName("item_type_1");

                entity.Property(e => e.ItemType2).HasColumnName("item_type_2");

                entity.Property(e => e.ItemType3).HasColumnName("item_type_3");

                entity.Property(e => e.ItemType4).HasColumnName("item_type_4");

                entity.Property(e => e.ItemType5).HasColumnName("item_type_5");
            });

            modelBuilder.Entity<HatsuneQuest>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("hatsune_quest");

                entity.HasIndex(e => e.EventId)
                    .HasName("hatsune_quest_0_event_id");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DailyLimit).HasColumnName("daily_limit");

                entity.Property(e => e.DropRewardId).HasColumnName("drop_reward_id");

                entity.Property(e => e.DropRewardNum).HasColumnName("drop_reward_num");

                entity.Property(e => e.DropRewardOdds).HasColumnName("drop_reward_odds");

                entity.Property(e => e.DropRewardType).HasColumnName("drop_reward_type");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.IconOffsetX).HasColumnName("icon_offset_x");

                entity.Property(e => e.IconOffsetY).HasColumnName("icon_offset_y");

                entity.Property(e => e.IconScale).HasColumnName("icon_scale");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.Love).HasColumnName("love");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.QuestSeq).HasColumnName("quest_seq");

                entity.Property(e => e.RankRewardGroup).HasColumnName("rank_reward_group");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryIdWaveend1).HasColumnName("story_id_waveend_1");

                entity.Property(e => e.StoryIdWaveend2).HasColumnName("story_id_waveend_2");

                entity.Property(e => e.StoryIdWaveend3).HasColumnName("story_id_waveend_3");

                entity.Property(e => e.StoryIdWavestart1).HasColumnName("story_id_wavestart_1");

                entity.Property(e => e.StoryIdWavestart2).HasColumnName("story_id_wavestart_2");

                entity.Property(e => e.StoryIdWavestart3).HasColumnName("story_id_wavestart_3");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.UnitExp).HasColumnName("unit_exp");

                entity.Property(e => e.WaveBgmQueId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_3");
            });

            modelBuilder.Entity<HatsuneQuestArea>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("hatsune_quest_area");

                entity.HasIndex(e => e.EventId)
                    .HasName("hatsune_quest_area_0_event_id");

                entity.Property(e => e.AreaId)
                    .HasColumnName("area_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalEffect).HasColumnName("additional_effect");

                entity.Property(e => e.AreaDisp).HasColumnName("area_disp");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("area_name");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MapId).HasColumnName("map_id");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.OpenTutorialId).HasColumnName("open_tutorial_id");

                entity.Property(e => e.QueId)
                    .IsRequired()
                    .HasColumnName("que_id");

                entity.Property(e => e.ScrollHeight).HasColumnName("scroll_height");

                entity.Property(e => e.ScrollWidth).HasColumnName("scroll_width");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.TutorialParam1)
                    .IsRequired()
                    .HasColumnName("tutorial_param_1");

                entity.Property(e => e.TutorialParam2)
                    .IsRequired()
                    .HasColumnName("tutorial_param_2");
            });

            modelBuilder.Entity<HatsuneQuestCondition>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("hatsune_quest_condition");

                entity.HasIndex(e => e.EventId)
                    .HasName("hatsune_quest_condition_0_event_id");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossId1).HasColumnName("condition_boss_id_1");

                entity.Property(e => e.ConditionBossId2).HasColumnName("condition_boss_id_2");

                entity.Property(e => e.ConditionMainQuestId).HasColumnName("condition_main_quest_id");

                entity.Property(e => e.ConditionQuestId1).HasColumnName("condition_quest_id_1");

                entity.Property(e => e.ConditionQuestId2).HasColumnName("condition_quest_id_2");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ReleaseBossId1).HasColumnName("release_boss_id_1");

                entity.Property(e => e.ReleaseBossId2).HasColumnName("release_boss_id_2");

                entity.Property(e => e.ReleaseQuestId1).HasColumnName("release_quest_id_1");

                entity.Property(e => e.ReleaseQuestId2).HasColumnName("release_quest_id_2");
            });

            modelBuilder.Entity<HatsuneQuiz>(entity =>
            {
                entity.HasKey(e => e.QuizId);

                entity.ToTable("hatsune_quiz");

                entity.HasIndex(e => e.EventId)
                    .HasName("hatsune_quiz_0_event_id");

                entity.HasIndex(e => new { e.EventId, e.ReleaseQuestId })
                    .HasName("hatsune_quiz_0_event_id_1_release_quest_id");

                entity.Property(e => e.QuizId)
                    .HasColumnName("quiz_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdvIdQuizEnd).HasColumnName("adv_id_quiz_end");

                entity.Property(e => e.AdvIdQuizStart).HasColumnName("adv_id_quiz_start");

                entity.Property(e => e.Answer).HasColumnName("answer");

                entity.Property(e => e.Choice1)
                    .IsRequired()
                    .HasColumnName("choice_1");

                entity.Property(e => e.Choice2)
                    .IsRequired()
                    .HasColumnName("choice_2");

                entity.Property(e => e.Choice3)
                    .IsRequired()
                    .HasColumnName("choice_3");

                entity.Property(e => e.Choice4)
                    .IsRequired()
                    .HasColumnName("choice_4");

                entity.Property(e => e.Choice5)
                    .IsRequired()
                    .HasColumnName("choice_5");

                entity.Property(e => e.Choice6)
                    .IsRequired()
                    .HasColumnName("choice_6");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Hint)
                    .IsRequired()
                    .HasColumnName("hint");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasColumnName("question");

                entity.Property(e => e.QuestionTitle)
                    .IsRequired()
                    .HasColumnName("question_title");

                entity.Property(e => e.QuizIconId).HasColumnName("quiz_icon_id");

                entity.Property(e => e.QuizPointName)
                    .IsRequired()
                    .HasColumnName("quiz_point_name");

                entity.Property(e => e.QuizPositionX).HasColumnName("quiz_position_x");

                entity.Property(e => e.QuizPositionY).HasColumnName("quiz_position_y");

                entity.Property(e => e.ReleaseQuestId).HasColumnName("release_quest_id");

                entity.Property(e => e.ResourceId).HasColumnName("resource_id");
            });

            modelBuilder.Entity<HatsuneQuizCondition>(entity =>
            {
                entity.ToTable("hatsune_quiz_condition");

                entity.HasIndex(e => new { e.EventId, e.QuizId })
                    .HasName("hatsune_quiz_condition_0_event_id_1_quiz_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionMissionId).HasColumnName("condition_mission_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.ConditionQuizId).HasColumnName("condition_quiz_id");

                entity.Property(e => e.ConditionTimeFrom).HasColumnName("condition_time_from");

                entity.Property(e => e.ConditionUnitId).HasColumnName("condition_unit_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.QuizId).HasColumnName("quiz_id");
            });

            modelBuilder.Entity<HatsuneQuizReward>(entity =>
            {
                entity.HasKey(e => e.QuizId);

                entity.ToTable("hatsune_quiz_reward");

                entity.Property(e => e.QuizId)
                    .HasColumnName("quiz_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<HatsuneRelayData>(entity =>
            {
                entity.HasKey(e => e.RelayStoryId);

                entity.ToTable("hatsune_relay_data");

                entity.Property(e => e.RelayStoryId)
                    .HasColumnName("relay_story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.IsEnableRead).HasColumnName("is_enable_read");

                entity.Property(e => e.StorySeq).HasColumnName("story_seq");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");
            });

            modelBuilder.Entity<HatsuneSchedule>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("hatsune_schedule");

                entity.HasIndex(e => e.OriginalEventId)
                    .HasName("hatsune_schedule_0_original_event_id");

                entity.HasIndex(e => e.SeriesEventId)
                    .HasName("hatsune_schedule_0_series_event_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BackgroudPosX).HasColumnName("backgroud_pos_x");

                entity.Property(e => e.BackgroudPosY).HasColumnName("backgroud_pos_y");

                entity.Property(e => e.BackgroudSizeX).HasColumnName("backgroud_size_x");

                entity.Property(e => e.BackgroudSizeY).HasColumnName("backgroud_size_y");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BannerUnitId).HasColumnName("banner_unit_id");

                entity.Property(e => e.CloseTime)
                    .IsRequired()
                    .HasColumnName("close_time");

                entity.Property(e => e.CountStartTime)
                    .IsRequired()
                    .HasColumnName("count_start_time");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.QueId)
                    .IsRequired()
                    .HasColumnName("que_id");

                entity.Property(e => e.SeriesEventId).HasColumnName("series_event_id");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.TeaserDialogType).HasColumnName("teaser_dialog_type");

                entity.Property(e => e.TeaserTime)
                    .IsRequired()
                    .HasColumnName("teaser_time");
            });

            modelBuilder.Entity<HatsuneSeriesGachaReference>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("hatsune_series_gacha_reference");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ReferenceKeyEventIdFlag).HasColumnName("reference_key_event_id_flag");
            });

            modelBuilder.Entity<HatsuneSpecialBattle>(entity =>
            {
                entity.HasKey(e => new { e.EventId, e.Mode });

                entity.ToTable("hatsune_special_battle");

                entity.HasIndex(e => e.EventId)
                    .HasName("hatsune_special_battle_0_event_id");

                entity.HasIndex(e => e.WaveGroupId)
                    .HasName("hatsune_special_battle_0_wave_group_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.ActionStartSecond).HasColumnName("action_start_second");

                entity.Property(e => e.AppearTime).HasColumnName("appear_time");

                entity.Property(e => e.DetailBossBgHeight).HasColumnName("detail_boss_bg_height");

                entity.Property(e => e.DetailBossBgSize).HasColumnName("detail_boss_bg_size");

                entity.Property(e => e.DetailBossMotion)
                    .IsRequired()
                    .HasColumnName("detail_boss_motion");

                entity.Property(e => e.HpGaugeColorFlag).HasColumnName("hp_gauge_color_flag");

                entity.Property(e => e.IsHideBoss).HasColumnName("is_hide_boss");

                entity.Property(e => e.PurposeCount).HasColumnName("purpose_count");

                entity.Property(e => e.PurposeType).HasColumnName("purpose_type");

                entity.Property(e => e.RecommendedLevel).HasColumnName("recommended_level");

                entity.Property(e => e.StartIdleTrigger).HasColumnName("start_idle_trigger");

                entity.Property(e => e.StoryIdModeEnd).HasColumnName("story_id_mode_end");

                entity.Property(e => e.StoryIdModeStart).HasColumnName("story_id_mode_start");

                entity.Property(e => e.StoryStartSecond).HasColumnName("story_start_second");

                entity.Property(e => e.TriggerHp).HasColumnName("trigger_hp");

                entity.Property(e => e.UnnecessaryDefeatChara).HasColumnName("unnecessary_defeat_chara");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<HatsuneSpecialBossTicketCount>(entity =>
            {
                entity.ToTable("hatsune_special_boss_ticket_count");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChallengeCountFrom).HasColumnName("challenge_count_from");

                entity.Property(e => e.ChallengeCountTo).HasColumnName("challenge_count_to");

                entity.Property(e => e.UseTicketNum).HasColumnName("use_ticket_num");
            });

            modelBuilder.Entity<HatsuneSpecialEnemy>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("hatsune_special_enemy");

                entity.Property(e => e.EnemyId)
                    .HasColumnName("enemy_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnemyPoint).HasColumnName("enemy_point");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.InitialPosition).HasColumnName("initial_position");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.Order).HasColumnName("order");
            });

            modelBuilder.Entity<HatsuneSpecialMissionData>(entity =>
            {
                entity.HasKey(e => e.SpecialMissionId);

                entity.ToTable("hatsune_special_mission_data");

                entity.Property(e => e.SpecialMissionId)
                    .HasColumnName("special_mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.PurposeType).HasColumnName("purpose_type");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<HatsuneStationaryMissionData>(entity =>
            {
                entity.HasKey(e => e.StationaryMissionId);

                entity.ToTable("hatsune_stationary_mission_data");

                entity.HasIndex(e => e.EventId)
                    .HasName("hatsune_stationary_mission_data_0_event_id");

                entity.Property(e => e.StationaryMissionId)
                    .HasColumnName("stationary_mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<HatsuneUnlockStoryCondition>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("hatsune_unlock_story_condition");

                entity.HasIndex(e => e.EventId)
                    .HasName("hatsune_unlock_story_condition_0_event_id");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionEntry).HasColumnName("condition_entry");

                entity.Property(e => e.ConditionMissionId).HasColumnName("condition_mission_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.ConditionTime)
                    .IsRequired()
                    .HasColumnName("condition_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");
            });

            modelBuilder.Entity<HatsuneUnlockUnitCondition>(entity =>
            {
                entity.ToTable("hatsune_unlock_unit_condition");

                entity.HasIndex(e => e.ConditionMissionId)
                    .HasName("hatsune_unlock_unit_condition_0_condition_mission_id");

                entity.HasIndex(e => new { e.UnitId, e.EventId })
                    .HasName("hatsune_unlock_unit_condition_0_unit_id_1_event_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionMissionId).HasColumnName("condition_mission_id");

                entity.Property(e => e.Description1)
                    .IsRequired()
                    .HasColumnName("description_1");

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("description_2");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.TopDescription)
                    .IsRequired()
                    .HasColumnName("top_description");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<HpDrainAt>(entity =>
            {
                entity.ToTable("hp_drain_at");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CorrectionValue).HasColumnName("correction_value");

                entity.Property(e => e.LimitValue).HasColumnName("limit_value");
            });

            modelBuilder.Entity<ItemData>(entity =>
            {
                entity.HasKey(e => e.ItemId);

                entity.ToTable("item_data");

                entity.Property(e => e.ItemId)
                    .HasColumnName("item_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.GojuonOrder).HasColumnName("gojuon_order");

                entity.Property(e => e.ItemName)
                    .IsRequired()
                    .HasColumnName("item_name");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.LimitNum).HasColumnName("limit_num");

                entity.Property(e => e.Price).HasColumnName("price");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.SellCheckDisp).HasColumnName("sell_check_disp");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<ItemETicketData>(entity =>
            {
                entity.HasKey(e => new { e.TicketId, e.ExchangeNumber });

                entity.ToTable("item_e_ticket_data");

                entity.HasIndex(e => e.ExchangeNumber)
                    .HasName("item_e_ticket_data_0_exchange_number");

                entity.HasIndex(e => e.TicketId)
                    .HasName("item_e_ticket_data_0_ticket_id");

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");

                entity.Property(e => e.ExchangeNumber).HasColumnName("exchange_number");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<KaiserAddTimesData>(entity =>
            {
                entity.ToTable("kaiser_add_times_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddTimes).HasColumnName("add_times");

                entity.Property(e => e.AddTimesTime)
                    .IsRequired()
                    .HasColumnName("add_times_time");

                entity.Property(e => e.Duration).HasColumnName("duration");
            });

            modelBuilder.Entity<KaiserExterminationReward>(entity =>
            {
                entity.HasKey(e => e.ExterminationRewardGroup);

                entity.ToTable("kaiser_extermination_reward");

                entity.Property(e => e.ExterminationRewardGroup)
                    .HasColumnName("extermination_reward_group")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<KaiserQuestData>(entity =>
            {
                entity.HasKey(e => e.KaiserBossId);

                entity.ToTable("kaiser_quest_data");

                entity.Property(e => e.KaiserBossId)
                    .HasColumnName("kaiser_boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BattleFinishStoryId).HasColumnName("battle_finish_story_id");

                entity.Property(e => e.BattleStartStoryId).HasColumnName("battle_start_story_id");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.ClearStoryId1).HasColumnName("clear_story_id_1");

                entity.Property(e => e.ClearStoryId2).HasColumnName("clear_story_id_2");

                entity.Property(e => e.DisappearanceStoryId).HasColumnName("disappearance_story_id");

                entity.Property(e => e.EnemyLocalPositionY).HasColumnName("enemy_local_position_y");

                entity.Property(e => e.EnemyPositionX).HasColumnName("enemy_position_x");

                entity.Property(e => e.EnemySize1).HasColumnName("enemy_size_1");

                entity.Property(e => e.ExterminationRewardGroup).HasColumnName("extermination_reward_group");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.LimitedMana).HasColumnName("limited_mana");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.OddsGroupId)
                    .IsRequired()
                    .HasColumnName("odds_group_id");

                entity.Property(e => e.RestrictionGroupId).HasColumnName("restriction_group_id");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.WaveBgm)
                    .IsRequired()
                    .HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<KaiserRestrictionGroup>(entity =>
            {
                entity.HasKey(e => new { e.RestrictionGroupId, e.UnitId });

                entity.ToTable("kaiser_restriction_group");

                entity.HasIndex(e => e.RestrictionGroupId)
                    .HasName("kaiser_restriction_group_0_restriction_group_id");

                entity.Property(e => e.RestrictionGroupId).HasColumnName("restriction_group_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<KaiserSchedule>(entity =>
            {
                entity.ToTable("kaiser_schedule");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AfterBg)
                    .IsRequired()
                    .HasColumnName("after_bg");

                entity.Property(e => e.AfterBgm)
                    .IsRequired()
                    .HasColumnName("after_bgm");

                entity.Property(e => e.CloseStoryConditionId).HasColumnName("close_story_condition_id");

                entity.Property(e => e.CloseStoryId).HasColumnName("close_story_id");

                entity.Property(e => e.CloseTime)
                    .IsRequired()
                    .HasColumnName("close_time");

                entity.Property(e => e.CountStartTime)
                    .IsRequired()
                    .HasColumnName("count_start_time");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.TeaserTime)
                    .IsRequired()
                    .HasColumnName("teaser_time");

                entity.Property(e => e.TopBg)
                    .IsRequired()
                    .HasColumnName("top_bg");

                entity.Property(e => e.TopBgm)
                    .IsRequired()
                    .HasColumnName("top_bgm");
            });

            modelBuilder.Entity<KaiserSpecialBattle>(entity =>
            {
                entity.HasKey(e => e.Mode);

                entity.ToTable("kaiser_special_battle");

                entity.Property(e => e.Mode)
                    .HasColumnName("mode")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionStartSecond).HasColumnName("action_start_second");

                entity.Property(e => e.AppearTime).HasColumnName("appear_time");

                entity.Property(e => e.HpGaugeColorFlag).HasColumnName("hp_gauge_color_flag");

                entity.Property(e => e.PurposeCount).HasColumnName("purpose_count");

                entity.Property(e => e.PurposeType).HasColumnName("purpose_type");

                entity.Property(e => e.RecommendedLevel).HasColumnName("recommended_level");

                entity.Property(e => e.StartIdleTrigger).HasColumnName("start_idle_trigger");

                entity.Property(e => e.StoryIdModeEnd).HasColumnName("story_id_mode_end");

                entity.Property(e => e.StoryIdModeStart).HasColumnName("story_id_mode_start");

                entity.Property(e => e.StoryStartSecond).HasColumnName("story_start_second");

                entity.Property(e => e.TriggerHp).HasColumnName("trigger_hp");

                entity.Property(e => e.UnnecessaryDefeatChara).HasColumnName("unnecessary_defeat_chara");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<KmkNaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("kmk_navi_comment");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeFaceTime).HasColumnName("change_face_time");

                entity.Property(e => e.ChangeFaceType).HasColumnName("change_face_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasColumnName("character_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<KmkReward>(entity =>
            {
                entity.ToTable("kmk_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.KmkScore).HasColumnName("kmk_score");

                entity.Property(e => e.MissionDetail)
                    .IsRequired()
                    .HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<LegionAddTimesData>(entity =>
            {
                entity.ToTable("legion_add_times_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddTimes).HasColumnName("add_times");

                entity.Property(e => e.AddTimesTime)
                    .IsRequired()
                    .HasColumnName("add_times_time");
            });

            modelBuilder.Entity<LegionBattleBonus>(entity =>
            {
                entity.ToTable("legion_battle_bonus");

                entity.HasIndex(e => e.Type)
                    .HasName("legion_battle_bonus_0_type");

                entity.HasIndex(e => new { e.Type, e.LegionBossId })
                    .HasName("legion_battle_bonus_0_type_1_legion_boss_id");

                entity.Property(e => e.LegionBattleBonusId)
                    .HasColumnName("legion_battle_bonus_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionHp)
                    .IsRequired()
                    .HasColumnName("condition_hp");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.LegionBattleEffectId).HasColumnName("legion_battle_effect_id");

                entity.Property(e => e.LegionBossId).HasColumnName("legion_boss_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<LegionBattleBonusEffect>(entity =>
            {
                entity.HasKey(e => e.LegionBattleEffectId);

                entity.ToTable("legion_battle_bonus_effect");

                entity.Property(e => e.LegionBattleEffectId)
                    .HasColumnName("legion_battle_effect_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnemyId).HasColumnName("enemy_id");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");

                entity.Property(e => e.TargetType).HasColumnName("target_type");

                entity.Property(e => e.TextId).HasColumnName("text_id");
            });

            modelBuilder.Entity<LegionBossEnemySetting>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("legion_boss_enemy_setting");

                entity.Property(e => e.BossId)
                    .HasColumnName("boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetailOffsetScale).HasColumnName("detail_offset_scale");

                entity.Property(e => e.DetailOffsetX).HasColumnName("detail_offset_x");

                entity.Property(e => e.DetailOffsetY).HasColumnName("detail_offset_y");
            });

            modelBuilder.Entity<LegionEffect>(entity =>
            {
                entity.HasKey(e => e.EffectId);

                entity.ToTable("legion_effect");

                entity.Property(e => e.EffectId)
                    .HasColumnName("effect_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Bonus1).HasColumnName("bonus_1");

                entity.Property(e => e.Bonus2).HasColumnName("bonus_2");

                entity.Property(e => e.Bonus3).HasColumnName("bonus_3");

                entity.Property(e => e.Bonus4).HasColumnName("bonus_4");

                entity.Property(e => e.Bonus5).HasColumnName("bonus_5");
            });

            modelBuilder.Entity<LegionEffectiveUnit>(entity =>
            {
                entity.HasKey(e => new { e.LegionBossId, e.UnitId });

                entity.ToTable("legion_effective_unit");

                entity.HasIndex(e => e.LegionBossId)
                    .HasName("legion_effective_unit_0_legion_boss_id");

                entity.Property(e => e.LegionBossId).HasColumnName("legion_boss_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.SupportEffectId).HasColumnName("support_effect_id");
            });

            modelBuilder.Entity<LegionExterminationReward>(entity =>
            {
                entity.HasKey(e => e.ExterminationRewardGroupId);

                entity.ToTable("legion_extermination_reward");

                entity.Property(e => e.ExterminationRewardGroupId)
                    .HasColumnName("extermination_reward_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<LegionMissionCategoryData>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("legion_mission_category_data");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<LegionMissionData>(entity =>
            {
                entity.HasKey(e => e.LegionMissionId);

                entity.ToTable("legion_mission_data");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("legion_mission_data_0_category_id");

                entity.Property(e => e.LegionMissionId)
                    .HasColumnName("legion_mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.ConditionNum)
                    .IsRequired()
                    .HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue).HasColumnName("condition_value");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.LegionBossId).HasColumnName("legion_boss_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<LegionMissionRewardData>(entity =>
            {
                entity.ToTable("legion_mission_reward_data");

                entity.HasIndex(e => e.MissionRewardId)
                    .HasName("legion_mission_reward_data_0_mission_reward_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<LegionQuestData>(entity =>
            {
                entity.HasKey(e => e.LegionBossId);

                entity.ToTable("legion_quest_data");

                entity.HasIndex(e => e.MapType)
                    .HasName("legion_quest_data_0_map_type");

                entity.Property(e => e.LegionBossId)
                    .HasColumnName("legion_boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllDisappearanceStoryId).HasColumnName("all_disappearance_story_id");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BattleFinishStoryId).HasColumnName("battle_finish_story_id");

                entity.Property(e => e.BattleStartStoryId).HasColumnName("battle_start_story_id");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.BonusMax).HasColumnName("bonus_max");

                entity.Property(e => e.ChallengeRewardGroupId).HasColumnName("challenge_reward_group_id");

                entity.Property(e => e.ClearStoryId1).HasColumnName("clear_story_id_1");

                entity.Property(e => e.ClearStoryId2).HasColumnName("clear_story_id_2");

                entity.Property(e => e.DisappearanceStoryId).HasColumnName("disappearance_story_id");

                entity.Property(e => e.EnemyLocalPositionY).HasColumnName("enemy_local_position_y");

                entity.Property(e => e.EnemyPositionX).HasColumnName("enemy_position_x");

                entity.Property(e => e.EnemySize1).HasColumnName("enemy_size_1");

                entity.Property(e => e.ExpelRewardGroupId).HasColumnName("expel_reward_group_id");

                entity.Property(e => e.ExterminationRewardGroupId).HasColumnName("extermination_reward_group_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.MaxRaidHp)
                    .IsRequired()
                    .HasColumnName("max_raid_hp");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.WaveBgm)
                    .IsRequired()
                    .HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<LegionSchedule>(entity =>
            {
                entity.ToTable("legion_schedule");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CloseStoryConditionId).HasColumnName("close_story_condition_id");

                entity.Property(e => e.CloseStoryId).HasColumnName("close_story_id");

                entity.Property(e => e.CloseTime)
                    .IsRequired()
                    .HasColumnName("close_time");

                entity.Property(e => e.CountStartTime)
                    .IsRequired()
                    .HasColumnName("count_start_time");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.TeaserTime)
                    .IsRequired()
                    .HasColumnName("teaser_time");

                entity.Property(e => e.TopBg)
                    .IsRequired()
                    .HasColumnName("top_bg");

                entity.Property(e => e.TopBgm)
                    .IsRequired()
                    .HasColumnName("top_bgm");
            });

            modelBuilder.Entity<LegionSpecialBattle>(entity =>
            {
                entity.HasKey(e => e.Mode);

                entity.ToTable("legion_special_battle");

                entity.Property(e => e.Mode)
                    .HasColumnName("mode")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionStartSecond).HasColumnName("action_start_second");

                entity.Property(e => e.HpGaugeColorFlag).HasColumnName("hp_gauge_color_flag");

                entity.Property(e => e.PurposeCount).HasColumnName("purpose_count");

                entity.Property(e => e.PurposeType).HasColumnName("purpose_type");

                entity.Property(e => e.StoryIdModeEnd).HasColumnName("story_id_mode_end");

                entity.Property(e => e.StoryIdModeStart).HasColumnName("story_id_mode_start");

                entity.Property(e => e.StoryStartSecond).HasColumnName("story_start_second");

                entity.Property(e => e.TriggerHp).HasColumnName("trigger_hp");

                entity.Property(e => e.UnnecessaryDefeatChara).HasColumnName("unnecessary_defeat_chara");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<LoginBonusAdv>(entity =>
            {
                entity.ToTable("login_bonus_adv");

                entity.HasIndex(e => e.LoginBonusId)
                    .HasName("login_bonus_adv_0_login_bonus_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdvId).HasColumnName("adv_id");

                entity.Property(e => e.CountKey).HasColumnName("count_key");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.LoginBonusId).HasColumnName("login_bonus_id");

                entity.Property(e => e.ReadProcessFlag).HasColumnName("read_process_flag");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<LoginBonusData>(entity =>
            {
                entity.HasKey(e => e.LoginBonusId);

                entity.ToTable("login_bonus_data");

                entity.Property(e => e.LoginBonusId)
                    .HasColumnName("login_bonus_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdvPlayType).HasColumnName("adv_play_type");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.CountNum).HasColumnName("count_num");

                entity.Property(e => e.CountType).HasColumnName("count_type");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.LoginBonusType).HasColumnName("login_bonus_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.StampId).HasColumnName("stamp_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<LoginBonusDetail>(entity =>
            {
                entity.ToTable("login_bonus_detail");

                entity.HasIndex(e => new { e.LoginBonusId, e.Count })
                    .HasName("login_bonus_detail_0_login_bonus_id_1_count");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasColumnName("character_name");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.LoginBonusId).HasColumnName("login_bonus_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");
            });

            modelBuilder.Entity<LoginBonusMessageData>(entity =>
            {
                entity.ToTable("login_bonus_message_data");

                entity.HasIndex(e => e.LoginBonusId)
                    .HasName("login_bonus_message_data_0_login_bonus_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalParam)
                    .IsRequired()
                    .HasColumnName("additional_param");

                entity.Property(e => e.AdditionalType).HasColumnName("additional_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasColumnName("character_name");

                entity.Property(e => e.DayCount).HasColumnName("day_count");

                entity.Property(e => e.LoginBonusId).HasColumnName("login_bonus_id");

                entity.Property(e => e.LuckPattern).HasColumnName("luck_pattern");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message");

                entity.Property(e => e.Rate).HasColumnName("rate");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");
            });

            modelBuilder.Entity<LoveChara>(entity =>
            {
                entity.HasKey(e => e.LoveLevel);

                entity.ToTable("love_chara");

                entity.Property(e => e.LoveLevel)
                    .HasColumnName("love_level")
                    .ValueGeneratedNever();

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.TotalLove).HasColumnName("total_love");

                entity.Property(e => e.UnlockedClass).HasColumnName("unlocked_class");
            });

            modelBuilder.Entity<LoveRankup>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.LoveRank });

                entity.ToTable("love_rankup");

                entity.HasIndex(e => e.UnitId)
                    .HasName("love_rankup_0_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.LoveRank).HasColumnName("love_rank");

                entity.Property(e => e.EffectUnitId).HasColumnName("effect_unit_id");
            });

            modelBuilder.Entity<LsvDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("lsv_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("lsv_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<LsvStoryData>(entity =>
            {
                entity.HasKey(e => e.SubStoryId);

                entity.ToTable("lsv_story_data");

                entity.HasIndex(e => e.OriginalEventId)
                    .HasName("lsv_story_data_0_original_event_id");

                entity.Property(e => e.SubStoryId)
                    .HasColumnName("sub_story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.ReadCondition).HasColumnName("read_condition");

                entity.Property(e => e.ReadEventStoryId).HasColumnName("read_event_story_id");

                entity.Property(e => e.TimeCondition)
                    .IsRequired()
                    .HasColumnName("time_condition");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<LsvStoryScript>(entity =>
            {
                entity.ToTable("lsv_story_script");

                entity.HasIndex(e => e.StoryId)
                    .HasName("lsv_story_script_0_story_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<LtoLetterScript>(entity =>
            {
                entity.ToTable("lto_letter_script");

                entity.HasIndex(e => e.LetterId)
                    .HasName("lto_letter_script_0_letter_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LetterId).HasColumnName("letter_id");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<LtoStoryData>(entity =>
            {
                entity.HasKey(e => e.SubStoryId);

                entity.ToTable("lto_story_data");

                entity.HasIndex(e => e.EventId)
                    .HasName("lto_story_data_0_event_id");

                entity.Property(e => e.SubStoryId)
                    .HasColumnName("sub_story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.RewardCount).HasColumnName("reward_count");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Metamorphose>(entity =>
            {
                entity.HasKey(e => new { e.TypeId, e.ConditionValue });

                entity.ToTable("metamorphose");

                entity.HasIndex(e => e.TypeId)
                    .HasName("metamorphose_0_type_id");

                entity.Property(e => e.TypeId).HasColumnName("type_id");

                entity.Property(e => e.ConditionValue).HasColumnName("condition_value");

                entity.Property(e => e.PrefabId).HasColumnName("prefab_id");
            });

            modelBuilder.Entity<MhpDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("mhp_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("mhp_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<MhpStoryData>(entity =>
            {
                entity.HasKey(e => e.SubStoryId);

                entity.ToTable("mhp_story_data");

                entity.HasIndex(e => e.OriginalEventId)
                    .HasName("mhp_story_data_0_original_event_id");

                entity.HasIndex(e => e.UnitId)
                    .HasName("mhp_story_data_0_unit_id");

                entity.Property(e => e.SubStoryId)
                    .HasColumnName("sub_story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.ReadCondition).HasColumnName("read_condition");

                entity.Property(e => e.ReadConditionTime)
                    .IsRequired()
                    .HasColumnName("read_condition_time");

                entity.Property(e => e.RewardCount).HasColumnName("reward_count");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<Minigame>(entity =>
            {
                entity.HasKey(e => e.MinigameSchemeId);

                entity.ToTable("minigame");

                entity.HasIndex(e => e.EventId)
                    .HasName("minigame_0_event_id");

                entity.Property(e => e.MinigameSchemeId)
                    .HasColumnName("minigame_scheme_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionsId1).HasColumnName("conditions_id_1");

                entity.Property(e => e.DisplayConditionId).HasColumnName("display_condition_id");

                entity.Property(e => e.DisplayConditionType).HasColumnName("display_condition_type");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FirstTimeStoryId).HasColumnName("first_time_story_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IsEnabledZeroScore).HasColumnName("is_enabled_zero_score");

                entity.Property(e => e.ReleaseConditions1).HasColumnName("release_conditions_1");

                entity.Property(e => e.ResultChatConditionId).HasColumnName("result_chat_condition_id");

                entity.Property(e => e.ScoreUnit)
                    .IsRequired()
                    .HasColumnName("score_unit");
            });

            modelBuilder.Entity<MissionRewardData>(entity =>
            {
                entity.ToTable("mission_reward_data");

                entity.HasIndex(e => e.MissionRewardId)
                    .HasName("mission_reward_data_0_mission_reward_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.LvFrom).HasColumnName("lv_from");

                entity.Property(e => e.LvTo).HasColumnName("lv_to");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("movie");

                entity.HasIndex(e => e.StoryId)
                    .HasName("movie_0_story_id");

                entity.Property(e => e.MovieId)
                    .HasColumnName("movie_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgmId)
                    .IsRequired()
                    .HasColumnName("bgm_id");

                entity.Property(e => e.BgmVolumeRate).HasColumnName("bgm_volume_rate");

                entity.Property(e => e.FadeLoopFlag).HasColumnName("fade_loop_flag");

                entity.Property(e => e.MyPageFlag).HasColumnName("my_page_flag");

                entity.Property(e => e.SeId)
                    .IsRequired()
                    .HasColumnName("se_id");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<MusicContent>(entity =>
            {
                entity.HasKey(e => e.MusicId);

                entity.ToTable("music_content");

                entity.Property(e => e.MusicId)
                    .HasColumnName("music_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CueId)
                    .IsRequired()
                    .HasColumnName("cue_id");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasColumnName("detail");

                entity.Property(e => e.ListenStartTime)
                    .IsRequired()
                    .HasColumnName("listen_start_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.TotalPlayingTime)
                    .IsRequired()
                    .HasColumnName("total_playing_time");
            });

            modelBuilder.Entity<MusicList>(entity =>
            {
                entity.HasKey(e => e.MusicId);

                entity.ToTable("music_list");

                entity.Property(e => e.MusicId)
                    .HasColumnName("music_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AndroidUrl)
                    .IsRequired()
                    .HasColumnName("android_url");

                entity.Property(e => e.CostItemNum).HasColumnName("cost_item_num");

                entity.Property(e => e.DmmUrl)
                    .IsRequired()
                    .HasColumnName("dmm_url");

                entity.Property(e => e.FontSize).HasColumnName("font_size");

                entity.Property(e => e.IosUrl)
                    .IsRequired()
                    .HasColumnName("ios_url");

                entity.Property(e => e.Kana)
                    .IsRequired()
                    .HasColumnName("kana");

                entity.Property(e => e.ListName)
                    .IsRequired()
                    .HasColumnName("list_name");

                entity.Property(e => e.PreShopStart)
                    .IsRequired()
                    .HasColumnName("pre_shop_start");

                entity.Property(e => e.ShopEnd)
                    .IsRequired()
                    .HasColumnName("shop_end");

                entity.Property(e => e.ShopStart)
                    .IsRequired()
                    .HasColumnName("shop_start");

                entity.Property(e => e.Sort).HasColumnName("sort");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<MypageFrame>(entity =>
            {
                entity.HasKey(e => e.FrameId);

                entity.ToTable("mypage_frame");

                entity.HasIndex(e => e.GroupId)
                    .HasName("mypage_frame_0_group_id");

                entity.Property(e => e.FrameId)
                    .HasColumnName("frame_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.FrameName)
                    .IsRequired()
                    .HasColumnName("frame_name");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<MyprofileContent>(entity =>
            {
                entity.ToTable("myprofile_content");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<NaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("navi_comment");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeFaceTime).HasColumnName("change_face_time");

                entity.Property(e => e.ChangeFaceType).HasColumnName("change_face_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasColumnName("character_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.UnlockStoryId).HasColumnName("unlock_story_id");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<NopDramaData>(entity =>
            {
                entity.ToTable("nop_drama_data");

                entity.HasIndex(e => e.StageId)
                    .HasName("nop_drama_data_0_stage_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ColPosY).HasColumnName("col_pos_y");

                entity.Property(e => e.ColSizeX).HasColumnName("col_size_x");

                entity.Property(e => e.ColSizeY).HasColumnName("col_size_y");

                entity.Property(e => e.CreateBackDramaId).HasColumnName("create_back_drama_id");

                entity.Property(e => e.CreateFrontDramaId).HasColumnName("create_front_drama_id");

                entity.Property(e => e.EventDramaId).HasColumnName("event_drama_id");

                entity.Property(e => e.IdleDramaId).HasColumnName("idle_drama_id");

                entity.Property(e => e.PositionId1).HasColumnName("position_id_1");

                entity.Property(e => e.PositionId2).HasColumnName("position_id_2");

                entity.Property(e => e.PositionId3).HasColumnName("position_id_3");

                entity.Property(e => e.StageId).HasColumnName("stage_id");

                entity.Property(e => e.SubStoryId).HasColumnName("sub_story_id");

                entity.Property(e => e.TalkDramaId).HasColumnName("talk_drama_id");

                entity.Property(e => e.TalkPosX).HasColumnName("talk_pos_x");

                entity.Property(e => e.TalkPosY).HasColumnName("talk_pos_y");
            });

            modelBuilder.Entity<NopDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("nop_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("nop_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<NotifData>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.NotifType });

                entity.ToTable("notif_data");

                entity.HasIndex(e => e.UnitId)
                    .HasName("notif_data_0_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.NotifType).HasColumnName("notif_type");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");
            });

            modelBuilder.Entity<NyxDramaData>(entity =>
            {
                entity.HasKey(e => e.DramaId);

                entity.ToTable("nyx_drama_data");

                entity.Property(e => e.DramaId)
                    .HasColumnName("drama_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionLockedStoryId).HasColumnName("condition_locked_story_id");

                entity.Property(e => e.ConditionUnlockedStoryId).HasColumnName("condition_unlocked_story_id");

                entity.Property(e => e.StoryPhase).HasColumnName("story_phase");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<NyxDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("nyx_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("nyx_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<NyxPhaseData>(entity =>
            {
                entity.HasKey(e => e.StoryPhase);

                entity.ToTable("nyx_phase_data");

                entity.Property(e => e.StoryPhase)
                    .HasColumnName("story_phase")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionQuestBoss).HasColumnName("condition_quest_boss");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.PhaseTitle)
                    .IsRequired()
                    .HasColumnName("phase_title");
            });

            modelBuilder.Entity<NyxStoryData>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("nyx_story_data");

                entity.HasIndex(e => e.StoryPhase)
                    .HasName("nyx_story_data_0_story_phase");

                entity.HasIndex(e => e.StorySeq)
                    .HasName("nyx_story_data_0_story_seq");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdvFlg).HasColumnName("adv_flg");

                entity.Property(e => e.AdvId).HasColumnName("adv_id");

                entity.Property(e => e.ConditionBossCount).HasColumnName("condition_boss_count");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.ReadConditionTime)
                    .IsRequired()
                    .HasColumnName("read_condition_time");

                entity.Property(e => e.StoryPhase).HasColumnName("story_phase");

                entity.Property(e => e.StorySeq).HasColumnName("story_seq");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<NyxStoryScript>(entity =>
            {
                entity.ToTable("nyx_story_script");

                entity.HasIndex(e => e.StoryId)
                    .HasName("nyx_story_script_0_story_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<OddsNameData>(entity =>
            {
                entity.ToTable("odds_name_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.IconType).HasColumnName("icon_type");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.OddsFile)
                    .IsRequired()
                    .HasColumnName("odds_file");
            });

            modelBuilder.Entity<OmpDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("omp_drama");

                entity.HasIndex(e => e.DramaId)
                    .HasName("omp_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<OmpStoryData>(entity =>
            {
                entity.HasKey(e => e.OmpStoryId);

                entity.ToTable("omp_story_data");

                entity.HasIndex(e => e.EventId)
                    .HasName("omp_story_data_0_event_id");

                entity.HasIndex(e => e.StorySeq)
                    .HasName("omp_story_data_0_story_seq");

                entity.Property(e => e.OmpStoryId)
                    .HasColumnName("omp_story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IsReadableOnResult).HasColumnName("is_readable_on_result");

                entity.Property(e => e.RewardCount).HasColumnName("reward_count");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.StorySeq).HasColumnName("story_seq");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");
            });

            modelBuilder.Entity<PctComboCoefficient>(entity =>
            {
                entity.ToTable("pct_combo_coefficient");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComboCoefficient).HasColumnName("combo_coefficient");

                entity.Property(e => e.ComboMax).HasColumnName("combo_max");

                entity.Property(e => e.ComboMin).HasColumnName("combo_min");
            });

            modelBuilder.Entity<PctEvaluation>(entity =>
            {
                entity.HasKey(e => e.EvaluationId);

                entity.ToTable("pct_evaluation");

                entity.Property(e => e.EvaluationId)
                    .HasColumnName("evaluation_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EvaluationPoint).HasColumnName("evaluation_point");

                entity.Property(e => e.FeverPoint).HasColumnName("fever_point");

                entity.Property(e => e.MeetWidth).HasColumnName("meet_width");
            });

            modelBuilder.Entity<PctGamingMotion>(entity =>
            {
                entity.HasKey(e => e.MotionId);

                entity.ToTable("pct_gaming_motion");

                entity.Property(e => e.MotionId)
                    .HasColumnName("motion_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GoodCount).HasColumnName("good_count");

                entity.Property(e => e.NiceCount).HasColumnName("nice_count");

                entity.Property(e => e.PerfectCount).HasColumnName("perfect_count");

                entity.Property(e => e.Point).HasColumnName("point");
            });

            modelBuilder.Entity<PctItempoint>(entity =>
            {
                entity.ToTable("pct_itempoint");

                entity.HasIndex(e => e.ItemId)
                    .HasName("pct_itempoint_0_item_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ItemId).HasColumnName("item_id");

                entity.Property(e => e.PctPointCoefficient).HasColumnName("pct_point_coefficient");
            });

            modelBuilder.Entity<PctResult>(entity =>
            {
                entity.ToTable("pct_result");

                entity.HasIndex(e => e.CharacterId)
                    .HasName("pct_result_0_character_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CommentId1).HasColumnName("comment_id_1");

                entity.Property(e => e.CommentId2).HasColumnName("comment_id_2");

                entity.Property(e => e.CommentId3).HasColumnName("comment_id_3");

                entity.Property(e => e.CommentId4).HasColumnName("comment_id_4");

                entity.Property(e => e.CommentId5).HasColumnName("comment_id_5");

                entity.Property(e => e.ScoreFrom).HasColumnName("score_from");

                entity.Property(e => e.ScoreTo).HasColumnName("score_to");
            });

            modelBuilder.Entity<PctReward>(entity =>
            {
                entity.ToTable("pct_reward");

                entity.HasIndex(e => e.PctPointType)
                    .HasName("pct_reward_0_pct_point_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissionDetail)
                    .IsRequired()
                    .HasColumnName("mission_detail");

                entity.Property(e => e.PctPoint).HasColumnName("pct_point");

                entity.Property(e => e.PctPointType).HasColumnName("pct_point_type");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<PctSystem>(entity =>
            {
                entity.ToTable("pct_system");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Chara1).HasColumnName("chara1");

                entity.Property(e => e.Chara1GaugeChoice).HasColumnName("chara1_gauge_choice");

                entity.Property(e => e.Chara2).HasColumnName("chara2");

                entity.Property(e => e.Chara2GaugeChoice).HasColumnName("chara2_gauge_choice");

                entity.Property(e => e.FeverPointMax).HasColumnName("fever_point_max");

                entity.Property(e => e.FeverReventionTime).HasColumnName("fever_revention_time");

                entity.Property(e => e.FeverTime).HasColumnName("fever_time");

                entity.Property(e => e.PctBaseSpeed).HasColumnName("pct_base_speed");

                entity.Property(e => e.PctTime).HasColumnName("pct_time");
            });

            modelBuilder.Entity<PctSystemFruits>(entity =>
            {
                entity.ToTable("pct_system_fruits");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Appearance).HasColumnName("appearance");

                entity.Property(e => e.AppearanceCharaOdds).HasColumnName("appearance_chara_odds");

                entity.Property(e => e.AppearancePattern)
                    .IsRequired()
                    .HasColumnName("appearance_pattern");

                entity.Property(e => e.BarSplit).HasColumnName("bar_split");

                entity.Property(e => e.LastTime).HasColumnName("last_time");

                entity.Property(e => e.WaitTime).HasColumnName("wait_time");
            });

            modelBuilder.Entity<PctTapSpeed>(entity =>
            {
                entity.ToTable("pct_tap_speed");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ComboCount).HasColumnName("combo_count");

                entity.Property(e => e.SpeedMagnification).HasColumnName("speed_magnification");
            });

            modelBuilder.Entity<PkbBatterCondition>(entity =>
            {
                entity.HasKey(e => e.BatterId);

                entity.ToTable("pkb_batter_condition");

                entity.Property(e => e.BatterId)
                    .HasColumnName("batter_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AbilityDetail)
                    .IsRequired()
                    .HasColumnName("ability_detail");

                entity.Property(e => e.AbilityName)
                    .IsRequired()
                    .HasColumnName("ability_name");

                entity.Property(e => e.Critical).HasColumnName("critical");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasColumnName("detail");

                entity.Property(e => e.IsPlayable).HasColumnName("is_playable");

                entity.Property(e => e.Meet).HasColumnName("meet");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.PkbScore).HasColumnName("pkb_score");

                entity.Property(e => e.Power).HasColumnName("power");
            });

            modelBuilder.Entity<PkbDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("pkb_drama");

                entity.HasIndex(e => e.DramaId)
                    .HasName("pkb_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<PkbDramaData>(entity =>
            {
                entity.HasKey(e => e.DramaId);

                entity.ToTable("pkb_drama_data");

                entity.Property(e => e.DramaId)
                    .HasColumnName("drama_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBatterId1).HasColumnName("condition_batter_id_1");

                entity.Property(e => e.ConditionBatterId2).HasColumnName("condition_batter_id_2");

                entity.Property(e => e.ConditionPitcherId1).HasColumnName("condition_pitcher_id_1");

                entity.Property(e => e.ConditionPitcherId2).HasColumnName("condition_pitcher_id_2");
            });

            modelBuilder.Entity<PkbNaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("pkb_navi_comment");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeFaceTime).HasColumnName("change_face_time");

                entity.Property(e => e.ChangeFaceType).HasColumnName("change_face_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasColumnName("character_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<PkbPitcherBallType>(entity =>
            {
                entity.HasKey(e => new { e.PitcherId, e.BallType });

                entity.ToTable("pkb_pitcher_ball_type");

                entity.HasIndex(e => e.PitcherId)
                    .HasName("pkb_pitcher_ball_type_0_pitcher_id");

                entity.Property(e => e.PitcherId).HasColumnName("pitcher_id");

                entity.Property(e => e.BallType).HasColumnName("ball_type");

                entity.Property(e => e.BallTypeName)
                    .IsRequired()
                    .HasColumnName("ball_type_name");
            });

            modelBuilder.Entity<PkbReward>(entity =>
            {
                entity.ToTable("pkb_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissionDetail)
                    .IsRequired()
                    .HasColumnName("mission_detail");

                entity.Property(e => e.PkbScore).HasColumnName("pkb_score");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<PositionSetting>(entity =>
            {
                entity.ToTable("position_setting");

                entity.Property(e => e.PositionSettingId)
                    .HasColumnName("position_setting_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Front).HasColumnName("front");

                entity.Property(e => e.Middle).HasColumnName("middle");
            });

            modelBuilder.Entity<PrizegachaData>(entity =>
            {
                entity.HasKey(e => e.PrizegachaId);

                entity.ToTable("prizegacha_data");

                entity.Property(e => e.PrizegachaId)
                    .HasColumnName("prizegacha_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispPrizeFixedCompensation).HasColumnName("disp_prize_fixed_compensation");

                entity.Property(e => e.GachaPrize1).HasColumnName("gacha_prize1");

                entity.Property(e => e.GachaPrize10).HasColumnName("gacha_prize10");

                entity.Property(e => e.PrizeFixedCompensation).HasColumnName("prize_fixed_compensation");

                entity.Property(e => e.PrizeFixedCompensationQuantity).HasColumnName("prize_fixed_compensation_quantity");

                entity.Property(e => e.PrizeMemoryId1).HasColumnName("prize_memory_id_1");

                entity.Property(e => e.PrizeMemoryId10).HasColumnName("prize_memory_id_10");

                entity.Property(e => e.PrizeMemoryId11).HasColumnName("prize_memory_id_11");

                entity.Property(e => e.PrizeMemoryId12).HasColumnName("prize_memory_id_12");

                entity.Property(e => e.PrizeMemoryId13).HasColumnName("prize_memory_id_13");

                entity.Property(e => e.PrizeMemoryId14).HasColumnName("prize_memory_id_14");

                entity.Property(e => e.PrizeMemoryId15).HasColumnName("prize_memory_id_15");

                entity.Property(e => e.PrizeMemoryId16).HasColumnName("prize_memory_id_16");

                entity.Property(e => e.PrizeMemoryId17).HasColumnName("prize_memory_id_17");

                entity.Property(e => e.PrizeMemoryId18).HasColumnName("prize_memory_id_18");

                entity.Property(e => e.PrizeMemoryId19).HasColumnName("prize_memory_id_19");

                entity.Property(e => e.PrizeMemoryId2).HasColumnName("prize_memory_id_2");

                entity.Property(e => e.PrizeMemoryId20).HasColumnName("prize_memory_id_20");

                entity.Property(e => e.PrizeMemoryId3).HasColumnName("prize_memory_id_3");

                entity.Property(e => e.PrizeMemoryId4).HasColumnName("prize_memory_id_4");

                entity.Property(e => e.PrizeMemoryId5).HasColumnName("prize_memory_id_5");

                entity.Property(e => e.PrizeMemoryId6).HasColumnName("prize_memory_id_6");

                entity.Property(e => e.PrizeMemoryId7).HasColumnName("prize_memory_id_7");

                entity.Property(e => e.PrizeMemoryId8).HasColumnName("prize_memory_id_8");

                entity.Property(e => e.PrizeMemoryId9).HasColumnName("prize_memory_id_9");

                entity.Property(e => e.RarityOdds).HasColumnName("rarity_odds");
            });

            modelBuilder.Entity<PrizegachaSpData>(entity =>
            {
                entity.HasKey(e => new { e.GachaId, e.Rarity });

                entity.ToTable("prizegacha_sp_data");

                entity.HasIndex(e => e.GachaId)
                    .HasName("prizegacha_sp_data_0_gacha_id");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.DispRarity).HasColumnName("disp_rarity");
            });

            modelBuilder.Entity<PrizegachaSpDetail>(entity =>
            {
                entity.HasKey(e => e.DispRarity);

                entity.ToTable("prizegacha_sp_detail");

                entity.Property(e => e.DispRarity)
                    .HasColumnName("disp_rarity")
                    .ValueGeneratedNever();

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<ProfileFrame>(entity =>
            {
                entity.ToTable("profile_frame");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<PromotionBonus>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.PromotionLevel });

                entity.ToTable("promotion_bonus");

                entity.HasIndex(e => e.UnitId)
                    .HasName("promotion_bonus_0_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<PsyDrama>(entity =>
            {
                entity.HasKey(e => e.DramaId);

                entity.ToTable("psy_drama");

                entity.Property(e => e.DramaId)
                    .HasColumnName("drama_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionCharaType).HasColumnName("condition_chara_type");

                entity.Property(e => e.ConditionPsyProduct1).HasColumnName("condition_psy_product_1");

                entity.Property(e => e.ConditionPsyProduct2).HasColumnName("condition_psy_product_2");

                entity.Property(e => e.ConditionPsyProduct3).HasColumnName("condition_psy_product_3");

                entity.Property(e => e.ConditionPsyProduct4).HasColumnName("condition_psy_product_4");

                entity.Property(e => e.ConditionPsyProduct5).HasColumnName("condition_psy_product_5");

                entity.Property(e => e.ConditionTime)
                    .IsRequired()
                    .HasColumnName("condition_time");

                entity.Property(e => e.ConditionTotalEat).HasColumnName("condition_total_eat");

                entity.Property(e => e.ReleasePsyProductId1).HasColumnName("release_psy_product_id_1");

                entity.Property(e => e.ReleasePsyProductId2).HasColumnName("release_psy_product_id_2");

                entity.Property(e => e.ReleasePsyProductId3).HasColumnName("release_psy_product_id_3");

                entity.Property(e => e.ReleasePsyProductId4).HasColumnName("release_psy_product_id_4");

                entity.Property(e => e.ReleasePsyProductId5).HasColumnName("release_psy_product_id_5");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<PsyDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("psy_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("psy_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<PsyNote>(entity =>
            {
                entity.HasKey(e => e.PsyProductId);

                entity.ToTable("psy_note");

                entity.Property(e => e.PsyProductId)
                    .HasColumnName("psy_product_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionFlavor1).HasColumnName("condition_flavor_1");

                entity.Property(e => e.ConditionFlavor2).HasColumnName("condition_flavor_2");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.Flavor1)
                    .IsRequired()
                    .HasColumnName("flavor_1");

                entity.Property(e => e.Flavor2)
                    .IsRequired()
                    .HasColumnName("flavor_2");

                entity.Property(e => e.Flavor3)
                    .IsRequired()
                    .HasColumnName("flavor_3");

                entity.Property(e => e.InitFlg).HasColumnName("init_flg");

                entity.Property(e => e.PsyProductName)
                    .IsRequired()
                    .HasColumnName("psy_product_name");
            });

            modelBuilder.Entity<PsyReward>(entity =>
            {
                entity.ToTable("psy_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionType).HasColumnName("condition_type");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");
            });

            modelBuilder.Entity<QuestAnnihilation>(entity =>
            {
                entity.HasKey(e => new { e.SystemId, e.QuestId });

                entity.ToTable("quest_annihilation");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");

                entity.Property(e => e.EffectType).HasColumnName("effect_type");

                entity.Property(e => e.QuestEffectPosition).HasColumnName("quest_effect_position");

                entity.Property(e => e.SeCueName)
                    .IsRequired()
                    .HasColumnName("se_cue_name");
            });

            modelBuilder.Entity<QuestAreaData>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("quest_area_data");

                entity.Property(e => e.AreaId)
                    .HasColumnName("area_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaDisplayName)
                    .IsRequired()
                    .HasColumnName("area_display_name");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("area_name");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.QueId)
                    .IsRequired()
                    .HasColumnName("que_id");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<QuestConditionData>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("quest_condition_data");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionQuestId1).HasColumnName("condition_quest_id_1");

                entity.Property(e => e.ConditionQuestId2).HasColumnName("condition_quest_id_2");

                entity.Property(e => e.ConditionQuestId3).HasColumnName("condition_quest_id_3");

                entity.Property(e => e.ConditionQuestId4).HasColumnName("condition_quest_id_4");

                entity.Property(e => e.ConditionQuestId5).HasColumnName("condition_quest_id_5");

                entity.Property(e => e.ReleaseQuestId1).HasColumnName("release_quest_id_1");

                entity.Property(e => e.ReleaseQuestId2).HasColumnName("release_quest_id_2");

                entity.Property(e => e.ReleaseQuestId3).HasColumnName("release_quest_id_3");

                entity.Property(e => e.ReleaseQuestId4).HasColumnName("release_quest_id_4");

                entity.Property(e => e.ReleaseQuestId5).HasColumnName("release_quest_id_5");
            });

            modelBuilder.Entity<QuestData>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("quest_data");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddTreasureNum).HasColumnName("add_treasure_num");

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DailyLimit).HasColumnName("daily_limit");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EnemyImage1).HasColumnName("enemy_image_1");

                entity.Property(e => e.EnemyImage2).HasColumnName("enemy_image_2");

                entity.Property(e => e.EnemyImage3).HasColumnName("enemy_image_3");

                entity.Property(e => e.EnemyImage4).HasColumnName("enemy_image_4");

                entity.Property(e => e.EnemyImage5).HasColumnName("enemy_image_5");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.LimitTeamLevel).HasColumnName("limit_team_level");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.Love).HasColumnName("love");

                entity.Property(e => e.LvRewardFlag).HasColumnName("lv_reward_flag");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.RankRewardGroup).HasColumnName("rank_reward_group");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryIdWaveend1).HasColumnName("story_id_waveend_1");

                entity.Property(e => e.StoryIdWaveend2).HasColumnName("story_id_waveend_2");

                entity.Property(e => e.StoryIdWaveend3).HasColumnName("story_id_waveend_3");

                entity.Property(e => e.StoryIdWavestart1).HasColumnName("story_id_wavestart_1");

                entity.Property(e => e.StoryIdWavestart2).HasColumnName("story_id_wavestart_2");

                entity.Property(e => e.StoryIdWavestart3).HasColumnName("story_id_wavestart_3");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.UnitExp).HasColumnName("unit_exp");

                entity.Property(e => e.WaveBgmQueId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_3");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<QuestDefeatNotice>(entity =>
            {
                entity.ToTable("quest_defeat_notice");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.RequiredQuestId).HasColumnName("required_quest_id");

                entity.Property(e => e.RequiredTeamLevel).HasColumnName("required_team_level");
            });

            modelBuilder.Entity<QuestRewardData>(entity =>
            {
                entity.HasKey(e => e.RewardGroupId);

                entity.ToTable("quest_reward_data");

                entity.Property(e => e.RewardGroupId)
                    .HasColumnName("reward_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<Rarity6QuestData>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("rarity_6_quest_data");

                entity.HasIndex(e => e.Rarity6QuestId)
                    .HasName("rarity_6_quest_data_0_rarity_6_quest_id");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.EnemyLocalPositionY1).HasColumnName("enemy_local_position_y_1");

                entity.Property(e => e.EnemyLocalPositionY2).HasColumnName("enemy_local_position_y_2");

                entity.Property(e => e.EnemyLocalPositionY3).HasColumnName("enemy_local_position_y_3");

                entity.Property(e => e.EnemyLocalPositionY4).HasColumnName("enemy_local_position_y_4");

                entity.Property(e => e.EnemyLocalPositionY5).HasColumnName("enemy_local_position_y_5");

                entity.Property(e => e.EnemyPositionX1).HasColumnName("enemy_position_x_1");

                entity.Property(e => e.EnemyPositionX2).HasColumnName("enemy_position_x_2");

                entity.Property(e => e.EnemyPositionX3).HasColumnName("enemy_position_x_3");

                entity.Property(e => e.EnemyPositionX4).HasColumnName("enemy_position_x_4");

                entity.Property(e => e.EnemyPositionX5).HasColumnName("enemy_position_x_5");

                entity.Property(e => e.EnemySize1).HasColumnName("enemy_size_1");

                entity.Property(e => e.EnemySize2).HasColumnName("enemy_size_2");

                entity.Property(e => e.EnemySize3).HasColumnName("enemy_size_3");

                entity.Property(e => e.EnemySize4).HasColumnName("enemy_size_4");

                entity.Property(e => e.EnemySize5).HasColumnName("enemy_size_5");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.Rarity6QuestId).HasColumnName("rarity_6_quest_id");

                entity.Property(e => e.RecommendedLevel).HasColumnName("recommended_level");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardGroupId).HasColumnName("reward_group_id");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.TreasureType).HasColumnName("treasure_type");

                entity.Property(e => e.WaveBgm)
                    .IsRequired()
                    .HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<RecoverStamina>(entity =>
            {
                entity.HasKey(e => e.Count);

                entity.ToTable("recover_stamina");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnName("cost");
            });

            modelBuilder.Entity<RedeemStaticPriceGroup>(entity =>
            {
                entity.HasKey(e => e.ConditionCategory);

                entity.ToTable("redeem_static_price_group");

                entity.Property(e => e.ConditionCategory)
                    .HasColumnName("condition_category")
                    .ValueGeneratedNever();

                entity.Property(e => e.Count).HasColumnName("count");
            });

            modelBuilder.Entity<RedeemUnit>(entity =>
            {
                entity.ToTable("redeem_unit");

                entity.HasIndex(e => e.UnitId)
                    .HasName("redeem_unit_0_unit_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionCategory).HasColumnName("condition_category");

                entity.Property(e => e.ConditionId).HasColumnName("condition_id");

                entity.Property(e => e.ConsumeNum)
                    .IsRequired()
                    .HasColumnName("consume_num");

                entity.Property(e => e.SlotId).HasColumnName("slot_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<RedeemUnitBg>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("redeem_unit_bg");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgId).HasColumnName("bg_id");
            });

            modelBuilder.Entity<ResistData>(entity =>
            {
                entity.HasKey(e => e.ResistStatusId);

                entity.ToTable("resist_data");

                entity.Property(e => e.ResistStatusId)
                    .HasColumnName("resist_status_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Ailment1).HasColumnName("ailment_1");

                entity.Property(e => e.Ailment10).HasColumnName("ailment_10");

                entity.Property(e => e.Ailment11).HasColumnName("ailment_11");

                entity.Property(e => e.Ailment12).HasColumnName("ailment_12");

                entity.Property(e => e.Ailment13).HasColumnName("ailment_13");

                entity.Property(e => e.Ailment14).HasColumnName("ailment_14");

                entity.Property(e => e.Ailment15).HasColumnName("ailment_15");

                entity.Property(e => e.Ailment16).HasColumnName("ailment_16");

                entity.Property(e => e.Ailment17).HasColumnName("ailment_17");

                entity.Property(e => e.Ailment18).HasColumnName("ailment_18");

                entity.Property(e => e.Ailment19).HasColumnName("ailment_19");

                entity.Property(e => e.Ailment2).HasColumnName("ailment_2");

                entity.Property(e => e.Ailment20).HasColumnName("ailment_20");

                entity.Property(e => e.Ailment21).HasColumnName("ailment_21");

                entity.Property(e => e.Ailment22).HasColumnName("ailment_22");

                entity.Property(e => e.Ailment23).HasColumnName("ailment_23");

                entity.Property(e => e.Ailment24).HasColumnName("ailment_24");

                entity.Property(e => e.Ailment25).HasColumnName("ailment_25");

                entity.Property(e => e.Ailment26).HasColumnName("ailment_26");

                entity.Property(e => e.Ailment27).HasColumnName("ailment_27");

                entity.Property(e => e.Ailment28).HasColumnName("ailment_28");

                entity.Property(e => e.Ailment29).HasColumnName("ailment_29");

                entity.Property(e => e.Ailment3).HasColumnName("ailment_3");

                entity.Property(e => e.Ailment30).HasColumnName("ailment_30");

                entity.Property(e => e.Ailment31).HasColumnName("ailment_31");

                entity.Property(e => e.Ailment32).HasColumnName("ailment_32");

                entity.Property(e => e.Ailment33).HasColumnName("ailment_33");

                entity.Property(e => e.Ailment34).HasColumnName("ailment_34");

                entity.Property(e => e.Ailment35).HasColumnName("ailment_35");

                entity.Property(e => e.Ailment36).HasColumnName("ailment_36");

                entity.Property(e => e.Ailment37).HasColumnName("ailment_37");

                entity.Property(e => e.Ailment38).HasColumnName("ailment_38");

                entity.Property(e => e.Ailment39).HasColumnName("ailment_39");

                entity.Property(e => e.Ailment4).HasColumnName("ailment_4");

                entity.Property(e => e.Ailment40).HasColumnName("ailment_40");

                entity.Property(e => e.Ailment41).HasColumnName("ailment_41");

                entity.Property(e => e.Ailment42).HasColumnName("ailment_42");

                entity.Property(e => e.Ailment43).HasColumnName("ailment_43");

                entity.Property(e => e.Ailment44).HasColumnName("ailment_44");

                entity.Property(e => e.Ailment45).HasColumnName("ailment_45");

                entity.Property(e => e.Ailment46).HasColumnName("ailment_46");

                entity.Property(e => e.Ailment47).HasColumnName("ailment_47");

                entity.Property(e => e.Ailment48).HasColumnName("ailment_48");

                entity.Property(e => e.Ailment49).HasColumnName("ailment_49");

                entity.Property(e => e.Ailment5).HasColumnName("ailment_5");

                entity.Property(e => e.Ailment50).HasColumnName("ailment_50");

                entity.Property(e => e.Ailment6).HasColumnName("ailment_6");

                entity.Property(e => e.Ailment7).HasColumnName("ailment_7");

                entity.Property(e => e.Ailment8).HasColumnName("ailment_8");

                entity.Property(e => e.Ailment9).HasColumnName("ailment_9");
            });

            modelBuilder.Entity<ResistVariationData>(entity =>
            {
                entity.HasKey(e => e.ResistVariationId);

                entity.ToTable("resist_variation_data");

                entity.Property(e => e.ResistVariationId)
                    .HasColumnName("resist_variation_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Value1).HasColumnName("value_1");

                entity.Property(e => e.Value2).HasColumnName("value_2");

                entity.Property(e => e.Value3).HasColumnName("value_3");

                entity.Property(e => e.Value4).HasColumnName("value_4");
            });

            modelBuilder.Entity<ReturnSpecialfesBanner>(entity =>
            {
                entity.HasKey(e => e.GachaId);

                entity.ToTable("return_specialfes_banner");

                entity.Property(e => e.GachaId)
                    .HasColumnName("gacha_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BannerId1).HasColumnName("banner_id_1");

                entity.Property(e => e.BannerId10).HasColumnName("banner_id_10");

                entity.Property(e => e.BannerId2).HasColumnName("banner_id_2");

                entity.Property(e => e.BannerId3).HasColumnName("banner_id_3");

                entity.Property(e => e.BannerId4).HasColumnName("banner_id_4");

                entity.Property(e => e.BannerId5).HasColumnName("banner_id_5");

                entity.Property(e => e.BannerId6).HasColumnName("banner_id_6");

                entity.Property(e => e.BannerId7).HasColumnName("banner_id_7");

                entity.Property(e => e.BannerId8).HasColumnName("banner_id_8");

                entity.Property(e => e.BannerId9).HasColumnName("banner_id_9");
            });

            modelBuilder.Entity<RewardCollectGuide>(entity =>
            {
                entity.HasKey(e => e.ObjectId);

                entity.ToTable("reward_collect_guide");

                entity.Property(e => e.ObjectId)
                    .HasColumnName("object_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.QuestId1).HasColumnName("quest_id_1");

                entity.Property(e => e.QuestId10).HasColumnName("quest_id_10");

                entity.Property(e => e.QuestId2).HasColumnName("quest_id_2");

                entity.Property(e => e.QuestId3).HasColumnName("quest_id_3");

                entity.Property(e => e.QuestId4).HasColumnName("quest_id_4");

                entity.Property(e => e.QuestId5).HasColumnName("quest_id_5");

                entity.Property(e => e.QuestId6).HasColumnName("quest_id_6");

                entity.Property(e => e.QuestId7).HasColumnName("quest_id_7");

                entity.Property(e => e.QuestId8).HasColumnName("quest_id_8");

                entity.Property(e => e.QuestId9).HasColumnName("quest_id_9");

                entity.Property(e => e.SystemId1).HasColumnName("system_id_1");

                entity.Property(e => e.SystemId2).HasColumnName("system_id_2");

                entity.Property(e => e.SystemId3).HasColumnName("system_id_3");

                entity.Property(e => e.SystemId4).HasColumnName("system_id_4");

                entity.Property(e => e.SystemId5).HasColumnName("system_id_5");
            });

            modelBuilder.Entity<RoomChange>(entity =>
            {
                entity.HasKey(e => e.RoomItemId);

                entity.ToTable("room_change");

                entity.Property(e => e.RoomItemId)
                    .HasColumnName("room_item_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeEnd)
                    .IsRequired()
                    .HasColumnName("change_end");

                entity.Property(e => e.ChangeId).HasColumnName("change_id");

                entity.Property(e => e.ChangeStart)
                    .IsRequired()
                    .HasColumnName("change_start");
            });

            modelBuilder.Entity<RoomCharacterPersonality>(entity =>
            {
                entity.HasKey(e => e.CharacterId);

                entity.ToTable("room_character_personality");

                entity.Property(e => e.CharacterId)
                    .HasColumnName("character_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PersonalityId).HasColumnName("personality_id");
            });

            modelBuilder.Entity<RoomCharacterSkinColor>(entity =>
            {
                entity.HasKey(e => e.CharacterId);

                entity.ToTable("room_character_skin_color");

                entity.Property(e => e.CharacterId)
                    .HasColumnName("character_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SkinColorId).HasColumnName("skin_color_id");
            });

            modelBuilder.Entity<RoomChatFormation>(entity =>
            {
                entity.ToTable("room_chat_formation");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IgnoreUnitId1).HasColumnName("ignore_unit_id1");

                entity.Property(e => e.IgnoreUnitId2).HasColumnName("ignore_unit_id2");

                entity.Property(e => e.IgnoreUnitId3).HasColumnName("ignore_unit_id3");

                entity.Property(e => e.IgnoreUnitId4).HasColumnName("ignore_unit_id4");

                entity.Property(e => e.IgnoreUnitId5).HasColumnName("ignore_unit_id5");

                entity.Property(e => e.Unit1Dir).HasColumnName("unit_1_dir");

                entity.Property(e => e.Unit1X).HasColumnName("unit_1_x");

                entity.Property(e => e.Unit1Y).HasColumnName("unit_1_y");

                entity.Property(e => e.Unit2Dir).HasColumnName("unit_2_dir");

                entity.Property(e => e.Unit2X).HasColumnName("unit_2_x");

                entity.Property(e => e.Unit2Y).HasColumnName("unit_2_y");

                entity.Property(e => e.Unit3Dir).HasColumnName("unit_3_dir");

                entity.Property(e => e.Unit3X).HasColumnName("unit_3_x");

                entity.Property(e => e.Unit3Y).HasColumnName("unit_3_y");

                entity.Property(e => e.Unit4Dir).HasColumnName("unit_4_dir");

                entity.Property(e => e.Unit4X).HasColumnName("unit_4_x");

                entity.Property(e => e.Unit4Y).HasColumnName("unit_4_y");

                entity.Property(e => e.Unit5Dir).HasColumnName("unit_5_dir");

                entity.Property(e => e.Unit5X).HasColumnName("unit_5_x");

                entity.Property(e => e.Unit5Y).HasColumnName("unit_5_y");

                entity.Property(e => e.UnitId1).HasColumnName("unit_id1");

                entity.Property(e => e.UnitId2).HasColumnName("unit_id2");

                entity.Property(e => e.UnitId3).HasColumnName("unit_id3");

                entity.Property(e => e.UnitId4).HasColumnName("unit_id4");

                entity.Property(e => e.UnitId5).HasColumnName("unit_id5");

                entity.Property(e => e.UnitNum).HasColumnName("unit_num");
            });

            modelBuilder.Entity<RoomChatInfo>(entity =>
            {
                entity.ToTable("room_chat_info");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FormationId).HasColumnName("formation_id");

                entity.Property(e => e.ScenarioId).HasColumnName("scenario_id");
            });

            modelBuilder.Entity<RoomChatScenario>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.ScenarioIdx });

                entity.ToTable("room_chat_scenario");

                entity.HasIndex(e => e.Id)
                    .HasName("room_chat_scenario_0_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ScenarioIdx).HasColumnName("scenario_idx");

                entity.Property(e => e.AffectType).HasColumnName("affect_type");

                entity.Property(e => e.AnimeId).HasColumnName("anime_id");

                entity.Property(e => e.Delay).HasColumnName("delay");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.UnitPosNo).HasColumnName("unit_pos_no");
            });

            modelBuilder.Entity<RoomEffect>(entity =>
            {
                entity.ToTable("room_effect");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Arcade).HasColumnName("arcade");

                entity.Property(e => e.Jukebox).HasColumnName("jukebox");

                entity.Property(e => e.Nebbia).HasColumnName("nebbia");

                entity.Property(e => e.Poster).HasColumnName("poster");

                entity.Property(e => e.RewardGet).HasColumnName("reward_get");

                entity.Property(e => e.Stock).HasColumnName("stock");

                entity.Property(e => e.Vegetable).HasColumnName("vegetable");
            });

            modelBuilder.Entity<RoomEffectRewardGet>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Level });

                entity.ToTable("room_effect_reward_get");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.IncStep).HasColumnName("inc_step");

                entity.Property(e => e.IntervalSecond).HasColumnName("interval_second");

                entity.Property(e => e.MaxCount).HasColumnName("max_count");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.StockMidStep)
                    .IsRequired()
                    .HasColumnName("stock_mid_step");

                entity.Property(e => e.StockMinStep)
                    .IsRequired()
                    .HasColumnName("stock_min_step");
            });

            modelBuilder.Entity<RoomEmotionIcon>(entity =>
            {
                entity.ToTable("room_emotion_icon");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnableAuto).HasColumnName("enable_auto");

                entity.Property(e => e.EnableTap).HasColumnName("enable_tap");
            });

            modelBuilder.Entity<RoomExclusiveCondition>(entity =>
            {
                entity.ToTable("room_exclusive_condition");

                entity.HasIndex(e => e.RoomItemId)
                    .HasName("room_exclusive_condition_0_room_item_id");

                entity.HasIndex(e => e.UnitId)
                    .HasName("room_exclusive_condition_0_unit_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Notification)
                    .IsRequired()
                    .HasColumnName("notification");

                entity.Property(e => e.RoomItemId).HasColumnName("room_item_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<RoomItem>(entity =>
            {
                entity.ToTable("room_item");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.CategoryActionType).HasColumnName("category_action_type");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.CostItemNum).HasColumnName("cost_item_num");

                entity.Property(e => e.EffectId1).HasColumnName("effect_id_1");

                entity.Property(e => e.EnableRemove).HasColumnName("enable_remove");

                entity.Property(e => e.ItemType).HasColumnName("item_type");

                entity.Property(e => e.MaxLevel).HasColumnName("max_level");

                entity.Property(e => e.MaxPossessionNum).HasColumnName("max_possession_num");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.ShopEnd)
                    .IsRequired()
                    .HasColumnName("shop_end");

                entity.Property(e => e.ShopNewDispEnd)
                    .IsRequired()
                    .HasColumnName("shop_new_disp_end");

                entity.Property(e => e.ShopOpenId).HasColumnName("shop_open_id");

                entity.Property(e => e.ShopOpenType).HasColumnName("shop_open_type");

                entity.Property(e => e.ShopOpenValue).HasColumnName("shop_open_value");

                entity.Property(e => e.ShopStart)
                    .IsRequired()
                    .HasColumnName("shop_start");

                entity.Property(e => e.SoldPrice).HasColumnName("sold_price");

                entity.Property(e => e.Sort).HasColumnName("sort");
            });

            modelBuilder.Entity<RoomItemAnnouncement>(entity =>
            {
                entity.ToTable("room_item_announcement");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnnouncementEnd)
                    .IsRequired()
                    .HasColumnName("announcement_end");

                entity.Property(e => e.AnnouncementStart)
                    .IsRequired()
                    .HasColumnName("announcement_start");

                entity.Property(e => e.AnnouncementText)
                    .IsRequired()
                    .HasColumnName("announcement_text");
            });

            modelBuilder.Entity<RoomItemDetail>(entity =>
            {
                entity.HasKey(e => new { e.RoomItemId, e.Level });

                entity.ToTable("room_item_detail");

                entity.HasIndex(e => new { e.LvupTriggerType, e.LvupTriggerId })
                    .HasName("room_item_detail_0_lvup_trigger_type_1_lvup_trigger_id");

                entity.HasIndex(e => new { e.LvupTriggerType2, e.LvupTriggerId2 })
                    .HasName("room_item_detail_0_lvup_trigger_type_2_1_lvup_trigger_id_2");

                entity.Property(e => e.RoomItemId).HasColumnName("room_item_id");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.ItemDetail)
                    .IsRequired()
                    .HasColumnName("item_detail");

                entity.Property(e => e.LvupItem1Id).HasColumnName("lvup_item1_id");

                entity.Property(e => e.LvupItem1Num).HasColumnName("lvup_item1_num");

                entity.Property(e => e.LvupItem1Type).HasColumnName("lvup_item1_type");

                entity.Property(e => e.LvupTime).HasColumnName("lvup_time");

                entity.Property(e => e.LvupTriggerId).HasColumnName("lvup_trigger_id");

                entity.Property(e => e.LvupTriggerId2).HasColumnName("lvup_trigger_id_2");

                entity.Property(e => e.LvupTriggerType).HasColumnName("lvup_trigger_type");

                entity.Property(e => e.LvupTriggerType2).HasColumnName("lvup_trigger_type_2");

                entity.Property(e => e.LvupTriggerValue).HasColumnName("lvup_trigger_value");

                entity.Property(e => e.LvupTriggerValue2).HasColumnName("lvup_trigger_value_2");
            });

            modelBuilder.Entity<RoomItemGetAnnouncement>(entity =>
            {
                entity.ToTable("room_item_get_announcement");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.GetDate)
                    .IsRequired()
                    .HasColumnName("get_date");

                entity.Property(e => e.RoomAnnouncementName)
                    .IsRequired()
                    .HasColumnName("room_announcement_name");

                entity.Property(e => e.RoomItemId).HasColumnName("room_item_id");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<RoomReleaseData>(entity =>
            {
                entity.HasKey(e => e.SystemId);

                entity.ToTable("room_release_data");

                entity.Property(e => e.SystemId)
                    .HasColumnName("system_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");
            });

            modelBuilder.Entity<RoomSetup>(entity =>
            {
                entity.HasKey(e => e.RoomItemId);

                entity.ToTable("room_setup");

                entity.Property(e => e.RoomItemId)
                    .HasColumnName("room_item_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GridHeight).HasColumnName("grid_height");

                entity.Property(e => e.GridWidth).HasColumnName("grid_width");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<RoomSkinColor>(entity =>
            {
                entity.HasKey(e => e.SkinColorId);

                entity.ToTable("room_skin_color");

                entity.Property(e => e.SkinColorId)
                    .HasColumnName("skin_color_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ColorBlue).HasColumnName("color_blue");

                entity.Property(e => e.ColorGreen).HasColumnName("color_green");

                entity.Property(e => e.ColorRed).HasColumnName("color_red");
            });

            modelBuilder.Entity<RoomUnitComments>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.Trigger, e.VoiceId, e.Time });

                entity.ToTable("room_unit_comments");

                entity.HasIndex(e => e.UnitId)
                    .HasName("room_unit_comments_0_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.Trigger).HasColumnName("trigger");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.BelovedStep).HasColumnName("beloved_step");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.FaceId).HasColumnName("face_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InsertWordType).HasColumnName("insert_word_type");
            });

            modelBuilder.Entity<SdNaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("sd_navi_comment");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.MotionType).HasColumnName("motion_type");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<SeasonPack>(entity =>
            {
                entity.ToTable("season_pack");

                entity.HasIndex(e => e.MissionId)
                    .HasName("season_pack_0_mission_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddNum1).HasColumnName("add_num_1");

                entity.Property(e => e.AfterText)
                    .IsRequired()
                    .HasColumnName("after_text");

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionFlg).HasColumnName("condition_flg");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.GiftMessageId).HasColumnName("gift_message_id");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.ItemRecordId).HasColumnName("item_record_id");

                entity.Property(e => e.MissionId).HasColumnName("mission_id");

                entity.Property(e => e.ReceiveText)
                    .IsRequired()
                    .HasColumnName("receive_text");

                entity.Property(e => e.RepurchaseDay).HasColumnName("repurchase_day");

                entity.Property(e => e.RewardRate1).HasColumnName("reward_rate_1");

                entity.Property(e => e.SystemId1).HasColumnName("system_id_1");

                entity.Property(e => e.Term).HasColumnName("term");
            });

            modelBuilder.Entity<SecretDungeonEmblemMission>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("secret_dungeon_emblem_mission");

                entity.Property(e => e.MissionId)
                    .HasColumnName("mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum)
                    .IsRequired()
                    .HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.DungeonAreaId).HasColumnName("dungeon_area_id");

                entity.Property(e => e.EmblemDescription)
                    .IsRequired()
                    .HasColumnName("emblem_description");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionDescription)
                    .IsRequired()
                    .HasColumnName("mission_description");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<SecretDungeonEmblemReward>(entity =>
            {
                entity.ToTable("secret_dungeon_emblem_reward");

                entity.HasIndex(e => e.MissionRewardId)
                    .HasName("secret_dungeon_emblem_reward_0_mission_reward_id");

                entity.HasIndex(e => e.RewardId)
                    .HasName("secret_dungeon_emblem_reward_0_reward_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IconType).HasColumnName("icon_type");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<SecretDungeonEnemyInfo>(entity =>
            {
                entity.HasKey(e => new { e.DungeonAreaId, e.FloorNum });

                entity.ToTable("secret_dungeon_enemy_info");

                entity.Property(e => e.DungeonAreaId).HasColumnName("dungeon_area_id");

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.EnemyName)
                    .IsRequired()
                    .HasColumnName("enemy_name");
            });

            modelBuilder.Entity<SecretDungeonFloorReward>(entity =>
            {
                entity.HasKey(e => new { e.DungeonAreaId, e.ClearCount });

                entity.ToTable("secret_dungeon_floor_reward");

                entity.HasIndex(e => e.DungeonAreaId)
                    .HasName("secret_dungeon_floor_reward_0_dungeon_area_id");

                entity.Property(e => e.DungeonAreaId).HasColumnName("dungeon_area_id");

                entity.Property(e => e.ClearCount).HasColumnName("clear_count");

                entity.Property(e => e.ClearEffectFlag).HasColumnName("clear_effect_flag");

                entity.Property(e => e.IconType).HasColumnName("icon_type");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<SecretDungeonFloorSetting>(entity =>
            {
                entity.ToTable("secret_dungeon_floor_setting");

                entity.HasIndex(e => e.QuestId)
                    .HasName("secret_dungeon_floor_setting_0_quest_id");

                entity.HasIndex(e => new { e.QuestId, e.Mode })
                    .HasName("secret_dungeon_floor_setting_0_quest_id_1_mode");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EnemyId).HasColumnName("enemy_id");

                entity.Property(e => e.EnemyIdentify).HasColumnName("enemy_identify");

                entity.Property(e => e.FloorPositionX).HasColumnName("floor_position_x");

                entity.Property(e => e.FloorPositionY).HasColumnName("floor_position_y");

                entity.Property(e => e.FloorScale).HasColumnName("floor_scale");

                entity.Property(e => e.Mode).HasColumnName("mode");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");
            });

            modelBuilder.Entity<SecretDungeonQuestData>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("secret_dungeon_quest_data");

                entity.HasIndex(e => new { e.DungeonAreaId, e.Difficulty })
                    .HasName("secret_dungeon_quest_data_0_dungeon_area_id_1_difficulty");

                entity.HasIndex(e => new { e.DungeonAreaId, e.FloorNum })
                    .HasName("secret_dungeon_quest_data_0_dungeon_area_id_1_floor_num");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DungeonAreaId).HasColumnName("dungeon_area_id");

                entity.Property(e => e.DungeonQuestDetailBgId).HasColumnName("dungeon_quest_detail_bg_id");

                entity.Property(e => e.DungeonQuestDetailBgPosition).HasColumnName("dungeon_quest_detail_bg_position");

                entity.Property(e => e.DungeonQuestDetailMonsterHeight).HasColumnName("dungeon_quest_detail_monster_height");

                entity.Property(e => e.DungeonQuestDetailMonsterPositionX1).HasColumnName("dungeon_quest_detail_monster_position_x_1");

                entity.Property(e => e.DungeonQuestDetailMonsterPositionX2).HasColumnName("dungeon_quest_detail_monster_position_x_2");

                entity.Property(e => e.DungeonQuestDetailMonsterPositionX3).HasColumnName("dungeon_quest_detail_monster_position_x_3");

                entity.Property(e => e.DungeonQuestDetailMonsterPositionX4).HasColumnName("dungeon_quest_detail_monster_position_x_4");

                entity.Property(e => e.DungeonQuestDetailMonsterPositionX5).HasColumnName("dungeon_quest_detail_monster_position_x_5");

                entity.Property(e => e.DungeonQuestDetailMonsterSize).HasColumnName("dungeon_quest_detail_monster_size");

                entity.Property(e => e.Emax).HasColumnName("emax");

                entity.Property(e => e.EnergyResetFlag).HasColumnName("energy_reset_flag");

                entity.Property(e => e.FixedStartTpRate).HasColumnName("fixed_start_tp_rate");

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.MultiTargetEffectTime).HasColumnName("multi_target_effect_time");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.PartsHpSaveFlag).HasColumnName("parts_hp_save_flag");

                entity.Property(e => e.QuestDetailMonsterScale1).HasColumnName("quest_detail_monster_scale_1");

                entity.Property(e => e.QuestDetailMonsterScale2).HasColumnName("quest_detail_monster_scale_2");

                entity.Property(e => e.QuestDetailMonsterScale3).HasColumnName("quest_detail_monster_scale_3");

                entity.Property(e => e.QuestDetailMonsterScale4).HasColumnName("quest_detail_monster_scale_4");

                entity.Property(e => e.QuestDetailMonsterScale5).HasColumnName("quest_detail_monster_scale_5");

                entity.Property(e => e.QuestType).HasColumnName("quest_type");

                entity.Property(e => e.RewardCoin).HasColumnName("reward_coin");

                entity.Property(e => e.RewardCsc).HasColumnName("reward_csc");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.RewardImage6).HasColumnName("reward_image_6");

                entity.Property(e => e.WaveBgmQueId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmSheetId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<SecretDungeonSchedule>(entity =>
            {
                entity.HasKey(e => e.DungeonAreaId);

                entity.ToTable("secret_dungeon_schedule");

                entity.Property(e => e.DungeonAreaId)
                    .HasColumnName("dungeon_area_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CloseTime)
                    .IsRequired()
                    .HasColumnName("close_time");

                entity.Property(e => e.CountStartTime)
                    .IsRequired()
                    .HasColumnName("count_start_time");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.TeaserTime)
                    .IsRequired()
                    .HasColumnName("teaser_time");
            });

            modelBuilder.Entity<SekaiAddTimesData>(entity =>
            {
                entity.ToTable("sekai_add_times_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddTimes).HasColumnName("add_times");

                entity.Property(e => e.AddTimesLimit).HasColumnName("add_times_limit");

                entity.Property(e => e.AddTimesTime)
                    .IsRequired()
                    .HasColumnName("add_times_time");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.SekaiId).HasColumnName("sekai_id");
            });

            modelBuilder.Entity<SekaiBossDamageRankReward>(entity =>
            {
                entity.ToTable("sekai_boss_damage_rank_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DamageRankId).HasColumnName("damage_rank_id");

                entity.Property(e => e.RankingFrom).HasColumnName("ranking_from");

                entity.Property(e => e.RankingTo).HasColumnName("ranking_to");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<SekaiBossFixReward>(entity =>
            {
                entity.HasKey(e => e.FixRewardId);

                entity.ToTable("sekai_boss_fix_reward");

                entity.Property(e => e.FixRewardId)
                    .HasColumnName("fix_reward_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BossTotalDamage)
                    .IsRequired()
                    .HasColumnName("boss_total_damage");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId10).HasColumnName("reward_id_10");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardId6).HasColumnName("reward_id_6");

                entity.Property(e => e.RewardId7).HasColumnName("reward_id_7");

                entity.Property(e => e.RewardId8).HasColumnName("reward_id_8");

                entity.Property(e => e.RewardId9).HasColumnName("reward_id_9");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum10).HasColumnName("reward_num_10");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardNum6).HasColumnName("reward_num_6");

                entity.Property(e => e.RewardNum7).HasColumnName("reward_num_7");

                entity.Property(e => e.RewardNum8).HasColumnName("reward_num_8");

                entity.Property(e => e.RewardNum9).HasColumnName("reward_num_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");

                entity.Property(e => e.SekaiId).HasColumnName("sekai_id");
            });

            modelBuilder.Entity<SekaiBossMode>(entity =>
            {
                entity.ToTable("sekai_boss_mode");

                entity.Property(e => e.SekaiBossModeId)
                    .HasColumnName("sekai_boss_mode_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.LimitedMana).HasColumnName("limited_mana");

                entity.Property(e => e.QueId)
                    .IsRequired()
                    .HasColumnName("que_id");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestDetailMonsterHeight).HasColumnName("quest_detail_monster_height");

                entity.Property(e => e.QuestDetailMonsterSize).HasColumnName("quest_detail_monster_size");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.RewardGoldCoefficient).HasColumnName("reward_gold_coefficient");

                entity.Property(e => e.ScoreCoefficient).HasColumnName("score_coefficient");

                entity.Property(e => e.SekaiEnemyId).HasColumnName("sekai_enemy_id");

                entity.Property(e => e.SekaiEnemyLevel)
                    .IsRequired()
                    .HasColumnName("sekai_enemy_level");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");
            });

            modelBuilder.Entity<SekaiEnemyParameter>(entity =>
            {
                entity.HasKey(e => e.SekaiEnemyId);

                entity.ToTable("sekai_enemy_parameter");

                entity.Property(e => e.SekaiEnemyId)
                    .HasColumnName("sekai_enemy_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.ExSkillLv1).HasColumnName("ex_skill_lv_1");

                entity.Property(e => e.ExSkillLv2).HasColumnName("ex_skill_lv_2");

                entity.Property(e => e.ExSkillLv3).HasColumnName("ex_skill_lv_3");

                entity.Property(e => e.ExSkillLv4).HasColumnName("ex_skill_lv_4");

                entity.Property(e => e.ExSkillLv5).HasColumnName("ex_skill_lv_5");

                entity.Property(e => e.Hp)
                    .IsRequired()
                    .HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ResistStatusId).HasColumnName("resist_status_id");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<SekaiSchedule>(entity =>
            {
                entity.HasKey(e => e.SekaiId);

                entity.ToTable("sekai_schedule");

                entity.Property(e => e.SekaiId)
                    .HasColumnName("sekai_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountStartTime)
                    .IsRequired()
                    .HasColumnName("count_start_time");

                entity.Property(e => e.DamageRankId).HasColumnName("damage_rank_id");

                entity.Property(e => e.EndLosstime)
                    .IsRequired()
                    .HasColumnName("end_losstime");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.LastSekaiId).HasColumnName("last_sekai_id");

                entity.Property(e => e.ResultEnd)
                    .IsRequired()
                    .HasColumnName("result_end");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.TeaserTime)
                    .IsRequired()
                    .HasColumnName("teaser_time");
            });

            modelBuilder.Entity<SekaiTopData>(entity =>
            {
                entity.ToTable("sekai_top_data");

                entity.HasIndex(e => e.SekaiId)
                    .HasName("sekai_top_data_0_sekai_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BossHpFrom)
                    .IsRequired()
                    .HasColumnName("boss_hp_from");

                entity.Property(e => e.BossHpTo)
                    .IsRequired()
                    .HasColumnName("boss_hp_to");

                entity.Property(e => e.BossMode).HasColumnName("boss_mode");

                entity.Property(e => e.BossTimeFrom)
                    .IsRequired()
                    .HasColumnName("boss_time_from");

                entity.Property(e => e.BossTimeTo)
                    .IsRequired()
                    .HasColumnName("boss_time_to");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Duration).HasColumnName("duration");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QueId)
                    .IsRequired()
                    .HasColumnName("que_id");

                entity.Property(e => e.ScaleRatio).HasColumnName("scale_ratio");

                entity.Property(e => e.SekaiBossModeId).HasColumnName("sekai_boss_mode_id");

                entity.Property(e => e.SekaiId).HasColumnName("sekai_id");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.TopBg).HasColumnName("top_bg");
            });

            modelBuilder.Entity<SekaiTopStoryData>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("sekai_top_story_data");

                entity.HasIndex(e => e.SekaiId)
                    .HasName("sekai_top_story_data_0_sekai_id");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BossTimeFrom)
                    .IsRequired()
                    .HasColumnName("boss_time_from");

                entity.Property(e => e.BossTimeTo)
                    .IsRequired()
                    .HasColumnName("boss_time_to");

                entity.Property(e => e.SekaiId).HasColumnName("sekai_id");
            });

            modelBuilder.Entity<SekaiUnlockStoryCondition>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("sekai_unlock_story_condition");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionEntry).HasColumnName("condition_entry");

                entity.Property(e => e.ConditionFixRewardId).HasColumnName("condition_fix_reward_id");

                entity.Property(e => e.ConditionTime)
                    .IsRequired()
                    .HasColumnName("condition_time");

                entity.Property(e => e.SekaiId).HasColumnName("sekai_id");
            });

            modelBuilder.Entity<SerialCodeData>(entity =>
            {
                entity.HasKey(e => e.SerialCampaignId);

                entity.ToTable("serial_code_data");

                entity.Property(e => e.SerialCampaignId)
                    .HasColumnName("serial_campaign_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasColumnName("campaign_name");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.LimitNum).HasColumnName("limit_num");

                entity.Property(e => e.SerialGroupId).HasColumnName("serial_group_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<SerialGroupData>(entity =>
            {
                entity.HasKey(e => e.SerialGroupId);

                entity.ToTable("serial_group_data");

                entity.Property(e => e.SerialGroupId)
                    .HasColumnName("serial_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CampaignName)
                    .IsRequired()
                    .HasColumnName("campaign_name");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.SerialCampaignId1).HasColumnName("serial_campaign_id_1");

                entity.Property(e => e.SerialCampaignId2).HasColumnName("serial_campaign_id_2");

                entity.Property(e => e.SerialCampaignId3).HasColumnName("serial_campaign_id_3");

                entity.Property(e => e.SerialCampaignId4).HasColumnName("serial_campaign_id_4");

                entity.Property(e => e.SerialCampaignId5).HasColumnName("serial_campaign_id_5");

                entity.Property(e => e.SerialCampaignId6).HasColumnName("serial_campaign_id_6");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<SeriesUnlockCondition>(entity =>
            {
                entity.HasKey(e => e.SequelEventId);

                entity.ToTable("series_unlock_condition");

                entity.Property(e => e.SequelEventId)
                    .HasColumnName("sequel_event_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionEventId).HasColumnName("condition_event_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.ConditionStoryId1).HasColumnName("condition_story_id_1");

                entity.Property(e => e.ConditionStoryId2).HasColumnName("condition_story_id_2");
            });

            modelBuilder.Entity<ShioriBattleMissionData>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("shiori_battle_mission_data");

                entity.Property(e => e.MissionId)
                    .HasColumnName("mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue10).HasColumnName("condition_value_10");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.ConditionValue6).HasColumnName("condition_value_6");

                entity.Property(e => e.ConditionValue7).HasColumnName("condition_value_7");

                entity.Property(e => e.ConditionValue8).HasColumnName("condition_value_8");

                entity.Property(e => e.ConditionValue9).HasColumnName("condition_value_9");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<ShioriBoss>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("shiori_boss");

                entity.HasIndex(e => e.EventId)
                    .HasName("shiori_boss_0_event_id");

                entity.HasIndex(e => e.WaveGroupId1)
                    .HasName("shiori_boss_0_wave_group_id_1");

                entity.HasIndex(e => new { e.EventId, e.Difficulty })
                    .HasName("shiori_boss_0_event_id_1_difficulty");

                entity.Property(e => e.BossId)
                    .HasColumnName("boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.BossPositionX).HasColumnName("boss_position_x");

                entity.Property(e => e.BossPositionY).HasColumnName("boss_position_y");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DeatailAuraSize).HasColumnName("deatail_aura_size");

                entity.Property(e => e.DetailBgId).HasColumnName("detail_bg_id");

                entity.Property(e => e.DetailBgPosition).HasColumnName("detail_bg_position");

                entity.Property(e => e.DetailBossBgHeight).HasColumnName("detail_boss_bg_height");

                entity.Property(e => e.DetailBossBgSize).HasColumnName("detail_boss_bg_size");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispOnBg).HasColumnName("disp_on_bg");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IconColliderScale).HasColumnName("icon_collider_scale");

                entity.Property(e => e.IconDisplayScale).HasColumnName("icon_display_scale");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.MapArrowOffset).HasColumnName("map_arrow_offset");

                entity.Property(e => e.MapAuraSize).HasColumnName("map_aura_size");

                entity.Property(e => e.MapPositionX).HasColumnName("map_position_x");

                entity.Property(e => e.MapPositionY).HasColumnName("map_position_y");

                entity.Property(e => e.MapSize).HasColumnName("map_size");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QdMode).HasColumnName("qd_mode");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.StoryIdWaveend1).HasColumnName("story_id_waveend_1");

                entity.Property(e => e.StoryIdWavestart1).HasColumnName("story_id_wavestart_1");

                entity.Property(e => e.WaveBgmQueId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmSheetId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");
            });

            modelBuilder.Entity<ShioriBossCondition>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("shiori_boss_condition");

                entity.Property(e => e.BossId)
                    .HasColumnName("boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ReleaseBossId).HasColumnName("release_boss_id");

                entity.Property(e => e.ReleaseQuestId).HasColumnName("release_quest_id");
            });

            modelBuilder.Entity<ShioriDescription>(entity =>
            {
                entity.ToTable("shiori_description");

                entity.HasIndex(e => e.Type)
                    .HasName("shiori_description_0_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<ShioriEnemyParameter>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("shiori_enemy_parameter");

                entity.Property(e => e.EnemyId)
                    .HasColumnName("enemy_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.ExSkillLv1).HasColumnName("ex_skill_lv_1");

                entity.Property(e => e.ExSkillLv2).HasColumnName("ex_skill_lv_2");

                entity.Property(e => e.ExSkillLv3).HasColumnName("ex_skill_lv_3");

                entity.Property(e => e.ExSkillLv4).HasColumnName("ex_skill_lv_4");

                entity.Property(e => e.ExSkillLv5).HasColumnName("ex_skill_lv_5");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ResistStatusId).HasColumnName("resist_status_id");

                entity.Property(e => e.ResistVariationId).HasColumnName("resist_variation_id");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<ShioriEventList>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("shiori_event_list");

                entity.HasIndex(e => e.OriginalEventId)
                    .HasName("shiori_event_list_0_original_event_id");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionCharaId).HasColumnName("condition_chara_id");

                entity.Property(e => e.ConditionMainQuestId).HasColumnName("condition_main_quest_id");

                entity.Property(e => e.ConditionShioriQuestId).HasColumnName("condition_shiori_quest_id");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.GojuonOrder).HasColumnName("gojuon_order");

                entity.Property(e => e.HelpIndex)
                    .IsRequired()
                    .HasColumnName("help_index");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.OriginalStartTime)
                    .IsRequired()
                    .HasColumnName("original_start_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<ShioriItem>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("shiori_item");

                entity.Property(e => e.EventId)
                    .HasColumnName("event_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UnitMaterialId1).HasColumnName("unit_material_id_1");

                entity.Property(e => e.UnitMaterialId2).HasColumnName("unit_material_id_2");
            });

            modelBuilder.Entity<ShioriMissionRewardData>(entity =>
            {
                entity.ToTable("shiori_mission_reward_data");

                entity.HasIndex(e => e.MissionRewardId)
                    .HasName("shiori_mission_reward_data_0_mission_reward_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<ShioriQuest>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("shiori_quest");

                entity.HasIndex(e => e.DropRewardId)
                    .HasName("shiori_quest_0_drop_reward_id");

                entity.HasIndex(e => e.EventId)
                    .HasName("shiori_quest_0_event_id");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DailyLimit).HasColumnName("daily_limit");

                entity.Property(e => e.DropRewardId).HasColumnName("drop_reward_id");

                entity.Property(e => e.DropRewardNum).HasColumnName("drop_reward_num");

                entity.Property(e => e.DropRewardOdds).HasColumnName("drop_reward_odds");

                entity.Property(e => e.DropRewardType).HasColumnName("drop_reward_type");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.IconOffsetX).HasColumnName("icon_offset_x");

                entity.Property(e => e.IconOffsetY).HasColumnName("icon_offset_y");

                entity.Property(e => e.IconScale).HasColumnName("icon_scale");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.Love).HasColumnName("love");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.QuestSeq).HasColumnName("quest_seq");

                entity.Property(e => e.RankRewardGroup).HasColumnName("rank_reward_group");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.StoryIdWaveend1).HasColumnName("story_id_waveend_1");

                entity.Property(e => e.StoryIdWaveend2).HasColumnName("story_id_waveend_2");

                entity.Property(e => e.StoryIdWaveend3).HasColumnName("story_id_waveend_3");

                entity.Property(e => e.StoryIdWavestart1).HasColumnName("story_id_wavestart_1");

                entity.Property(e => e.StoryIdWavestart2).HasColumnName("story_id_wavestart_2");

                entity.Property(e => e.StoryIdWavestart3).HasColumnName("story_id_wavestart_3");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.UnitExp).HasColumnName("unit_exp");

                entity.Property(e => e.WaveBgmQueId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_3");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<ShioriQuestArea>(entity =>
            {
                entity.HasKey(e => e.AreaId);

                entity.ToTable("shiori_quest_area");

                entity.HasIndex(e => e.EventId)
                    .HasName("shiori_quest_area_0_event_id");

                entity.Property(e => e.AreaId)
                    .HasColumnName("area_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalEffect).HasColumnName("additional_effect");

                entity.Property(e => e.AreaDisp).HasColumnName("area_disp");

                entity.Property(e => e.AreaName)
                    .IsRequired()
                    .HasColumnName("area_name");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MapId).HasColumnName("map_id");

                entity.Property(e => e.MapType).HasColumnName("map_type");

                entity.Property(e => e.OpenTutorialId).HasColumnName("open_tutorial_id");

                entity.Property(e => e.QueId)
                    .IsRequired()
                    .HasColumnName("que_id");

                entity.Property(e => e.ScrollHeight).HasColumnName("scroll_height");

                entity.Property(e => e.ScrollWidth).HasColumnName("scroll_width");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.TutorialParam1)
                    .IsRequired()
                    .HasColumnName("tutorial_param_1");

                entity.Property(e => e.TutorialParam2)
                    .IsRequired()
                    .HasColumnName("tutorial_param_2");
            });

            modelBuilder.Entity<ShioriQuestCondition>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("shiori_quest_condition");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionMainQuestId).HasColumnName("condition_main_quest_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ReleaseBossId).HasColumnName("release_boss_id");

                entity.Property(e => e.ReleaseQuestId).HasColumnName("release_quest_id");
            });

            modelBuilder.Entity<ShioriStationaryMissionData>(entity =>
            {
                entity.HasKey(e => e.StationaryMissionId);

                entity.ToTable("shiori_stationary_mission_data");

                entity.Property(e => e.StationaryMissionId)
                    .HasColumnName("stationary_mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<ShioriUnlockUnitCondition>(entity =>
            {
                entity.ToTable("shiori_unlock_unit_condition");

                entity.HasIndex(e => e.ConditionMissionId)
                    .HasName("shiori_unlock_unit_condition_0_condition_mission_id");

                entity.HasIndex(e => new { e.UnitId, e.EventId })
                    .HasName("shiori_unlock_unit_condition_0_unit_id_1_event_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionMissionId).HasColumnName("condition_mission_id");

                entity.Property(e => e.Description1)
                    .IsRequired()
                    .HasColumnName("description_1");

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("description_2");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.TopDescription)
                    .IsRequired()
                    .HasColumnName("top_description");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<ShioriWaveGroupData>(entity =>
            {
                entity.HasKey(e => e.WaveGroupId);

                entity.ToTable("shiori_wave_group_data");

                entity.Property(e => e.WaveGroupId)
                    .HasColumnName("wave_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.DispRewardId1).HasColumnName("disp_reward_id_1");

                entity.Property(e => e.DispRewardId2).HasColumnName("disp_reward_id_2");

                entity.Property(e => e.DispRewardId3).HasColumnName("disp_reward_id_3");

                entity.Property(e => e.DispRewardId4).HasColumnName("disp_reward_id_4");

                entity.Property(e => e.DispRewardId5).HasColumnName("disp_reward_id_5");

                entity.Property(e => e.DispRewardType1).HasColumnName("disp_reward_type_1");

                entity.Property(e => e.DispRewardType2).HasColumnName("disp_reward_type_2");

                entity.Property(e => e.DispRewardType3).HasColumnName("disp_reward_type_3");

                entity.Property(e => e.DispRewardType4).HasColumnName("disp_reward_type_4");

                entity.Property(e => e.DispRewardType5).HasColumnName("disp_reward_type_5");

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.RewardGroupId1).HasColumnName("reward_group_id_1");

                entity.Property(e => e.RewardGroupId2).HasColumnName("reward_group_id_2");

                entity.Property(e => e.RewardGroupId3).HasColumnName("reward_group_id_3");

                entity.Property(e => e.RewardGroupId4).HasColumnName("reward_group_id_4");

                entity.Property(e => e.RewardGroupId5).HasColumnName("reward_group_id_5");

                entity.Property(e => e.RewardLotCount1).HasColumnName("reward_lot_count_1");

                entity.Property(e => e.RewardLotCount2).HasColumnName("reward_lot_count_2");

                entity.Property(e => e.RewardLotCount3).HasColumnName("reward_lot_count_3");

                entity.Property(e => e.RewardLotCount4).HasColumnName("reward_lot_count_4");

                entity.Property(e => e.RewardLotCount5).HasColumnName("reward_lot_count_5");

                entity.Property(e => e.RewardOdds1).HasColumnName("reward_odds_1");

                entity.Property(e => e.RewardOdds2).HasColumnName("reward_odds_2");

                entity.Property(e => e.RewardOdds3).HasColumnName("reward_odds_3");

                entity.Property(e => e.RewardOdds4).HasColumnName("reward_odds_4");

                entity.Property(e => e.RewardOdds5).HasColumnName("reward_odds_5");

                entity.Property(e => e.Wave).HasColumnName("wave");
            });

            modelBuilder.Entity<ShopStaticPriceGroup>(entity =>
            {
                entity.ToTable("shop_static_price_group");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BuyCountFrom).HasColumnName("buy_count_from");

                entity.Property(e => e.BuyCountTo).HasColumnName("buy_count_to");

                entity.Property(e => e.Count).HasColumnName("count");

                entity.Property(e => e.PriceGroupId).HasColumnName("price_group_id");
            });

            modelBuilder.Entity<SjrChara>(entity =>
            {
                entity.ToTable("sjr_chara");

                entity.Property(e => e.SjrCharaId)
                    .HasColumnName("sjr_chara_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Personality).HasColumnName("personality");

                entity.Property(e => e.ProperId).HasColumnName("proper_id");

                entity.Property(e => e.RecommendType1).HasColumnName("recommend_type_1");

                entity.Property(e => e.RecommendType2).HasColumnName("recommend_type_2");

                entity.Property(e => e.RecommendType3).HasColumnName("recommend_type_3");

                entity.Property(e => e.ResumeTime).HasColumnName("resume_time");

                entity.Property(e => e.Speed).HasColumnName("speed");

                entity.Property(e => e.Spring).HasColumnName("spring");

                entity.Property(e => e.TiredCoefficient).HasColumnName("tired_coefficient");

                entity.Property(e => e.TpLength).HasColumnName("tp_length");

                entity.Property(e => e.UbId).HasColumnName("ub_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<SjrCourse>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("sjr_course");

                entity.Property(e => e.CourseId)
                    .HasColumnName("course_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DifficultyLevel).HasColumnName("difficulty_level");

                entity.Property(e => e.Feature).HasColumnName("feature");

                entity.Property(e => e.Length).HasColumnName("length");

                entity.Property(e => e.PeekPos).HasColumnName("peek_pos");

                entity.Property(e => e.Rail1).HasColumnName("rail_1");

                entity.Property(e => e.Rail2).HasColumnName("rail_2");

                entity.Property(e => e.Rail3).HasColumnName("rail_3");

                entity.Property(e => e.Time).HasColumnName("time");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SjrDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("sjr_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("sjr_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<SjrEmblem>(entity =>
            {
                entity.HasKey(e => e.EmblemId);

                entity.ToTable("sjr_emblem");

                entity.Property(e => e.EmblemId)
                    .HasColumnName("emblem_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");
            });

            modelBuilder.Entity<SjrFeatureGroup>(entity =>
            {
                entity.HasKey(e => e.FeatureId);

                entity.ToTable("sjr_feature_group");

                entity.Property(e => e.FeatureId)
                    .HasColumnName("feature_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupId).HasColumnName("group_id");
            });

            modelBuilder.Entity<SjrNameFormer>(entity =>
            {
                entity.ToTable("sjr_name_former");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionType1).HasColumnName("condition_type_1");

                entity.Property(e => e.ConditionType2).HasColumnName("condition_type_2");

                entity.Property(e => e.ConditionType3).HasColumnName("condition_type_3");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConstrainGroup).HasColumnName("constrain_group");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");
            });

            modelBuilder.Entity<SjrNameLater>(entity =>
            {
                entity.ToTable("sjr_name_later");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.NameGroup).HasColumnName("name_group");

                entity.Property(e => e.ScoreFrom).HasColumnName("score_from");

                entity.Property(e => e.ScoreTo).HasColumnName("score_to");
            });

            modelBuilder.Entity<SjrNpcActionOdds>(entity =>
            {
                entity.ToTable("sjr_npc_action_odds");

                entity.HasIndex(e => e.ActionOddsId)
                    .HasName("sjr_npc_action_odds_0_action_odds_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionOddsId).HasColumnName("action_odds_id");

                entity.Property(e => e.Angle).HasColumnName("angle");

                entity.Property(e => e.Distance).HasColumnName("distance");

                entity.Property(e => e.Rate).HasColumnName("rate");
            });

            modelBuilder.Entity<SjrParameterEvaluation>(entity =>
            {
                entity.HasKey(e => e.ParameterType);

                entity.ToTable("sjr_parameter_evaluation");

                entity.Property(e => e.ParameterType)
                    .HasColumnName("parameter_type")
                    .ValueGeneratedNever();

                entity.Property(e => e.Border1).HasColumnName("border_1");

                entity.Property(e => e.Border2).HasColumnName("border_2");

                entity.Property(e => e.Border3).HasColumnName("border_3");
            });

            modelBuilder.Entity<SjrProperEvaluation>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("sjr_proper_evaluation");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Border1).HasColumnName("border_1");

                entity.Property(e => e.Border2).HasColumnName("border_2");
            });

            modelBuilder.Entity<SjrProperFeature>(entity =>
            {
                entity.HasKey(e => e.ProperId);

                entity.ToTable("sjr_proper_feature");

                entity.Property(e => e.ProperId)
                    .HasColumnName("proper_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FeatureGroup1).HasColumnName("feature_group_1");

                entity.Property(e => e.FeatureGroup2).HasColumnName("feature_group_2");

                entity.Property(e => e.FeatureGroup3).HasColumnName("feature_group_3");

                entity.Property(e => e.Value1).HasColumnName("value_1");

                entity.Property(e => e.Value2).HasColumnName("value_2");

                entity.Property(e => e.Value3).HasColumnName("value_3");
            });

            modelBuilder.Entity<SjrRail>(entity =>
            {
                entity.ToTable("sjr_rail");

                entity.HasIndex(e => e.RailId)
                    .HasName("sjr_rail_0_rail_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GimmickId).HasColumnName("gimmick_id");

                entity.Property(e => e.GimmickPos).HasColumnName("gimmick_pos");

                entity.Property(e => e.RailId).HasColumnName("rail_id");
            });

            modelBuilder.Entity<SjrReward>(entity =>
            {
                entity.ToTable("sjr_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissionDetail)
                    .IsRequired()
                    .HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.SjrScore).HasColumnName("sjr_score");
            });

            modelBuilder.Entity<SjrScore>(entity =>
            {
                entity.HasKey(e => new { e.Round, e.Type });

                entity.ToTable("sjr_score");

                entity.Property(e => e.Round).HasColumnName("round");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.ActionScore).HasColumnName("action_score");

                entity.Property(e => e.ExtraBonus).HasColumnName("extra_bonus");

                entity.Property(e => e.FirstScore).HasColumnName("first_score");

                entity.Property(e => e.HardBonus).HasColumnName("hard_bonus");

                entity.Property(e => e.NormalBonus).HasColumnName("normal_bonus");

                entity.Property(e => e.SecondScore).HasColumnName("second_score");

                entity.Property(e => e.ThirdScore).HasColumnName("third_score");

                entity.Property(e => e.TimeScore).HasColumnName("time_score");
            });

            modelBuilder.Entity<SjrUbData>(entity =>
            {
                entity.HasKey(e => e.UbId);

                entity.ToTable("sjr_ub_data");

                entity.Property(e => e.UbId)
                    .HasColumnName("ub_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.InGameDescription)
                    .IsRequired()
                    .HasColumnName("in_game_description");

                entity.Property(e => e.TopDescription)
                    .IsRequired()
                    .HasColumnName("top_description");

                entity.Property(e => e.UbType).HasColumnName("ub_type");

                entity.Property(e => e.UbValue1).HasColumnName("ub_value_1");

                entity.Property(e => e.UbValue2).HasColumnName("ub_value_2");

                entity.Property(e => e.UbValue3).HasColumnName("ub_value_3");

                entity.Property(e => e.UbValue4).HasColumnName("ub_value_4");
            });

            modelBuilder.Entity<SkeStoryData>(entity =>
            {
                entity.HasKey(e => e.SubStoryId);

                entity.ToTable("ske_story_data");

                entity.HasIndex(e => e.OriginalEventId)
                    .HasName("ske_story_data_0_original_event_id");

                entity.Property(e => e.SubStoryId)
                    .HasColumnName("sub_story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.ReadConditionEventStoryId).HasColumnName("read_condition_event_story_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.UnlockConditionBossId).HasColumnName("unlock_condition_boss_id");

                entity.Property(e => e.UnlockConditionQuestId).HasColumnName("unlock_condition_quest_id");
            });

            modelBuilder.Entity<SkeStoryScript>(entity =>
            {
                entity.ToTable("ske_story_script");

                entity.HasIndex(e => e.StoryId)
                    .HasName("ske_story_script_0_story_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<SkillAction>(entity =>
            {
                entity.HasKey(e => e.ActionId);

                entity.ToTable("skill_action");

                entity.Property(e => e.ActionId)
                    .HasColumnName("action_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionDetail1).HasColumnName("action_detail_1");

                entity.Property(e => e.ActionDetail2).HasColumnName("action_detail_2");

                entity.Property(e => e.ActionDetail3).HasColumnName("action_detail_3");

                entity.Property(e => e.ActionType).HasColumnName("action_type");

                entity.Property(e => e.ActionValue1).HasColumnName("action_value_1");

                entity.Property(e => e.ActionValue2).HasColumnName("action_value_2");

                entity.Property(e => e.ActionValue3).HasColumnName("action_value_3");

                entity.Property(e => e.ActionValue4).HasColumnName("action_value_4");

                entity.Property(e => e.ActionValue5).HasColumnName("action_value_5");

                entity.Property(e => e.ActionValue6).HasColumnName("action_value_6");

                entity.Property(e => e.ActionValue7).HasColumnName("action_value_7");

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.LevelUpDisp)
                    .IsRequired()
                    .HasColumnName("level_up_disp");

                entity.Property(e => e.TargetArea).HasColumnName("target_area");

                entity.Property(e => e.TargetAssignment).HasColumnName("target_assignment");

                entity.Property(e => e.TargetCount).HasColumnName("target_count");

                entity.Property(e => e.TargetNumber).HasColumnName("target_number");

                entity.Property(e => e.TargetRange).HasColumnName("target_range");

                entity.Property(e => e.TargetType).HasColumnName("target_type");
            });

            modelBuilder.Entity<SkillCost>(entity =>
            {
                entity.HasKey(e => e.TargetLevel);

                entity.ToTable("skill_cost");

                entity.Property(e => e.TargetLevel)
                    .HasColumnName("target_level")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnName("cost");
            });

            modelBuilder.Entity<SkillData>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("skill_data");

                entity.Property(e => e.SkillId)
                    .HasColumnName("skill_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Action1).HasColumnName("action_1");

                entity.Property(e => e.Action2).HasColumnName("action_2");

                entity.Property(e => e.Action3).HasColumnName("action_3");

                entity.Property(e => e.Action4).HasColumnName("action_4");

                entity.Property(e => e.Action5).HasColumnName("action_5");

                entity.Property(e => e.Action6).HasColumnName("action_6");

                entity.Property(e => e.Action7).HasColumnName("action_7");

                entity.Property(e => e.BossUbCoolTime).HasColumnName("boss_ub_cool_time");

                entity.Property(e => e.DependAction1).HasColumnName("depend_action_1");

                entity.Property(e => e.DependAction2).HasColumnName("depend_action_2");

                entity.Property(e => e.DependAction3).HasColumnName("depend_action_3");

                entity.Property(e => e.DependAction4).HasColumnName("depend_action_4");

                entity.Property(e => e.DependAction5).HasColumnName("depend_action_5");

                entity.Property(e => e.DependAction6).HasColumnName("depend_action_6");

                entity.Property(e => e.DependAction7).HasColumnName("depend_action_7");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.IconType).HasColumnName("icon_type");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.SkillAreaWidth).HasColumnName("skill_area_width");

                entity.Property(e => e.SkillCastTime).HasColumnName("skill_cast_time");

                entity.Property(e => e.SkillType).HasColumnName("skill_type");
            });

            modelBuilder.Entity<SkipBossData>(entity =>
            {
                entity.HasKey(e => e.BossId);

                entity.ToTable("skip_boss_data");

                entity.Property(e => e.BossId)
                    .HasColumnName("boss_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SkipBgId).HasColumnName("skip_bg_id");

                entity.Property(e => e.SkipMotionId).HasColumnName("skip_motion_id");

                entity.Property(e => e.SkipPositionX).HasColumnName("skip_position_x");

                entity.Property(e => e.SkipPositionY).HasColumnName("skip_position_y");

                entity.Property(e => e.SkipScaleX).HasColumnName("skip_scale_x");

                entity.Property(e => e.SkipScaleY).HasColumnName("skip_scale_y");
            });

            modelBuilder.Entity<SkipMonsterData>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("skip_monster_data");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.BgSkipId).HasColumnName("bg_skip_id");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");
            });

            modelBuilder.Entity<SpBattleVoice>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.UnitId });

                entity.ToTable("sp_battle_voice");

                entity.HasIndex(e => e.UnitId)
                    .HasName("sp_battle_voice_0_unit_id");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.Value).HasColumnName("value");

                entity.Property(e => e.VoiceType).HasColumnName("voice_type");
            });

            modelBuilder.Entity<SpDetailVoice>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("sp_detail_voice");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CueName1)
                    .IsRequired()
                    .HasColumnName("cue_name_1");

                entity.Property(e => e.CueName2)
                    .IsRequired()
                    .HasColumnName("cue_name_2");

                entity.Property(e => e.CueName3)
                    .IsRequired()
                    .HasColumnName("cue_name_3");

                entity.Property(e => e.CueName4)
                    .IsRequired()
                    .HasColumnName("cue_name_4");

                entity.Property(e => e.CueName5)
                    .IsRequired()
                    .HasColumnName("cue_name_5");
            });

            modelBuilder.Entity<SpLoseVoice>(entity =>
            {
                entity.HasKey(e => e.OriginalUnitId);

                entity.ToTable("sp_lose_voice");

                entity.Property(e => e.OriginalUnitId)
                    .HasColumnName("original_unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SpeakerUnitId1).HasColumnName("speaker_unit_id_1");

                entity.Property(e => e.SpeakerUnitId10).HasColumnName("speaker_unit_id_10");

                entity.Property(e => e.SpeakerUnitId2).HasColumnName("speaker_unit_id_2");

                entity.Property(e => e.SpeakerUnitId3).HasColumnName("speaker_unit_id_3");

                entity.Property(e => e.SpeakerUnitId4).HasColumnName("speaker_unit_id_4");

                entity.Property(e => e.SpeakerUnitId5).HasColumnName("speaker_unit_id_5");

                entity.Property(e => e.SpeakerUnitId6).HasColumnName("speaker_unit_id_6");

                entity.Property(e => e.SpeakerUnitId7).HasColumnName("speaker_unit_id_7");

                entity.Property(e => e.SpeakerUnitId8).HasColumnName("speaker_unit_id_8");

                entity.Property(e => e.SpeakerUnitId9).HasColumnName("speaker_unit_id_9");

                entity.Property(e => e.Unit1Clip).HasColumnName("unit_1_clip");

                entity.Property(e => e.Unit1Depth).HasColumnName("unit_1_depth");

                entity.Property(e => e.Unit1PosX).HasColumnName("unit_1_pos_x");

                entity.Property(e => e.Unit1PosY).HasColumnName("unit_1_pos_y");

                entity.Property(e => e.Unit2Clip).HasColumnName("unit_2_clip");

                entity.Property(e => e.Unit2Depth).HasColumnName("unit_2_depth");

                entity.Property(e => e.Unit2PosX).HasColumnName("unit_2_pos_x");

                entity.Property(e => e.Unit2PosY).HasColumnName("unit_2_pos_y");

                entity.Property(e => e.Unit3Clip).HasColumnName("unit_3_clip");

                entity.Property(e => e.Unit3Depth).HasColumnName("unit_3_depth");

                entity.Property(e => e.Unit3PosX).HasColumnName("unit_3_pos_x");

                entity.Property(e => e.Unit3PosY).HasColumnName("unit_3_pos_y");

                entity.Property(e => e.UnitId1).HasColumnName("unit_id_1");

                entity.Property(e => e.UnitId2).HasColumnName("unit_id_2");

                entity.Property(e => e.UnitId3).HasColumnName("unit_id_3");

                entity.Property(e => e.UnitOnlyDisp).HasColumnName("unit_only_disp");
            });

            modelBuilder.Entity<SpLoseVoiceGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.UnitId });

                entity.ToTable("sp_lose_voice_group");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.SpeakerUnitId).HasColumnName("speaker_unit_id");
            });

            modelBuilder.Entity<SpaceBattleData>(entity =>
            {
                entity.HasKey(e => e.SpaceBattleId);

                entity.ToTable("space_battle_data");

                entity.Property(e => e.SpaceBattleId)
                    .HasColumnName("space_battle_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.QueId)
                    .IsRequired()
                    .HasColumnName("que_id");

                entity.Property(e => e.QuestDetailBgId).HasColumnName("quest_detail_bg_id");

                entity.Property(e => e.QuestDetailBgPosition).HasColumnName("quest_detail_bg_position");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.SpaceEnemyId).HasColumnName("space_enemy_id");
            });

            modelBuilder.Entity<SpaceSchedule>(entity =>
            {
                entity.HasKey(e => e.SpaceId);

                entity.ToTable("space_schedule");

                entity.Property(e => e.SpaceId)
                    .HasColumnName("space_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountEndTime)
                    .IsRequired()
                    .HasColumnName("count_end_time");

                entity.Property(e => e.CountStartTime)
                    .IsRequired()
                    .HasColumnName("count_start_time");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.Sid).HasColumnName("sid");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.TeaserTime)
                    .IsRequired()
                    .HasColumnName("teaser_time");
            });

            modelBuilder.Entity<SpaceTopData>(entity =>
            {
                entity.ToTable("space_top_data");

                entity.HasIndex(e => e.SpaceId)
                    .HasName("space_top_data_0_space_id");

                entity.HasIndex(e => e.StoryId)
                    .HasName("space_top_data_0_story_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.PartFlag).HasColumnName("part_flag");

                entity.Property(e => e.SkipBattleTime)
                    .IsRequired()
                    .HasColumnName("skip_battle_time");

                entity.Property(e => e.SpaceBattleId).HasColumnName("space_battle_id");

                entity.Property(e => e.SpaceId).HasColumnName("space_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.TimeFrom)
                    .IsRequired()
                    .HasColumnName("time_from");

                entity.Property(e => e.TimeTo)
                    .IsRequired()
                    .HasColumnName("time_to");
            });

            modelBuilder.Entity<SpecialStill>(entity =>
            {
                entity.HasKey(e => e.StillId);

                entity.ToTable("special_still");

                entity.Property(e => e.StillId)
                    .HasColumnName("still_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BackMomoryType).HasColumnName("back_momory_type");

                entity.Property(e => e.Type).HasColumnName("type");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<SpecialStoryBanner>(entity =>
            {
                entity.ToTable("special_story_banner");

                entity.HasIndex(e => e.StoryGroupId)
                    .HasName("special_story_banner_0_story_group_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.RemindEndTime)
                    .IsRequired()
                    .HasColumnName("remind_end_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");
            });

            modelBuilder.Entity<SpecialfesBanner>(entity =>
            {
                entity.HasKey(e => e.GachaId);

                entity.ToTable("specialfes_banner");

                entity.Property(e => e.GachaId)
                    .HasColumnName("gacha_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BannerId1).HasColumnName("banner_id_1");

                entity.Property(e => e.BannerId10).HasColumnName("banner_id_10");

                entity.Property(e => e.BannerId2).HasColumnName("banner_id_2");

                entity.Property(e => e.BannerId3).HasColumnName("banner_id_3");

                entity.Property(e => e.BannerId4).HasColumnName("banner_id_4");

                entity.Property(e => e.BannerId5).HasColumnName("banner_id_5");

                entity.Property(e => e.BannerId6).HasColumnName("banner_id_6");

                entity.Property(e => e.BannerId7).HasColumnName("banner_id_7");

                entity.Property(e => e.BannerId8).HasColumnName("banner_id_8");

                entity.Property(e => e.BannerId9).HasColumnName("banner_id_9");
            });

            modelBuilder.Entity<SpskillLabelData>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("spskill_label_data");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.NormalLabelText)
                    .IsRequired()
                    .HasColumnName("normal_label_text");

                entity.Property(e => e.SpLabelText)
                    .IsRequired()
                    .HasColumnName("sp_label_text");
            });

            modelBuilder.Entity<SpskillLvInitializeData>(entity =>
            {
                entity.HasKey(e => e.InitializeSkillId);

                entity.ToTable("spskill_lv_initialize_data");

                entity.Property(e => e.InitializeSkillId)
                    .HasColumnName("initialize_skill_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseSkillId).HasColumnName("base_skill_id");
            });

            modelBuilder.Entity<SrtAction>(entity =>
            {
                entity.HasKey(e => e.ActionName);

                entity.ToTable("srt_action");

                entity.Property(e => e.ActionName).HasColumnName("action_name");

                entity.Property(e => e.DragonAction)
                    .IsRequired()
                    .HasColumnName("dragon_action");

                entity.Property(e => e.HomareAction)
                    .IsRequired()
                    .HasColumnName("homare_action");

                entity.Property(e => e.InoriAction)
                    .IsRequired()
                    .HasColumnName("inori_action");

                entity.Property(e => e.KayaAction)
                    .IsRequired()
                    .HasColumnName("kaya_action");

                entity.Property(e => e.TalkText)
                    .IsRequired()
                    .HasColumnName("talk_text");

                entity.Property(e => e.TalkTextType).HasColumnName("talk_text_type");

                entity.Property(e => e.VoiceList)
                    .IsRequired()
                    .HasColumnName("voice_list");
            });

            modelBuilder.Entity<SrtPanel>(entity =>
            {
                entity.HasKey(e => e.ReadingId);

                entity.ToTable("srt_panel");

                entity.HasIndex(e => e.PanelId)
                    .HasName("srt_panel_0_panel_id");

                entity.HasIndex(e => e.Version)
                    .HasName("srt_panel_0_version");

                entity.Property(e => e.ReadingId)
                    .HasColumnName("reading_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DetailText)
                    .IsRequired()
                    .HasColumnName("detail_text");

                entity.Property(e => e.PanelId).HasColumnName("panel_id");

                entity.Property(e => e.ReadType).HasColumnName("read_type");

                entity.Property(e => e.Reading)
                    .IsRequired()
                    .HasColumnName("reading");

                entity.Property(e => e.Version).HasColumnName("version");
            });

            modelBuilder.Entity<SrtReward>(entity =>
            {
                entity.ToTable("srt_reward");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissionDetail)
                    .IsRequired()
                    .HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.SrtScore).HasColumnName("srt_score");
            });

            modelBuilder.Entity<SrtScore>(entity =>
            {
                entity.HasKey(e => e.DifficultyLevel);

                entity.ToTable("srt_score");

                entity.Property(e => e.DifficultyLevel)
                    .HasColumnName("difficulty_level")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoefficientAvgAnswerTime).HasColumnName("coefficient_avg_answer_time");

                entity.Property(e => e.CoefficientCountPriconnePanel).HasColumnName("coefficient_count_priconne_panel");

                entity.Property(e => e.CoefficientFever).HasColumnName("coefficient_fever");

                entity.Property(e => e.CoefficientReadType1).HasColumnName("coefficient_read_type_1");

                entity.Property(e => e.CoefficientReadType2).HasColumnName("coefficient_read_type_2");

                entity.Property(e => e.CoefficientReadType3).HasColumnName("coefficient_read_type_3");

                entity.Property(e => e.CoefficientTurnBonus).HasColumnName("coefficient_turn_bonus");

                entity.Property(e => e.CoefficientWrongNum).HasColumnName("coefficient_wrong_num");

                entity.Property(e => e.ConstantTurnBonus).HasColumnName("constant_turn_bonus");

                entity.Property(e => e.ConstantWrongNum).HasColumnName("constant_wrong_num");
            });

            modelBuilder.Entity<SrtTopTalk>(entity =>
            {
                entity.ToTable("srt_top_talk");

                entity.HasIndex(e => e.TalkId)
                    .HasName("srt_top_talk_0_talk_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharaIndex).HasColumnName("chara_index");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.Direction).HasColumnName("direction");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("sheet_name");

                entity.Property(e => e.TalkId).HasColumnName("talk_id");

                entity.Property(e => e.TalkText)
                    .IsRequired()
                    .HasColumnName("talk_text");
            });

            modelBuilder.Entity<SspStoryData>(entity =>
            {
                entity.HasKey(e => e.SubStoryId);

                entity.ToTable("ssp_story_data");

                entity.HasIndex(e => e.ContentsType)
                    .HasName("ssp_story_data_0_contents_type");

                entity.HasIndex(e => e.OriginalEventId)
                    .HasName("ssp_story_data_0_original_event_id");

                entity.Property(e => e.SubStoryId)
                    .HasColumnName("sub_story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.ContentsType).HasColumnName("contents_type");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.ReadCondition).HasColumnName("read_condition");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<Stamp>(entity =>
            {
                entity.ToTable("stamp");

                entity.Property(e => e.StampId)
                    .HasColumnName("stamp_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date");
            });

            modelBuilder.Entity<StationaryMissionData>(entity =>
            {
                entity.HasKey(e => e.StationaryMissionId);

                entity.ToTable("stationary_mission_data");

                entity.Property(e => e.StationaryMissionId)
                    .HasColumnName("stationary_mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryIcon).HasColumnName("category_icon");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue10).HasColumnName("condition_value_10");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.ConditionValue6).HasColumnName("condition_value_6");

                entity.Property(e => e.ConditionValue7).HasColumnName("condition_value_7");

                entity.Property(e => e.ConditionValue8).HasColumnName("condition_value_8");

                entity.Property(e => e.ConditionValue9).HasColumnName("condition_value_9");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.MaxLevel).HasColumnName("max_level");

                entity.Property(e => e.MinLevel).HasColumnName("min_level");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.SystemId).HasColumnName("system_id");

                entity.Property(e => e.TitleColorId).HasColumnName("title_color_id");

                entity.Property(e => e.VisibleFlag).HasColumnName("visible_flag");
            });

            modelBuilder.Entity<Still>(entity =>
            {
                entity.ToTable("still");

                entity.HasIndex(e => e.StillGroupId)
                    .HasName("still_0_still_group_id");

                entity.HasIndex(e => e.StoryId)
                    .HasName("still_0_story_id");

                entity.Property(e => e.StillId)
                    .HasColumnName("still_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlbumIgnore).HasColumnName("album_ignore");

                entity.Property(e => e.FacialId).HasColumnName("facial_id");

                entity.Property(e => e.MyPageFlag).HasColumnName("my_page_flag");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.ScrollDirection).HasColumnName("scroll_direction");

                entity.Property(e => e.StillGroupId).HasColumnName("still_group_id");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.UnitId1).HasColumnName("unit_id_1");

                entity.Property(e => e.UnitId10).HasColumnName("unit_id_10");

                entity.Property(e => e.UnitId2).HasColumnName("unit_id_2");

                entity.Property(e => e.UnitId3).HasColumnName("unit_id_3");

                entity.Property(e => e.UnitId4).HasColumnName("unit_id_4");

                entity.Property(e => e.UnitId5).HasColumnName("unit_id_5");

                entity.Property(e => e.UnitId6).HasColumnName("unit_id_6");

                entity.Property(e => e.UnitId7).HasColumnName("unit_id_7");

                entity.Property(e => e.UnitId8).HasColumnName("unit_id_8");

                entity.Property(e => e.UnitId9).HasColumnName("unit_id_9");

                entity.Property(e => e.VerticalStillFlg).HasColumnName("vertical_still_flg");
            });

            modelBuilder.Entity<StoryCharacterMask>(entity =>
            {
                entity.HasKey(e => e.CharaId);

                entity.ToTable("story_character_mask");

                entity.Property(e => e.CharaId)
                    .HasColumnName("chara_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Offset).HasColumnName("offset");

                entity.Property(e => e.Size).HasColumnName("size");

                entity.Property(e => e.Softness).HasColumnName("softness");
            });

            modelBuilder.Entity<StoryData>(entity =>
            {
                entity.HasKey(e => e.StoryGroupId);

                entity.ToTable("story_data");

                entity.Property(e => e.StoryGroupId)
                    .HasColumnName("story_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionFreeFlag).HasColumnName("condition_free_flag");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.GojuonOrder).HasColumnName("gojuon_order");

                entity.Property(e => e.Order).HasColumnName("order");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryType).HasColumnName("story_type");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<StoryDetail>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("story_detail");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.ForceUnlockTime)
                    .IsRequired()
                    .HasColumnName("force_unlock_time");

                entity.Property(e => e.ForceUnlockTime2)
                    .IsRequired()
                    .HasColumnName("force_unlock_time_2");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.PreStoryId2).HasColumnName("pre_story_id_2");

                entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardValue1).HasColumnName("reward_value_1");

                entity.Property(e => e.RewardValue2).HasColumnName("reward_value_2");

                entity.Property(e => e.RewardValue3).HasColumnName("reward_value_3");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryEnd).HasColumnName("story_end");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryQuestId).HasColumnName("story_quest_id");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.UnlockQuestId).HasColumnName("unlock_quest_id");

                entity.Property(e => e.VisibleType).HasColumnName("visible_type");
            });

            modelBuilder.Entity<StoryQuestData>(entity =>
            {
                entity.HasKey(e => e.StoryQuestId);

                entity.ToTable("story_quest_data");

                entity.Property(e => e.StoryQuestId)
                    .HasColumnName("story_quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.GuestUnit1).HasColumnName("guest_unit_1");

                entity.Property(e => e.GuestUnit2).HasColumnName("guest_unit_2");

                entity.Property(e => e.GuestUnit3).HasColumnName("guest_unit_3");

                entity.Property(e => e.GuestUnit4).HasColumnName("guest_unit_4");

                entity.Property(e => e.GuestUnit5).HasColumnName("guest_unit_5");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.WaveBgmQueId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_3");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<SvdDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("svd_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("svd_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<SvdStoryData>(entity =>
            {
                entity.HasKey(e => e.SubStoryId);

                entity.ToTable("svd_story_data");

                entity.HasIndex(e => e.OriginalEventId)
                    .HasName("svd_story_data_0_original_event_id");

                entity.Property(e => e.SubStoryId)
                    .HasColumnName("sub_story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionBossId).HasColumnName("condition_boss_id");

                entity.Property(e => e.ConditionQuestId).HasColumnName("condition_quest_id");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.ReadCondition).HasColumnName("read_condition");

                entity.Property(e => e.ReadConditionTime)
                    .IsRequired()
                    .HasColumnName("read_condition_time");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<SvdStoryScript>(entity =>
            {
                entity.ToTable("svd_story_script");

                entity.HasIndex(e => e.StoryId)
                    .HasName("svd_story_script_0_story_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<TaqCompletionRewards>(entity =>
            {
                entity.ToTable("taq_completion_rewards");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CompletionNum).HasColumnName("completion_num");

                entity.Property(e => e.EmblemId).HasColumnName("emblem_id");

                entity.Property(e => e.MissionDetail)
                    .IsRequired()
                    .HasColumnName("mission_detail");
            });

            modelBuilder.Entity<TaqData>(entity =>
            {
                entity.HasKey(e => e.TaqNo);

                entity.ToTable("taq_data");

                entity.Property(e => e.TaqNo)
                    .HasColumnName("taq_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssistDetail)
                    .IsRequired()
                    .HasColumnName("assist_detail");

                entity.Property(e => e.CharNo1).HasColumnName("char_no_1");

                entity.Property(e => e.CharNo2).HasColumnName("char_no_2");

                entity.Property(e => e.CharNo3).HasColumnName("char_no_3");

                entity.Property(e => e.CharNo4).HasColumnName("char_no_4");

                entity.Property(e => e.CharNo5).HasColumnName("char_no_5");

                entity.Property(e => e.Chunk)
                    .IsRequired()
                    .HasColumnName("chunk");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasColumnName("detail");

                entity.Property(e => e.Detail2)
                    .IsRequired()
                    .HasColumnName("detail_2");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.Genre).HasColumnName("genre");

                entity.Property(e => e.ImageId).HasColumnName("image_id");

                entity.Property(e => e.InputType1).HasColumnName("input_type_1");

                entity.Property(e => e.InputType2).HasColumnName("input_type_2");

                entity.Property(e => e.InputType3).HasColumnName("input_type_3");

                entity.Property(e => e.InputType4).HasColumnName("input_type_4");

                entity.Property(e => e.InputType5).HasColumnName("input_type_5");

                entity.Property(e => e.TaqType).HasColumnName("taq_type");

                entity.Property(e => e.Word)
                    .IsRequired()
                    .HasColumnName("word");
            });

            modelBuilder.Entity<TaqDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("taq_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("taq_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<TaqGameSetting>(entity =>
            {
                entity.ToTable("taq_game_setting");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.HelpUseCountHard).HasColumnName("help_use_count_hard");

                entity.Property(e => e.HelpUseCountNormal).HasColumnName("help_use_count_normal");

                entity.Property(e => e.HelpUseCountVeryhard).HasColumnName("help_use_count_veryhard");

                entity.Property(e => e.LotteryRate).HasColumnName("lottery_rate");
            });

            modelBuilder.Entity<TaqGenre>(entity =>
            {
                entity.HasKey(e => e.GenreId);

                entity.ToTable("taq_genre");

                entity.Property(e => e.GenreId)
                    .HasColumnName("genre_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenreName)
                    .IsRequired()
                    .HasColumnName("genre_name");
            });

            modelBuilder.Entity<TaqGoodUnit>(entity =>
            {
                entity.HasKey(e => e.TaqNo);

                entity.ToTable("taq_good_unit");

                entity.Property(e => e.TaqNo)
                    .HasColumnName("taq_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.UnitId1).HasColumnName("unit_id_1");

                entity.Property(e => e.UnitId10).HasColumnName("unit_id_10");

                entity.Property(e => e.UnitId2).HasColumnName("unit_id_2");

                entity.Property(e => e.UnitId3).HasColumnName("unit_id_3");

                entity.Property(e => e.UnitId4).HasColumnName("unit_id_4");

                entity.Property(e => e.UnitId5).HasColumnName("unit_id_5");

                entity.Property(e => e.UnitId6).HasColumnName("unit_id_6");

                entity.Property(e => e.UnitId7).HasColumnName("unit_id_7");

                entity.Property(e => e.UnitId8).HasColumnName("unit_id_8");

                entity.Property(e => e.UnitId9).HasColumnName("unit_id_9");
            });

            modelBuilder.Entity<TaqIncorrectWord>(entity =>
            {
                entity.HasKey(e => e.WordId);

                entity.ToTable("taq_incorrect_word");

                entity.Property(e => e.WordId)
                    .HasColumnName("word_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IncorrectWord)
                    .IsRequired()
                    .HasColumnName("incorrect_word");
            });

            modelBuilder.Entity<TaqKanjiList>(entity =>
            {
                entity.ToTable("taq_kanji_list");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Kanji)
                    .IsRequired()
                    .HasColumnName("kanji");
            });

            modelBuilder.Entity<TaqNecessaryWord>(entity =>
            {
                entity.HasKey(e => e.TaqNo);

                entity.ToTable("taq_necessary_word");

                entity.Property(e => e.TaqNo)
                    .HasColumnName("taq_no")
                    .ValueGeneratedNever();

                entity.Property(e => e.NecessaryWord1)
                    .IsRequired()
                    .HasColumnName("necessary_word_1");

                entity.Property(e => e.NecessaryWord2)
                    .IsRequired()
                    .HasColumnName("necessary_word_2");

                entity.Property(e => e.NecessaryWord3)
                    .IsRequired()
                    .HasColumnName("necessary_word_3");

                entity.Property(e => e.NecessaryWord4)
                    .IsRequired()
                    .HasColumnName("necessary_word_4");

                entity.Property(e => e.NecessaryWord5)
                    .IsRequired()
                    .HasColumnName("necessary_word_5");

                entity.Property(e => e.UnnecessaryWord1)
                    .IsRequired()
                    .HasColumnName("unnecessary_word_1");

                entity.Property(e => e.UnnecessaryWord2)
                    .IsRequired()
                    .HasColumnName("unnecessary_word_2");

                entity.Property(e => e.UnnecessaryWord3)
                    .IsRequired()
                    .HasColumnName("unnecessary_word_3");

                entity.Property(e => e.UnnecessaryWord4)
                    .IsRequired()
                    .HasColumnName("unnecessary_word_4");

                entity.Property(e => e.UnnecessaryWord5)
                    .IsRequired()
                    .HasColumnName("unnecessary_word_5");
            });

            modelBuilder.Entity<TaqRewards>(entity =>
            {
                entity.ToTable("taq_rewards");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissionDetail)
                    .IsRequired()
                    .HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.Score).HasColumnName("score");
            });

            modelBuilder.Entity<TaqUnit>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("taq_unit");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GenreStatus1).HasColumnName("genre_status_1");

                entity.Property(e => e.GenreStatus2).HasColumnName("genre_status_2");

                entity.Property(e => e.GenreStatus3).HasColumnName("genre_status_3");

                entity.Property(e => e.GenreStatus4).HasColumnName("genre_status_4");

                entity.Property(e => e.GenreStatus5).HasColumnName("genre_status_5");

                entity.Property(e => e.GenreStatus6).HasColumnName("genre_status_6");

                entity.Property(e => e.PersonalityId).HasColumnName("personality_id");

                entity.Property(e => e.SortOrder).HasColumnName("sort_order");
            });

            modelBuilder.Entity<ThumbnailHideCondition>(entity =>
            {
                entity.HasKey(e => e.StoryGroupId);

                entity.ToTable("thumbnail_hide_condition");

                entity.Property(e => e.StoryGroupId)
                    .HasColumnName("story_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.HideStoryIdFrom).HasColumnName("hide_story_id_from");

                entity.Property(e => e.HideStoryIdTo).HasColumnName("hide_story_id_to");

                entity.Property(e => e.UnlockConditionStoryId).HasColumnName("unlock_condition_story_id");
            });

            modelBuilder.Entity<TicketGachaData>(entity =>
            {
                entity.HasKey(e => e.GachaId);

                entity.ToTable("ticket_gacha_data");

                entity.Property(e => e.GachaId)
                    .HasColumnName("gacha_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CharaOddsStar1)
                    .IsRequired()
                    .HasColumnName("chara_odds_star1");

                entity.Property(e => e.CharaOddsStar2)
                    .IsRequired()
                    .HasColumnName("chara_odds_star2");

                entity.Property(e => e.CharaOddsStar3)
                    .IsRequired()
                    .HasColumnName("chara_odds_star3");

                entity.Property(e => e.GachaDetail).HasColumnName("gacha_detail");

                entity.Property(e => e.GachaName)
                    .IsRequired()
                    .HasColumnName("gacha_name");

                entity.Property(e => e.GachaTimes).HasColumnName("gacha_times");

                entity.Property(e => e.GachaType).HasColumnName("gacha_type");

                entity.Property(e => e.GuaranteeRarity)
                    .IsRequired()
                    .HasColumnName("guarantee_rarity");

                entity.Property(e => e.RarityOdds)
                    .IsRequired()
                    .HasColumnName("rarity_odds");

                entity.Property(e => e.StagingType).HasColumnName("staging_type");

                entity.Property(e => e.TicketId).HasColumnName("ticket_id");
            });

            modelBuilder.Entity<Tips>(entity =>
            {
                entity.ToTable("tips");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.TipsIndex).HasColumnName("tips_index");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TmeMapData>(entity =>
            {
                entity.HasKey(e => e.TmeObjectId);

                entity.ToTable("tme_map_data");

                entity.HasIndex(e => e.EventId)
                    .HasName("tme_map_data_0_event_id");

                entity.Property(e => e.TmeObjectId)
                    .HasColumnName("tme_object_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaDifficultyType).HasColumnName("area_difficulty_type");

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.ReleaseEffect).HasColumnName("release_effect");

                entity.Property(e => e.TapEffect).HasColumnName("tap_effect");
            });

            modelBuilder.Entity<TowerAreaData>(entity =>
            {
                entity.HasKey(e => e.TowerAreaId);

                entity.ToTable("tower_area_data");

                entity.Property(e => e.TowerAreaId)
                    .HasColumnName("tower_area_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaBg).HasColumnName("area_bg");

                entity.Property(e => e.CloisterQuestId).HasColumnName("cloister_quest_id");

                entity.Property(e => e.MaxFloorNum).HasColumnName("max_floor_num");

                entity.Property(e => e.TowerBgm)
                    .IsRequired()
                    .HasColumnName("tower_bgm");
            });

            modelBuilder.Entity<TowerCloisterQuestData>(entity =>
            {
                entity.HasKey(e => e.TowerCloisterQuestId);

                entity.ToTable("tower_cloister_quest_data");

                entity.Property(e => e.TowerCloisterQuestId)
                    .HasColumnName("tower_cloister_quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.DailyLimit).HasColumnName("daily_limit");

                entity.Property(e => e.DropRewardGroupId).HasColumnName("drop_reward_group_id");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.RecoveryHpRate).HasColumnName("recovery_hp_rate");

                entity.Property(e => e.RecoveryTpRate).HasColumnName("recovery_tp_rate");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.StartTpRate).HasColumnName("start_tp_rate");

                entity.Property(e => e.W1EnemyLocalPositionY1).HasColumnName("w1_enemy_local_position_y_1");

                entity.Property(e => e.W1EnemyLocalPositionY2).HasColumnName("w1_enemy_local_position_y_2");

                entity.Property(e => e.W1EnemyLocalPositionY3).HasColumnName("w1_enemy_local_position_y_3");

                entity.Property(e => e.W1EnemyLocalPositionY4).HasColumnName("w1_enemy_local_position_y_4");

                entity.Property(e => e.W1EnemyLocalPositionY5).HasColumnName("w1_enemy_local_position_y_5");

                entity.Property(e => e.W1EnemyPositionX1).HasColumnName("w1_enemy_position_x_1");

                entity.Property(e => e.W1EnemyPositionX2).HasColumnName("w1_enemy_position_x_2");

                entity.Property(e => e.W1EnemyPositionX3).HasColumnName("w1_enemy_position_x_3");

                entity.Property(e => e.W1EnemyPositionX4).HasColumnName("w1_enemy_position_x_4");

                entity.Property(e => e.W1EnemyPositionX5).HasColumnName("w1_enemy_position_x_5");

                entity.Property(e => e.W1EnemySize1).HasColumnName("w1_enemy_size_1");

                entity.Property(e => e.W1EnemySize2).HasColumnName("w1_enemy_size_2");

                entity.Property(e => e.W1EnemySize3).HasColumnName("w1_enemy_size_3");

                entity.Property(e => e.W1EnemySize4).HasColumnName("w1_enemy_size_4");

                entity.Property(e => e.W1EnemySize5).HasColumnName("w1_enemy_size_5");

                entity.Property(e => e.W2EnemyLocalPositionY1).HasColumnName("w2_enemy_local_position_y_1");

                entity.Property(e => e.W2EnemyLocalPositionY2).HasColumnName("w2_enemy_local_position_y_2");

                entity.Property(e => e.W2EnemyLocalPositionY3).HasColumnName("w2_enemy_local_position_y_3");

                entity.Property(e => e.W2EnemyLocalPositionY4).HasColumnName("w2_enemy_local_position_y_4");

                entity.Property(e => e.W2EnemyLocalPositionY5).HasColumnName("w2_enemy_local_position_y_5");

                entity.Property(e => e.W2EnemyPositionX1).HasColumnName("w2_enemy_position_x_1");

                entity.Property(e => e.W2EnemyPositionX2).HasColumnName("w2_enemy_position_x_2");

                entity.Property(e => e.W2EnemyPositionX3).HasColumnName("w2_enemy_position_x_3");

                entity.Property(e => e.W2EnemyPositionX4).HasColumnName("w2_enemy_position_x_4");

                entity.Property(e => e.W2EnemyPositionX5).HasColumnName("w2_enemy_position_x_5");

                entity.Property(e => e.W2EnemySize1).HasColumnName("w2_enemy_size_1");

                entity.Property(e => e.W2EnemySize2).HasColumnName("w2_enemy_size_2");

                entity.Property(e => e.W2EnemySize3).HasColumnName("w2_enemy_size_3");

                entity.Property(e => e.W2EnemySize4).HasColumnName("w2_enemy_size_4");

                entity.Property(e => e.W2EnemySize5).HasColumnName("w2_enemy_size_5");

                entity.Property(e => e.W3EnemyLocalPositionY1).HasColumnName("w3_enemy_local_position_y_1");

                entity.Property(e => e.W3EnemyLocalPositionY2).HasColumnName("w3_enemy_local_position_y_2");

                entity.Property(e => e.W3EnemyLocalPositionY3).HasColumnName("w3_enemy_local_position_y_3");

                entity.Property(e => e.W3EnemyLocalPositionY4).HasColumnName("w3_enemy_local_position_y_4");

                entity.Property(e => e.W3EnemyLocalPositionY5).HasColumnName("w3_enemy_local_position_y_5");

                entity.Property(e => e.W3EnemyPositionX1).HasColumnName("w3_enemy_position_x_1");

                entity.Property(e => e.W3EnemyPositionX2).HasColumnName("w3_enemy_position_x_2");

                entity.Property(e => e.W3EnemyPositionX3).HasColumnName("w3_enemy_position_x_3");

                entity.Property(e => e.W3EnemyPositionX4).HasColumnName("w3_enemy_position_x_4");

                entity.Property(e => e.W3EnemyPositionX5).HasColumnName("w3_enemy_position_x_5");

                entity.Property(e => e.W3EnemySize1).HasColumnName("w3_enemy_size_1");

                entity.Property(e => e.W3EnemySize2).HasColumnName("w3_enemy_size_2");

                entity.Property(e => e.W3EnemySize3).HasColumnName("w3_enemy_size_3");

                entity.Property(e => e.W3EnemySize4).HasColumnName("w3_enemy_size_4");

                entity.Property(e => e.W3EnemySize5).HasColumnName("w3_enemy_size_5");

                entity.Property(e => e.WaveBgm)
                    .IsRequired()
                    .HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<TowerEnemyParameter>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("tower_enemy_parameter");

                entity.Property(e => e.EnemyId)
                    .HasColumnName("enemy_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnemyColor).HasColumnName("enemy_color");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.ExSkillLv1).HasColumnName("ex_skill_lv_1");

                entity.Property(e => e.ExSkillLv2).HasColumnName("ex_skill_lv_2");

                entity.Property(e => e.ExSkillLv3).HasColumnName("ex_skill_lv_3");

                entity.Property(e => e.ExSkillLv4).HasColumnName("ex_skill_lv_4");

                entity.Property(e => e.ExSkillLv5).HasColumnName("ex_skill_lv_5");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MainSkillLv1).HasColumnName("main_skill_lv_1");

                entity.Property(e => e.MainSkillLv10).HasColumnName("main_skill_lv_10");

                entity.Property(e => e.MainSkillLv2).HasColumnName("main_skill_lv_2");

                entity.Property(e => e.MainSkillLv3).HasColumnName("main_skill_lv_3");

                entity.Property(e => e.MainSkillLv4).HasColumnName("main_skill_lv_4");

                entity.Property(e => e.MainSkillLv5).HasColumnName("main_skill_lv_5");

                entity.Property(e => e.MainSkillLv6).HasColumnName("main_skill_lv_6");

                entity.Property(e => e.MainSkillLv7).HasColumnName("main_skill_lv_7");

                entity.Property(e => e.MainSkillLv8).HasColumnName("main_skill_lv_8");

                entity.Property(e => e.MainSkillLv9).HasColumnName("main_skill_lv_9");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.ResistStatusId).HasColumnName("resist_status_id");

                entity.Property(e => e.ResistVariationId).HasColumnName("resist_variation_id");

                entity.Property(e => e.UnionBurstLevel).HasColumnName("union_burst_level");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<TowerExQuestData>(entity =>
            {
                entity.HasKey(e => e.TowerExQuestId);

                entity.ToTable("tower_ex_quest_data");

                entity.HasIndex(e => e.FloorNum)
                    .HasName("tower_ex_quest_data_0_floor_num");

                entity.Property(e => e.TowerExQuestId)
                    .HasColumnName("tower_ex_quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalRewardId).HasColumnName("additional_reward_id");

                entity.Property(e => e.AdditionalRewardType).HasColumnName("additional_reward_type");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.ClpFlag).HasColumnName("clp_flag");

                entity.Property(e => e.EnemyLocalPositionY1).HasColumnName("enemy_local_position_y_1");

                entity.Property(e => e.EnemyLocalPositionY2).HasColumnName("enemy_local_position_y_2");

                entity.Property(e => e.EnemyLocalPositionY3).HasColumnName("enemy_local_position_y_3");

                entity.Property(e => e.EnemyLocalPositionY4).HasColumnName("enemy_local_position_y_4");

                entity.Property(e => e.EnemyLocalPositionY5).HasColumnName("enemy_local_position_y_5");

                entity.Property(e => e.EnemyPositionX1).HasColumnName("enemy_position_x_1");

                entity.Property(e => e.EnemyPositionX2).HasColumnName("enemy_position_x_2");

                entity.Property(e => e.EnemyPositionX3).HasColumnName("enemy_position_x_3");

                entity.Property(e => e.EnemyPositionX4).HasColumnName("enemy_position_x_4");

                entity.Property(e => e.EnemyPositionX5).HasColumnName("enemy_position_x_5");

                entity.Property(e => e.EnemySize1).HasColumnName("enemy_size_1");

                entity.Property(e => e.EnemySize2).HasColumnName("enemy_size_2");

                entity.Property(e => e.EnemySize3).HasColumnName("enemy_size_3");

                entity.Property(e => e.EnemySize4).HasColumnName("enemy_size_4");

                entity.Property(e => e.EnemySize5).HasColumnName("enemy_size_5");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.SkipLevel).HasColumnName("skip_level");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.TowerAreaId).HasColumnName("tower_area_id");

                entity.Property(e => e.WaveBgm)
                    .IsRequired()
                    .HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<TowerQuestData>(entity =>
            {
                entity.HasKey(e => e.TowerQuestId);

                entity.ToTable("tower_quest_data");

                entity.HasIndex(e => e.FloorNum)
                    .HasName("tower_quest_data_0_floor_num");

                entity.Property(e => e.TowerQuestId)
                    .HasColumnName("tower_quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalRewardId).HasColumnName("additional_reward_id");

                entity.Property(e => e.AdditionalRewardType).HasColumnName("additional_reward_type");

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BgPosition).HasColumnName("bg_position");

                entity.Property(e => e.BossFloorFlg).HasColumnName("boss_floor_flg");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.ClpFlag).HasColumnName("clp_flag");

                entity.Property(e => e.EnemyLocalPositionY1).HasColumnName("enemy_local_position_y_1");

                entity.Property(e => e.EnemyLocalPositionY2).HasColumnName("enemy_local_position_y_2");

                entity.Property(e => e.EnemyLocalPositionY3).HasColumnName("enemy_local_position_y_3");

                entity.Property(e => e.EnemyLocalPositionY4).HasColumnName("enemy_local_position_y_4");

                entity.Property(e => e.EnemyLocalPositionY5).HasColumnName("enemy_local_position_y_5");

                entity.Property(e => e.EnemyPositionX1).HasColumnName("enemy_position_x_1");

                entity.Property(e => e.EnemyPositionX2).HasColumnName("enemy_position_x_2");

                entity.Property(e => e.EnemyPositionX3).HasColumnName("enemy_position_x_3");

                entity.Property(e => e.EnemyPositionX4).HasColumnName("enemy_position_x_4");

                entity.Property(e => e.EnemyPositionX5).HasColumnName("enemy_position_x_5");

                entity.Property(e => e.EnemySize1).HasColumnName("enemy_size_1");

                entity.Property(e => e.EnemySize2).HasColumnName("enemy_size_2");

                entity.Property(e => e.EnemySize3).HasColumnName("enemy_size_3");

                entity.Property(e => e.EnemySize4).HasColumnName("enemy_size_4");

                entity.Property(e => e.EnemySize5).HasColumnName("enemy_size_5");

                entity.Property(e => e.FixRewardGroupId).HasColumnName("fix_reward_group_id");

                entity.Property(e => e.FloorImageAddType).HasColumnName("floor_image_add_type");

                entity.Property(e => e.FloorImageType).HasColumnName("floor_image_type");

                entity.Property(e => e.FloorNum).HasColumnName("floor_num");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.OpenTowerExQuestId).HasColumnName("open_tower_ex_quest_id");

                entity.Property(e => e.RecoveryHpRate).HasColumnName("recovery_hp_rate");

                entity.Property(e => e.RecoveryTpRate).HasColumnName("recovery_tp_rate");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.SkipLevel).HasColumnName("skip_level");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.StartTpRate).HasColumnName("start_tp_rate");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.TowerAreaId).HasColumnName("tower_area_id");

                entity.Property(e => e.WaveBgm)
                    .IsRequired()
                    .HasColumnName("wave_bgm");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<TowerQuestFixRewardGroup>(entity =>
            {
                entity.HasKey(e => e.FixRewardGroupId);

                entity.ToTable("tower_quest_fix_reward_group");

                entity.Property(e => e.FixRewardGroupId)
                    .HasColumnName("fix_reward_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId10).HasColumnName("reward_id_10");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardId6).HasColumnName("reward_id_6");

                entity.Property(e => e.RewardId7).HasColumnName("reward_id_7");

                entity.Property(e => e.RewardId8).HasColumnName("reward_id_8");

                entity.Property(e => e.RewardId9).HasColumnName("reward_id_9");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum10).HasColumnName("reward_num_10");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardNum6).HasColumnName("reward_num_6");

                entity.Property(e => e.RewardNum7).HasColumnName("reward_num_7");

                entity.Property(e => e.RewardNum8).HasColumnName("reward_num_8");

                entity.Property(e => e.RewardNum9).HasColumnName("reward_num_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");

                entity.Property(e => e.TreasureType1).HasColumnName("treasure_type_1");

                entity.Property(e => e.TreasureType10).HasColumnName("treasure_type_10");

                entity.Property(e => e.TreasureType2).HasColumnName("treasure_type_2");

                entity.Property(e => e.TreasureType3).HasColumnName("treasure_type_3");

                entity.Property(e => e.TreasureType4).HasColumnName("treasure_type_4");

                entity.Property(e => e.TreasureType5).HasColumnName("treasure_type_5");

                entity.Property(e => e.TreasureType6).HasColumnName("treasure_type_6");

                entity.Property(e => e.TreasureType7).HasColumnName("treasure_type_7");

                entity.Property(e => e.TreasureType8).HasColumnName("treasure_type_8");

                entity.Property(e => e.TreasureType9).HasColumnName("treasure_type_9");
            });

            modelBuilder.Entity<TowerQuestOddsGroup>(entity =>
            {
                entity.HasKey(e => new { e.OddsGroupId, e.TeamLevelFrom, e.TeamLevelTo });

                entity.ToTable("tower_quest_odds_group");

                entity.HasIndex(e => e.OddsGroupId)
                    .HasName("tower_quest_odds_group_0_odds_group_id");

                entity.Property(e => e.OddsGroupId).HasColumnName("odds_group_id");

                entity.Property(e => e.TeamLevelFrom).HasColumnName("team_level_from");

                entity.Property(e => e.TeamLevelTo).HasColumnName("team_level_to");

                entity.Property(e => e.OddsCsv1)
                    .IsRequired()
                    .HasColumnName("odds_csv_1");

                entity.Property(e => e.OddsCsv10)
                    .IsRequired()
                    .HasColumnName("odds_csv_10");

                entity.Property(e => e.OddsCsv2)
                    .IsRequired()
                    .HasColumnName("odds_csv_2");

                entity.Property(e => e.OddsCsv3)
                    .IsRequired()
                    .HasColumnName("odds_csv_3");

                entity.Property(e => e.OddsCsv4)
                    .IsRequired()
                    .HasColumnName("odds_csv_4");

                entity.Property(e => e.OddsCsv5)
                    .IsRequired()
                    .HasColumnName("odds_csv_5");

                entity.Property(e => e.OddsCsv6)
                    .IsRequired()
                    .HasColumnName("odds_csv_6");

                entity.Property(e => e.OddsCsv7)
                    .IsRequired()
                    .HasColumnName("odds_csv_7");

                entity.Property(e => e.OddsCsv8)
                    .IsRequired()
                    .HasColumnName("odds_csv_8");

                entity.Property(e => e.OddsCsv9)
                    .IsRequired()
                    .HasColumnName("odds_csv_9");

                entity.Property(e => e.TreasureType1).HasColumnName("treasure_type_1");

                entity.Property(e => e.TreasureType10).HasColumnName("treasure_type_10");

                entity.Property(e => e.TreasureType2).HasColumnName("treasure_type_2");

                entity.Property(e => e.TreasureType3).HasColumnName("treasure_type_3");

                entity.Property(e => e.TreasureType4).HasColumnName("treasure_type_4");

                entity.Property(e => e.TreasureType5).HasColumnName("treasure_type_5");

                entity.Property(e => e.TreasureType6).HasColumnName("treasure_type_6");

                entity.Property(e => e.TreasureType7).HasColumnName("treasure_type_7");

                entity.Property(e => e.TreasureType8).HasColumnName("treasure_type_8");

                entity.Property(e => e.TreasureType9).HasColumnName("treasure_type_9");
            });

            modelBuilder.Entity<TowerSchedule>(entity =>
            {
                entity.ToTable("tower_schedule");

                entity.HasIndex(e => e.OpeningStoryId)
                    .HasName("tower_schedule_0_opening_story_id");

                entity.Property(e => e.TowerScheduleId)
                    .HasColumnName("tower_schedule_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountStartTime)
                    .IsRequired()
                    .HasColumnName("count_start_time");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.MaxTowerAreaId).HasColumnName("max_tower_area_id");

                entity.Property(e => e.OpeningStoryId).HasColumnName("opening_story_id");

                entity.Property(e => e.RecoveryDisableTime)
                    .IsRequired()
                    .HasColumnName("recovery_disable_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<TowerStoryData>(entity =>
            {
                entity.HasKey(e => e.StoryGroupId);

                entity.ToTable("tower_story_data");

                entity.Property(e => e.StoryGroupId)
                    .HasColumnName("story_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryType).HasColumnName("story_type");

                entity.Property(e => e.ThumbnailId).HasColumnName("thumbnail_id");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TowerStoryDetail>(entity =>
            {
                entity.HasKey(e => e.StoryId);

                entity.ToTable("tower_story_detail");

                entity.Property(e => e.StoryId)
                    .HasColumnName("story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.LoveLevel).HasColumnName("love_level");

                entity.Property(e => e.PreStoryId).HasColumnName("pre_story_id");

                entity.Property(e => e.RequirementId).HasColumnName("requirement_id");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardValue1).HasColumnName("reward_value_1");

                entity.Property(e => e.RewardValue2).HasColumnName("reward_value_2");

                entity.Property(e => e.RewardValue3).HasColumnName("reward_value_3");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryEnd).HasColumnName("story_end");

                entity.Property(e => e.StoryGroupId).HasColumnName("story_group_id");

                entity.Property(e => e.StoryQuestId).HasColumnName("story_quest_id");

                entity.Property(e => e.SubTitle)
                    .IsRequired()
                    .HasColumnName("sub_title");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.UnlockQuestId).HasColumnName("unlock_quest_id");

                entity.Property(e => e.VisibleType).HasColumnName("visible_type");
            });

            modelBuilder.Entity<TowerWaveGroupData>(entity =>
            {
                entity.HasKey(e => e.WaveGroupId);

                entity.ToTable("tower_wave_group_data");

                entity.Property(e => e.WaveGroupId)
                    .HasColumnName("wave_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Odds).HasColumnName("odds");
            });

            modelBuilder.Entity<TpRecoveryAt>(entity =>
            {
                entity.ToTable("tp_recovery_at");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CorrectionValue).HasColumnName("correction_value");

                entity.Property(e => e.LimitValue).HasColumnName("limit_value");
            });

            modelBuilder.Entity<TrainingQuestData>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("training_quest_data");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AreaId).HasColumnName("area_id");

                entity.Property(e => e.Background1).HasColumnName("background_1");

                entity.Property(e => e.Background2).HasColumnName("background_2");

                entity.Property(e => e.Background3).HasColumnName("background_3");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EnemyImage1).HasColumnName("enemy_image_1");

                entity.Property(e => e.EnemyImage2).HasColumnName("enemy_image_2");

                entity.Property(e => e.EnemyImage3).HasColumnName("enemy_image_3");

                entity.Property(e => e.EnemyImage4).HasColumnName("enemy_image_4");

                entity.Property(e => e.EnemyImage5).HasColumnName("enemy_image_5");

                entity.Property(e => e.LimitTeamLevel).HasColumnName("limit_team_level");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.RankRewardGroup).HasColumnName("rank_reward_group");

                entity.Property(e => e.RewardImage1).HasColumnName("reward_image_1");

                entity.Property(e => e.RewardImage2).HasColumnName("reward_image_2");

                entity.Property(e => e.RewardImage3).HasColumnName("reward_image_3");

                entity.Property(e => e.RewardImage4).HasColumnName("reward_image_4");

                entity.Property(e => e.RewardImage5).HasColumnName("reward_image_5");

                entity.Property(e => e.Stamina).HasColumnName("stamina");

                entity.Property(e => e.StaminaStart).HasColumnName("stamina_start");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.TeamExp).HasColumnName("team_exp");

                entity.Property(e => e.TrainingQuestDetailBgId).HasColumnName("training_quest_detail_bg_id");

                entity.Property(e => e.TrainingQuestDetailBgPosition).HasColumnName("training_quest_detail_bg_position");

                entity.Property(e => e.UnitExp).HasColumnName("unit_exp");

                entity.Property(e => e.UnlockQuestId1).HasColumnName("unlock_quest_id_1");

                entity.Property(e => e.UnlockQuestId2).HasColumnName("unlock_quest_id_2");

                entity.Property(e => e.WaveBgmQueId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_1");

                entity.Property(e => e.WaveBgmQueId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_2");

                entity.Property(e => e.WaveBgmQueId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id_3");

                entity.Property(e => e.WaveBgmSheetId1)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_1");

                entity.Property(e => e.WaveBgmSheetId2)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_2");

                entity.Property(e => e.WaveBgmSheetId3)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id_3");

                entity.Property(e => e.WaveGroupId1).HasColumnName("wave_group_id_1");

                entity.Property(e => e.WaveGroupId2).HasColumnName("wave_group_id_2");

                entity.Property(e => e.WaveGroupId3).HasColumnName("wave_group_id_3");
            });

            modelBuilder.Entity<TravelAreaData>(entity =>
            {
                entity.HasKey(e => e.TravelAreaId);

                entity.ToTable("travel_area_data");

                entity.Property(e => e.TravelAreaId)
                    .HasColumnName("travel_area_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.ConditionTeamLv).HasColumnName("condition_team_lv");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.TopIconId).HasColumnName("top_icon_id");

                entity.Property(e => e.TopIconX).HasColumnName("top_icon_x");

                entity.Property(e => e.TopIconY).HasColumnName("top_icon_y");

                entity.Property(e => e.TravelAreaName)
                    .IsRequired()
                    .HasColumnName("travel_area_name");
            });

            modelBuilder.Entity<TravelDecreaseTimeCost>(entity =>
            {
                entity.HasKey(e => e.Count);

                entity.ToTable("travel_decrease_time_cost");

                entity.Property(e => e.Count)
                    .HasColumnName("count")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnName("cost");
            });

            modelBuilder.Entity<TravelExEventData>(entity =>
            {
                entity.HasKey(e => e.StillId);

                entity.ToTable("travel_ex_event_data");

                entity.Property(e => e.StillId)
                    .HasColumnName("still_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            modelBuilder.Entity<TravelExEventDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("travel_ex_event_drama");

                entity.HasIndex(e => e.DramaId)
                    .HasName("travel_ex_event_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<TravelQuestData>(entity =>
            {
                entity.HasKey(e => e.TravelQuestId);

                entity.ToTable("travel_quest_data");

                entity.HasIndex(e => e.TravelAreaId)
                    .HasName("travel_quest_data_0_travel_area_id");

                entity.Property(e => e.TravelQuestId)
                    .HasColumnName("travel_quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.IconX).HasColumnName("icon_x");

                entity.Property(e => e.IconY).HasColumnName("icon_y");

                entity.Property(e => e.LimitUnitNum).HasColumnName("limit_unit_num");

                entity.Property(e => e.MainReward1).HasColumnName("main_reward_1");

                entity.Property(e => e.MainReward2).HasColumnName("main_reward_2");

                entity.Property(e => e.MainReward3).HasColumnName("main_reward_3");

                entity.Property(e => e.MainReward4).HasColumnName("main_reward_4");

                entity.Property(e => e.MainReward5).HasColumnName("main_reward_5");

                entity.Property(e => e.NeedPower).HasColumnName("need_power");

                entity.Property(e => e.SituationGroupId).HasColumnName("situation_group_id");

                entity.Property(e => e.TravelAreaId).HasColumnName("travel_area_id");

                entity.Property(e => e.TravelDecreaseFlag).HasColumnName("travel_decrease_flag");

                entity.Property(e => e.TravelQuestName)
                    .IsRequired()
                    .HasColumnName("travel_quest_name");

                entity.Property(e => e.TravelTime).HasColumnName("travel_time");

                entity.Property(e => e.TravelTimeDecreaseLimit).HasColumnName("travel_time_decrease_limit");
            });

            modelBuilder.Entity<TravelQuestResult>(entity =>
            {
                entity.HasKey(e => e.SituationId);

                entity.ToTable("travel_quest_result");

                entity.Property(e => e.SituationId)
                    .HasColumnName("situation_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DramaId).HasColumnName("drama_id");
            });

            modelBuilder.Entity<TravelQuestResultGroup>(entity =>
            {
                entity.ToTable("travel_quest_result_group");

                entity.HasIndex(e => e.SituationGroupId)
                    .HasName("travel_quest_result_group_0_situation_group_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SituationGroupId).HasColumnName("situation_group_id");

                entity.Property(e => e.SituationId).HasColumnName("situation_id");
            });

            modelBuilder.Entity<TravelQuestSubReward>(entity =>
            {
                entity.ToTable("travel_quest_sub_reward");

                entity.HasIndex(e => e.RewardId)
                    .HasName("travel_quest_sub_reward_0_reward_id");

                entity.HasIndex(e => e.TravelQuestId)
                    .HasName("travel_quest_sub_reward_0_travel_quest_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");

                entity.Property(e => e.TravelQuestId).HasColumnName("travel_quest_id");
            });

            modelBuilder.Entity<TravelStartDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("travel_start_drama");

                entity.HasIndex(e => e.DramaId)
                    .HasName("travel_start_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<TravelTopEventData>(entity =>
            {
                entity.HasKey(e => new { e.TopEventId, e.Pattern });

                entity.ToTable("travel_top_event_data");

                entity.HasIndex(e => e.TopEventId)
                    .HasName("travel_top_event_data_0_top_event_id");

                entity.Property(e => e.TopEventId).HasColumnName("top_event_id");

                entity.Property(e => e.Pattern).HasColumnName("pattern");

                entity.Property(e => e.BranchId1).HasColumnName("branch_id_1");

                entity.Property(e => e.BranchId2).HasColumnName("branch_id_2");

                entity.Property(e => e.BranchId3).HasColumnName("branch_id_3");

                entity.Property(e => e.BranchId4).HasColumnName("branch_id_4");

                entity.Property(e => e.BranchId5).HasColumnName("branch_id_5");

                entity.Property(e => e.ChestId).HasColumnName("chest_id");

                entity.Property(e => e.DramaType).HasColumnName("drama_type");

                entity.Property(e => e.MainDramaId).HasColumnName("main_drama_id");

                entity.Property(e => e.PreDramaId).HasColumnName("pre_drama_id");

                entity.Property(e => e.ZoomOffsetX).HasColumnName("zoom_offset_x");

                entity.Property(e => e.ZoomOffsetY).HasColumnName("zoom_offset_y");
            });

            modelBuilder.Entity<TravelTopEventDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("travel_top_event_drama");

                entity.HasIndex(e => e.DramaId)
                    .HasName("travel_top_event_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<TravelTopEventPosDetail>(entity =>
            {
                entity.HasKey(e => e.PosId);

                entity.ToTable("travel_top_event_pos_detail");

                entity.Property(e => e.PosId)
                    .HasColumnName("pos_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllPosFlag).HasColumnName("all_pos_flag");

                entity.Property(e => e.PosGroupId).HasColumnName("pos_group_id");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");
            });

            modelBuilder.Entity<TrialBattleCategory>(entity =>
            {
                entity.HasKey(e => e.CategoryId);

                entity.ToTable("trial_battle_category");

                entity.Property(e => e.CategoryId)
                    .HasColumnName("category_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasColumnName("category_name");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DescriptionDetail)
                    .IsRequired()
                    .HasColumnName("description_detail");

                entity.Property(e => e.IconId).HasColumnName("icon_id");

                entity.Property(e => e.LabelType1).HasColumnName("label_type_1");

                entity.Property(e => e.LabelType2).HasColumnName("label_type_2");

                entity.Property(e => e.LabelType3).HasColumnName("label_type_3");
            });

            modelBuilder.Entity<TrialBattleData>(entity =>
            {
                entity.HasKey(e => e.QuestId);

                entity.ToTable("trial_battle_data");

                entity.HasIndex(e => e.CategoryId)
                    .HasName("trial_battle_data_0_category_id");

                entity.Property(e => e.QuestId)
                    .HasColumnName("quest_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BattleName)
                    .IsRequired()
                    .HasColumnName("battle_name");

                entity.Property(e => e.CategoryId).HasColumnName("category_id");

                entity.Property(e => e.ClearRewardGroup).HasColumnName("clear_reward_group");

                entity.Property(e => e.DetailBgId).HasColumnName("detail_bg_id");

                entity.Property(e => e.DetailBgPosition).HasColumnName("detail_bg_position");

                entity.Property(e => e.DetailBossBgHeight).HasColumnName("detail_boss_bg_height");

                entity.Property(e => e.DetailBossBgSize).HasColumnName("detail_boss_bg_size");

                entity.Property(e => e.Difficulty).HasColumnName("difficulty");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.WaveBgmQueId)
                    .IsRequired()
                    .HasColumnName("wave_bgm_que_id");

                entity.Property(e => e.WaveBgmSheetId)
                    .IsRequired()
                    .HasColumnName("wave_bgm_sheet_id");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<TrialBattleMissionData>(entity =>
            {
                entity.HasKey(e => e.TrialMissionId);

                entity.ToTable("trial_battle_mission_data");

                entity.Property(e => e.TrialMissionId)
                    .HasColumnName("trial_mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue).HasColumnName("condition_value");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.DispGroup).HasColumnName("disp_group");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.QuestId).HasColumnName("quest_id");
            });

            modelBuilder.Entity<TrialBattleMissionReward>(entity =>
            {
                entity.ToTable("trial_battle_mission_reward");

                entity.HasIndex(e => e.MissionRewardId)
                    .HasName("trial_battle_mission_reward_0_mission_reward_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissionRewardId).HasColumnName("mission_reward_id");

                entity.Property(e => e.RewardId).HasColumnName("reward_id");

                entity.Property(e => e.RewardNum).HasColumnName("reward_num");

                entity.Property(e => e.RewardType).HasColumnName("reward_type");
            });

            modelBuilder.Entity<TrialBattleRewardData>(entity =>
            {
                entity.HasKey(e => e.RewardGroupId);

                entity.ToTable("trial_battle_reward_data");

                entity.Property(e => e.RewardGroupId)
                    .HasColumnName("reward_group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<TtkDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("ttk_drama");

                entity.HasIndex(e => e.DramaId)
                    .HasName("ttk_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<TtkEnemy>(entity =>
            {
                entity.HasKey(e => e.EnemyId);

                entity.ToTable("ttk_enemy");

                entity.Property(e => e.EnemyId)
                    .HasColumnName("enemy_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Coin).HasColumnName("coin");

                entity.Property(e => e.Max).HasColumnName("max");

                entity.Property(e => e.Score).HasColumnName("score");
            });

            modelBuilder.Entity<TtkNaviComment>(entity =>
            {
                entity.HasKey(e => e.CommentId);

                entity.ToTable("ttk_navi_comment");

                entity.Property(e => e.CommentId)
                    .HasColumnName("comment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ChangeFaceTime).HasColumnName("change_face_time");

                entity.Property(e => e.ChangeFaceType).HasColumnName("change_face_type");

                entity.Property(e => e.CharacterId).HasColumnName("character_id");

                entity.Property(e => e.CharacterName)
                    .IsRequired()
                    .HasColumnName("character_name");

                entity.Property(e => e.Description).HasColumnName("description");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.WhereType).HasColumnName("where_type");
            });

            modelBuilder.Entity<TtkReward>(entity =>
            {
                entity.ToTable("ttk_reward");

                entity.HasIndex(e => e.TtkScore)
                    .HasName("ttk_reward_0_ttk_score");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MissionDetail)
                    .IsRequired()
                    .HasColumnName("mission_detail");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardCount4).HasColumnName("reward_count_4");

                entity.Property(e => e.RewardCount5).HasColumnName("reward_count_5");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.TtkScore).HasColumnName("ttk_score");
            });

            modelBuilder.Entity<TtkScore>(entity =>
            {
                entity.HasKey(e => e.DifficultyLevel);

                entity.ToTable("ttk_score");

                entity.Property(e => e.DifficultyLevel)
                    .HasColumnName("difficulty_level")
                    .ValueGeneratedNever();

                entity.Property(e => e.CoefficientCoinScore).HasColumnName("coefficient_coin_score");

                entity.Property(e => e.CoefficientDifficulty).HasColumnName("coefficient_difficulty");

                entity.Property(e => e.CoefficientWrongNum).HasColumnName("coefficient_wrong_num");

                entity.Property(e => e.Life).HasColumnName("life");
            });

            modelBuilder.Entity<TtkStory>(entity =>
            {
                entity.ToTable("ttk_story");

                entity.HasIndex(e => e.TtkScore)
                    .HasName("ttk_story_0_ttk_score");

                entity.Property(e => e.TtkStoryId)
                    .HasColumnName("ttk_story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");

                entity.Property(e => e.TtkScore).HasColumnName("ttk_score");
            });

            modelBuilder.Entity<TtkStoryScript>(entity =>
            {
                entity.ToTable("ttk_story_script");

                entity.HasIndex(e => e.StoryId)
                    .HasName("ttk_story_script_0_story_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Command).HasColumnName("command");

                entity.Property(e => e.CommandParam).HasColumnName("command_param");

                entity.Property(e => e.CueName)
                    .IsRequired()
                    .HasColumnName("cue_name");

                entity.Property(e => e.EndPos).HasColumnName("end_pos");

                entity.Property(e => e.LineNum).HasColumnName("line_num");

                entity.Property(e => e.SeekTime).HasColumnName("seek_time");

                entity.Property(e => e.SeqNum).HasColumnName("seq_num");

                entity.Property(e => e.SheetName)
                    .IsRequired()
                    .HasColumnName("sheet_name");

                entity.Property(e => e.StartPos).HasColumnName("start_pos");

                entity.Property(e => e.StoryId).HasColumnName("story_id");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<TtkWeapon>(entity =>
            {
                entity.ToTable("ttk_weapon");

                entity.HasIndex(e => e.TtkScore)
                    .HasName("ttk_weapon_0_ttk_score");

                entity.Property(e => e.TtkWeaponId)
                    .HasColumnName("ttk_weapon_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.TtkScore).HasColumnName("ttk_score");
            });

            modelBuilder.Entity<UbAutoData>(entity =>
            {
                entity.HasKey(e => e.UbAutoId);

                entity.ToTable("ub_auto_data");

                entity.Property(e => e.UbAutoId)
                    .HasColumnName("ub_auto_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AutoDetail1).HasColumnName("auto_detail_1");

                entity.Property(e => e.AutoDetail2).HasColumnName("auto_detail_2");

                entity.Property(e => e.AutoDetail3).HasColumnName("auto_detail_3");

                entity.Property(e => e.AutoDetail4).HasColumnName("auto_detail_4");

                entity.Property(e => e.AutoDetail5).HasColumnName("auto_detail_5");

                entity.Property(e => e.AutoType).HasColumnName("auto_type");

                entity.Property(e => e.AutoValue1).HasColumnName("auto_value_1");

                entity.Property(e => e.AutoValue2).HasColumnName("auto_value_2");

                entity.Property(e => e.AutoValue3).HasColumnName("auto_value_3");

                entity.Property(e => e.AutoValue4).HasColumnName("auto_value_4");

                entity.Property(e => e.AutoValue5).HasColumnName("auto_value_5");
            });

            modelBuilder.Entity<UbAutoDefine>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("ub_auto_define");

                entity.Property(e => e.SkillId)
                    .HasColumnName("skill_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UbAutoId1).HasColumnName("ub_auto_id_1");

                entity.Property(e => e.UbAutoId2).HasColumnName("ub_auto_id_2");

                entity.Property(e => e.UbAutoId3).HasColumnName("ub_auto_id_3");

                entity.Property(e => e.UbAutoId4).HasColumnName("ub_auto_id_4");

                entity.Property(e => e.UbAutoId5).HasColumnName("ub_auto_id_5");
            });

            modelBuilder.Entity<UekBoss>(entity =>
            {
                entity.HasKey(e => e.Area);

                entity.ToTable("uek_boss");

                entity.HasIndex(e => e.EnemyId)
                    .HasName("uek_boss_0_enemy_id");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .ValueGeneratedNever();

                entity.Property(e => e.Background).HasColumnName("background");

                entity.Property(e => e.BgmQueId)
                    .IsRequired()
                    .HasColumnName("bgm_que_id");

                entity.Property(e => e.BgmSheetId)
                    .IsRequired()
                    .HasColumnName("bgm_sheet_id");

                entity.Property(e => e.DetailBgId).HasColumnName("detail_bg_id");

                entity.Property(e => e.DetailBgPosition).HasColumnName("detail_bg_position");

                entity.Property(e => e.DetailBossBgHeight).HasColumnName("detail_boss_bg_height");

                entity.Property(e => e.DetailBossBgSize).HasColumnName("detail_boss_bg_size");

                entity.Property(e => e.EnemyId).HasColumnName("enemy_id");

                entity.Property(e => e.LimitTime).HasColumnName("limit_time");

                entity.Property(e => e.QuestName)
                    .IsRequired()
                    .HasColumnName("quest_name");

                entity.Property(e => e.ResultBossPositionY).HasColumnName("result_boss_position_y");

                entity.Property(e => e.ResultMovie).HasColumnName("result_movie");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");
            });

            modelBuilder.Entity<UekDrama>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("uek_drama");

                entity.HasIndex(e => e.DramaId)
                    .HasName("uek_drama_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<UekMission>(entity =>
            {
                entity.HasKey(e => e.MissionId);

                entity.ToTable("uek_mission");

                entity.Property(e => e.MissionId)
                    .HasColumnName("mission_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.ConditionNum).HasColumnName("condition_num");

                entity.Property(e => e.ConditionValue1).HasColumnName("condition_value_1");

                entity.Property(e => e.ConditionValue2).HasColumnName("condition_value_2");

                entity.Property(e => e.ConditionValue3).HasColumnName("condition_value_3");

                entity.Property(e => e.ConditionValue4).HasColumnName("condition_value_4");

                entity.Property(e => e.ConditionValue5).HasColumnName("condition_value_5");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.EventId).HasColumnName("event_id");

                entity.Property(e => e.MissionCondition).HasColumnName("mission_condition");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardId4).HasColumnName("reward_id_4");

                entity.Property(e => e.RewardId5).HasColumnName("reward_id_5");

                entity.Property(e => e.RewardNum1).HasColumnName("reward_num_1");

                entity.Property(e => e.RewardNum2).HasColumnName("reward_num_2");

                entity.Property(e => e.RewardNum3).HasColumnName("reward_num_3");

                entity.Property(e => e.RewardNum4).HasColumnName("reward_num_4");

                entity.Property(e => e.RewardNum5).HasColumnName("reward_num_5");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.SystemId).HasColumnName("system_id");
            });

            modelBuilder.Entity<UekSpineAnimLink>(entity =>
            {
                entity.HasKey(e => e.SpineId);

                entity.ToTable("uek_spine_anim_link");

                entity.HasIndex(e => e.AnimNum)
                    .HasName("uek_spine_anim_link_0_anim_num");

                entity.Property(e => e.SpineId)
                    .HasColumnName("spine_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AnimNum).HasColumnName("anim_num");
            });

            modelBuilder.Entity<UniqueEquipEnhanceRate>(entity =>
            {
                entity.ToTable("unique_equip_enhance_rate");

                entity.HasIndex(e => e.EquipmentId)
                    .HasName("unique_equip_enhance_rate_0_equipment_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MaxLv).HasColumnName("max_lv");

                entity.Property(e => e.MinLv).HasColumnName("min_lv");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<UniqueEquipmentBonus>(entity =>
            {
                entity.ToTable("unique_equipment_bonus");

                entity.HasIndex(e => e.EquipmentId)
                    .HasName("unique_equipment_bonus_0_equipment_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EquipmentId).HasColumnName("equipment_id");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MaxLv).HasColumnName("max_lv");

                entity.Property(e => e.MinLv).HasColumnName("min_lv");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<UniqueEquipmentCraft>(entity =>
            {
                entity.HasKey(e => e.EquipId);

                entity.ToTable("unique_equipment_craft");

                entity.Property(e => e.EquipId)
                    .HasColumnName("equip_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConsumeNum1).HasColumnName("consume_num_1");

                entity.Property(e => e.ConsumeNum10).HasColumnName("consume_num_10");

                entity.Property(e => e.ConsumeNum2).HasColumnName("consume_num_2");

                entity.Property(e => e.ConsumeNum3).HasColumnName("consume_num_3");

                entity.Property(e => e.ConsumeNum4).HasColumnName("consume_num_4");

                entity.Property(e => e.ConsumeNum5).HasColumnName("consume_num_5");

                entity.Property(e => e.ConsumeNum6).HasColumnName("consume_num_6");

                entity.Property(e => e.ConsumeNum7).HasColumnName("consume_num_7");

                entity.Property(e => e.ConsumeNum8).HasColumnName("consume_num_8");

                entity.Property(e => e.ConsumeNum9).HasColumnName("consume_num_9");

                entity.Property(e => e.CraftedCost).HasColumnName("crafted_cost");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemId10).HasColumnName("item_id_10");

                entity.Property(e => e.ItemId2).HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3).HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4).HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5).HasColumnName("item_id_5");

                entity.Property(e => e.ItemId6).HasColumnName("item_id_6");

                entity.Property(e => e.ItemId7).HasColumnName("item_id_7");

                entity.Property(e => e.ItemId8).HasColumnName("item_id_8");

                entity.Property(e => e.ItemId9).HasColumnName("item_id_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");
            });

            modelBuilder.Entity<UniqueEquipmentData>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("unique_equipment_data");

                entity.Property(e => e.EquipmentId)
                    .HasColumnName("equipment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.CraftFlg).HasColumnName("craft_flg");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnableDonation).HasColumnName("enable_donation");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EquipmentEnhancePoint).HasColumnName("equipment_enhance_point");

                entity.Property(e => e.EquipmentName)
                    .IsRequired()
                    .HasColumnName("equipment_name");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.RequireLevel).HasColumnName("require_level");

                entity.Property(e => e.SalePrice).HasColumnName("sale_price");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<UniqueEquipmentEnhanceData>(entity =>
            {
                entity.HasKey(e => new { e.EquipSlot, e.EnhanceLevel });

                entity.ToTable("unique_equipment_enhance_data");

                entity.Property(e => e.EquipSlot).HasColumnName("equip_slot");

                entity.Property(e => e.EnhanceLevel).HasColumnName("enhance_level");

                entity.Property(e => e.NeededMana).HasColumnName("needed_mana");

                entity.Property(e => e.NeededPoint).HasColumnName("needed_point");

                entity.Property(e => e.Rank).HasColumnName("rank");

                entity.Property(e => e.TotalPoint).HasColumnName("total_point");
            });

            modelBuilder.Entity<UniqueEquipmentEnhanceRate>(entity =>
            {
                entity.HasKey(e => e.EquipmentId);

                entity.ToTable("unique_equipment_enhance_rate");

                entity.Property(e => e.EquipmentId)
                    .HasColumnName("equipment_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EquipmentName)
                    .IsRequired()
                    .HasColumnName("equipment_name");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<UniqueEquipmentRankup>(entity =>
            {
                entity.HasKey(e => new { e.EquipId, e.UniqueEquipRank });

                entity.ToTable("unique_equipment_rankup");

                entity.HasIndex(e => e.EquipId)
                    .HasName("unique_equipment_rankup_0_equip_id");

                entity.Property(e => e.EquipId).HasColumnName("equip_id");

                entity.Property(e => e.UniqueEquipRank).HasColumnName("unique_equip_rank");

                entity.Property(e => e.ConsumeNum1).HasColumnName("consume_num_1");

                entity.Property(e => e.ConsumeNum10).HasColumnName("consume_num_10");

                entity.Property(e => e.ConsumeNum2).HasColumnName("consume_num_2");

                entity.Property(e => e.ConsumeNum3).HasColumnName("consume_num_3");

                entity.Property(e => e.ConsumeNum4).HasColumnName("consume_num_4");

                entity.Property(e => e.ConsumeNum5).HasColumnName("consume_num_5");

                entity.Property(e => e.ConsumeNum6).HasColumnName("consume_num_6");

                entity.Property(e => e.ConsumeNum7).HasColumnName("consume_num_7");

                entity.Property(e => e.ConsumeNum8).HasColumnName("consume_num_8");

                entity.Property(e => e.ConsumeNum9).HasColumnName("consume_num_9");

                entity.Property(e => e.CraftedCost).HasColumnName("crafted_cost");

                entity.Property(e => e.ItemId1).HasColumnName("item_id_1");

                entity.Property(e => e.ItemId10).HasColumnName("item_id_10");

                entity.Property(e => e.ItemId2).HasColumnName("item_id_2");

                entity.Property(e => e.ItemId3).HasColumnName("item_id_3");

                entity.Property(e => e.ItemId4).HasColumnName("item_id_4");

                entity.Property(e => e.ItemId5).HasColumnName("item_id_5");

                entity.Property(e => e.ItemId6).HasColumnName("item_id_6");

                entity.Property(e => e.ItemId7).HasColumnName("item_id_7");

                entity.Property(e => e.ItemId8).HasColumnName("item_id_8");

                entity.Property(e => e.ItemId9).HasColumnName("item_id_9");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType10).HasColumnName("reward_type_10");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.RewardType4).HasColumnName("reward_type_4");

                entity.Property(e => e.RewardType5).HasColumnName("reward_type_5");

                entity.Property(e => e.RewardType6).HasColumnName("reward_type_6");

                entity.Property(e => e.RewardType7).HasColumnName("reward_type_7");

                entity.Property(e => e.RewardType8).HasColumnName("reward_type_8");

                entity.Property(e => e.RewardType9).HasColumnName("reward_type_9");

                entity.Property(e => e.UnitLevel).HasColumnName("unit_level");
            });

            modelBuilder.Entity<UnitAttackPattern>(entity =>
            {
                entity.HasKey(e => e.PatternId);

                entity.ToTable("unit_attack_pattern");

                entity.Property(e => e.PatternId)
                    .HasColumnName("pattern_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtkPattern1).HasColumnName("atk_pattern_1");

                entity.Property(e => e.AtkPattern10).HasColumnName("atk_pattern_10");

                entity.Property(e => e.AtkPattern11).HasColumnName("atk_pattern_11");

                entity.Property(e => e.AtkPattern12).HasColumnName("atk_pattern_12");

                entity.Property(e => e.AtkPattern13).HasColumnName("atk_pattern_13");

                entity.Property(e => e.AtkPattern14).HasColumnName("atk_pattern_14");

                entity.Property(e => e.AtkPattern15).HasColumnName("atk_pattern_15");

                entity.Property(e => e.AtkPattern16).HasColumnName("atk_pattern_16");

                entity.Property(e => e.AtkPattern17).HasColumnName("atk_pattern_17");

                entity.Property(e => e.AtkPattern18).HasColumnName("atk_pattern_18");

                entity.Property(e => e.AtkPattern19).HasColumnName("atk_pattern_19");

                entity.Property(e => e.AtkPattern2).HasColumnName("atk_pattern_2");

                entity.Property(e => e.AtkPattern20).HasColumnName("atk_pattern_20");

                entity.Property(e => e.AtkPattern3).HasColumnName("atk_pattern_3");

                entity.Property(e => e.AtkPattern4).HasColumnName("atk_pattern_4");

                entity.Property(e => e.AtkPattern5).HasColumnName("atk_pattern_5");

                entity.Property(e => e.AtkPattern6).HasColumnName("atk_pattern_6");

                entity.Property(e => e.AtkPattern7).HasColumnName("atk_pattern_7");

                entity.Property(e => e.AtkPattern8).HasColumnName("atk_pattern_8");

                entity.Property(e => e.AtkPattern9).HasColumnName("atk_pattern_9");

                entity.Property(e => e.LoopEnd).HasColumnName("loop_end");

                entity.Property(e => e.LoopStart).HasColumnName("loop_start");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<UnitBackground>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_background");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.BgName)
                    .IsRequired()
                    .HasColumnName("bg_name");

                entity.Property(e => e.FaceType).HasColumnName("face_type");

                entity.Property(e => e.Position).HasColumnName("position");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasColumnName("unit_name");
            });

            modelBuilder.Entity<UnitClipSetting>(entity =>
            {
                entity.HasKey(e => e.ClipId);

                entity.ToTable("unit_clip_setting");

                entity.Property(e => e.ClipId)
                    .HasColumnName("clip_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CenterX).HasColumnName("center_x");

                entity.Property(e => e.SizeX).HasColumnName("size_x");

                entity.Property(e => e.SoftnessX).HasColumnName("softness_x");
            });

            modelBuilder.Entity<UnitComments>(entity =>
            {
                entity.ToTable("unit_comments");

                entity.HasIndex(e => e.UnitId)
                    .HasName("unit_comments_0_unit_id");

                entity.HasIndex(e => new { e.UnitId, e.UseType })
                    .HasName("unit_comments_0_unit_id_1_use_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllCommentsFlag).HasColumnName("all_comments_flag");

                entity.Property(e => e.ChangeFace).HasColumnName("change_face");

                entity.Property(e => e.ChangeFace2).HasColumnName("change_face_2");

                entity.Property(e => e.ChangeFace3).HasColumnName("change_face_3");

                entity.Property(e => e.ChangeTime).HasColumnName("change_time");

                entity.Property(e => e.ChangeTime2).HasColumnName("change_time_2");

                entity.Property(e => e.ChangeTime3).HasColumnName("change_time_3");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description");

                entity.Property(e => e.FaceId).HasColumnName("face_id");

                entity.Property(e => e.FaceId2).HasColumnName("face_id_2");

                entity.Property(e => e.FaceId3).HasColumnName("face_id_3");

                entity.Property(e => e.TargetUnitId).HasColumnName("target_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.UseType).HasColumnName("use_type");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");
            });

            modelBuilder.Entity<UnitConversion>(entity =>
            {
                entity.HasKey(e => e.OriginalUnitId);

                entity.ToTable("unit_conversion");

                entity.HasIndex(e => e.UnitId)
                    .HasName("unit_conversion_0_unit_id")
                    .IsUnique();

                entity.Property(e => e.OriginalUnitId)
                    .HasColumnName("original_unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UnitId).HasColumnName("unit_id");
            });

            modelBuilder.Entity<UnitData>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_data");

                entity.HasIndex(e => e.OriginalUnitId)
                    .HasName("unit_data_0_original_unit_id");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtkType).HasColumnName("atk_type");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Cutin1).HasColumnName("cutin_1");

                entity.Property(e => e.Cutin1Star6).HasColumnName("cutin1_star6");

                entity.Property(e => e.Cutin2).HasColumnName("cutin_2");

                entity.Property(e => e.Cutin2Star6).HasColumnName("cutin2_star6");

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.ExskillDisplay).HasColumnName("exskill_display");

                entity.Property(e => e.GuildId).HasColumnName("guild_id");

                entity.Property(e => e.IsLimited).HasColumnName("is_limited");

                entity.Property(e => e.Kana)
                    .IsRequired()
                    .HasColumnName("kana");

                entity.Property(e => e.MotionType).HasColumnName("motion_type");

                entity.Property(e => e.MoveSpeed).HasColumnName("move_speed");

                entity.Property(e => e.NormalAtkCastTime).HasColumnName("normal_atk_cast_time");

                entity.Property(e => e.OnlyDispOwned).HasColumnName("only_disp_owned");

                entity.Property(e => e.OriginalUnitId).HasColumnName("original_unit_id");

                entity.Property(e => e.PrefabId).HasColumnName("prefab_id");

                entity.Property(e => e.PrefabIdBattle).HasColumnName("prefab_id_battle");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.SeType).HasColumnName("se_type");

                entity.Property(e => e.SearchAreaWidth).HasColumnName("search_area_width");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasColumnName("unit_name");
            });

            modelBuilder.Entity<UnitEnemyData>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_enemy_data");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AtkType).HasColumnName("atk_type");

                entity.Property(e => e.Comment)
                    .IsRequired()
                    .HasColumnName("comment");

                entity.Property(e => e.Cutin).HasColumnName("cutin");

                entity.Property(e => e.CutinStar6).HasColumnName("cutin_star6");

                entity.Property(e => e.MotionType).HasColumnName("motion_type");

                entity.Property(e => e.MoveSpeed).HasColumnName("move_speed");

                entity.Property(e => e.NormalAtkCastTime).HasColumnName("normal_atk_cast_time");

                entity.Property(e => e.PrefabId).HasColumnName("prefab_id");

                entity.Property(e => e.SeType).HasColumnName("se_type");

                entity.Property(e => e.SearchAreaWidth).HasColumnName("search_area_width");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasColumnName("unit_name");

                entity.Property(e => e.VisualChangeFlag).HasColumnName("visual_change_flag");
            });

            modelBuilder.Entity<UnitExEquipmentSlot>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_ex_equipment_slot");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SlotCategory1).HasColumnName("slot_category_1");

                entity.Property(e => e.SlotCategory2).HasColumnName("slot_category_2");

                entity.Property(e => e.SlotCategory3).HasColumnName("slot_category_3");
            });

            modelBuilder.Entity<UnitIntroduction>(entity =>
            {
                entity.ToTable("unit_introduction");

                entity.HasIndex(e => e.GachaId)
                    .HasName("unit_introduction_0_gacha_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.GachaId).HasColumnName("gacha_id");

                entity.Property(e => e.IntroductionNumber).HasColumnName("introduction_number");

                entity.Property(e => e.MaximumChunkSize1).HasColumnName("maximum_chunk_size_1");

                entity.Property(e => e.MaximumChunkSize2).HasColumnName("maximum_chunk_size_2");

                entity.Property(e => e.MaximumChunkSize3).HasColumnName("maximum_chunk_size_3");

                entity.Property(e => e.MaximumChunkSizeLoop1).HasColumnName("maximum_chunk_size_loop_1");

                entity.Property(e => e.MaximumChunkSizeLoop2).HasColumnName("maximum_chunk_size_loop_2");

                entity.Property(e => e.MaximumChunkSizeLoop3).HasColumnName("maximum_chunk_size_loop_3");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");
            });

            modelBuilder.Entity<UnitMotionList>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_motion_list");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.SpMotion).HasColumnName("sp_motion");
            });

            modelBuilder.Entity<UnitMypagePos>(entity =>
            {
                entity.ToTable("unit_mypage_pos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.Scale).HasColumnName("scale");
            });

            modelBuilder.Entity<UnitPosAdjustment>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_pos_adjustment");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Actual1Clip).HasColumnName("actual_1_clip");

                entity.Property(e => e.Actual1Depth).HasColumnName("actual_1_depth");

                entity.Property(e => e.Actual1PosX).HasColumnName("actual_1_pos_x");

                entity.Property(e => e.Actual1PosY).HasColumnName("actual_1_pos_y");

                entity.Property(e => e.Actual2Clip).HasColumnName("actual_2_clip");

                entity.Property(e => e.Actual2Depth).HasColumnName("actual_2_depth");

                entity.Property(e => e.Actual2PosX).HasColumnName("actual_2_pos_x");

                entity.Property(e => e.Actual2PosY).HasColumnName("actual_2_pos_y");

                entity.Property(e => e.Actual3Clip).HasColumnName("actual_3_clip");

                entity.Property(e => e.Actual3Depth).HasColumnName("actual_3_depth");

                entity.Property(e => e.Actual3PosX).HasColumnName("actual_3_pos_x");

                entity.Property(e => e.Actual3PosY).HasColumnName("actual_3_pos_y");

                entity.Property(e => e.ActualId1).HasColumnName("actual_id1");

                entity.Property(e => e.ActualId2).HasColumnName("actual_id2");

                entity.Property(e => e.ActualId3).HasColumnName("actual_id3");

                entity.Property(e => e.FriendPosX).HasColumnName("friend_pos_x");

                entity.Property(e => e.Home1Clip).HasColumnName("home_1_clip");

                entity.Property(e => e.Home1Depth).HasColumnName("home_1_depth");

                entity.Property(e => e.Home1PosX).HasColumnName("home_1_pos_x");

                entity.Property(e => e.Home1PosY).HasColumnName("home_1_pos_y");

                entity.Property(e => e.Home2Clip).HasColumnName("home_2_clip");

                entity.Property(e => e.Home2Depth).HasColumnName("home_2_depth");

                entity.Property(e => e.Home2PosX).HasColumnName("home_2_pos_x");

                entity.Property(e => e.Home2PosY).HasColumnName("home_2_pos_y");

                entity.Property(e => e.Home3Clip).HasColumnName("home_3_clip");

                entity.Property(e => e.Home3Depth).HasColumnName("home_3_depth");

                entity.Property(e => e.Home3PosX).HasColumnName("home_3_pos_x");

                entity.Property(e => e.Home3PosY).HasColumnName("home_3_pos_y");

                entity.Property(e => e.Id1).HasColumnName("id_1");

                entity.Property(e => e.Id2).HasColumnName("id_2");

                entity.Property(e => e.Id3).HasColumnName("id_3");

                entity.Property(e => e.IsMyprofileImage).HasColumnName("is_myprofile_image");

                entity.Property(e => e.Profile1Clip).HasColumnName("profile_1_clip");

                entity.Property(e => e.Profile1Depth).HasColumnName("profile_1_depth");

                entity.Property(e => e.Profile1PosX).HasColumnName("profile_1_pos_x");

                entity.Property(e => e.Profile1PosY).HasColumnName("profile_1_pos_y");

                entity.Property(e => e.Profile1Scale).HasColumnName("profile_1_scale");

                entity.Property(e => e.Profile2Clip).HasColumnName("profile_2_clip");

                entity.Property(e => e.Profile2Depth).HasColumnName("profile_2_depth");

                entity.Property(e => e.Profile2PosX).HasColumnName("profile_2_pos_x");

                entity.Property(e => e.Profile2PosY).HasColumnName("profile_2_pos_y");

                entity.Property(e => e.Profile2Scale).HasColumnName("profile_2_scale");

                entity.Property(e => e.Profile3Clip).HasColumnName("profile_3_clip");

                entity.Property(e => e.Profile3Depth).HasColumnName("profile_3_depth");

                entity.Property(e => e.Profile3PosX).HasColumnName("profile_3_pos_x");

                entity.Property(e => e.Profile3PosY).HasColumnName("profile_3_pos_y");

                entity.Property(e => e.Profile3Scale).HasColumnName("profile_3_scale");

                entity.Property(e => e.SkipPositionX).HasColumnName("skip_position_x");
            });

            modelBuilder.Entity<UnitProfile>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_profile");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Age)
                    .IsRequired()
                    .HasColumnName("age");

                entity.Property(e => e.BirthDay)
                    .IsRequired()
                    .HasColumnName("birth_day");

                entity.Property(e => e.BirthMonth)
                    .IsRequired()
                    .HasColumnName("birth_month");

                entity.Property(e => e.BloodType)
                    .IsRequired()
                    .HasColumnName("blood_type");

                entity.Property(e => e.CatchCopy)
                    .IsRequired()
                    .HasColumnName("catch_copy");

                entity.Property(e => e.Favorite)
                    .IsRequired()
                    .HasColumnName("favorite");

                entity.Property(e => e.Guild)
                    .IsRequired()
                    .HasColumnName("guild");

                entity.Property(e => e.GuildId)
                    .IsRequired()
                    .HasColumnName("guild_id");

                entity.Property(e => e.Height)
                    .IsRequired()
                    .HasColumnName("height");

                entity.Property(e => e.Race)
                    .IsRequired()
                    .HasColumnName("race");

                entity.Property(e => e.SelfText)
                    .IsRequired()
                    .HasColumnName("self_text");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasColumnName("unit_name");

                entity.Property(e => e.Voice)
                    .IsRequired()
                    .HasColumnName("voice");

                entity.Property(e => e.VoiceId).HasColumnName("voice_id");

                entity.Property(e => e.Weight)
                    .IsRequired()
                    .HasColumnName("weight");
            });

            modelBuilder.Entity<UnitPromotion>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.PromotionLevel });

                entity.ToTable("unit_promotion");

                entity.HasIndex(e => e.UnitId)
                    .HasName("unit_promotion_0_unit_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.EquipSlot1).HasColumnName("equip_slot_1");

                entity.Property(e => e.EquipSlot2).HasColumnName("equip_slot_2");

                entity.Property(e => e.EquipSlot3).HasColumnName("equip_slot_3");

                entity.Property(e => e.EquipSlot4).HasColumnName("equip_slot_4");

                entity.Property(e => e.EquipSlot5).HasColumnName("equip_slot_5");

                entity.Property(e => e.EquipSlot6).HasColumnName("equip_slot_6");
            });

            modelBuilder.Entity<UnitPromotionStatus>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.PromotionLevel });

                entity.ToTable("unit_promotion_status");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<UnitRarity>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.Rarity });

                entity.ToTable("unit_rarity");

                entity.HasIndex(e => e.UnitId)
                    .HasName("unit_rarity_0_unit_id");

                entity.HasIndex(e => e.UnitMaterialId)
                    .HasName("unit_rarity_0_unit_material_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.Rarity).HasColumnName("rarity");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.AccuracyGrowth).HasColumnName("accuracy_growth");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.AtkGrowth).HasColumnName("atk_growth");

                entity.Property(e => e.ConsumeGold).HasColumnName("consume_gold");

                entity.Property(e => e.ConsumeNum).HasColumnName("consume_num");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.DefGrowth).HasColumnName("def_growth");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.DodgeGrowth).HasColumnName("dodge_growth");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyRecoveryRateGrowth).HasColumnName("energy_recovery_rate_growth");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.EnergyReduceRateGrowth).HasColumnName("energy_reduce_rate_growth");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpGrowth).HasColumnName("hp_growth");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.HpRecoveryRateGrowth).HasColumnName("hp_recovery_rate_growth");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.LifeStealGrowth).HasColumnName("life_steal_growth");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicCriticalGrowth).HasColumnName("magic_critical_growth");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicDefGrowth).HasColumnName("magic_def_growth");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicPenetrateGrowth).HasColumnName("magic_penetrate_growth");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MagicStrGrowth).HasColumnName("magic_str_growth");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalCriticalGrowth).HasColumnName("physical_critical_growth");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.PhysicalPenetrateGrowth).HasColumnName("physical_penetrate_growth");

                entity.Property(e => e.UnitMaterialId).HasColumnName("unit_material_id");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveEnergyRecoveryGrowth).HasColumnName("wave_energy_recovery_growth");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");

                entity.Property(e => e.WaveHpRecoveryGrowth).HasColumnName("wave_hp_recovery_growth");
            });

            modelBuilder.Entity<UnitSkillData>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_skill_data");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ExSkill1).HasColumnName("ex_skill_1");

                entity.Property(e => e.ExSkill2).HasColumnName("ex_skill_2");

                entity.Property(e => e.ExSkill3).HasColumnName("ex_skill_3");

                entity.Property(e => e.ExSkill4).HasColumnName("ex_skill_4");

                entity.Property(e => e.ExSkill5).HasColumnName("ex_skill_5");

                entity.Property(e => e.ExSkillEvolution1).HasColumnName("ex_skill_evolution_1");

                entity.Property(e => e.ExSkillEvolution2).HasColumnName("ex_skill_evolution_2");

                entity.Property(e => e.ExSkillEvolution3).HasColumnName("ex_skill_evolution_3");

                entity.Property(e => e.ExSkillEvolution4).HasColumnName("ex_skill_evolution_4");

                entity.Property(e => e.ExSkillEvolution5).HasColumnName("ex_skill_evolution_5");

                entity.Property(e => e.MainSkill1).HasColumnName("main_skill_1");

                entity.Property(e => e.MainSkill10).HasColumnName("main_skill_10");

                entity.Property(e => e.MainSkill2).HasColumnName("main_skill_2");

                entity.Property(e => e.MainSkill3).HasColumnName("main_skill_3");

                entity.Property(e => e.MainSkill4).HasColumnName("main_skill_4");

                entity.Property(e => e.MainSkill5).HasColumnName("main_skill_5");

                entity.Property(e => e.MainSkill6).HasColumnName("main_skill_6");

                entity.Property(e => e.MainSkill7).HasColumnName("main_skill_7");

                entity.Property(e => e.MainSkill8).HasColumnName("main_skill_8");

                entity.Property(e => e.MainSkill9).HasColumnName("main_skill_9");

                entity.Property(e => e.MainSkillEvolution1).HasColumnName("main_skill_evolution_1");

                entity.Property(e => e.MainSkillEvolution2).HasColumnName("main_skill_evolution_2");

                entity.Property(e => e.SpSkill1).HasColumnName("sp_skill_1");

                entity.Property(e => e.SpSkill2).HasColumnName("sp_skill_2");

                entity.Property(e => e.SpSkill3).HasColumnName("sp_skill_3");

                entity.Property(e => e.SpSkill4).HasColumnName("sp_skill_4");

                entity.Property(e => e.SpSkill5).HasColumnName("sp_skill_5");

                entity.Property(e => e.SpSkillEvolution1).HasColumnName("sp_skill_evolution_1");

                entity.Property(e => e.SpSkillEvolution2).HasColumnName("sp_skill_evolution_2");

                entity.Property(e => e.SpUnionBurst).HasColumnName("sp_union_burst");

                entity.Property(e => e.UnionBurst).HasColumnName("union_burst");

                entity.Property(e => e.UnionBurstEvolution).HasColumnName("union_burst_evolution");
            });

            modelBuilder.Entity<UnitSkillDataRf>(entity =>
            {
                entity.ToTable("unit_skill_data_rf");

                entity.HasIndex(e => e.RfSkillId)
                    .HasName("unit_skill_data_rf_0_rf_skill_id");

                entity.HasIndex(e => e.SkillId)
                    .HasName("unit_skill_data_rf_0_skill_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.MaxLv).HasColumnName("max_lv");

                entity.Property(e => e.MinLv).HasColumnName("min_lv");

                entity.Property(e => e.RfSkillId).HasColumnName("rf_skill_id");

                entity.Property(e => e.SkillId).HasColumnName("skill_id");
            });

            modelBuilder.Entity<UnitStatusCoefficient>(entity =>
            {
                entity.HasKey(e => e.CoefficientId);

                entity.ToTable("unit_status_coefficient");

                entity.Property(e => e.CoefficientId)
                    .HasColumnName("coefficient_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccuracyCoefficient).HasColumnName("accuracy_coefficient");

                entity.Property(e => e.AtkCoefficient).HasColumnName("atk_coefficient");

                entity.Property(e => e.DefCoefficient).HasColumnName("def_coefficient");

                entity.Property(e => e.DodgeCoefficient).HasColumnName("dodge_coefficient");

                entity.Property(e => e.EnergyRecoveryRateCoefficient).HasColumnName("energy_recovery_rate_coefficient");

                entity.Property(e => e.EnergyReduceRateCoefficient).HasColumnName("energy_reduce_rate_coefficient");

                entity.Property(e => e.ExskillEvolutionCoefficient).HasColumnName("exskill_evolution_coefficient");

                entity.Property(e => e.HpCoefficient).HasColumnName("hp_coefficient");

                entity.Property(e => e.HpRecoveryRateCoefficient).HasColumnName("hp_recovery_rate_coefficient");

                entity.Property(e => e.LifeStealCoefficient).HasColumnName("life_steal_coefficient");

                entity.Property(e => e.MagicCriticalCoefficient).HasColumnName("magic_critical_coefficient");

                entity.Property(e => e.MagicDefCoefficient).HasColumnName("magic_def_coefficient");

                entity.Property(e => e.MagicPenetrateCoefficient).HasColumnName("magic_penetrate_coefficient");

                entity.Property(e => e.MagicStrCoefficient).HasColumnName("magic_str_coefficient");

                entity.Property(e => e.OverallCoefficient).HasColumnName("overall_coefficient");

                entity.Property(e => e.PhysicalCriticalCoefficient).HasColumnName("physical_critical_coefficient");

                entity.Property(e => e.PhysicalPenetrateCoefficient).HasColumnName("physical_penetrate_coefficient");

                entity.Property(e => e.Skill1EvolutionCoefficient).HasColumnName("skill1_evolution_coefficient");

                entity.Property(e => e.Skill1EvolutionSlvCoefficient).HasColumnName("skill1_evolution_slv_coefficient");

                entity.Property(e => e.SkillLvCoefficient).HasColumnName("skill_lv_coefficient");

                entity.Property(e => e.UbEvolutionCoefficient).HasColumnName("ub_evolution_coefficient");

                entity.Property(e => e.UbEvolutionSlvCoefficient).HasColumnName("ub_evolution_slv_coefficient");

                entity.Property(e => e.WaveEnergyRecoveryCoefficient).HasColumnName("wave_energy_recovery_coefficient");

                entity.Property(e => e.WaveHpRecoveryCoefficient).HasColumnName("wave_hp_recovery_coefficient");
            });

            modelBuilder.Entity<UnitUniqueEquip>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unit_unique_equip");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EquipId).HasColumnName("equip_id");

                entity.Property(e => e.EquipSlot).HasColumnName("equip_slot");
            });

            modelBuilder.Entity<UnlockRarity6>(entity =>
            {
                entity.HasKey(e => new { e.UnitId, e.SlotId, e.UnlockLevel });

                entity.ToTable("unlock_rarity_6");

                entity.HasIndex(e => e.MaterialId)
                    .HasName("unlock_rarity_6_0_material_id");

                entity.HasIndex(e => e.UnitId)
                    .HasName("unlock_rarity_6_0_unit_id");

                entity.HasIndex(e => new { e.UnitId, e.SlotId })
                    .HasName("unlock_rarity_6_0_unit_id_1_slot_id");

                entity.HasIndex(e => new { e.UnitId, e.UnlockLevel })
                    .HasName("unlock_rarity_6_0_unit_id_1_unlock_level");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.SlotId).HasColumnName("slot_id");

                entity.Property(e => e.UnlockLevel).HasColumnName("unlock_level");

                entity.Property(e => e.Accuracy).HasColumnName("accuracy");

                entity.Property(e => e.Atk).HasColumnName("atk");

                entity.Property(e => e.ConsumeGold).HasColumnName("consume_gold");

                entity.Property(e => e.Def).HasColumnName("def");

                entity.Property(e => e.Dodge).HasColumnName("dodge");

                entity.Property(e => e.EnergyRecoveryRate).HasColumnName("energy_recovery_rate");

                entity.Property(e => e.EnergyReduceRate).HasColumnName("energy_reduce_rate");

                entity.Property(e => e.Hp).HasColumnName("hp");

                entity.Property(e => e.HpRecoveryRate).HasColumnName("hp_recovery_rate");

                entity.Property(e => e.LifeSteal).HasColumnName("life_steal");

                entity.Property(e => e.MagicCritical).HasColumnName("magic_critical");

                entity.Property(e => e.MagicDef).HasColumnName("magic_def");

                entity.Property(e => e.MagicPenetrate).HasColumnName("magic_penetrate");

                entity.Property(e => e.MagicStr).HasColumnName("magic_str");

                entity.Property(e => e.MaterialCount).HasColumnName("material_count");

                entity.Property(e => e.MaterialId).HasColumnName("material_id");

                entity.Property(e => e.MaterialType).HasColumnName("material_type");

                entity.Property(e => e.PhysicalCritical).HasColumnName("physical_critical");

                entity.Property(e => e.PhysicalPenetrate).HasColumnName("physical_penetrate");

                entity.Property(e => e.UnlockFlag).HasColumnName("unlock_flag");

                entity.Property(e => e.WaveEnergyRecovery).HasColumnName("wave_energy_recovery");

                entity.Property(e => e.WaveHpRecovery).HasColumnName("wave_hp_recovery");
            });

            modelBuilder.Entity<UnlockSkillData>(entity =>
            {
                entity.HasKey(e => e.UnlockSkill);

                entity.ToTable("unlock_skill_data");

                entity.Property(e => e.UnlockSkill)
                    .HasColumnName("unlock_skill")
                    .ValueGeneratedNever();

                entity.Property(e => e.PromotionLevel).HasColumnName("promotion_level");
            });

            modelBuilder.Entity<UnlockUnitCondition>(entity =>
            {
                entity.HasKey(e => e.UnitId);

                entity.ToTable("unlock_unit_condition");

                entity.Property(e => e.UnitId)
                    .HasColumnName("unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClassId).HasColumnName("class_id");

                entity.Property(e => e.ConditionId1).HasColumnName("condition_id_1");

                entity.Property(e => e.ConditionId2).HasColumnName("condition_id_2");

                entity.Property(e => e.ConditionId3).HasColumnName("condition_id_3");

                entity.Property(e => e.ConditionId4).HasColumnName("condition_id_4");

                entity.Property(e => e.ConditionId5).HasColumnName("condition_id_5");

                entity.Property(e => e.ConditionType1).HasColumnName("condition_type_1");

                entity.Property(e => e.ConditionType2).HasColumnName("condition_type_2");

                entity.Property(e => e.ConditionType3).HasColumnName("condition_type_3");

                entity.Property(e => e.ConditionType4).HasColumnName("condition_type_4");

                entity.Property(e => e.ConditionType5).HasColumnName("condition_type_5");

                entity.Property(e => e.ConditionTypeDetail1).HasColumnName("condition_type_detail_1");

                entity.Property(e => e.ConditionTypeDetail2).HasColumnName("condition_type_detail_2");

                entity.Property(e => e.ConditionTypeDetail3).HasColumnName("condition_type_detail_3");

                entity.Property(e => e.ConditionTypeDetail4).HasColumnName("condition_type_detail_4");

                entity.Property(e => e.ConditionTypeDetail5).HasColumnName("condition_type_detail_5");

                entity.Property(e => e.Count1).HasColumnName("count_1");

                entity.Property(e => e.Count2).HasColumnName("count_2");

                entity.Property(e => e.Count3).HasColumnName("count_3");

                entity.Property(e => e.Count4).HasColumnName("count_4");

                entity.Property(e => e.Count5).HasColumnName("count_5");

                entity.Property(e => e.PreUnitId).HasColumnName("pre_unit_id");

                entity.Property(e => e.ReleaseEffectType).HasColumnName("release_effect_type");

                entity.Property(e => e.UnitName)
                    .IsRequired()
                    .HasColumnName("unit_name");
            });

            modelBuilder.Entity<VisualCustomize>(entity =>
            {
                entity.ToTable("visual_customize");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasColumnName("end_time");

                entity.Property(e => e.ProfileLogo).HasColumnName("profile_logo");

                entity.Property(e => e.QuestTopMovie).HasColumnName("quest_top_movie");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasColumnName("start_time");

                entity.Property(e => e.StoryTopMovie).HasColumnName("story_top_movie");

                entity.Property(e => e.TitleMovie).HasColumnName("title_movie");

                entity.Property(e => e.TitlePrefab).HasColumnName("title_prefab");

                entity.Property(e => e.TitleVoice).HasColumnName("title_voice");

                entity.Property(e => e.WatchedStoryId).HasColumnName("watched_story_id");
            });

            modelBuilder.Entity<VoiceGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId);

                entity.ToTable("voice_group");

                entity.Property(e => e.GroupId)
                    .HasColumnName("group_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupIdComment)
                    .IsRequired()
                    .HasColumnName("group_id_comment");

                entity.Property(e => e.GroupUnitId01).HasColumnName("group_unit_id_01");

                entity.Property(e => e.GroupUnitId02).HasColumnName("group_unit_id_02");

                entity.Property(e => e.GroupUnitId03).HasColumnName("group_unit_id_03");

                entity.Property(e => e.GroupUnitId04).HasColumnName("group_unit_id_04");

                entity.Property(e => e.GroupUnitId05).HasColumnName("group_unit_id_05");
            });

            modelBuilder.Entity<VoiceGroupChara>(entity =>
            {
                entity.HasKey(e => e.GroupUnitId);

                entity.ToTable("voice_group_chara");

                entity.Property(e => e.GroupUnitId)
                    .HasColumnName("group_unit_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.GroupUnitIdComment)
                    .IsRequired()
                    .HasColumnName("group_unit_id_comment");

                entity.Property(e => e.UnitId01).HasColumnName("unit_id_01");

                entity.Property(e => e.UnitId02).HasColumnName("unit_id_02");

                entity.Property(e => e.UnitId03).HasColumnName("unit_id_03");

                entity.Property(e => e.UnitId04).HasColumnName("unit_id_04");

                entity.Property(e => e.UnitId05).HasColumnName("unit_id_05");

                entity.Property(e => e.UnitId06).HasColumnName("unit_id_06");

                entity.Property(e => e.UnitId07).HasColumnName("unit_id_07");

                entity.Property(e => e.UnitId08).HasColumnName("unit_id_08");

                entity.Property(e => e.UnitId09).HasColumnName("unit_id_09");

                entity.Property(e => e.UnitId10).HasColumnName("unit_id_10");
            });

            modelBuilder.Entity<VoteData>(entity =>
            {
                entity.HasKey(e => e.VoteId);

                entity.ToTable("vote_data");

                entity.Property(e => e.VoteId)
                    .HasColumnName("vote_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ResultEndTime)
                    .IsRequired()
                    .HasColumnName("result_end_time");

                entity.Property(e => e.ResultStartTime)
                    .IsRequired()
                    .HasColumnName("result_start_time");

                entity.Property(e => e.ResultStoryId).HasColumnName("result_story_id");

                entity.Property(e => e.StartStoryId).HasColumnName("start_story_id");

                entity.Property(e => e.VoteEndTime)
                    .IsRequired()
                    .HasColumnName("vote_end_time");

                entity.Property(e => e.VoteStartTime)
                    .IsRequired()
                    .HasColumnName("vote_start_time");
            });

            modelBuilder.Entity<VoteInfo>(entity =>
            {
                entity.HasKey(e => new { e.VoteId, e.VoteHelpIndex });

                entity.ToTable("vote_info");

                entity.Property(e => e.VoteId).HasColumnName("vote_id");

                entity.Property(e => e.VoteHelpIndex).HasColumnName("vote_help_index");

                entity.Property(e => e.VoteHelp)
                    .IsRequired()
                    .HasColumnName("vote_help");

                entity.Property(e => e.VoteTitle)
                    .IsRequired()
                    .HasColumnName("vote_title");
            });

            modelBuilder.Entity<VoteUnit>(entity =>
            {
                entity.HasKey(e => new { e.VoteId, e.UnitId });

                entity.ToTable("vote_unit");

                entity.Property(e => e.VoteId).HasColumnName("vote_id");

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.UnitRarity).HasColumnName("unit_rarity");
            });

            modelBuilder.Entity<WacBirthdayDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("wac_birthday_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("wac_birthday_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<WacData>(entity =>
            {
                entity.HasKey(e => new { e.WacId, e.DateId });

                entity.ToTable("wac_data");

                entity.HasIndex(e => e.MuralGroupId)
                    .HasName("wac_data_0_mural_group_id");

                entity.Property(e => e.WacId).HasColumnName("wac_id");

                entity.Property(e => e.DateId).HasColumnName("date_id");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.BirthdayLoginBonusId).HasColumnName("birthday_login_bonus_id");

                entity.Property(e => e.DrawEndToCenter).HasColumnName("draw_end_to_center");

                entity.Property(e => e.EffectId).HasColumnName("effect_id");

                entity.Property(e => e.IdleDramaId).HasColumnName("idle_drama_id");

                entity.Property(e => e.MuralGroupId).HasColumnName("mural_group_id");

                entity.Property(e => e.MuralOffsetX).HasColumnName("mural_offset_x");

                entity.Property(e => e.PostDramaId).HasColumnName("post_drama_id");

                entity.Property(e => e.PreDramaId).HasColumnName("pre_drama_id");

                entity.Property(e => e.UnitId1).HasColumnName("unit_id_1");

                entity.Property(e => e.UnitId2).HasColumnName("unit_id_2");

                entity.Property(e => e.UnitSearchId).HasColumnName("unit_search_id");

                entity.Property(e => e.UnlockTime)
                    .IsRequired()
                    .HasColumnName("unlock_time");
            });

            modelBuilder.Entity<WacDramaScript>(entity =>
            {
                entity.HasKey(e => e.CommandId);

                entity.ToTable("wac_drama_script");

                entity.HasIndex(e => e.DramaId)
                    .HasName("wac_drama_script_0_drama_id");

                entity.Property(e => e.CommandId)
                    .HasColumnName("command_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CommandType).HasColumnName("command_type");

                entity.Property(e => e.DramaId).HasColumnName("drama_id");

                entity.Property(e => e.Param01)
                    .IsRequired()
                    .HasColumnName("param_01");

                entity.Property(e => e.Param02)
                    .IsRequired()
                    .HasColumnName("param_02");

                entity.Property(e => e.Param03)
                    .IsRequired()
                    .HasColumnName("param_03");

                entity.Property(e => e.Param04)
                    .IsRequired()
                    .HasColumnName("param_04");

                entity.Property(e => e.Param05)
                    .IsRequired()
                    .HasColumnName("param_05");

                entity.Property(e => e.Param06)
                    .IsRequired()
                    .HasColumnName("param_06");

                entity.Property(e => e.Param07)
                    .IsRequired()
                    .HasColumnName("param_07");

                entity.Property(e => e.Param08)
                    .IsRequired()
                    .HasColumnName("param_08");
            });

            modelBuilder.Entity<WacMuralBgData>(entity =>
            {
                entity.HasKey(e => new { e.WacId, e.DateId });

                entity.ToTable("wac_mural_bg_data");

                entity.Property(e => e.WacId).HasColumnName("wac_id");

                entity.Property(e => e.DateId).HasColumnName("date_id");

                entity.Property(e => e.BgId).HasColumnName("bg_id");

                entity.Property(e => e.EndOffsetX)
                    .IsRequired()
                    .HasColumnName("end_offset_x");

                entity.Property(e => e.StartOffsetX)
                    .IsRequired()
                    .HasColumnName("start_offset_x");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<WacMuralData>(entity =>
            {
                entity.HasKey(e => new { e.MuralGroupId, e.DateId });

                entity.ToTable("wac_mural_data");

                entity.HasIndex(e => e.MuralGroupId)
                    .HasName("wac_mural_data_0_mural_group_id");

                entity.Property(e => e.MuralGroupId).HasColumnName("mural_group_id");

                entity.Property(e => e.DateId).HasColumnName("date_id");

                entity.Property(e => e.Depth).HasColumnName("depth");

                entity.Property(e => e.Height).HasColumnName("height");

                entity.Property(e => e.PartsId).HasColumnName("parts_id");

                entity.Property(e => e.PosX).HasColumnName("pos_x");

                entity.Property(e => e.PosY).HasColumnName("pos_y");

                entity.Property(e => e.Width).HasColumnName("width");
            });

            modelBuilder.Entity<WacPresentStillData>(entity =>
            {
                entity.HasKey(e => new { e.WacId, e.DateId });

                entity.ToTable("wac_present_still_data");

                entity.Property(e => e.WacId).HasColumnName("wac_id");

                entity.Property(e => e.DateId).HasColumnName("date_id");

                entity.Property(e => e.StillId).HasColumnName("still_id");
            });

            modelBuilder.Entity<WacUnitSearchData>(entity =>
            {
                entity.ToTable("wac_unit_search_data");

                entity.HasIndex(e => e.UnitId)
                    .HasName("wac_unit_search_data_0_unit_id");

                entity.HasIndex(e => e.UnitSearchId)
                    .HasName("wac_unit_search_data_0_unit_search_id");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.UnitId).HasColumnName("unit_id");

                entity.Property(e => e.UnitSearchId).HasColumnName("unit_search_id");
            });

            modelBuilder.Entity<WaveGroupData>(entity =>
            {
                entity.ToTable("wave_group_data");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DropGold1).HasColumnName("drop_gold_1");

                entity.Property(e => e.DropGold2).HasColumnName("drop_gold_2");

                entity.Property(e => e.DropGold3).HasColumnName("drop_gold_3");

                entity.Property(e => e.DropGold4).HasColumnName("drop_gold_4");

                entity.Property(e => e.DropGold5).HasColumnName("drop_gold_5");

                entity.Property(e => e.DropRewardId1).HasColumnName("drop_reward_id_1");

                entity.Property(e => e.DropRewardId2).HasColumnName("drop_reward_id_2");

                entity.Property(e => e.DropRewardId3).HasColumnName("drop_reward_id_3");

                entity.Property(e => e.DropRewardId4).HasColumnName("drop_reward_id_4");

                entity.Property(e => e.DropRewardId5).HasColumnName("drop_reward_id_5");

                entity.Property(e => e.EnemyId1).HasColumnName("enemy_id_1");

                entity.Property(e => e.EnemyId2).HasColumnName("enemy_id_2");

                entity.Property(e => e.EnemyId3).HasColumnName("enemy_id_3");

                entity.Property(e => e.EnemyId4).HasColumnName("enemy_id_4");

                entity.Property(e => e.EnemyId5).HasColumnName("enemy_id_5");

                entity.Property(e => e.GuestEnemyId).HasColumnName("guest_enemy_id");

                entity.Property(e => e.GuestLane).HasColumnName("guest_lane");

                entity.Property(e => e.Odds).HasColumnName("odds");

                entity.Property(e => e.WaveGroupId).HasColumnName("wave_group_id");
            });

            modelBuilder.Entity<Worldmap>(entity =>
            {
                entity.HasKey(e => e.CourseId);

                entity.ToTable("worldmap");

                entity.Property(e => e.CourseId)
                    .HasColumnName("course_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndAreaId).HasColumnName("end_area_id");

                entity.Property(e => e.MapId).HasColumnName("map_id");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name");

                entity.Property(e => e.QueId)
                    .IsRequired()
                    .HasColumnName("que_id");

                entity.Property(e => e.SheetId)
                    .IsRequired()
                    .HasColumnName("sheet_id");

                entity.Property(e => e.StartAreaId).HasColumnName("start_area_id");
            });

            modelBuilder.Entity<YsnStoryData>(entity =>
            {
                entity.HasKey(e => e.SubStoryId);

                entity.ToTable("ysn_story_data");

                entity.HasIndex(e => e.OriginalEventId)
                    .HasName("ysn_story_data_0_original_event_id");

                entity.Property(e => e.SubStoryId)
                    .HasColumnName("sub_story_id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ConditionStoryId).HasColumnName("condition_story_id");

                entity.Property(e => e.DispOrder).HasColumnName("disp_order");

                entity.Property(e => e.OriginalEventId).HasColumnName("original_event_id");

                entity.Property(e => e.RewardCount1).HasColumnName("reward_count_1");

                entity.Property(e => e.RewardCount2).HasColumnName("reward_count_2");

                entity.Property(e => e.RewardCount3).HasColumnName("reward_count_3");

                entity.Property(e => e.RewardId1).HasColumnName("reward_id_1");

                entity.Property(e => e.RewardId2).HasColumnName("reward_id_2");

                entity.Property(e => e.RewardId3).HasColumnName("reward_id_3");

                entity.Property(e => e.RewardType1).HasColumnName("reward_type_1");

                entity.Property(e => e.RewardType2).HasColumnName("reward_type_2");

                entity.Property(e => e.RewardType3).HasColumnName("reward_type_3");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
