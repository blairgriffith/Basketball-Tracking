export default function SingleTeam(team){
    return `
    
    <h1>${team.name}</h1>
    <ul>
        ${team.players.map(player => {
        return `
            <li>
                <p>${player.name}</p>
                <img class='select-conference' src="${player.imageURL}">
                <input class='select-conference__id' type='hidden' value="${player.playerId}">
            
            </li>
            `;
        })
        .join("")}
    
    </ul>
        
    `
}