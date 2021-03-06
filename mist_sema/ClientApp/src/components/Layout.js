import React, {Component} from 'react';
import {Container} from 'reactstrap';
import {NavMenu} from './NavMenu';
import {Stack} from "@mui/material";

export class Layout extends Component {
    static displayName = Layout.name;

    render() {
        return (
            <div>
                <Stack>
                    <NavMenu/>
                    <Container>
                        {this.props.children}
                    </Container>
                </Stack>
            </div>
        );
    }
}
