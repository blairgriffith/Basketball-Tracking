export default function Conferences(allconf){
    return `
    
    <h1>Choose a Conference</h1>
    <ul>
        ${allconf.map(conference => {
        return `
            <li>
                <p>${conference.name}</p>
                <img class='select-conference' src="${conference.imageURL}">
                <input class='select-conference__id' type='hidden' value="${conference.conferenceId}">
            
            </li>
            `;
        })
        .join("")}
    
    </ul>
        
    `
    };