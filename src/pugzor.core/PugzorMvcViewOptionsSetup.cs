﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pugzor.core
{
    public class PugzorMvcViewOptionsSetup : IConfigureOptions<MvcViewOptions>
    {
        private readonly IPugzorViewEngine _pugzorViewEngine;

        /// <summary>
        /// Initializes a new instance of <see cref="PugzorMvcViewOptionsSetup"/>.
        /// </summary>
        /// <param name="pugzorViewEngine">The <see cref="IPugzorViewEngine"/>.</param>
        public PugzorMvcViewOptionsSetup(IPugzorViewEngine pugzorViewEngine)
        {
            if (pugzorViewEngine == null)
            {
                throw new ArgumentNullException(nameof(pugzorViewEngine));
            }

            _pugzorViewEngine = pugzorViewEngine;
        }

        /// <summary>
        /// Configures <paramref name="options"/> to use <see cref="PugzorViewEngine"/>.
        /// </summary>
        /// <param name="options">The <see cref="MvcViewOptions"/> to configure.</param>
        public void Configure(MvcViewOptions options)
        {
            if (options == null)
            {
                throw new ArgumentNullException(nameof(options));
            }

            options.ViewEngines.Add(_pugzorViewEngine);
        }

    }
}
