using n8n.SDK.Models;
using RestEase;

namespace n8n.SDK;

/// <summary>
/// Based on https://docs.n8n.io/api/api-reference/ (1.1.1)
/// </summary>
[PublicAPI]
public interface INodemationApi
{
    /// <summary>
    /// Generate a security audit for your n8n instance.
    /// </summary>
    /// <param name="request">Audit options (optional).</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/audit")]
    Task<Audit> GenerateAuditAsync([Body] AuditRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Creates a credential that can be used by nodes of the specified type.
    /// </summary>
    /// <param name="credential">Credential to be created.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/credentials")]
    Task<CreateCredentialResponse> CreateCredentialAsync([Body] Credential credential, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a credential from your instance. You must be the owner of the credentials
    /// </summary>
    /// <param name="id">The credential ID that needs to be deleted</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/credentials/{id}")]
    Task<Credential> DeleteCredentialAsync([Path] string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Show credential data schema
    /// </summary>
    /// <param name="credentialTypeName">The credential type name that you want to get the schema for</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/credentials/schema/{credentialTypeName}")]
    Task<object> GetCredentialTypeAsync([Path] string credentialTypeName, CancellationToken cancellationToken = default);

    /// <summary>
    /// Transfer a credential to another project.
    /// </summary>
    /// <param name="id">The ID of the credential.</param>
    /// <param name="request">Destination project for the credential transfer.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Put("/credentials/{id}/transfer")]
    Task TransferCredentialAsync([Path] string id, [Body] DestinationProjectRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all executions from your instance.
    /// </summary>
    /// <param name="includeData">Whether or not to include the execution's detailed data.</param>
    /// <param name="status">Status to filter the executions by.</param>
    /// <param name="workflowId">Workflow to filter the executions by.</param>
    /// <param name="projectId"></param>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="cursor">Paginate by setting the cursor parameter to the nextCursor attribute returned by the previous request's response. Default value fetches the first "page" of the collection. See pagination for more detail.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/executions")]
    Task<ExecutionList> GetExecutionsAsync(
        [Query("includeData")] bool? includeData = null,
        [Query("status")] string? status = null,
        [Query("workflowId")] string? workflowId = null,
        [Query("projectId")] string? projectId = null,
        [Query("limit")] int? limit = null,
        [Query("cursor")] string? cursor = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve an execution from your instance.
    /// </summary>
    /// <param name="id">The ID of the execution.</param>
    /// <param name="includeData">Whether or not to include the execution's detailed data.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/executions/{id}")]
    Task<Execution> GetExecutionAsync([Path] string id, [Query("includeData")] bool? includeData = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes an execution from your instance.
    /// </summary>
    /// <param name="id">The ID of the execution.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/executions/{id}")]
    Task<Execution> DeleteExecutionAsync([Path] string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a tag in your instance.
    /// </summary>
    /// <param name="tag">Created tag object.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/tags")]
    Task<Tag> CreateTagAsync([Body] Tag tag, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all tags from your instance.
    /// </summary>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="cursor">Paginate by setting the cursor parameter to the nextCursor attribute returned by the previous request's response. Default value fetches the first "page" of the collection. See pagination for more detail.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/tags")]
    Task<TagList> GetTagsAsync([Query("limit")] int? limit = null, [Query("cursor")] string? cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a tag.
    /// </summary>
    /// <param name="id">The ID of the tag.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/tags/{id}")]
    Task<Tag> GetTagAsync([Path] string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a tag.
    /// </summary>
    /// <param name="id">The ID of the tag.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/tags/{id}")]
    Task<Tag> DeleteTagAsync([Path] string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a tag.
    /// </summary>
    /// <param name="id">The ID of the tag.</param>
    /// <param name="tag">Updated tag object.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Put("/tags/{id}")]
    Task<Tag> UpdateTagAsync([Path] string id, [Body] Tag tag, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a workflow in your instance.
    /// </summary>
    /// <param name="workflow">Created workflow object.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/workflows")]
    Task<Workflow> CreateWorkflowAsync([Body] Workflow workflow, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all workflows from your instance.
    /// </summary>
    /// <param name="active"></param>
    /// <param name="tags"></param>
    /// <param name="name"></param>
    /// <param name="projectId"></param>
    /// <param name="excludePinnedData">Set this to avoid retrieving pinned data</param>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="cursor">Paginate by setting the cursor parameter to the nextCursor attribute returned by the previous request's response. Default value fetches the first "page" of the collection. See pagination for more detail.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/workflows")]
    Task<WorkflowList> GetWorkflowsAsync(
        [Query("active", QuerySerializationMethod.Serialized)] bool? active = null,
        [Query("tags")] string? tags = null,
        [Query("name")] string? name = null,
        [Query("projectId")] string? projectId = null,
        [Query("excludePinnedData")] bool? excludePinnedData = null,
        [Query("limit")] int? limit = null,
        [Query("cursor")] string? cursor = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieves a workflow.
    /// </summary>
    /// <param name="id">The ID of the workflow.</param>
    /// <param name="excludePinnedData">Set this to avoid retrieving pinned data</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/workflows/{id}")]
    Task<Workflow> GetWorkflowAsync([Path] string id, [Query("excludePinnedData")] bool? excludePinnedData = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deletes a workflow.
    /// </summary>
    /// <param name="id">The ID of the workflow.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/workflows/{id}")]
    Task<Workflow> DeleteWorkflowAsync([Path] string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a workflow.
    /// </summary>
    /// <param name="id">The ID of the workflow.</param>
    /// <param name="workflow">Updated workflow object.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Put("/workflows/{id}")]
    Task<Workflow> UpdateWorkflowAsync([Path] string id, [Body] Workflow workflow, CancellationToken cancellationToken = default);

    /// <summary>
    /// Activate a workflow.
    /// </summary>
    /// <param name="id">The ID of the workflow.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/workflows/{id}/activate")]
    Task<Workflow> ActivateWorkflowAsync([Path] string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Deactivate a workflow.
    /// </summary>
    /// <param name="id">The ID of the workflow.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/workflows/{id}/deactivate")]
    Task<Workflow> DeactivateWorkflowAsync([Path] string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Transfer a workflow to another project.
    /// </summary>
    /// <param name="id">The ID of the workflow.</param>
    /// <param name="request">Destination project information for the workflow transfer.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Put("/workflows/{id}/transfer")]
    Task TransferWorkflowAsync([Path] string id, [Body] DestinationProjectRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get workflow tags.
    /// </summary>
    /// <param name="id">The ID of the workflow.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/workflows/{id}/tags")]
    Task<ICollection<Tag>> GetWorkflowTagsAsync([Path] string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update tags of a workflow.
    /// </summary>
    /// <param name="id">The ID of the workflow.</param>
    /// <param name="tagIds">List of tags</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Put("/workflows/{id}/tags")]
    Task<ICollection<Tag>> UpdateWorkflowTagsAsync([Path] string id, [Body] IEnumerable<TagIdOnly> tagIds, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve all users from your instance. Only available for the instance owner.
    /// </summary>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="cursor">Paginate by setting the cursor parameter to the nextCursor attribute returned by the previous request's response. Default value fetches the first "page" of the collection. See pagination for more detail.</param>
    /// <param name="includeRole">Whether to include the user's role or not.</param>
    /// <param name="projectId"></param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/users")]
    Task<UserList> GetUsersAsync(
        [Query("limit")] int? limit = null,
        [Query("cursor")] string? cursor = null,
        [Query("includeRole")] bool? includeRole = null,
        [Query("projectId")] string? projectId = null,
        CancellationToken cancellationToken = default);

    /// <summary>
    /// Create one or more users.
    /// </summary>
    /// <param name="users">Array of users to be created.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/users")]
    Task<CreateUsersResponse> CreateUserAsync([Body] IEnumerable<CreateUserRequest> users, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve a user from your instance. Only available for the instance owner.
    /// </summary>
    /// <param name="id">The ID or email of the user.</param>
    /// <param name="includeRole">Whether to include the user's role or not.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/users/{id}")]
    Task<User> GetUserAsync([Path] string id, [Query("includeRole")] bool? includeRole = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a user from your instance.
    /// </summary>
    /// <param name="id">The ID or email of the user.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/users/{id}")]
    Task DeleteUserAsync([Path] string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Change a user's global role
    /// </summary>
    /// <param name="id">The ID or email of the user.</param>
    /// <param name="request">New role for the user</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Patch("/users/{id}/role")]
    Task ChangeUserRoleAsync([Path] string id, [Body] ChangeRoleRequest request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Pull changes from the remote repository
    /// </summary>
    /// <param name="request">Pull options</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/source-control/pull")]
    Task<ImportResult> PullAsync([Body] Pull request, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a variable in your instance.
    /// </summary>
    /// <param name="variable">Payload for variable to create.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/variables")]
    Task CreateVariableAsync([Body] Variable variable, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve variables from your instance.
    /// </summary>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="cursor">Paginate by setting the cursor parameter to the nextCursor attribute returned by the previous request's response. Default value fetches the first "page" of the collection. See pagination for more detail.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/variables")]
    Task<VariableList> GetVariablesAsync([Query("limit")] int? limit = null, [Query("cursor")] string? cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a variable from your instance.
    /// </summary>
    /// <param name="id">The ID of the variable.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/variables/{id}")]
    Task DeleteVariableAsync([Path] string id, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a variable from your instance.
    /// </summary>
    /// <param name="id">The ID of the variable.</param>
    /// <param name="variable">Payload for variable to update.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Put("/variables/{id}")]
    Task UpdateVariableAsync([Path] string id, [Body] Variable variable, CancellationToken cancellationToken = default);

    /// <summary>
    /// Create a project in your instance.
    /// </summary>
    /// <param name="project">Payload for project to create.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/projects")]
    Task CreateProjectAsync([Body] Project project, CancellationToken cancellationToken = default);

    /// <summary>
    /// Retrieve projects from your instance.
    /// </summary>
    /// <param name="limit">The maximum number of items to return.</param>
    /// <param name="cursor">Paginate by setting the cursor parameter to the nextCursor attribute returned by the previous request's response. Default value fetches the first "page" of the collection. See pagination for more detail.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Get("/projects")]
    Task<ProjectList> GetProjectsAsync([Query("limit")] int? limit = null, [Query("cursor")] string? cursor = null, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a project from your instance.
    /// </summary>
    /// <param name="projectId">The ID of the project.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/projects/{projectId}")]
    Task DeleteProjectAsync([Path] string projectId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Update a project.
    /// </summary>
    /// <param name="projectId">The ID of the project.</param>
    /// <param name="project">Updated project object.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Put("/projects/{projectId}")]
    Task UpdateProjectAsync([Path] string projectId, [Body] Project project, CancellationToken cancellationToken = default);

    /// <summary>
    /// Add one or more users to a project on your instance.
    /// </summary>
    /// <param name="projectId">The ID of the project.</param>
    /// <param name="relations">Payload containing an array of one or more users to add to the project.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Post("/projects/{projectId}/users")]
    Task AddUsersToProjectAsync([Path] string projectId, [Body] ProjectUserRelations relations, CancellationToken cancellationToken = default);

    /// <summary>
    /// Delete a user from a project on your instance.
    /// </summary>
    /// <param name="projectId">The ID of the project.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Delete("/projects/{projectId}/users/{userId}")]
    Task DeleteUserFromProjectAsync([Path] string projectId, [Path] string userId, CancellationToken cancellationToken = default);

    /// <summary>
    /// Change a user's role in a project.
    /// </summary>
    /// <param name="projectId">The ID of the project.</param>
    /// <param name="userId">The ID of the user.</param>
    /// <param name="role">Payload containing the new role to assign to the project user.</param>
    /// <param name="cancellationToken">The optional <see cref="CancellationToken"/>.</param>
    [Patch("/projects/{projectId}/users/{userId}")]
    Task ChangeUserRoleInProjectAsync([Path] string projectId, [Path] string userId, [Body] ProjectUserRole role, CancellationToken cancellationToken = default);
}