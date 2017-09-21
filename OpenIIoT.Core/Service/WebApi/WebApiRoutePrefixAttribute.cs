﻿/*
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀  ▀  ▀      ▀▀
      █
      █    ▄█     █▄                        ▄████████                   ▄████████                                         ▄███████▄
      █   ███     ███                       ███    ███                 ███    ███                                        ███    ███
      █   ███     ███    ▄█████ ▀██████▄    ███    ███    █████▄  █   ▄███▄▄▄▄██▀  ██████  ██   █      ██       ▄█████   ███    ███    █████    ▄█████    ▄█████  █  ▀███  ▐██▀
      █   ███     ███   ██   █    ██   ██   ███    ███   ██   ██ ██  ▀▀███▀▀▀▀▀   ██    ██ ██   ██ ▀███████▄   ██   █    ███    ███   ██  ██   ██   █    ██   ▀█ ██    ██  ██
      █   ███     ███  ▄██▄▄     ▄██▄▄█▀  ▀███████████   ██   ██ ██▌ ▀███████████ ██    ██ ██   ██     ██  ▀  ▄██▄▄    ▀█████████▀   ▄██▄▄█▀  ▄██▄▄     ▄██▄▄    ██▌    ████▀
      █   ███     ███ ▀▀██▀▀    ▀▀██▀▀█▄    ███    ███ ▀██████▀  ██    ███    ███ ██    ██ ██   ██     ██    ▀▀██▀▀      ███        ▀███████ ▀▀██▀▀    ▀▀██▀▀    ██     ████
      █   ███ ▄█▄ ███   ██   █    ██   ██   ███    ███   ██      ██    ███    ███ ██    ██ ██   ██     ██      ██   █    ███          ██  ██   ██   █    ██      ██   ▄██ ▀██
      █    ▀███▀███▀    ███████ ▄██████▀    ███    █▀   ▄███▀    █     ███    ███  ██████  ██████     ▄██▀     ███████  ▄████▀        ██  ██   ███████   ██      █   ███    ██▄
      █
      █     ▄████████
      █     ███    ███
      █     ███    ███     ██        ██       █████  █  ▀██████▄  ██   █      ██       ▄█████
      █     ███    ███ ▀███████▄ ▀███████▄   ██  ██ ██    ██   ██ ██   ██ ▀███████▄   ██   █
      █   ▀███████████     ██  ▀     ██  ▀  ▄██▄▄█▀ ██▌  ▄██▄▄█▀  ██   ██     ██  ▀  ▄██▄▄
      █     ███    ███     ██        ██    ▀███████ ██  ▀▀██▀▀█▄  ██   ██     ██    ▀▀██▀▀
      █     ███    ███     ██        ██      ██  ██ ██    ██   ██ ██   ██     ██      ██   █
      █     ███    █▀     ▄██▀      ▄██▀     ██  ██ █   ▄██████▀  ██████     ▄██▀     ███████
      █
 ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄▄  ▄▄ ▄▄   ▄▄▄▄ ▄▄     ▄▄     ▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄ ▄ ▄
 █████████████████████████████████████████████████████████████ ███████████████ ██  ██ ██   ████ ██     ██     ████████████████ █ █
      ▄
      █  Annotates a controller with a WebRoot-prepended route prefix that applies to all actions within the controller.
      █
      █▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀ ▀▀▀▀▀▀▀▀▀▀▀ ▀ ▀▀▀     ▀▀               ▀
      █  The GNU Affero General Public License (GNU AGPL)
      █
      █  Copyright (C) 2016-2017 JP Dillingham (jp@dillingham.ws)
      █
      █  This program is free software: you can redistribute it and/or modify
      █  it under the terms of the GNU Affero General Public License as published by
      █  the Free Software Foundation, either version 3 of the License, or
      █  (at your option) any later version.
      █
      █  This program is distributed in the hope that it will be useful,
      █  but WITHOUT ANY WARRANTY; without even the implied warranty of
      █  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
      █  GNU Affero General Public License for more details.
      █
      █  You should have received a copy of the GNU Affero General Public License
      █  along with this program.  If not, see <http://www.gnu.org/licenses/>.
      █
      ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀  ▀▀ ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀██
                                                                                                   ██
                                                                                               ▀█▄ ██ ▄█▀
                                                                                                 ▀████▀
                                                                                                   ▀▀                            */

using System.Web.Http;
using OpenIIoT.SDK;

namespace OpenIIoT.Core.Service.WebApi
{
    /// <summary>
    ///     Annotates a controller with a WebRoot-prepended route prefix that applies to all actions within the controller.
    /// </summary>
    public class WebApiRoutePrefixAttribute : RoutePrefixAttribute
    {
        #region Public Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="WebApiRoutePrefixAttribute"/> class.
        /// </summary>
        /// <param name="prefix">The route prefix for the controller.</param>
        public WebApiRoutePrefixAttribute(string prefix)
            : base(prefix)
        {
        }

        #endregion Public Constructors

        #region Public Properties

        /// <summary>
        ///     Gets the route prefix.
        /// </summary>
        public override string Prefix
        {
            get
            {
                string root = WebApiService.StaticConfiguration.Root.TrimEnd('/');
                return $"{root}/{WebApiConstants.ApiRoutePrefix}/{base.Prefix}".TrimStart('/');
            }
        }

        #endregion Public Properties

        #region Private Properties

        /// <summary>
        ///     Gets the settings for the application.
        /// </summary>
        private IApplicationSettings Settings => ApplicationManager.GetInstance().Settings;

        #endregion Private Properties
    }
}