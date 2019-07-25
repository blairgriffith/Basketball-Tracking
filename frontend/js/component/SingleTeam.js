export default function SingleTeam(team){
    return `
    <teamheading>
        <img src='${team.imageURL}'>
        <h1>${team.name}</h1>
    </teamheading>
    <addplayer>
        <h2> Add a player </h2> 
        <input type="text" class="add-player_name" placeholder="Add a player name.">
        <input type="text" class="add-player_imageUrl" placeholder="Add a player Image.">
        <input class='add-player_conferenceId' type='hidden' value="${team.conferenceId}">
        <button class="add-player_submit">Submit</button>
    </addplayer>
    <br />
    <playersbyid>
    ${team.players.map(player => {
        return `

        <playerbyid>
            <img src='${player.imageURL}'>
            <p>${player.location}</p>
            <p>${player.name}</p>
            <playerbyidinput>
                <input class='delete-player__id' type='hidden' value="${player.playerId}">
                <input class='delete-player__conferenceId' type='hidden' value='${player.conferenceId}'>
                <button class='delete-playerId__delete'>Delete Team</button>

                <input class='edit-player_playerId' type='hidden' value="${player.playerId}">
                <input type="text" class="edit-player_location" value='${player.location}' placeholder="Edit a player location.">
                <input type="text" class="edit-player_name" value='${player.name}'placeholder="Edit a player name.">
                <input type="text" class="edit-player_imageUrl" value='${player.imageUrl}' placeholder="Edit player image.">
                <input class='edit-player_conferenceId' type='hidden' value="${player.conferenceId}">
                <button class="edit-player_submit">Edit Team</button>
                <br />
            </playerbyidinput>                                  
        </playerbyid>
            `;
    })
    .join("")}
    </playersbyid>
    
 
    `
}