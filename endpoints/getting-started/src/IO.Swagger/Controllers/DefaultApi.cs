/*
 * Copyright (c) 2017 Google Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not
 * use this file except in compliance with the License. You may obtain a copy of
 * the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS, WITHOUT
 * WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the
 * License for the specific language governing permissions and limitations under
 * the License.
 */
/*
 * Endpoints Example
 *
 * A simple Google Cloud Endpoints API example.
 *
 * OpenAPI spec version: 1.0.0
 *
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using IO.Swagger.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Swashbuckle.SwaggerGen.Annotations;

namespace IO.Swagger.Controllers
{
    /// <summary>
    ///
    /// </summary>
    public class DefaultApiController : Controller
    {
        /// <summary>
        ///
        /// </summary>
        /// <remarks>Returns the requests&#39; authentication information.</remarks>
        /// <response code="200">Authenication info.</response>
        [HttpGet]
        [Route("/auth/info/googleidtoken")]
        [SwaggerOperation("AuthInfoGoogleIdToken")]
        [SwaggerResponse(200, type: typeof(AuthInfoResponse))]
        public virtual IActionResult AuthInfoGoogleIdToken()
        {
            string exampleJson = null;

            var example = exampleJson != null
                ? JsonConvert.DeserializeObject<AuthInfoResponse>(exampleJson)
                : default(AuthInfoResponse);
            return new ObjectResult(example);
        }

        /// <summary>
        ///
        /// </summary>
        /// <remarks>Returns the requests&#39; authentication information.</remarks>
        /// <response code="200">Authenication info.</response>
        [HttpGet]
        [Route("/auth/info/googlejwt")]
        [SwaggerOperation("AuthInfoGoogleJwt")]
        [SwaggerResponse(200, type: typeof(AuthInfoResponse))]
        public virtual IActionResult AuthInfoGoogleJwt()
        {
            string exampleJson = null;

            var example = exampleJson != null
                ? JsonConvert.DeserializeObject<AuthInfoResponse>(exampleJson)
                : default(AuthInfoResponse);
            return new ObjectResult(example);
        }

        /// <summary>
        ///
        /// </summary>
        /// <remarks>Echo back a given message.</remarks>
        /// <param name="message">Message to echo</param>
        /// <response code="200">Echo</response>
        [HttpPost]
        [Route("/echo")]
        [SwaggerOperation("Echo")]
        [SwaggerResponse(200, type: typeof(EchoMessage))]
        public virtual IActionResult Echo([FromBody]EchoMessage message)
        {
            return new ObjectResult(message);
        }

        /// <summary>
        /// GET API for the health checks
        /// </summary>
        /// <returns>200 if health check has passed</returns>
        [HttpGet]
        [Route("/_ah/health")]
        public virtual IActionResult HealthCheck()
        {
            return new StatusCodeResult(200);
        }
    }
}