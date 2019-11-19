﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Disqord.Rest;

namespace Disqord
{
    // TODO: sort or something
    public abstract partial class DiscordClientBase : IRestDiscordClient, IAsyncDisposable
    {
        public Task SendOrAcceptFriendRequestAsync(Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).SendOrAcceptFriendRequestAsync(userId, options);
        public Task SendOrAcceptFriendRequestAsync(string name, string discriminator, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).SendOrAcceptFriendRequestAsync(name, discriminator, options);
        public Task BlockUserAsync(Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).BlockUserAsync(userId, options);
        public Task DeleteRelationshipAsync(Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteRelationshipAsync(userId, options);
        public Task<IReadOnlyList<RestRelationship>> GetRelationshipsAsync(RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetRelationshipsAsync(options);
        public Task<IReadOnlyList<RestUser>> GetMutualFriendsAsync(Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetMutualFriendsAsync(userId, options);
        public Task<RestWebhook> CreateWebhookAsync(Snowflake channelId, string name, LocalAttachment avatar = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).CreateWebhookAsync(channelId, name, avatar, options);
        public Task<IReadOnlyList<RestWebhook>> GetChannelWebhooksAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetChannelWebhooksAsync(channelId, options);
        public Task<IReadOnlyList<RestWebhook>> GetGuildWebhooksAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetGuildWebhooksAsync(guildId, options);
        public Task<RestWebhook> GetWebhookAsync(Snowflake webhookId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetWebhookAsync(webhookId, options);
        public Task<RestWebhook> GetWebhookWithTokenAsync(Snowflake webhookId, string webhookToken, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetWebhookWithTokenAsync(webhookId, webhookToken, options);
        public Task<RestWebhook> ModifyWebhookAsync(Snowflake webhookId, Action<ModifyWebhookProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyWebhookAsync(webhookId, action, options);
        public Task<RestWebhook> ModifyWebhookWithTokenAsync(Snowflake webhookId, string webhookToken, Action<ModifyWebhookProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyWebhookWithTokenAsync(webhookId, webhookToken, action, options);
        public Task DeleteWebhookAsync(Snowflake webhookId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteWebhookAsync(webhookId, options);
        public Task DeleteWebhookWithTokenAsync(Snowflake webhookId, string webhookToken, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteWebhookWithTokenAsync(webhookId, webhookToken, options);
        public Task<RestUserMessage> ExecuteWebhookAsync(Snowflake webhookId, string webhookToken, string content = null, bool textToSpeech = false, IEnumerable<LocalEmbed> LocalEmbeds = null, string name = null, string avatarUrl = null, bool wait = false, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ExecuteWebhookAsync(webhookId, webhookToken, content, textToSpeech, LocalEmbeds, name, avatarUrl, wait, options);
        public Task<RestUserMessage> ExecuteWebhookAsync(Snowflake webhookId, string webhookToken, LocalAttachment attachment, string content = null, bool textToSpeech = false, IEnumerable<LocalEmbed> LocalEmbeds = null, string name = null, string avatarUrl = null, bool wait = false, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ExecuteWebhookAsync(webhookId, webhookToken, attachment, content, textToSpeech, LocalEmbeds, name, avatarUrl, wait, options);
        public Task<RestUserMessage> ExecuteWebhookAsync(Snowflake webhookId, string webhookToken, IEnumerable<LocalAttachment> attachments, string content = null, bool textToSpeech = false, IEnumerable<LocalEmbed> LocalEmbeds = null, string name = null, string avatarUrl = null, bool wait = false, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ExecuteWebhookAsync(webhookId, webhookToken, attachments, content, textToSpeech, LocalEmbeds, name, avatarUrl, wait, options);
        //public RestRequestEnumerator<RestAuditLog> GetAuditLogsEnumerator(Snowflake guildId, int limit = 100, Snowflake? userId = null, Snowflake? startFromId = null) => ((IRestDiscordClient) this.RestClient).GetAuditLogsEnumerator(guildId, limit, userId, startFromId);
        //public RestRequestEnumerator<T> GetAuditLogsEnumerator<T>(Snowflake guildId, int limit = 100, Snowflake? userId = null, Snowflake? startFromId = null) where T : RestAuditLog => ((IRestDiscordClient) this.RestClient).GetAuditLogsEnumerator<T>(guildId, limit, userId, startFromId);
        //public Task<IReadOnlyList<RestAuditLog>> GetAuditLogsAsync(Snowflake guildId, int limit = 100, Snowflake? userId = null, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetAuditLogsAsync(guildId, limit, userId, startFromId, options);
        //public Task<IReadOnlyList<T>> GetAuditLogsAsync<T>(Snowflake guildId, int limit = 100, Snowflake? userId = null, Snowflake? startFromId = null, RestRequestOptions options = null) where T : RestAuditLog => ((IRestDiscordClient) this.RestClient).GetAuditLogsAsync<T>(guildId, limit, userId, startFromId, options);
        public Task<string> GetGatewayUrlAsync(RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetGatewayUrlAsync(options);
        public Task<RestGatewayBotResponse> GetGatewayBotUrlAsync(RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetGatewayBotUrlAsync(options);
        public Task<RestProfile> GetProfileAsync(Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetProfileAsync(userId, options);
        public Task SetNoteAsync(Snowflake userId, string note, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).SetNoteAsync(userId, note, options);
        public Task<RestGuild> CreateGuildAsync(string name, string voiceRegionId = null, LocalAttachment icon = null, VerificationLevel verificationLevel = VerificationLevel.None, DefaultNotificationLevel defaultNotificationLevel = DefaultNotificationLevel.AllMessages, ContentFilterLevel contentFilterLevel = ContentFilterLevel.Disabled, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).CreateGuildAsync(name, voiceRegionId, icon, verificationLevel, defaultNotificationLevel, contentFilterLevel, options);
        public Task<RestGuild> GetGuildAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetGuildAsync(guildId, options);
        public Task<RestGuild> ModifyGuildAsync(Snowflake guildId, Action<ModifyGuildProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyGuildAsync(guildId, action, options);
        public Task DeleteGuildAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteGuildAsync(guildId, options);
        public Task<IReadOnlyList<RestGuildChannel>> GetChannelsAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetChannelsAsync(guildId, options);
        public Task ReorderChannelsAsync(Snowflake guildId, IReadOnlyDictionary<Snowflake, int> positions, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ReorderChannelsAsync(guildId, positions, options);
        public Task<RestMember> GetMemberAsync(Snowflake guildId, Snowflake memberId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetMemberAsync(guildId, memberId, options);
        public RestRequestEnumerator<RestMember> GetMembersEnumerator(Snowflake guildId, int limit, Snowflake? startFromId = null) => ((IRestDiscordClient) this.RestClient).GetMembersEnumerator(guildId, limit, startFromId);
        public Task<IReadOnlyList<RestMember>> GetMembersAsync(Snowflake guildId, int limit = 1000, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetMembersAsync(guildId, limit, startFromId, options);
        public Task ModifyMemberAsync(Snowflake guildId, Snowflake memberId, Action<ModifyMemberProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyMemberAsync(guildId, memberId, action, options);
        public Task ModifyOwnNickAsync(Snowflake guildId, string nick, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyOwnNickAsync(guildId, nick, options);
        public Task GrantRoleAsync(Snowflake guildId, Snowflake memberId, Snowflake roleId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GrantRoleAsync(guildId, memberId, roleId, options);
        public Task RevokeRoleAsync(Snowflake guildId, Snowflake memberId, Snowflake roleId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).RevokeRoleAsync(guildId, memberId, roleId, options);
        public Task KickMemberAsync(Snowflake guildId, Snowflake memberId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).KickMemberAsync(guildId, memberId, options);
        public Task<IReadOnlyList<RestBan>> GetBansAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetBansAsync(guildId, options);
        public Task<RestBan> GetBanAsync(Snowflake guildId, Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetBanAsync(guildId, userId, options);
        public Task BanMemberAsync(Snowflake guildId, Snowflake memberId, string reason = null, int? deleteMessageDays = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).BanMemberAsync(guildId, memberId, reason, deleteMessageDays, options);
        public Task UnbanMemberAsync(Snowflake guildId, Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).UnbanMemberAsync(guildId, userId, options);
        public Task<IReadOnlyList<RestRole>> GetRolesAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetRolesAsync(guildId, options);
        public Task<RestRole> CreateRoleAsync(Snowflake guildId, Action<CreateRoleProperties> action = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).CreateRoleAsync(guildId, action, options);
        public Task<IReadOnlyList<RestRole>> ReorderRolesAsync(Snowflake guildId, IReadOnlyDictionary<Snowflake, int> positions, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ReorderRolesAsync(guildId, positions, options);
        public Task<RestRole> ModifyRoleAsync(Snowflake guildId, Snowflake roleId, Action<ModifyRoleProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyRoleAsync(guildId, roleId, action, options);
        public Task DeleteRoleAsync(Snowflake guildId, Snowflake roleId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteRoleAsync(guildId, roleId, options);
        public Task<int> GetPruneCountAsync(Snowflake guildId, int days, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetPruneCountAsync(guildId, days, options);
        public Task<int?> PruneAsync(Snowflake guildId, int days, bool computePruneCount = true, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).PruneAsync(guildId, days, computePruneCount, options);
        public Task<IReadOnlyList<RestGuildVoiceRegion>> GetVoiceRegionsAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetVoiceRegionsAsync(guildId, options);
        public Task<IReadOnlyList<RestInvite>> GetGuildInvitesAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetGuildInvitesAsync(guildId, options);
        public Task<RestWidget> GetWidgetAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetWidgetAsync(guildId, options);
        public Task<RestWidget> ModifyWidgetAsync(Snowflake guildId, Action<ModifyWidgetProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyWidgetAsync(guildId, action, options);
        public Task<string> GetVanityInviteAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetVanityInviteAsync(guildId, options);
        public Task<RestChannel> GetChannelAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetChannelAsync(channelId, options);
        public Task<RestGroupChannel> ModifyGroupChannelAsync(Snowflake channelId, Action<ModifyGroupChannelProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyGroupChannelAsync(channelId, action, options);
        public Task<RestTextChannel> ModifyTextChannelAsync(Snowflake channelId, Action<ModifyTextChannelProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyTextChannelAsync(channelId, action, options);
        public Task<RestVoiceChannel> ModifyVoiceChannelAsync(Snowflake channelId, Action<ModifyVoiceChannelProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyVoiceChannelAsync(channelId, action, options);
        public Task<RestCategoryChannel> ModifyCategoryChannelAsync(Snowflake channelId, Action<ModifyCategoryChannelProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyCategoryChannelAsync(channelId, action, options);
        public Task DeleteOrCloseChannelAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteOrCloseChannelAsync(channelId, options);
        public RestRequestEnumerator<RestMessage> GetMessagesEnumerator(Snowflake channelId, int limit, RetrievalDirection direction = RetrievalDirection.Before, Snowflake? startFromId = null) => ((IRestDiscordClient) this.RestClient).GetMessagesEnumerator(channelId, limit, direction, startFromId);
        public Task<IReadOnlyList<RestMessage>> GetMessagesAsync(Snowflake channelId, int limit = 100, RetrievalDirection direction = RetrievalDirection.Before, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetMessagesAsync(channelId, limit, direction, startFromId, options);
        public Task<RestMessage> GetMessageAsync(Snowflake channelId, Snowflake messageId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetMessageAsync(channelId, messageId, options);
        public Task<RestUserMessage> SendMessageAsync(Snowflake channelId, string content = null, bool textToSpeech = false, LocalEmbed LocalEmbed = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).SendMessageAsync(channelId, content, textToSpeech, LocalEmbed, options);
        public Task<RestUserMessage> SendMessageAsync(Snowflake channelId, LocalAttachment attachment, string content = null, bool textToSpeech = false, LocalEmbed LocalEmbed = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).SendMessageAsync(channelId, attachment, content, textToSpeech, LocalEmbed, options);
        public Task<RestUserMessage> SendMessageAsync(Snowflake channelId, IEnumerable<LocalAttachment> attachments, string content = null, bool textToSpeech = false, LocalEmbed LocalEmbed = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).SendMessageAsync(channelId, attachments, content, textToSpeech, LocalEmbed, options);
        public Task AddReactionAsync(Snowflake channelId, Snowflake messageId, IEmoji emoji, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).AddReactionAsync(channelId, messageId, emoji, options);
        public Task RemoveOwnReactionAsync(Snowflake channelId, Snowflake messageId, IEmoji emoji, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).RemoveOwnReactionAsync(channelId, messageId, emoji, options);
        public Task RemoveMemberReactionAsync(Snowflake channelId, Snowflake messageId, Snowflake memberId, IEmoji emoji, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).RemoveMemberReactionAsync(channelId, messageId, memberId, emoji, options);
        public RestRequestEnumerator<RestUser> GetReactionEnumerator(Snowflake channelId, Snowflake messageId, IEmoji emoji, int limit, RetrievalDirection direction = RetrievalDirection.Before, Snowflake? startFromId = null) => ((IRestDiscordClient) this.RestClient).GetReactionEnumerator(channelId, messageId, emoji, limit, direction, startFromId);
        public Task<IReadOnlyList<RestUser>> GetReactionsAsync(Snowflake channelId, Snowflake messageId, IEmoji emoji, int limit = 100, RetrievalDirection direction = RetrievalDirection.Before, Snowflake? startFromId = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetReactionsAsync(channelId, messageId, emoji, limit, direction, startFromId, options);
        public Task ClearReactionsAsync(Snowflake channelId, Snowflake messageId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ClearReactionsAsync(channelId, messageId, options);
        public Task<RestUserMessage> ModifyMessageAsync(Snowflake channelId, Snowflake messageId, Action<ModifyMessageProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyMessageAsync(channelId, messageId, action, options);
        public Task DeleteMessageAsync(Snowflake channelId, Snowflake messageId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteMessageAsync(channelId, messageId, options);
        public RestRequestEnumerator<Snowflake> GetBulkMessageDeletionEnumerator(Snowflake channelId, IEnumerable<Snowflake> messageIds) => ((IRestDiscordClient) this.RestClient).GetBulkMessageDeletionEnumerator(channelId, messageIds);
        public Task DeleteMessagesAsync(Snowflake channelId, IEnumerable<Snowflake> messageIds, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteMessagesAsync(channelId, messageIds, options);
        public Task AddOrModifyOverwriteAsync(Snowflake channelId, LocalOverwrite overwrite, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).AddOrModifyOverwriteAsync(channelId, overwrite, options);
        public Task<IReadOnlyList<RestInvite>> GetChannelInvitesAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetChannelInvitesAsync(channelId, options);
        public Task<RestInvite> CreateInviteAsync(Snowflake channelId, int maxAgeSeconds = 86400, int maxUses = 0, bool isTemporaryMembership = false, bool isUnique = false, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).CreateInviteAsync(channelId, maxAgeSeconds, maxUses, isTemporaryMembership, isUnique, options);
        public Task<RestInvite> CreateInviteAsync(Snowflake channelId, TimeSpan maxAge, int maxUses = 0, bool isTemporaryMembership = false, bool isUnique = false, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).CreateInviteAsync(channelId, maxAge, maxUses, isTemporaryMembership, isUnique, options);
        public Task DeleteOverwriteAsync(Snowflake channelId, Snowflake targetId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteOverwriteAsync(channelId, targetId, options);
        public Task TriggerTypingAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).TriggerTypingAsync(channelId, options);
        public Task<IReadOnlyList<RestUserMessage>> GetPinnedMessagesAsync(Snowflake channelId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetPinnedMessagesAsync(channelId, options);
        public Task PinMessageAsync(Snowflake channelId, Snowflake messageId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).PinMessageAsync(channelId, messageId, options);
        public Task UnpinMessageAsync(Snowflake channelId, Snowflake messageId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).UnpinMessageAsync(channelId, messageId, options);
        public Task AddGroupRecipientAsync(Snowflake channelId, Snowflake userId, string nick = null, string accessToken = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).AddGroupRecipientAsync(channelId, userId, nick, accessToken, options);
        public Task RemoveGroupRecipientAsync(Snowflake channelId, Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).RemoveGroupRecipientAsync(channelId, userId, options);
        public Task MarkMessageAsReadAsync(Snowflake channelId, Snowflake messageId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).MarkMessageAsReadAsync(channelId, messageId, options);
        public Task<RestApplication> GetCurrentApplicationAsync() => ((IRestDiscordClient) this.RestClient).GetCurrentApplicationAsync();
        public Task<RestCurrentUser> GetCurrentUserAsync(RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetCurrentUserAsync(options);
        public Task<RestUser> GetUserAsync(Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetUserAsync(userId, options);
        public Task<RestCurrentUser> ModifyCurrentUserAsync(Action<ModifyCurrentUserProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyCurrentUserAsync(action, options);
        public Task LeaveGuildAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).LeaveGuildAsync(guildId, options);
        public Task<RestDmChannel> CreateDmChannelAsync(Snowflake userId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).CreateDmChannelAsync(userId, options);
        public Task<IReadOnlyList<RestVoiceRegion>> GetVoiceRegionsAsync(RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetVoiceRegionsAsync(options);
        public Task<RestInvite> GetInviteAsync(string code, bool withCounts = true, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetInviteAsync(code, withCounts, options);
        public Task<RestInvite> DeleteInviteAsync(string code, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteInviteAsync(code, options);
        public Task<IReadOnlyList<RestGuildEmoji>> GetGuildEmojisAsync(Snowflake guildId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetGuildEmojisAsync(guildId, options);
        public Task<RestGuildEmoji> GetGuildEmojiAsync(Snowflake guildId, Snowflake emojiId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetGuildEmojiAsync(guildId, emojiId, options);
        public Task<RestGuildEmoji> CreateGuildEmojiAsync(Snowflake guildId, LocalAttachment image, string name = null, IEnumerable<Snowflake> roleIds = null, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).CreateGuildEmojiAsync(guildId, image, name, roleIds, options);
        public Task<RestGuildEmoji> ModifyGuildEmojiAsync(Snowflake guildId, Snowflake emojiId, Action<ModifyGuildEmojiProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyGuildEmojiAsync(guildId, emojiId, action, options);
        public Task DeleteGuildEmojiAsync(Snowflake guildId, Snowflake emojiId, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).DeleteGuildEmojiAsync(guildId, emojiId, options);
        public Task AcceptInviteAsync(string code, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).AcceptInviteAsync(code, options);
        public Task<RestUserSettings> GetUserSettingsAsync(RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).GetUserSettingsAsync(options);
        public Task<RestUserSettings> ModifyUserSettingsAsync(Action<ModifyUserSettingsProperties> action, RestRequestOptions options = null) => ((IRestDiscordClient) this.RestClient).ModifyUserSettingsAsync(action, options);
    }
}
