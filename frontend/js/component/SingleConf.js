export default function SingleConf(conference){
    return `
    <div class='add-item-container'>
        <div class='add-item'>
            <h3> Add a team </h3> 
            <br />
            <input type="text" class="add-team_location" placeholder="Add team location...">
            <input type="text" class="add-team_name" placeholder="Add team name...">
            <input type="text" class="add-team_imageUrl" placeholder="Add team image URL...">
            <input class='add-team_conferenceId' type='hidden' value="${conference.conferenceId}">
            <button class="add-team_submit">Submit</button>
        </div>
    </div>
    <br />
    <div class='children'>
    ${conference.teams.map(team => {
        return `

        <div class='child-by-id'>
            <img class='select-teamId__select' src='${team.imageURL}'>
            <p>${team.location} ${team.name}</p>
            <div class='child-by-id-input'>  

                <button class="edit-item">Edit Team</button>
                <button class='delete-teamId__delete'>Delete Team</button>
                <input class='select-team__id' type='hidden' value="${team.teamId}">
                <input class='delete-team__id' type='hidden' value="${team.teamId}">
                <input class='delete-team__conferenceId' type='hidden' value='${team.conferenceId}'>
                    <div class='edit-box'>
                        <input class='edit-team_teamId' type='hidden' value="${team.teamId}">
                        <input type="text" class="edit-team_location" value='${team.location}' placeholder="Edit a team location.">
                        <input type="text" class="edit-team_name" value='${team.name}'placeholder="Edit a team name.">
                        <input type="text" class="edit-team_imageUrl" value='${team.imageUrl}' placeholder="Edit team image.">
                        <input class='edit-team_conferenceId' type='hidden' value="${team.conferenceId}">
                        <button class="edit-player_submit">Edit Player</button>
                    </div>
                <br />
            </div>                                  
        </div>
            `;
    })
    .join("")}
    </div>
    
    `
};