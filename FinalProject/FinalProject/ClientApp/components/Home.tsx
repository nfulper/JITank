import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div>
            <h1>Tank, Just in Time!</h1>
            <p>Manage your mobile inventory space effectively.</p>
            
        </div>;
    }
}
