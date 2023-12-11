/* tslint:disable */
/* eslint-disable */
/**
 * Server API - Login
 * The Restful APIs of Login.
 *
 * The version of the OpenAPI document: 1.0.0
 *
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 * Do not edit the class manually.
 */

import { exists, mapValues } from '../runtime';
import type { RoomUser } from './RoomUser';
import { RoomUserFromJSON, RoomUserFromJSONTyped, RoomUserToJSON } from './RoomUser';

/**
 *
 * @export
 * @interface Room
 */
export interface Room {
  /**
   *
   * @type {string}
   * @memberof Room
   */
  roomId: string;
  /**
   *
   * @type {string}
   * @memberof Room
   */
  spaceId: string;
  /**
   *
   * @type {Array<RoomUser>}
   * @memberof Room
   */
  users?: Array<RoomUser>;
}

/**
 * Check if a given object implements the Room interface.
 */
export function instanceOfRoom(value: object): boolean {
  let isInstance = true;
  isInstance = isInstance && 'roomId' in value;
  isInstance = isInstance && 'spaceId' in value;

  return isInstance;
}

export function RoomFromJSON(json: any): Room {
  return RoomFromJSONTyped(json, false);
}

export function RoomFromJSONTyped(json: any, ignoreDiscriminator: boolean): Room {
  if (json === undefined || json === null) {
    return json;
  }
  return {
    roomId: json['room_id'],
    spaceId: json['space_id'],
    users: !exists(json, 'users') ? undefined : (json['users'] as Array<any>).map(RoomUserFromJSON),
  };
}

export function RoomToJSON(value?: Room | null): any {
  if (value === undefined) {
    return undefined;
  }
  if (value === null) {
    return null;
  }
  return {
    room_id: value.roomId,
    space_id: value.spaceId,
    users: value.users === undefined ? undefined : (value.users as Array<any>).map(RoomUserToJSON),
  };
}