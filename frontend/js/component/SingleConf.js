export default function SingleConf(conference){
    return `
    
    <teamsbyid>
    ${conference.teams.map(team => {
        return `

        <teambyid>
            <p>${team.name}</p>
            <img class='select-teamId__select' src="${team.imageUrl}">
            <p>${team.location}</p>
            <teambyidinput>  
            <input class='select-team__id' type='hidden' value="${team.teamId}">
            <input class='delete-team__id' type='hidden' value="${team.teamId}">
            <button class='delete-teamId__delete'>Delete Team</button>
            </br>    
            <input class='edit-team__teamId' type='hidden' value="${team.teamId}">
            <input class='edit-team_teamId' type='hidden' value="${team.conferenceId}">
            <input type="text" class="edit-team_name" placeholder="Edit a team name.">
            <input type="text" class="edit-team_location" placeholder="Edit a team location.">
            <button class="edit-team_submit">Edit Team</button>
            </teambyidinput>                                  
            </teambyid>
            `;
    })
    .join("")}
    </teamsbyid>
    <addteam>
        <h2> Add a team </h2> 
        <input class='add-team_conferenceId' type='hidden' value="${conference.conferenceId}">
        <input type="text" class="add-team_name" placeholder="Add a team name.">
        <input type="text" class="add-team_location" placeholder="Edit a team location.">
        <input type="text" class="add-team_imageUrl" placeholder="Add a team Image.">
        <button class="add-team_submit"> Submit</button>
    </addteam>
    `
};