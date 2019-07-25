export default function SingleConf(conference){
    return `
    <addteam>
        <h2> Add a team </h2> 
        <input type="text" class="add-team_location" placeholder="Edit a team location.">
        <input type="text" class="add-team_name" placeholder="Add a team name.">
        <input type="text" class="add-team_imageUrl" placeholder="Add a team Image.">
        <input class='add-team_conferenceId' type='hidden' value="${conference.conferenceId}">
        <button class="add-team_submit">Submit</button>
    </addteam>
    <br />
    <teamsbyid>
    ${conference.teams.map(team => {
        return `

        <teambyid>
            <img class='select-teamId__select' src='${team.imageURL}'>
            <p>${team.location}</p>
            <p>${team.name}</p>
            <teambyidinput>  
                <input class='select-team__id' type='hidden' value="${team.teamId}">
                <input class='delete-team__id' type='hidden' value="${team.teamId}">
                <input class='delete-team__conferenceId' type='hidden' value='${team.conferenceId}'>
                <button class='delete-teamId__delete'>Delete Team</button>

                <input class='edit-team_teamId' type='hidden' value="${team.teamId}">
                <input type="text" class="edit-team_location" value='${team.location}' placeholder="Edit a team location.">
                <input type="text" class="edit-team_name" value='${team.name}'placeholder="Edit a team name.">
                <input type="text" class="edit-team_imageUrl" value='${team.imageUrl}' placeholder="Edit team image.">
                <input class='edit-team_conferenceId' type='hidden' value="${team.conferenceId}">
                <button class="edit-team_submit">Edit Team</button>
                <br />
            </teambyidinput>                                  
        </teambyid>
            `;
    })
    .join("")}
    </teamsbyid>
    
    `
};