﻿// Copyright (c) Quarrel. All rights reserved.

using DiscordAPI.Models;
using DiscordAPI.Models.Channels;
using DiscordAPI.Models.Guilds;
using System.Collections.Generic;

namespace Quarrel.ViewModels.Services.Discord.Guilds
{
    /// <summary>
    /// Manages all guild information.
    /// </summary>
    public interface IGuildsService
    {
        /// <summary>
        /// Gets a guild by Id.
        /// </summary>
        /// <param name="guildId">The guild's id.</param>
        /// <returns>The requested <see cref="Guild"/>.</returns>
        Guild GetGuild(string guildId);

        /// <summary>
        /// Adds or updates a guild in the guild list.
        /// </summary>
        /// <param name="guild">The new guild value.</param>
        void AddOrUpdateGuild(Guild guild);

        /// <summary>
        /// Removes a guild from the guild list.
        /// </summary>
        /// <param name="guildId">The guild's id.</param>
        void RemoveGuild(string guildId);

        /// <summary>
        /// Adds or updates a <see cref="GuildChannel"/> in its guild.
        /// </summary>
        /// <param name="channel">The <see cref="GuildChannel"/>.</param>
        void AddOrUpdateChannel(GuildChannel channel);

        /// <summary>
        /// Removes a <see cref="GuildChannel"/> from its guild.
        /// </summary>
        /// <param name="channelId">The <see cref="GuildChannel"/>'s id.</param>
        /// <param name="guildId">The guild's id.</param>
        void RemoveChannel(string channelId, string guildId);

        /// <summary>
        /// Gets the settings for a guild.
        /// </summary>
        /// <param name="guildId">The guild's id.</param>
        /// <returns>The requested <see cref="GuildSetting"/>s.</returns>
        GuildSetting GetGuildSetting(string guildId);

        /// <summary>
        /// Adds or updates an item in the guilds settings list.
        /// </summary>
        /// <param name="guildId">The guild's id.</param>
        /// <param name="guildSetting">The guild's settings.</param>
        void AddOrUpdateGuildSettings(string guildId, GuildSetting guildSetting);

        /// <summary>
        /// Gets a guild member by user id and guild id.
        /// </summary>
        /// <param name="memberId">The GuildMember user id.</param>
        /// <param name="guildId">The GuildMember guild id.</param>
        /// <returns>The requested <see cref="GuildMember"/> or null.</returns>
        GuildMember GetGuildMember(string memberId, string guildId);

        /// <summary>
        /// Gets a guild member by username, discriminator and guild id.
        /// </summary>
        /// <param name="username">The GuildMember username.</param>
        /// <param name="discriminator">The GuildMember discriminator.</param>
        /// <param name="guildId">The GuildMember guild id.</param>
        /// <returns>The requested <see cref="GuildMember"/> or null.</returns>
        GuildMember GetGuildMember(string username, string discriminator, string guildId);

        /// <summary>
        /// Gets a collection of GuildMembers by user ids and guild id.
        /// </summary>
        /// <param name="memberIds">The member ids.</param>
        /// <param name="guildId">The guild id.</param>
        /// <returns>A hashed collection of guild members by user id.</returns>
        IReadOnlyDictionary<string, GuildMember> GetAndRequestGuildMembers(IEnumerable<string> memberIds, string guildId);

        /// <summary>
        /// Adds a <see cref="GuildMember"/> to the guild service.
        /// </summary>
        /// <param name="member">The <see cref="GuildMember"/>.</param>
        /// <param name="guildId">The guild they belong to.</param>
        void AddOrUpdateGuildMember(GuildMember member, string guildId);

        /// <summary>
        /// Quries a guild's members by <paramref name="query"/>.
        /// </summary>
        /// <param name="query">The query to filter by.</param>
        /// <param name="guildId">The guild to query.</param>
        /// <param name="take">The max number of members to return.</param>
        /// <returns>The top matches for members by the <paramref name="query"/> in <paramref name="guildId"/>.</returns>
        IEnumerable<GuildMember> QueryGuildMembers(string query, string guildId, int take= 10);
    }
}
