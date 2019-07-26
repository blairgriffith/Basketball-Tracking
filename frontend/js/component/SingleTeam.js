export default function SingleTeam(team){
    return `
    <div class='heading'>
        <img src='${team.imageURL}'>
        <h1>${team.location} ${team.name}</h1>
    </div>
    <br />
    <div class='add-item-container'>
        <div class='add-item'>
            <h3> Add a player </h3> 
            <br />
            <input type="text" class="add-player_name" placeholder="Add player's name...">
            <input type="text" class="add-player_imageUrl" placeholder="Add player's Image URL...">
            <input class='add-player_teamId' type='hidden' value="${team.teamId}">
            <button class="add-player_submit">Submit</button>
        </div>
    </div>
    <br />
    <div class='children'>
    ${team.players.map(player => {
        return `

        <div class='child-by-id'>
            <img src='${player.imageURL}'>
            <p>${player.name}</p>
            <div class='child-by-id-input'>
            
            <button class="edit-item">Edit Player</button>
            <button class='delete-playerId__delete'>Delete Player</button>
            <input class='delete-player__id' type='hidden' value="${player.playerId}">
            <input class='delete-player__teamId' type='hidden' value='${player.teamId}'>
                <div class='edit-box'
                    <span>Name</span> 
                    <input type="text" class="edit-player_name" value='${player.name}'placeholder="Edit player's name...">
                    <br />
                    <span>Image URL</span>
                    <input class='edit-player_playerId' type='hidden' value="${player.playerId}">
                    <input type="text" class="edit-player_imageUrl" value='${player.imageURL}' placeholder="Edit player image...">
                    <input class='edit-player_teamId' type='hidden' value="${player.teamId}">
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
}