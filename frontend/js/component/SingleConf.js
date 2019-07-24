export default function SingleConf(conference){
    return `
    
    <h1>${conference.name}</h1>
    <ul>
        ${conference.teams.map(team => {
        return `
            <li>
                <p>${team.name}</p>
                <img class='select-conference' src="${team.imageURL}">
                <input class='select-conference__id' type='hidden' value="${team.teamId}">
            
            </li>
            `;
        })
        .join("")}
    
    </ul>
        
    `
}